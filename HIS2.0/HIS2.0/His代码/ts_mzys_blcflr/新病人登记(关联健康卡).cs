using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TrasenFrame.Classes;
using TrasenClasses.GeneralControls;
using TrasenClasses.GeneralClasses;
using ts_mz_class;
using TrasenFrame.Forms;

namespace ts_mzys_blcflr
{
    public partial class FrmbrxxJkk : Form
    {

        private Guid Brxxid = Guid.Empty;
        private Guid Kdjid = Guid.Empty;
        private string FunctionName = "";
        public string ReturnItem = "";
        public string ReturnMzh = "";
        public FrmbrxxJkk(string _FunctionName, Guid brxxid, Guid kdjid)
        {
            InitializeComponent();
            Brxxid = brxxid;
            Kdjid = kdjid;
            FunctionName = _FunctionName;
            ts_mz_class.FunAddComboBox.AddKlx(false, 0, cmbklx, InstanceForm.BDatabase);   
        } 

        private void Frmhjsf_Load(object sender, EventArgs e)
        {
            //年龄单位
            DataTable tb = new DataTable();
            tb.Columns.Add("ID", Type.GetType("System.Int32"));
            tb.Columns.Add("NAME", Type.GetType("System.String"));
            DataRow row = tb.NewRow();
            row["ID"] = 0;
            row["NAME"] = "岁";
            tb.Rows.Add(row);
            row = tb.NewRow();
            row["ID"] = 1;
            row["NAME"] = "月";
            tb.Rows.Add(row);
            row = tb.NewRow();
            row["ID"] = 2;
            row["NAME"] = "天";
            tb.Rows.Add(row);
            row = tb.NewRow();
            row["ID"] = 3;
            row["NAME"] = "小时";
            tb.Rows.Add(row);
            cmbDW.DisplayMember = "NAME";
            cmbDW.ValueMember = "ID";
            cmbDW.DataSource = tb;
            cmbDW.SelectedIndex = 0;

            //ini文件读取
            string Bxm = ApiFunction.GetIniString("划价收费", "姓名处停留", Constant.ApplicationDirectory + "//ClientWindow.ini");
            FunAddComboBox.Addxb(false, cmbxb, InstanceForm.BDatabase);
        }

        public  void butsave_Click(object sender, EventArgs e)
        {

            try
            {
                string Stime = DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToString("yyyy-MM-dd");
                string Etime = DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToString("yyyy-MM-dd");
                //Add By Zj 2012-05-04
                string sqlcount = " select count(*) from mz_ghxx where djy=" + InstanceForm.BCurrentUser.EmployeeId + " and ghsj>='" + Stime + " 00:00:00' and ghsj<='" + Etime + " 23:59:59' ";
                int resultcount = Convert.ToInt32(InstanceForm.BDatabase.GetDataResult(sqlcount));
                SystemCfg cfg3037 = new SystemCfg(3037);
                if (cfg3037.Config != "0")
                {
                    if (resultcount >= Convert.ToInt32(cfg3037.Config))
                    {
                        MessageBox.Show("由于系统限制,您不能再无号接诊病人,请让病人挂号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                //修改病人姓名
                if (Brxxid != Guid.Empty)
                {
                    string ssql = "select brxm from yy_brxx where brxxid='" + Brxxid + "'";
                    string brxm = InstanceForm.BDatabase.GetDataTable(ssql).Rows[0][0].ToString();
                    if (txtbrxm.Text.Trim() != brxm.Trim())
                    {
                        MessageBox.Show("不能修改卡信息！"); 
                        return;
                    }
                }


                Guid _NewBrxxID = Guid.Empty;
                Guid _NewGhxxID = Guid.Empty;
                int _PDXH = 0;
                int err_code = -1;
                string err_text = "";

                InstanceForm.BDatabase.BeginTransaction();

                //病人信息保存
                if (Brxxid == Guid.Empty)
                {
                    if (txtbrxm.Text.Trim() == "")
                        throw new Exception("请输入病人姓名");
                    if (rdonl.Checked == true && txtnl.Text.Trim() == "")
                    {
                        throw new Exception("请输入病人年龄");
                    }

                    YY_BRXX.BrxxDj(Guid.Empty,
                        txtbrxm.Text.Trim(),
                        Convertor.IsNull(cmbxb.SelectedValue, "9"),
                        dtpcsrq.Value.ToShortDateString(),
                        "", "", "", "",
                        txtcsdz.Text.Trim(), txtjtdz.Text.Trim(), "", txtjtdh.Text.Trim(), "", txtbrlxfs.Text.Trim(), txtdzyj.Text.Trim(), txtgzdw.Text.Trim(), "", "", txtdwdh.Text.Trim(), "", txtsfzh.Text.Trim(), 0, 0, "", InstanceForm.BCurrentUser.EmployeeId, 0, out _NewBrxxID, out err_code, out err_text, InstanceForm.BDatabase);
                    if (_NewBrxxID == Guid.Empty || err_code != 0) throw new Exception(err_text);
                }
                else
                    _NewBrxxID = Brxxid;
                string Mzh = Fun.GetNewMzh(InstanceForm.BDatabase);

                int DocTypeId = 0;
                try
                {
                    Doctor doc = new Doctor(InstanceForm.BCurrentUser.EmployeeId, InstanceForm.BDatabase);
                    DocTypeId = Convert.ToInt32(doc.TypeID);
                }
                catch (System.Exception err)
                {

                }

                int ghlx = 1;
                string djsj = DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToString();
                if (InstanceForm.BCurrentDept.Jz_Flag == 1)
                    ghlx = 2;
                //挂号信息保存
                mz_ghxx.GhxxDj(Guid.Empty, _NewBrxxID, ghlx, Kdjid, Mzh.Trim(), InstanceForm.BCurrentDept.DeptId, InstanceForm.BCurrentUser.EmployeeId, DocTypeId, 0, InstanceForm.BCurrentUser.EmployeeId, 0, "", ref _PDXH, 0, "", TrasenFrame.Forms.FrmMdiMain.Jgbm, out _NewGhxxID, out err_code, out err_text, 0, 0, 0, "", "", "", 0, "", "", djsj, InstanceForm.BDatabase);
                if (_NewGhxxID == Guid.Empty || err_code != 0) throw new Exception(err_text);

                InstanceForm.BDatabase.CommitTransaction();

                ReturnMzh = Mzh;

                if (new SystemCfg(3119).Config == "1")
                {
                    ReturnItem = GetGhFy();
                }
                this.Close();
            }
            catch (System.Exception err)
            {
                InstanceForm.BDatabase.RollbackTransaction();
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 是否可以选择级别
        /// </summary>
        public bool Ifkyxzjb = false;

        private string GetGhFy()
        {
            string ItemidArray = "";
            if (new SystemCfg(3120).Config == "1")
            {
                int ysjb = 1;
                int ghlx = 1;//挂号类型
                string tj = "=";
                if (Ifkyxzjb)
                    tj = ">=";
                string ssql = "";
                string jb = "";
                DateTime time1 = Convert.ToDateTime("0:00:00");
                DateTime time2 = Convert.ToDateTime(DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase));
                TimeSpan TS = new TimeSpan(time2.Ticks - time1.Ticks);
                int Time = (int)TS.TotalHours;
                string pblx = "1";
                if (Time <= 12)
                    pblx = "1";
                else
                    pblx = "2";
                if (new SystemCfg(3100).Config == "1")
                {
                    jb = "select TYPE_ID 挂号级别,TYPE_NAME 级别名称  from JC_DOCTOR_TYPE  where zcjb" + tj + "( select top 1 YS_TYPEID from JC_ROLE_DOCTOR where EMPLOYEE_ID=" + InstanceForm.BCurrentUser.EmployeeId.ToString() + " )";
                }
                else
                {
                    jb = "select TYPE_ID 挂号级别,TYPE_NAME 级别名称  from JC_DOCTOR_TYPE  where  type_id<>4 and  zcjb" + tj + "( select top 1 YS_TYPEID from JC_ROLE_DOCTOR where EMPLOYEE_ID=" + InstanceForm.BCurrentUser.EmployeeId.ToString() + " ) and zcjb in(1,2,3) ";
                }
                //Add By zch 2013-04-11 急诊则使用急诊费用
                if (InstanceForm.BCurrentDept.Jz_Flag == 0)
                {
                    ssql = "select cast(GHF_ID as varchar(50))+','+cast(ZCF_ID as varchar(50))+','+cast(JCF_ID as varchar(50))+','+cast(FZF_ID as varchar(50)) as item_id,GHF_ID,ZCF_ID,JCF_ID,FZF_ID,TYPE_ID from JC_DOCTOR_TYPE where zcjb in( select YS_TYPEID from JC_ROLE_DOCTOR where EMPLOYEE_ID=" + InstanceForm.BCurrentUser.EmployeeId.ToString() + " ) and zcjb in(1,2,3)";
                    ghlx = 1;
                    //add by zouchihua 普通门诊按照排班来设置级别 如果没有排班按照默认医生的级别 
                    #region

                    string pbxx = " select * from JC_MZ_YSPB where PBKSID=" + InstanceForm.BCurrentDept.DeptId + " and  ysid='" + InstanceForm.BCurrentUser.UserID + "' and pblx=" + pblx + " and  pbsj='" + DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToShortDateString() + "'";
                    DataTable pbxxtb = InstanceForm.BDatabase.GetDataTable(pbxx);
                    if (pbxxtb.Rows.Count > 0)
                    {
                        ssql = "select cast(GHF_ID as varchar(50))+','+cast(ZCF_ID as varchar(50))+','+cast(JCF_ID as varchar(50))+','+cast(FZF_ID as varchar(50)) as item_id,GHF_ID,ZCF_ID,JCF_ID,FZF_ID,TYPE_ID from JC_DOCTOR_TYPE where TYPE_ID=" + pbxxtb.Rows[0]["ZZJBID"].ToString() + " and zcjb in(1,2,3)";
                        //获得一下 过滤知名专家
                        jb = "  select TYPE_ID 挂号级别,TYPE_NAME 级别名称  from JC_DOCTOR_TYPE  where  ((4!=" + pbxxtb.Rows[0]["ZZJBID"].ToString() + " and type_id!=4) or 1=1)   and  zcjb " + tj + "(select zcjb  from JC_DOCTOR_TYPE where TYPE_ID=" + pbxxtb.Rows[0]["ZZJBID"].ToString() + ") and zcjb in(1,2,3) ";
                    }

                    #endregion
                }
                else
                {
                    ghlx = 2;
                    ssql = "select cast(JGHF_ID as varchar(50))+','+cast(JZCF_ID as varchar(50))+','+cast(JJCF_ID as varchar(50))+','+cast(JFZF_ID as varchar(50)) as item_id,JGHF_ID,JZCF_ID,JJCF_ID,JFZF_ID,TYPE_ID  from JC_DOCTOR_TYPE where zcjb in( select YS_TYPEID from JC_ROLE_DOCTOR where EMPLOYEE_ID=" + InstanceForm.BCurrentUser.EmployeeId.ToString() + " ) and zcjb in(1,2,3)";
                    string pbxx = " select * from JC_MZ_YSPB where PBKSID=" + InstanceForm.BCurrentDept.DeptId + " and  ysid='" + InstanceForm.BCurrentUser.UserID + "' and pblx=" + pblx + " and  pbsj='" + DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToShortDateString() + "'";
                    DataTable pbxxtb = InstanceForm.BDatabase.GetDataTable(pbxx);
                    if (pbxxtb.Rows.Count > 0)
                    {
                        ssql = "select cast(JGHF_ID as varchar(50))+','+cast(JZCF_ID as varchar(50))+','+cast(JJCF_ID as varchar(50))+','+cast(JFZF_ID as varchar(50)) as item_id,JGHF_ID,JZCF_ID,JJCF_ID,JFZF_ID,TYPE_ID  from JC_DOCTOR_TYPE where TYPE_ID=" + pbxxtb.Rows[0]["ZZJBID"].ToString() + " and zcjb in(1,2,3)";
                        jb = "  select TYPE_ID 挂号级别,TYPE_NAME 级别名称  from JC_DOCTOR_TYPE  where  ((4!=" + pbxxtb.Rows[0]["ZZJBID"].ToString() + " and type_id!=4) or 1=1)     and  zcjb " + tj + "(select zcjb  from JC_DOCTOR_TYPE where TYPE_ID=" + pbxxtb.Rows[0]["ZZJBID"].ToString() + ") and zcjb in(1,2,3) ";
                    }
                }
                DataTable tbjb = FrmMdiMain.Database.GetDataTable(jb);
                //获得挂号费
                DataRow dr = InstanceForm.BDatabase.GetDataRow(ssql);
                if (dr != null)
                    ysjb = Convert.ToInt32(dr["TYPE_ID"]);
                else
                {
                    //MessageBox.Show("没有找到该医生对应的级别！\r\n对应sql语句：" + ssql);
                    // this.DialogResult = DialogResult.No;
                    //  this.Close();
                    ysjb = 1;//没有找到默认为1，
                    //return;
                }

                int err_code = -1;
                string err_text = "";
                //获得挂号结果集  blb 默认为空
                DataSet dset = null;
                SystemCfg cfg3089 = new SystemCfg(3089);//Add by cc 2014-03-18
                if (cfg3089.Config == "1")
                {
                    string strSql = string.Format(@"SELECT TOP 1 a.YHLXID FROM dbo.JC_KYHLXSZ a INNER JOIN dbo.JC_YHLX b ON a.YHLXID = b.ID INNER JOIN 
                                                                    YY_KDJB c ON a.KDJID = c.KDJID 
                                                                    WHERE  KH='{0}'
                                                                    AND b.YHMC ='院内职工免挂号费和治疗费'", this.txtkh.Text.Trim());
                    DataTable dt = FrmMdiMain.Database.GetDataTable(strSql);
                    if (dt.Rows.Count > 0)
                    {
                        dset = mz_ghxx.mzgh_get_sfmx(ghlx, 0, 0, FrmMdiMain.CurrentDept.DeptId, ysjb, FrmMdiMain.CurrentUser.EmployeeId, "", 0, 0, new Guid(dt.Rows[0][0].ToString()), FrmMdiMain.Jgbm, out err_code, out err_text, "", InstanceForm.BDatabase);
                    }
                    else
                    {
                        dset = mz_ghxx.mzgh_get_sfmx(ghlx, 0, 0, FrmMdiMain.CurrentDept.DeptId, ysjb, FrmMdiMain.CurrentUser.EmployeeId, "", 0, 0, Guid.Empty, FrmMdiMain.Jgbm, out err_code, out err_text, "", InstanceForm.BDatabase);
                    }
                }
                else
                {
                    dset = mz_ghxx.mzgh_get_sfmx(ghlx, 0, 0, FrmMdiMain.CurrentDept.DeptId, ysjb, FrmMdiMain.CurrentUser.EmployeeId, "", 0, 0, Guid.Empty, FrmMdiMain.Jgbm, out err_code, out err_text, "", InstanceForm.BDatabase);
                }
                DataTable ghftb = dset.Tables[4];
                for (int i = 0; i <= ghftb.Rows.Count - 1; i++)
                {
                    ghftb.Rows[i]["je"] = Convert.ToString(Convert.ToDecimal(ghftb.Rows[i]["je"]) - Convert.ToDecimal(ghftb.Rows[i]["yhje"]));
                }
                // End add by cc 2014-03-18 

                
                for (int i = 0; i < ghftb.Rows.Count; i++)
                {
                    if (ghftb.Rows[i]["item_id"].ToString() != "-999" && ghftb.Rows[i]["je"].ToString() != "0.00")//Add by cc 2014-03-18
                        ItemidArray += ghftb.Rows[i]["item_id"].ToString() + ",";
                }
                ItemidArray = ItemidArray.Substring(0, ItemidArray.Length - 1) + "";
            }
            else if (new SystemCfg(3120).Config == "2") {
                ItemidArray = new SystemCfg(3121).Config;
            } 
            return ItemidArray;
        }

        private void GotoNext(object sender, KeyPressEventArgs e)
        {
            Control control = (Control)sender;
            if (e.KeyChar == 13)
            { 
                if (control.Name == "txtsfzh")
                    butsave.Focus();
                else
                    SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rdocsrq_CheckedChanged(object sender, EventArgs e)
        {
            txtnl.Enabled = rdonl.Checked == true ? true : false;
            dtpcsrq.Enabled = rdocsrq.Checked == true ? true : false;
        }

        private void txtnl_Leave(object sender, EventArgs e)
        { 
            if (txtnl.Text.Trim() != "" && Convertor.IsNumeric(txtnl.Text) == false)
            {
                MessageBox.Show("年龄请输入数字");
                return;
            }
            if (txtnl.Text.Trim() != "")
                dtpcsrq.Value = DateManager.AgeToDate(new Age(Convert.ToInt16(txtnl.Text), (AgeUnit)cmbDW.SelectedIndex), InstanceForm.BDatabase);
            else
                dtpcsrq.Value = DateManager.ServerDateTimeByDBType(TrasenFrame.Forms.FrmMdiMain.Database);
        }

        private void butquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmbrxx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                txtnl_Leave(sender, e);
                butsave_Click(sender, e);
            }
        }

        private void dtpcsrq_ValueChanged(object sender, EventArgs e)
        { 
            SetNlControl(dtpcsrq.Value);
        }

        private void SetNlControl(DateTime csrq)
        {
            Age age = DateManager.DateToAge(csrq, InstanceForm.BDatabase);
            txtnl.Text = age.AgeNum.ToString();
            cmbDW.SelectedIndex = (int)age.Unit;
        }

        private void txtnl_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 39 || (int)e.KeyCode == 40)
            {
                rdocsrq.Checked = true;
                dtpcsrq.Focus();
            }
        }

        private void txtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13) return;
            txtkh.Text = ts_mz_class.Fun.returnKh((int)cmbklx.SelectedValue, txtkh.Text.Trim(), InstanceForm.BDatabase);
            string ssq = "select * from YY_KDJB where klx=" + cmbklx.SelectedValue + " and kh='" + txtkh.Text.Trim() + "'  and ZFBZ=0 ";
            DataTable tbk = InstanceForm.BDatabase.GetDataTable(ssq);
            if (tbk.Rows.Count == 0) return;
            Brxxid = new Guid(tbk.Rows[0]["brxxid"].ToString());
            Kdjid = new Guid(tbk.Rows[0]["kdjid"].ToString());
            string ssql = "select *,dbo.fun_zy_age(csrq,3,getdate()) nl from vi_yy_brxx where brxxid='" + tbk.Rows[0]["brxxid"].ToString() + "'";
            DataTable tb = InstanceForm.BDatabase.GetDataTable(ssql);
            if (tb.Rows.Count > 0)
            {
                txtbrxm.Text = Convertor.IsNull(tb.Rows[0]["brxm"], ""); 
                cmbxb.Text = Convertor.IsNull(tb.Rows[0]["xb"], "");
                txtnl.Text = Convertor.IsNull(tb.Rows[0]["nl"], "");
                dtpcsrq.Value = Convert.ToDateTime(tb.Rows[0]["csrq"]);
                txtcsdz.Text = Convertor.IsNull(tb.Rows[0]["csdz"], "");
                txtjtdz.Text = Convertor.IsNull(tb.Rows[0]["jtdz"], "");
                txtjtdh.Text = Convertor.IsNull(tb.Rows[0]["jtdh"], "");
                txtbrlxfs.Text = Convertor.IsNull(tb.Rows[0]["brlxfs"], "");
                txtdzyj.Text = Convertor.IsNull(tb.Rows[0]["dzyj"], "");
                txtgzdw.Text = Convertor.IsNull(tb.Rows[0]["gzdw"], "");
                txtdwdh.Text = Convertor.IsNull(tb.Rows[0]["gzdwdh"], "");
                txtsfzh.Text = Convertor.IsNull(tb.Rows[0]["sfzh"], "");
                cmbxb.SelectedValue = Convertor.IsNull(tb.Rows[0]["xb"], "");

                txtbrxm.Enabled = false;
                cmbxb.Enabled = false;
                txtnl.Enabled = false;
                dtpcsrq.Enabled = false;
                txtcsdz.Enabled = false;
                txtjtdz.Enabled = false;
                txtjtdh.Enabled = false;
                txtbrlxfs.Enabled = false;
                txtdzyj.Enabled = false;
                txtgzdw.Enabled = false;
                txtdwdh.Enabled = false;
                txtsfzh.Enabled = false;
            }
        }
    }
}