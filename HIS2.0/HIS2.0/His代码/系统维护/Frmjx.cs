using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TrasenFrame.Classes;
using TrasenClasses.GeneralControls;
using TrasenClasses.GeneralClasses;
using TrasenClasses.DatabaseAccess;
using YpClass;
namespace ts_yp_xtwh
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Frmjx : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private myDataGrid.myDataGrid myDataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtdm;
		private System.Windows.Forms.Button butsave;
		private System.Windows.Forms.Button butdel;
		private System.Windows.Forms.Button butquit;
		private MenuTag _menuTag;
		private string _chineseName;
		private Form _mdiParent;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.ComboBox cmbyplx;
		private System.Windows.Forms.Button butprint;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private DataGridTextBoxColumn dataGridTextBoxColumn6;
        private DataGridTextBoxColumn dataGridTextBoxColumn7;
        private ComboBox cmbjxdl;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Frmjx(MenuTag menuTag,string chineseName,Form mdiParent)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			_menuTag=menuTag;
			_chineseName=chineseName;
			_mdiParent=mdiParent;
			this.Text=_chineseName;
            this.Text = this.Text + " [" + InstanceForm._menuTag.Jgbm + "]";
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.myDataGrid1 = new myDataGrid.myDataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butprint = new System.Windows.Forms.Button();
            this.butquit = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.txtdm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbjxdl = new System.Windows.Forms.ComboBox();
            this.cmbyplx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 454);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(768, 31);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 300;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 1001;
            // 
            // myDataGrid1
            // 
            this.myDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.myDataGrid1.CaptionVisible = false;
            this.myDataGrid1.DataMember = "";
            this.myDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.myDataGrid1.Location = new System.Drawing.Point(3, 21);
            this.myDataGrid1.Name = "myDataGrid1";
            this.myDataGrid1.Size = new System.Drawing.Size(762, 347);
            this.myDataGrid1.TabIndex = 0;
            this.myDataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            this.myDataGrid1.CurrentCellChanged += new System.EventHandler(this.myDataGrid1_CurrentCellChanged);
            this.myDataGrid1.myKeyDown += new myDataGrid.myDelegate(this.myDataGrid1_myKeyDown);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.AllowSorting = false;
            this.dataGridTableStyle1.DataGrid = this.myDataGrid1;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.dataGridTextBoxColumn5,
            this.dataGridTextBoxColumn3,
            this.dataGridTextBoxColumn4,
            this.dataGridTextBoxColumn9,
            this.dataGridTextBoxColumn10,
            this.dataGridTextBoxColumn6,
            this.dataGridTextBoxColumn7,
            this.dataGridTextBoxColumn8});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "序号";
            this.dataGridTextBoxColumn1.Width = 40;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "名称";
            this.dataGridTextBoxColumn2.Width = 150;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "英文名";
            this.dataGridTextBoxColumn5.NullText = "";
            this.dataGridTextBoxColumn5.Width = 75;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "拼音码";
            this.dataGridTextBoxColumn3.Width = 70;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "五笔码";
            this.dataGridTextBoxColumn4.Width = 70;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "统领分类";
            this.dataGridTextBoxColumn9.NullText = "";
            this.dataGridTextBoxColumn9.ReadOnly = true;
            this.dataGridTextBoxColumn9.Width = 80;
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.HeaderText = "tlfl";
            this.dataGridTextBoxColumn10.ReadOnly = true;
            this.dataGridTextBoxColumn10.Width = 0;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "剂型大类";
            this.dataGridTextBoxColumn6.ReadOnly = true;
            this.dataGridTextBoxColumn6.Width = 75;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "JXDL";
            this.dataGridTextBoxColumn7.ReadOnly = true;
            this.dataGridTextBoxColumn7.Width = 0;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "ID";
            this.dataGridTextBoxColumn8.NullText = "";
            this.dataGridTextBoxColumn8.ReadOnly = true;
            this.dataGridTextBoxColumn8.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butprint);
            this.groupBox1.Controls.Add(this.butquit);
            this.groupBox1.Controls.Add(this.butdel);
            this.groupBox1.Controls.Add(this.butsave);
            this.groupBox1.Controls.Add(this.txtdm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // butprint
            // 
            this.butprint.Location = new System.Drawing.Point(725, 21);
            this.butprint.Name = "butprint";
            this.butprint.Size = new System.Drawing.Size(128, 41);
            this.butprint.TabIndex = 7;
            this.butprint.Text = "打印(&P)";
            this.butprint.Click += new System.EventHandler(this.butprint_Click);
            // 
            // butquit
            // 
            this.butquit.Location = new System.Drawing.Point(864, 21);
            this.butquit.Name = "butquit";
            this.butquit.Size = new System.Drawing.Size(128, 41);
            this.butquit.TabIndex = 4;
            this.butquit.Text = "退出(&Q)";
            this.butquit.Click += new System.EventHandler(this.butquit_Click);
            // 
            // butdel
            // 
            this.butdel.Location = new System.Drawing.Point(587, 21);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(128, 41);
            this.butdel.TabIndex = 3;
            this.butdel.Text = "删除(&D)";
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(448, 21);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(128, 41);
            this.butsave.TabIndex = 2;
            this.butsave.Text = "保存(&S)";
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // txtdm
            // 
            this.txtdm.Location = new System.Drawing.Point(91, 31);
            this.txtdm.Name = "txtdm";
            this.txtdm.Size = new System.Drawing.Size(256, 25);
            this.txtdm.TabIndex = 1;
            this.txtdm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdm_KeyUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbjxdl);
            this.groupBox2.Controls.Add(this.cmbyplx);
            this.groupBox2.Controls.Add(this.myDataGrid1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 371);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "药品剂型";
            // 
            // cmbjxdl
            // 
            this.cmbjxdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjxdl.Location = new System.Drawing.Point(448, 242);
            this.cmbjxdl.Name = "cmbjxdl";
            this.cmbjxdl.Size = new System.Drawing.Size(128, 23);
            this.cmbjxdl.TabIndex = 2;
            this.cmbjxdl.Visible = false;
            this.cmbjxdl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbjxdl_KeyPress);
            this.cmbjxdl.Move += new System.EventHandler(this.cmbjxdl_Move);
            // 
            // cmbyplx
            // 
            this.cmbyplx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyplx.Location = new System.Drawing.Point(213, 278);
            this.cmbyplx.Name = "cmbyplx";
            this.cmbyplx.Size = new System.Drawing.Size(128, 23);
            this.cmbyplx.TabIndex = 1;
            this.cmbyplx.Visible = false;
            this.cmbyplx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbyplx_KeyPress);
            this.cmbyplx.Move += new System.EventHandler(this.cmbyplx_Move);
            // 
            // Frmjx
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(768, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Frmjx";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmsccj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]


		private void Frmsccj_Load(object sender, System.EventArgs e)
		{
			try
			{
				//初始化
				DataTable myTb=new DataTable();
			
				for(int i=0;i<=this.myDataGrid1.TableStyles[0].GridColumnStyles.Count-1;i++) 
				{	
					if(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].GetType().ToString()=="System.Windows.Forms.DataGridBoolColumn")
						myTb.Columns.Add(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText,Type.GetType("System.Int16"));	
					else
						myTb.Columns.Add(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText,Type.GetType("System.String"));	
									   
					this.myDataGrid1.TableStyles[0].GridColumnStyles[i].MappingName=this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
					this.myDataGrid1.TableStyles[0].GridColumnStyles[i].NullText="";
				}

				DataRow row=myTb.NewRow();
				row["序号"]="1";
				myTb.Rows.Add(row);
			
				this.myDataGrid1.DataSource=myTb;
				this.myDataGrid1.TableStyles[0].MappingName ="Tb";
				this.AddData("");

                Yp.Addcmbtlfl(cmbyplx, InstanceForm.BDatabase);
                Addcmbjxdl(cmbjxdl, InstanceForm.BDatabase);
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}
        public static void Addcmbjxdl(System.Windows.Forms.ComboBox cmb, RelationalDatabase _DataBase)
        {
            string ssql = "select jxbm as code,jxmc as name from yp_ypjxdl  ";
            DataTable tb = _DataBase.GetDataTable(ssql);
            tb.TableName = "jxdl";
            cmb.ValueMember = "code";
            cmb.DisplayMember = "name";
            cmb.DataSource = tb;

            cmb.Text = "";
        }

		private void AddData(string ss)
		{
			DataTable myTb=new DataTable();
			string ssql="";

			if (ss.Trim()=="")
			{
                ssql = "select 0 序号,mc 名称,ywm 英文名,pym 拼音码,wbm 五笔码,(select name from yp_tlfl where code=tlfl) 统领分类,tlfl,(select jxmc from yp_ypjxdl where jxbm=jxdl) 剂型大类,jxdl,id from yp_ypjx";
			}
			else
			{
                ssql = "select 0 序号,mc 名称,ywm 英文名,pym 拼音码,wbm 五笔码,(select name from yp_tlfl where code=tlfl) 统领分类,tlfl,(select jxmc from yp_ypjxdl where jxbm=jxdl) 剂型大类,jxdl,id from yp_ypjx where pym like '" + txtdm.Text.Trim() + "%' or wbm like '" + txtdm.Text.Trim() + "%' or mc like '%" + txtdm.Text.Trim() + "%' ";
			}
			myTb=InstanceForm.BDatabase.GetDataTable(ssql);
			FunBase.AddRowtNo(myTb);
			myTb.TableName="Tb";
			this.myDataGrid1.DataSource=myTb;
			this.myDataGrid1.TableStyles[0].MappingName ="Tb";
			DataRow row=myTb.NewRow();
			row["序号"]=myTb.Rows.Count+1;
			myTb.Rows.Add(row);
            myTb.AcceptChanges();
		}

		private bool myDataGrid1_myKeyDown(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
		{
			try
			{

				DataTable tb=(DataTable)this.myDataGrid1.DataSource ;
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
				int ncol=this.myDataGrid1.CurrentCell.ColumnNumber;
				int nkey=Convert.ToInt32(keyData);
				string columnName=this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol].HeaderText.Trim();
				if (nrow>tb.Rows.Count-1) return true;
				
				//如果是名称列
				if (columnName.Trim()=="名称" && nkey==13)
				{
					string coltext="";
					DataGridTextBoxColumn txtCol=(DataGridTextBoxColumn)this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol];
					coltext=txtCol.TextBox.Text;
					if (coltext.Trim()=="") return true;

					if (nrow>=tb.Rows.Count-1)
					{
						DataRow row=tb.NewRow();
						row["序号"]=nrow+2;
						tb.Rows.Add(row);
					}

					tb.Rows[nrow]["名称"]=coltext;
					tb.Rows[nrow]["拼音码"]=PubStaticFun.GetPYWBM(coltext,0);
					tb.Rows[nrow]["五笔码"]=PubStaticFun.GetPYWBM(coltext,1);
				}

				//回车控制
				//if (nkey==13 && columnName!="药品类型")
				if (nkey==13 && columnName!="统领分类")
					this.myDataGrid1.CurrentCell=new DataGridCell(nrow,ncol+1);
				//if (nkey==13 && columnName=="药品类型")
                if (nkey == 13 && (columnName == "统领分类" || columnName == "剂型大类"))
					this.myDataGrid1.CurrentCell=new DataGridCell(nrow+1,1);
                if (this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol + 1].HeaderText.Trim() == "统领分类" || this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol + 1].HeaderText.Trim() == "剂型大类")
					cmbyplx.Focus();

			}
			catch(System.Exception err)
			{
				MessageBox.Show("错误"+err.Message );
			}
			return false;
		}

		private void txtdm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				this.AddData(txtdm.Text.Trim());
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}

		}

		private void butdel_Click(object sender, System.EventArgs e)
		{
            Guid log_djid = Guid.Empty;
            ts_HospData_Share.ts_update_log ts = new ts_HospData_Share.ts_update_log();
			try
			{
				DataTable tb=(DataTable)this.myDataGrid1.DataSource ;
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
				if (nrow>tb.Rows.Count-1) return;
				int ID=Convert.ToInt32(Convertor.IsNull(tb.Rows[nrow]["id"],"0"));
				//看是否有过使用记录
				string ssql="select * from yp_ypggd where ypjx="+ID+" ";
				DataTable tab=InstanceForm.BDatabase.GetDataTable(ssql);
				if (tab.Rows.Count>0){MessageBox.Show("对不起，这个剂型在系统中已经使用了，不能删除");return;}

                InstanceForm.BDatabase.BeginTransaction();
                ssql = "delete from yp_ypjx where id=" + ID + "";
                InstanceForm.BDatabase.DoCommand(ssql);

                //三院数据处理_____保存日志 
                if (ID > 0)
                {
                    string bz = "删除剂型 【" + tb.Rows[nrow]["名称"].ToString() + "】 ";

                    ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, bz, "yp_ypjx", "id", ID.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                }
                InstanceForm.BDatabase.CommitTransaction();

                DataRow row = tb.Rows[nrow];
                tb.Rows.Remove(row);
			}
			catch(System.Exception err)
			{
                InstanceForm.BDatabase.RollbackTransaction();
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}


            try
            {
                //三院数据处理
                string errtext = "";
                ts_HospData_Share.ts_update_type ty = new ts_HospData_Share.ts_update_type((int)ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BDatabase);
                if (ty.Bzx == 1)
                    ts.Pexec_log(log_djid, InstanceForm.BDatabase, out errtext);

                MessageBox.Show("删除成功" + errtext);

            }
            catch (System.Exception err)
            {
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
		}

		private void butquit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butsave_Click(object sender, System.EventArgs e)
		{
            ts_HospData_Share.ts_update_log ts = new ts_HospData_Share.ts_update_log();
            Guid log_djid = Guid.Empty;
            DataTable tb = (DataTable)this.myDataGrid1.DataSource;
            string[] ss = new string[tb.Rows.Count];

			try
			{
				this.butsave.Enabled=false;
				InstanceForm.BDatabase.BeginTransaction();

				string ssql="";
				string mc="";
				string ywm="";
				string pym="";
				string wbm="";
				string tlfl="";
                string jxdl = "";


				for(int i=0;i<=tb.Rows.Count-1;i++)
				{
                    if ( tb.Rows[i].RowState == DataRowState.Unchanged )
                        continue;

					int ID=Convert.ToInt32(Convertor.IsNull(tb.Rows[i]["id"],"0"));
					mc=tb.Rows[i]["名称"].ToString();
					ywm=tb.Rows[i]["英文名"].ToString();
					pym=tb.Rows[i]["拼音码"].ToString();
					wbm=tb.Rows[i]["五笔码"].ToString();
					tlfl=Convertor.IsNull(tb.Rows[i]["tlfl"],"");
                    jxdl = Convertor.IsNull(tb.Rows[i]["jxdl"], "");

					if (tlfl.Trim()=="" && mc.Trim()!="")
					{
						throw new Exception("统领分类是必填项");
					}
					if (mc.Trim()!="")
					{
						if (ID==0)
						{
							ssql="insert into yp_ypjx(mc,ywm,pym,wbm ,yplx,tlfl,jxdl) values('"+mc+"','"+ywm.Trim()+"','"+pym+"','"+wbm+"',0,'"+tlfl+"','"+jxdl+"') ";
						}
						else
						{
							ssql="update yp_ypjx set mc='"+mc+"',ywm='"+ywm.Trim()+"',pym='"+pym+"',wbm='"+wbm+"',yplx=0,tlfl='"+tlfl+"',jxdl='"+jxdl+"' where id="+ID+" ";
						}

                        //三院数据处理
                        if (ID == 0)
                        {
                            InstanceForm.BDatabase.DoCommand(ssql);
                            long newid = Convert.ToInt64(InstanceForm.BDatabase.GetDataTable("select @@IDENTITY").Rows[0][0]);
                            ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BCurrentUser.Name + "添加剂型 【" + mc + " 】", "yp_ypjx", "id", newid.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                            ss[i] = log_djid.ToString();
                        }
                        else
                        {
                            string _ssql = "select * from yp_ypjx where id=" + ID + " and mc='" + mc + "' and pym='" + pym + "'  and wbm='"+wbm+"' and tlfl='"+tlfl+"'";
                            DataTable tb_x = InstanceForm.BDatabase.GetDataTable(_ssql);
                            if (tb_x.Rows.Count == 0)
                            {
                                ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BCurrentUser.Name + "修改剂型 【" + mc + " 】", "yp_ypjx", "id", ID.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                                ss[i] = log_djid.ToString();
                            }
                            InstanceForm.BDatabase.DoCommand(ssql);
                        }

					}
				}

				InstanceForm.BDatabase.CommitTransaction();

			}
			catch(System.Exception err)
			{
				this.butsave.Enabled=true;
				InstanceForm.BDatabase.RollbackTransaction();
				MessageBox.Show("发生错误"+err.Message);
                return;
			}


            try
            {
                //三院数据处理
                string msg = "";
                for (int i = 0; i <= ss.Length - 1; i++)
                {
                    if (Convertor.IsNull(ss[i], "") == "") continue;
                    string errtext = "";
                    ts_HospData_Share.ts_update_log tss = new ts_HospData_Share.ts_update_log();
                    ts_HospData_Share.ts_update_type ty = new ts_HospData_Share.ts_update_type((int)ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BDatabase);
                    if (ty.Bzx == 1)
                    {
                        tss.Pexec_log(new Guid(ss[i]), InstanceForm.BDatabase, out errtext);
                        msg = msg + errtext;
                    }
                }

                MessageBox.Show("保存成功" + msg);
                this.butsave.Enabled = true;
                this.AddData("");
            }
            catch (System.Exception err)
            {
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

		}

		private void myDataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
            try
            {
                int nrow = this.myDataGrid1.CurrentCell.RowNumber;
                int ncol = this.myDataGrid1.CurrentCell.ColumnNumber;
                string columnName = this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol].HeaderText.Trim();
                this.cmbyplx.Visible = false;
                this.cmbjxdl.Visible = false;
                if (columnName.Trim() == "统领分类")
                {
                    DataTable tb = (DataTable)this.myDataGrid1.DataSource;
                    if (nrow > tb.Rows.Count - 1) return;

                    this.cmbyplx.Visible = true;
                    this.cmbyplx.Left = this.myDataGrid1.GetCellBounds(nrow, ncol).Left + this.myDataGrid1.Left;
                    this.cmbyplx.Top = this.myDataGrid1.GetCellBounds(nrow, ncol).Top + this.myDataGrid1.Top;
                    this.cmbyplx.Width = this.myDataGrid1.GetCellBounds(nrow, ncol).Width;

                    string tlfl = Convertor.IsNull(tb.Rows[nrow]["tlfl"], "0");
                    cmbyplx.Text = Yp.SeekTlfl(tlfl, InstanceForm.BDatabase);
                    cmbyplx.Focus();
                    return;

                }
                if (columnName.Trim() == "剂型大类")
                {
                    DataTable tb = (DataTable)this.myDataGrid1.DataSource;
                    if (nrow > tb.Rows.Count - 1) return;

                    this.cmbjxdl.Visible = true;
                    this.cmbjxdl.Left = this.myDataGrid1.GetCellBounds(nrow, ncol).Left + this.myDataGrid1.Left;
                    this.cmbjxdl.Top = this.myDataGrid1.GetCellBounds(nrow, ncol).Top + this.myDataGrid1.Top;
                    this.cmbjxdl.Width = this.myDataGrid1.GetCellBounds(nrow, ncol).Width;

                    string jxdl = Convertor.IsNull(tb.Rows[nrow]["jxdl"], "0");
                    cmbjxdl.Text = Convertor.IsNull(InstanceForm.BDatabase.GetDataResult("select jxmc from YP_YPJXDL where jxbm='" + jxdl + "'"), "");
                    cmbjxdl.Focus();
                    return;

                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void cmbyplx_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			int nrow=this.myDataGrid1.CurrentCell.RowNumber;
			int ncol=this.myDataGrid1.CurrentCell.ColumnNumber ;
			string columnName=this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol].HeaderText.Trim();
			if (columnName.Trim()=="统领分类")
			{
				DataTable tb=(DataTable)this.myDataGrid1.DataSource;
				tb.Rows[nrow][ncol]=cmbyplx.Text;
				tb.Rows[nrow]["tlfl"]=cmbyplx.SelectedValue;
				this.myDataGrid1.CurrentCell=new DataGridCell(nrow+1,1);
				return;
			}
			this.cmbyplx.Visible=false;
		}
        private void cmbjxdl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            int nrow = this.myDataGrid1.CurrentCell.RowNumber;
            int ncol = this.myDataGrid1.CurrentCell.ColumnNumber;
            string columnName = this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol].HeaderText.Trim();
            if (columnName.Trim() == "剂型大类")
            {
                DataTable tb = (DataTable)this.myDataGrid1.DataSource;
                tb.Rows[nrow][ncol] = cmbjxdl.Text;
                tb.Rows[nrow]["JXDL"] = cmbjxdl.SelectedValue;
                this.myDataGrid1.CurrentCell = new DataGridCell(nrow + 1, 1);
                return;
            }
            this.cmbjxdl.Visible = false;
        }

		private void butprint_Click(object sender, System.EventArgs e)
		{
			try
			{
				#region 简单打印

				this.butprint.Enabled=false;

				Excel.Application myExcel = new Excel.Application( ) ;

				myExcel.Application.Workbooks.Add (true ) ;
			
				//查询条件
				string swhere="";

				//写入行头
				DataTable tb=(DataTable)this.myDataGrid1.DataSource;
				int SumRowCount=tb.Rows.Count;
				int SumColCount=0;

				for(int j=0;j<this.myDataGrid1.TableStyles[0].GridColumnStyles.Count;j++)
				{
					if (this.myDataGrid1.TableStyles[0].GridColumnStyles[j].Width>0)
					{
						SumColCount=SumColCount+1;
						myExcel.Cells[5,SumColCount]=this.myDataGrid1.TableStyles[0].GridColumnStyles[j].HeaderText.Trim() ;
					}
				
				}
				myExcel.get_Range(myExcel.Cells[5,1],myExcel.Cells[5,SumColCount]).Font.Bold = true;
				myExcel.get_Range(myExcel.Cells[5,1],myExcel.Cells[5,SumColCount]).Font.Size = 10;


				//逐行写入数据，
				
				for(int i=0;i<tb.Rows.Count;i++)
				{
					int ncol=0;
					for(int j=0;j<tb.Columns.Count;j++)
					{
						if (this.myDataGrid1.TableStyles[0].GridColumnStyles[j].Width>0)
						{
							ncol=ncol+1;
							myExcel.Cells[6+i,ncol]="'"+tb.Rows[i][j].ToString().Trim();
							
						}
					}
				}

				//设置报表表格为最适应宽度
				myExcel.get_Range(myExcel.Cells[6,1],myExcel.Cells[5+SumRowCount,SumColCount]).Select();
				myExcel.get_Range(myExcel.Cells[6,1],myExcel.Cells[5+SumRowCount,SumColCount]).Columns.AutoFit();
				
				//加边框
				myExcel.get_Range(myExcel.Cells[5,1],myExcel.Cells[5+SumRowCount,SumColCount]).Borders.LineStyle = 1;

				//报表名称
				myExcel.Cells[1,1]="药品剂型表";
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).Font.Bold = true;
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).Font.Size = 16;
				//报表名称跨行居中
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).Select();
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenterAcrossSelection;

				//报表条件
				myExcel.Cells[3,1]=swhere.Trim();
				myExcel.get_Range(myExcel.Cells[3,1],myExcel.Cells[3,SumColCount]).Font.Size = 10;
				myExcel.get_Range(myExcel.Cells[3,1],myExcel.Cells[3,SumColCount]).Select();
				myExcel.get_Range(myExcel.Cells[3,1],myExcel.Cells[5,SumColCount]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

				//最后一行为黄色
				//myExcel.get_Range(myExcel.Cells[5+SumRowCount,1],myExcel.Cells[5+SumRowCount,SumColCount]).Interior.ColorIndex = 19;
			

				//让Excel文件可见
				myExcel.Visible=true;
				this.butprint.Enabled=true;

				#endregion 
			}
			catch(System.Exception err)
			{
				this.butprint.Enabled=true;
				MessageBox.Show(err.Message);
			}
		}

		private void cmbyplx_Move(object sender, System.EventArgs e)
		{
			this.cmbyplx.Focus();
		}

        private void cmbjxdl_Move(object sender, EventArgs e)
        {
            this.cmbjxdl.Focus();
        }

		

	}
}
