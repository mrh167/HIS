using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TrasenFrame.Classes;
using TrasenClasses.GeneralControls;
using TrasenClasses.GeneralClasses;
using YpClass;
using System.IO;
//using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ts_yp_tj
{
	/// <summary>
	/// Frmyprk 的摘要说明。
	/// </summary>
	public class Frmyptj : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.StatusBarPanel statusBarPanel4;
		private System.Windows.Forms.Label lblrkrq;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblrkfs;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
		private System.Windows.Forms.TextBox txtbz;
		private System.Windows.Forms.Label lbldjh;
		private System.Windows.Forms.Label lbldjhdd;
		private System.Windows.Forms.TextBox txttjwh;
		private System.Windows.Forms.ComboBox cmbtjfs;
		private System.Windows.Forms.Label lbldwcj;
		private System.Windows.Forms.TextBox txtxlsj;
		private System.Windows.Forms.TextBox txtxpfj;
		private System.Windows.Forms.Button butmodif;
		private System.Windows.Forms.Button butdel;
		private System.Windows.Forms.Button butadd;
		private System.Windows.Forms.Label lblkc;
		private System.Windows.Forms.Label lblylsj;
		private System.Windows.Forms.Label lblypfj;
		private System.Windows.Forms.Label lblypmc;
		private System.Windows.Forms.Label lblcj;
		private System.Windows.Forms.Label lblgg;
		private System.Windows.Forms.TextBox txtypdm;
		private System.Windows.Forms.Button butclose;
		private System.Windows.Forms.Button butprint;
		private System.Windows.Forms.Button butsave;
		private System.Windows.Forms.Button butnew;
		private myDataGrid.myDataGrid myDataGrid1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
		private System.Windows.Forms.Label lbldw;
		private System.Windows.Forms.Label lblhh;
		private System.Windows.Forms.DateTimePicker dtpsj;
		private System.Windows.Forms.DateTimePicker dtprq;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox checkBox1;
		private myDataGrid.myDataGrid myDataGrid2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn25;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn26;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn27;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn28;
		private System.Windows.Forms.DataGridTextBoxColumn col_上次进价;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn30;
		private System.Windows.Forms.TextBox txtmrjj;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridTextBoxColumn col_默认进价;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblscjj;
		private System.Windows.Forms.Label lblscghdw;
		private System.Windows.Forms.Label label11;
		private MenuTag _menuTag;
		private string _chineseName;
		private Form _mdiParent;
		private System.Windows.Forms.Label lblpm;
		private System.Windows.Forms.DataGridTextBoxColumn 商品名;
		private YpConfig ss;
        private System.Windows.Forms.Label lblsdjh;
        private SystemCfg klcfg;
        private bool bpcgl = false;//是否进行批次管理
        private bool btjhj = false;
        private System.Windows.Forms.Button btn_PL;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_CY_PL;//是否调进货价

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Frmyptj(MenuTag menuTag,string chineseName,Form mdiParent)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			_menuTag=menuTag;
			_chineseName=chineseName;
			_mdiParent=mdiParent;

            this.Text = chineseName;
            this.Text = this.Text + " [" + InstanceForm._menuTag.Jgbm + "]";
            ss = new YpConfig(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase);

             klcfg = new SystemCfg(8024);

             //初始化未发药处方列表
             FunBase.CsDataGrid(this.myDataGrid1, this.myDataGrid1.TableStyles[0], "Tb");
             FunBase.CsDataGrid(this.myDataGrid2, this.myDataGrid2.TableStyles[0], "Tb1");
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
				if(components != null)
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PL = new System.Windows.Forms.Button();
            this.lblsdjh = new System.Windows.Forms.Label();
            this.dtpsj = new System.Windows.Forms.DateTimePicker();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldjh = new System.Windows.Forms.Label();
            this.lbldjhdd = new System.Windows.Forms.Label();
            this.dtprq = new System.Windows.Forms.DateTimePicker();
            this.lblrkrq = new System.Windows.Forms.Label();
            this.txttjwh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbtjfs = new System.Windows.Forms.ComboBox();
            this.lblrkfs = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblpm = new System.Windows.Forms.Label();
            this.lblscghdw = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblscjj = new System.Windows.Forms.Label();
            this.txtmrjj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldw = new System.Windows.Forms.Label();
            this.lbldwcj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxlsj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxpfj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butmodif = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.lblkc = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblylsj = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblypfj = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblhh = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblypmc = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblcj = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblgg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtypdm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myDataGrid1 = new myDataGrid.myDataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.商品名 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.col_上次进价 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.col_默认进价 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn30 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.myDataGrid2 = new myDataGrid.myDataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn28 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.butsave = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.butclose = new System.Windows.Forms.Button();
            this.butprint = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.btn_CY_PL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CY_PL);
            this.groupBox1.Controls.Add(this.btn_PL);
            this.groupBox1.Controls.Add(this.lblsdjh);
            this.groupBox1.Controls.Add(this.dtpsj);
            this.groupBox1.Controls.Add(this.txtbz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbldjh);
            this.groupBox1.Controls.Add(this.lbldjhdd);
            this.groupBox1.Controls.Add(this.dtprq);
            this.groupBox1.Controls.Add(this.lblrkrq);
            this.groupBox1.Controls.Add(this.txttjwh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbtjfs);
            this.groupBox1.Controls.Add(this.lblrkfs);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_PL
            // 
            this.btn_PL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_PL.Location = new System.Drawing.Point(743, 35);
            this.btn_PL.Name = "btn_PL";
            this.btn_PL.Size = new System.Drawing.Size(116, 24);
            this.btn_PL.TabIndex = 18;
            this.btn_PL.Text = "批量调价显示";
            this.btn_PL.Click += new System.EventHandler(this.btn_PL_Click);
            // 
            // lblsdjh
            // 
            this.lblsdjh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsdjh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblsdjh.Location = new System.Drawing.Point(741, 12);
            this.lblsdjh.Name = "lblsdjh";
            this.lblsdjh.Size = new System.Drawing.Size(118, 20);
            this.lblsdjh.TabIndex = 17;
            // 
            // dtpsj
            // 
            this.dtpsj.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpsj.Location = new System.Drawing.Point(517, 11);
            this.dtpsj.Name = "dtpsj";
            this.dtpsj.Size = new System.Drawing.Size(72, 21);
            this.dtpsj.TabIndex = 3;
            this.dtpsj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // txtbz
            // 
            this.txtbz.ForeColor = System.Drawing.Color.Navy;
            this.txtbz.Location = new System.Drawing.Point(64, 37);
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(675, 21);
            this.txtbz.TabIndex = 4;
            this.txtbz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "备注";
            // 
            // lbldjh
            // 
            this.lbldjh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldjh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbldjh.Location = new System.Drawing.Point(649, 12);
            this.lbldjh.Name = "lbldjh";
            this.lbldjh.Size = new System.Drawing.Size(90, 20);
            this.lbldjh.TabIndex = 15;
            // 
            // lbldjhdd
            // 
            this.lbldjhdd.Location = new System.Drawing.Point(594, 16);
            this.lbldjhdd.Name = "lbldjhdd";
            this.lbldjhdd.Size = new System.Drawing.Size(64, 16);
            this.lbldjhdd.TabIndex = 14;
            this.lbldjhdd.Text = "调价单号";
            // 
            // dtprq
            // 
            this.dtprq.Location = new System.Drawing.Point(403, 11);
            this.dtprq.Name = "dtprq";
            this.dtprq.Size = new System.Drawing.Size(111, 21);
            this.dtprq.TabIndex = 2;
            this.dtprq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // lblrkrq
            // 
            this.lblrkrq.Location = new System.Drawing.Point(348, 16);
            this.lblrkrq.Name = "lblrkrq";
            this.lblrkrq.Size = new System.Drawing.Size(64, 16);
            this.lblrkrq.TabIndex = 4;
            this.lblrkrq.Text = "调价日期";
            // 
            // txttjwh
            // 
            this.txttjwh.ForeColor = System.Drawing.Color.Navy;
            this.txttjwh.Location = new System.Drawing.Point(227, 11);
            this.txttjwh.Name = "txttjwh";
            this.txttjwh.Size = new System.Drawing.Size(114, 21);
            this.txttjwh.TabIndex = 1;
            this.txttjwh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(174, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "调价文号";
            // 
            // cmbtjfs
            // 
            this.cmbtjfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtjfs.ForeColor = System.Drawing.Color.Red;
            this.cmbtjfs.ItemHeight = 12;
            this.cmbtjfs.Items.AddRange(new object[] {
            "立即调价",
            "稍后调价"});
            this.cmbtjfs.Location = new System.Drawing.Point(65, 12);
            this.cmbtjfs.Name = "cmbtjfs";
            this.cmbtjfs.Size = new System.Drawing.Size(106, 20);
            this.cmbtjfs.TabIndex = 0;
            this.cmbtjfs.SelectedIndexChanged += new System.EventHandler(this.cmbtjfs_SelectedIndexChanged);
            this.cmbtjfs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // lblrkfs
            // 
            this.lblrkfs.Location = new System.Drawing.Point(8, 16);
            this.lblrkfs.Name = "lblrkfs";
            this.lblrkfs.Size = new System.Drawing.Size(64, 16);
            this.lblrkfs.TabIndex = 0;
            this.lblrkfs.Text = "调价方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblpm);
            this.groupBox2.Controls.Add(this.lblscghdw);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblscjj);
            this.groupBox2.Controls.Add(this.txtmrjj);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbldw);
            this.groupBox2.Controls.Add(this.lbldwcj);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtxlsj);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtxpfj);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.butmodif);
            this.groupBox2.Controls.Add(this.butdel);
            this.groupBox2.Controls.Add(this.butadd);
            this.groupBox2.Controls.Add(this.lblkc);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.lblylsj);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lblypfj);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblhh);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblypmc);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblcj);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblgg);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtypdm);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblpm
            // 
            this.lblpm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpm.ForeColor = System.Drawing.Color.Navy;
            this.lblpm.Location = new System.Drawing.Point(232, 14);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(144, 20);
            this.lblpm.TabIndex = 71;
            // 
            // lblscghdw
            // 
            this.lblscghdw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblscghdw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblscghdw.ForeColor = System.Drawing.Color.Navy;
            this.lblscghdw.Location = new System.Drawing.Point(657, 40);
            this.lblscghdw.Name = "lblscghdw";
            this.lblscghdw.Size = new System.Drawing.Size(167, 20);
            this.lblscghdw.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(601, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "上次供货商";
            // 
            // lblscjj
            // 
            this.lblscjj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblscjj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblscjj.ForeColor = System.Drawing.Color.Navy;
            this.lblscjj.Location = new System.Drawing.Point(514, 40);
            this.lblscjj.Name = "lblscjj";
            this.lblscjj.Size = new System.Drawing.Size(84, 20);
            this.lblscjj.TabIndex = 67;
            // 
            // txtmrjj
            // 
            this.txtmrjj.ForeColor = System.Drawing.Color.Navy;
            this.txtmrjj.Location = new System.Drawing.Point(514, 64);
            this.txtmrjj.Name = "txtmrjj";
            this.txtmrjj.Size = new System.Drawing.Size(84, 21);
            this.txtmrjj.TabIndex = 8;
            this.txtmrjj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmrjj_KeyUp);
            this.txtmrjj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(458, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "默认进价";
            // 
            // lbldw
            // 
            this.lbldw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbldw.ForeColor = System.Drawing.Color.Navy;
            this.lbldw.Location = new System.Drawing.Point(128, 40);
            this.lbldw.Name = "lbldw";
            this.lbldw.Size = new System.Drawing.Size(40, 20);
            this.lbldw.TabIndex = 64;
            // 
            // lbldwcj
            // 
            this.lbldwcj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldwcj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbldwcj.ForeColor = System.Drawing.Color.Navy;
            this.lbldwcj.Location = new System.Drawing.Point(64, 65);
            this.lbldwcj.Name = "lbldwcj";
            this.lbldwcj.Size = new System.Drawing.Size(104, 20);
            this.lbldwcj.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "单位差价";
            // 
            // txtxlsj
            // 
            this.txtxlsj.ForeColor = System.Drawing.Color.Navy;
            this.txtxlsj.Location = new System.Drawing.Point(370, 64);
            this.txtxlsj.Name = "txtxlsj";
            this.txtxlsj.Size = new System.Drawing.Size(80, 21);
            this.txtxlsj.TabIndex = 7;
            this.txtxlsj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtxlsj_KeyUp);
            this.txtxlsj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(314, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "现零售价";
            // 
            // txtxpfj
            // 
            this.txtxpfj.ForeColor = System.Drawing.Color.Navy;
            this.txtxpfj.Location = new System.Drawing.Point(232, 65);
            this.txtxpfj.Name = "txtxpfj";
            this.txtxpfj.Size = new System.Drawing.Size(80, 21);
            this.txtxpfj.TabIndex = 66;
            this.txtxpfj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtxpfj_KeyUp);
            this.txtxpfj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "现批发价";
            // 
            // butmodif
            // 
            this.butmodif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butmodif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butmodif.Location = new System.Drawing.Point(759, 63);
            this.butmodif.Name = "butmodif";
            this.butmodif.Size = new System.Drawing.Size(64, 24);
            this.butmodif.TabIndex = 11;
            this.butmodif.Text = "修改(&M)";
            this.butmodif.Click += new System.EventHandler(this.butmodif_Click);
            // 
            // butdel
            // 
            this.butdel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butdel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butdel.Location = new System.Drawing.Point(687, 63);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(64, 24);
            this.butdel.TabIndex = 10;
            this.butdel.Text = "删除(&D)";
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butadd
            // 
            this.butadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butadd.Location = new System.Drawing.Point(615, 63);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(64, 24);
            this.butadd.TabIndex = 9;
            this.butadd.Text = "添加(&A)";
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // lblkc
            // 
            this.lblkc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblkc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblkc.ForeColor = System.Drawing.Color.Navy;
            this.lblkc.Location = new System.Drawing.Point(64, 40);
            this.lblkc.Name = "lblkc";
            this.lblkc.Size = new System.Drawing.Size(64, 20);
            this.lblkc.TabIndex = 51;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(21, 41);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(48, 16);
            this.label36.TabIndex = 50;
            this.label36.Text = "库存量";
            // 
            // lblylsj
            // 
            this.lblylsj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblylsj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblylsj.ForeColor = System.Drawing.Color.Navy;
            this.lblylsj.Location = new System.Drawing.Point(370, 40);
            this.lblylsj.Name = "lblylsj";
            this.lblylsj.Size = new System.Drawing.Size(80, 20);
            this.lblylsj.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(314, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 28;
            this.label23.Text = "原零售价";
            // 
            // lblypfj
            // 
            this.lblypfj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblypfj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblypfj.ForeColor = System.Drawing.Color.Navy;
            this.lblypfj.Location = new System.Drawing.Point(232, 40);
            this.lblypfj.Name = "lblypfj";
            this.lblypfj.Size = new System.Drawing.Size(80, 20);
            this.lblypfj.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(176, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 16);
            this.label20.TabIndex = 26;
            this.label20.Text = "原批发价";
            // 
            // lblhh
            // 
            this.lblhh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblhh.Location = new System.Drawing.Point(752, 15);
            this.lblhh.Name = "lblhh";
            this.lblhh.Size = new System.Drawing.Size(72, 20);
            this.lblhh.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(720, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "货号";
            // 
            // lblypmc
            // 
            this.lblypmc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblypmc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblypmc.ForeColor = System.Drawing.Color.Navy;
            this.lblypmc.Location = new System.Drawing.Point(376, 14);
            this.lblypmc.Name = "lblypmc";
            this.lblypmc.Size = new System.Drawing.Size(104, 20);
            this.lblypmc.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(176, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "药品名称";
            // 
            // lblcj
            // 
            this.lblcj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcj.Location = new System.Drawing.Point(632, 15);
            this.lblcj.Name = "lblcj";
            this.lblcj.Size = new System.Drawing.Size(83, 20);
            this.lblcj.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(600, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "厂家";
            // 
            // lblgg
            // 
            this.lblgg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblgg.ForeColor = System.Drawing.Color.Navy;
            this.lblgg.Location = new System.Drawing.Point(512, 15);
            this.lblgg.Name = "lblgg";
            this.lblgg.Size = new System.Drawing.Size(84, 20);
            this.lblgg.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(480, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "规格";
            // 
            // txtypdm
            // 
            this.txtypdm.ForeColor = System.Drawing.Color.Navy;
            this.txtypdm.Location = new System.Drawing.Point(64, 15);
            this.txtypdm.Name = "txtypdm";
            this.txtypdm.Size = new System.Drawing.Size(104, 21);
            this.txtypdm.TabIndex = 5;
            this.txtypdm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextKeyUp);
            this.txtypdm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoNext);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "药品代码";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(458, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "上次进价";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(968, 452);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 384);
            this.panel2.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.myDataGrid1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 293);
            this.panel3.TabIndex = 64;
            // 
            // myDataGrid1
            // 
            this.myDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.myDataGrid1.CaptionVisible = false;
            this.myDataGrid1.DataMember = "";
            this.myDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGrid1.ForeColor = System.Drawing.Color.Navy;
            this.myDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.myDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.myDataGrid1.Name = "myDataGrid1";
            this.myDataGrid1.Size = new System.Drawing.Size(962, 293);
            this.myDataGrid1.TabIndex = 60;
            this.myDataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            this.myDataGrid1.CurrentCellChanged += new System.EventHandler(this.myDataGrid1_CurrentCellChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.AllowSorting = false;
            this.dataGridTableStyle1.DataGrid = this.myDataGrid1;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.商品名,
            this.dataGridTextBoxColumn3,
            this.dataGridTextBoxColumn4,
            this.dataGridTextBoxColumn5,
            this.dataGridTextBoxColumn6,
            this.dataGridTextBoxColumn7,
            this.dataGridTextBoxColumn8,
            this.dataGridTextBoxColumn9,
            this.dataGridTextBoxColumn10,
            this.dataGridTextBoxColumn11,
            this.dataGridTextBoxColumn12,
            this.dataGridTextBoxColumn13,
            this.dataGridTextBoxColumn16,
            this.dataGridTextBoxColumn15,
            this.col_上次进价,
            this.col_默认进价,
            this.dataGridTextBoxColumn14,
            this.dataGridTextBoxColumn30});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.ReadOnly = true;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "序号";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 40;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "品名";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 120;
            // 
            // 商品名
            // 
            this.商品名.Format = "";
            this.商品名.FormatInfo = null;
            this.商品名.HeaderText = "商品名";
            this.商品名.Width = 120;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "规格";
            this.dataGridTextBoxColumn3.NullText = "";
            this.dataGridTextBoxColumn3.Width = 90;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "厂家";
            this.dataGridTextBoxColumn4.NullText = "";
            this.dataGridTextBoxColumn4.Width = 90;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "库存";
            this.dataGridTextBoxColumn5.NullText = "";
            this.dataGridTextBoxColumn5.Width = 50;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "单位";
            this.dataGridTextBoxColumn6.NullText = "";
            this.dataGridTextBoxColumn6.Width = 40;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "原批发价";
            this.dataGridTextBoxColumn7.NullText = "";
            this.dataGridTextBoxColumn7.Width = 60;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "现批发价";
            this.dataGridTextBoxColumn8.NullText = "";
            this.dataGridTextBoxColumn8.Width = 60;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "原零售价";
            this.dataGridTextBoxColumn9.NullText = "";
            this.dataGridTextBoxColumn9.Width = 60;
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.HeaderText = "现零售价";
            this.dataGridTextBoxColumn10.NullText = "";
            this.dataGridTextBoxColumn10.Width = 60;
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            this.dataGridTextBoxColumn11.HeaderText = "调价差价";
            this.dataGridTextBoxColumn11.NullText = "";
            this.dataGridTextBoxColumn11.Width = 60;
            // 
            // dataGridTextBoxColumn12
            // 
            this.dataGridTextBoxColumn12.Format = "";
            this.dataGridTextBoxColumn12.FormatInfo = null;
            this.dataGridTextBoxColumn12.HeaderText = "调价金额";
            this.dataGridTextBoxColumn12.NullText = "";
            this.dataGridTextBoxColumn12.Width = 70;
            // 
            // dataGridTextBoxColumn13
            // 
            this.dataGridTextBoxColumn13.Format = "";
            this.dataGridTextBoxColumn13.FormatInfo = null;
            this.dataGridTextBoxColumn13.HeaderText = "CJID";
            this.dataGridTextBoxColumn13.NullText = "";
            this.dataGridTextBoxColumn13.Width = 0;
            // 
            // dataGridTextBoxColumn16
            // 
            this.dataGridTextBoxColumn16.Format = "";
            this.dataGridTextBoxColumn16.FormatInfo = null;
            this.dataGridTextBoxColumn16.HeaderText = "dwbl";
            this.dataGridTextBoxColumn16.NullText = "";
            this.dataGridTextBoxColumn16.ReadOnly = true;
            this.dataGridTextBoxColumn16.Width = 0;
            // 
            // dataGridTextBoxColumn15
            // 
            this.dataGridTextBoxColumn15.Format = "";
            this.dataGridTextBoxColumn15.FormatInfo = null;
            this.dataGridTextBoxColumn15.HeaderText = "id";
            this.dataGridTextBoxColumn15.NullText = "";
            this.dataGridTextBoxColumn15.ReadOnly = true;
            this.dataGridTextBoxColumn15.Width = 0;
            // 
            // col_上次进价
            // 
            this.col_上次进价.Format = "";
            this.col_上次进价.FormatInfo = null;
            this.col_上次进价.HeaderText = "上次进价";
            this.col_上次进价.Width = 70;
            // 
            // col_默认进价
            // 
            this.col_默认进价.Format = "";
            this.col_默认进价.FormatInfo = null;
            this.col_默认进价.HeaderText = "默认进价";
            this.col_默认进价.Width = 70;
            // 
            // dataGridTextBoxColumn14
            // 
            this.dataGridTextBoxColumn14.Format = "";
            this.dataGridTextBoxColumn14.FormatInfo = null;
            this.dataGridTextBoxColumn14.HeaderText = "货号";
            this.dataGridTextBoxColumn14.NullText = "";
            this.dataGridTextBoxColumn14.Width = 60;
            // 
            // dataGridTextBoxColumn30
            // 
            this.dataGridTextBoxColumn30.Format = "";
            this.dataGridTextBoxColumn30.FormatInfo = null;
            this.dataGridTextBoxColumn30.HeaderText = "上次供货商";
            this.dataGridTextBoxColumn30.Width = 150;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 293);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(962, 3);
            this.splitter1.TabIndex = 63;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.myDataGrid2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 88);
            this.panel4.TabIndex = 62;
            this.panel4.Visible = false;
            // 
            // myDataGrid2
            // 
            this.myDataGrid2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.myDataGrid2.CaptionVisible = false;
            this.myDataGrid2.DataMember = "";
            this.myDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.myDataGrid2.Location = new System.Drawing.Point(0, 0);
            this.myDataGrid2.Name = "myDataGrid2";
            this.myDataGrid2.ReadOnly = true;
            this.myDataGrid2.Size = new System.Drawing.Size(962, 88);
            this.myDataGrid2.TabIndex = 0;
            this.myDataGrid2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle2});
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.DataGrid = this.myDataGrid2;
            this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn18,
            this.dataGridTextBoxColumn19,
            this.dataGridTextBoxColumn20,
            this.dataGridTextBoxColumn21,
            this.dataGridTextBoxColumn22,
            this.dataGridTextBoxColumn23,
            this.dataGridTextBoxColumn17,
            this.dataGridTextBoxColumn27,
            this.dataGridTextBoxColumn28,
            this.dataGridTextBoxColumn24,
            this.dataGridTextBoxColumn25,
            this.dataGridTextBoxColumn26});
            this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataGridTextBoxColumn18
            // 
            this.dataGridTextBoxColumn18.Format = "";
            this.dataGridTextBoxColumn18.FormatInfo = null;
            this.dataGridTextBoxColumn18.HeaderText = "品名";
            this.dataGridTextBoxColumn18.Width = 120;
            // 
            // dataGridTextBoxColumn19
            // 
            this.dataGridTextBoxColumn19.Format = "";
            this.dataGridTextBoxColumn19.FormatInfo = null;
            this.dataGridTextBoxColumn19.HeaderText = "规格";
            this.dataGridTextBoxColumn19.Width = 75;
            // 
            // dataGridTextBoxColumn20
            // 
            this.dataGridTextBoxColumn20.Format = "";
            this.dataGridTextBoxColumn20.FormatInfo = null;
            this.dataGridTextBoxColumn20.HeaderText = "厂家";
            this.dataGridTextBoxColumn20.Width = 75;
            // 
            // dataGridTextBoxColumn21
            // 
            this.dataGridTextBoxColumn21.Format = "";
            this.dataGridTextBoxColumn21.FormatInfo = null;
            this.dataGridTextBoxColumn21.HeaderText = "供货单位";
            this.dataGridTextBoxColumn21.Width = 150;
            // 
            // dataGridTextBoxColumn22
            // 
            this.dataGridTextBoxColumn22.Format = "";
            this.dataGridTextBoxColumn22.FormatInfo = null;
            this.dataGridTextBoxColumn22.HeaderText = "入库数量";
            this.dataGridTextBoxColumn22.Width = 80;
            // 
            // dataGridTextBoxColumn23
            // 
            this.dataGridTextBoxColumn23.Format = "";
            this.dataGridTextBoxColumn23.FormatInfo = null;
            this.dataGridTextBoxColumn23.HeaderText = "单位";
            this.dataGridTextBoxColumn23.Width = 40;
            // 
            // dataGridTextBoxColumn17
            // 
            this.dataGridTextBoxColumn17.Format = "";
            this.dataGridTextBoxColumn17.FormatInfo = null;
            this.dataGridTextBoxColumn17.HeaderText = "扣率";
            this.dataGridTextBoxColumn17.Width = 55;
            // 
            // dataGridTextBoxColumn27
            // 
            this.dataGridTextBoxColumn27.Format = "";
            this.dataGridTextBoxColumn27.FormatInfo = null;
            this.dataGridTextBoxColumn27.HeaderText = "进价";
            this.dataGridTextBoxColumn27.Width = 60;
            // 
            // dataGridTextBoxColumn28
            // 
            this.dataGridTextBoxColumn28.Format = "";
            this.dataGridTextBoxColumn28.FormatInfo = null;
            this.dataGridTextBoxColumn28.HeaderText = "进货金额";
            this.dataGridTextBoxColumn28.Width = 75;
            // 
            // dataGridTextBoxColumn24
            // 
            this.dataGridTextBoxColumn24.Format = "";
            this.dataGridTextBoxColumn24.FormatInfo = null;
            this.dataGridTextBoxColumn24.HeaderText = "零售金额";
            this.dataGridTextBoxColumn24.Width = 75;
            // 
            // dataGridTextBoxColumn25
            // 
            this.dataGridTextBoxColumn25.Format = "";
            this.dataGridTextBoxColumn25.FormatInfo = null;
            this.dataGridTextBoxColumn25.HeaderText = "单据号";
            this.dataGridTextBoxColumn25.Width = 60;
            // 
            // dataGridTextBoxColumn26
            // 
            this.dataGridTextBoxColumn26.Format = "";
            this.dataGridTextBoxColumn26.FormatInfo = null;
            this.dataGridTextBoxColumn26.HeaderText = "单据日期";
            this.dataGridTextBoxColumn26.Width = 75;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Export);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.butsave);
            this.panel1.Controls.Add(this.butnew);
            this.panel1.Controls.Add(this.butclose);
            this.panel1.Controls.Add(this.butprint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 48);
            this.panel1.TabIndex = 61;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(652, 3);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(88, 24);
            this.btn_Export.TabIndex = 61;
            this.btn_Export.Text = "导  出";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(16, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 24);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "显示历史入库记录";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(472, 3);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(88, 24);
            this.butsave.TabIndex = 57;
            this.butsave.Text = "保存(&S)";
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // butnew
            // 
            this.butnew.Location = new System.Drawing.Point(384, 3);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(88, 24);
            this.butnew.TabIndex = 56;
            this.butnew.Text = "新单号(&N)";
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // butclose
            // 
            this.butclose.Location = new System.Drawing.Point(748, 3);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(88, 24);
            this.butclose.TabIndex = 59;
            this.butclose.Text = "关闭(&Q)";
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // butprint
            // 
            this.butprint.Enabled = false;
            this.butprint.Location = new System.Drawing.Point(560, 3);
            this.butprint.Name = "butprint";
            this.butprint.Size = new System.Drawing.Size(88, 24);
            this.butprint.TabIndex = 58;
            this.butprint.Text = "打印(&P)";
            this.butprint.Click += new System.EventHandler(this.butprint_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 588);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3,
            this.statusBarPanel4});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(968, 24);
            this.statusBar1.TabIndex = 3;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 150;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 150;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Width = 150;
            // 
            // statusBarPanel4
            // 
            this.statusBarPanel4.Name = "statusBarPanel4";
            this.statusBarPanel4.Width = 400;
            // 
            // btn_CY_PL
            // 
            this.btn_CY_PL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CY_PL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_CY_PL.Location = new System.Drawing.Point(861, 34);
            this.btn_CY_PL.Name = "btn_CY_PL";
            this.btn_CY_PL.Size = new System.Drawing.Size(88, 24);
            this.btn_CY_PL.TabIndex = 19;
            this.btn_CY_PL.Text = "草药批量调价";
            this.btn_CY_PL.Click += new System.EventHandler(this.btn_CY_PL_Click);
            // 
            // Frmyptj
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(968, 612);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmyptj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "药品调价单";
            this.Load += new System.EventHandler(this.Frmyptj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Frmyptj_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.dtprq.Value=DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase);
				this.dtpsj.Value =DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase);

				if (ss.网络内容显示商品名==true)
					this.商品名.Width=120;
				else
					this.商品名.Width=0;
				this.cmbtjfs.SelectedIndex=0;

                if (_menuTag.Function_Name == "Fun_ts_yp_tj_cx")
                {
                    butnew.Visible = false;
                    butsave.Enabled = false;
                }

                int deptid = Convert.ToInt32(InstanceForm.BCurrentDept.DeptId);
                bpcgl = Yp.BPcgl(deptid, InstanceForm.BDatabase);//是否进行批次管理

                SystemCfg cfg8056 = new SystemCfg(8056);//调进货价
                if (cfg8056.Config == "1")
                {
                    btjhj = true;
                }

                //if (btjhj && bpcgl)
                //{
                //    label7.Text = "原进货价";
                //    label5.Text = "现进货价";
                //}

                if (("136").Contains(InstanceForm.BCurrentDept.DeptId.ToString()))
                {
                    btn_CY_PL.Visible = true;
                }
                else
                {
                    btn_CY_PL.Visible = false;
                }

			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}


		#region 按钮事件
		//添加行
		private void butadd_Click(object sender, System.EventArgs e)
		{
			try
			{
                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				for (int i=0;i<=tb.Rows.Count-1;i++)
				{
					if (Convert.ToInt32(this.lblypmc.Tag)==Convert.ToInt32(tb.Rows[i]["cjid"]))
					{
						MessageBox.Show("在当前网格中已存在这个药品的调价信息，不能重复录入");
						return;
					}
				}

				DataRow row=tb.NewRow();
				this.Fillrow(row);
				if (row["品名"].ToString().Trim()!="") 
				{
					tb.Rows.Add(row);
					this.Sumje();
					this.myDataGrid1.Select(tb.Rows.Count-1);
					this.myDataGrid1.CurrentCell=new DataGridCell(tb.Rows.Count-1,3);
					this.csgroupbox2();
					this.butadd.Enabled=true;
				}

			}
			catch(System.Exception err)
			{
				MessageBox.Show(err.ToString());
			}
		}
	
		
		//删除行
		private void butdel_Click(object sender, System.EventArgs e)
		{
			try
			{
                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
				if (nrow>=tb.Rows.Count) return;
				if(MessageBox.Show("您确定要删除第"+Convert.ToString((nrow+1))+"行吗 ？","询问窗",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
				{
					DataRow datarow=tb.Rows[nrow];
					string ssql="delete from yf_tjmx where id='"+Convertor.IsNull(datarow["id"],Guid.Empty.ToString())+"'";
					int i=InstanceForm.BDatabase.DoCommand(ssql);
					tb.Rows.Remove(datarow);
					this.Sumje();
					this.csgroupbox2();
				}
				this.butadd.Enabled=true;
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}
		
		
		//新单据
		private void butnew_Click(object sender, System.EventArgs e)
		{
			this.csgroupbox1();
			this.csgroupbox2();
            System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
			tb.Rows.Clear();
			this.statusBar1.Panels[0].Text="";
			this.statusBar1.Panels[1].Text="";
			this.statusBar1.Panels[2].Text="";
			this.butadd.Enabled=true;
			this.butdel.Enabled=true;
			this.butmodif.Enabled=true;
			this.butsave.Enabled=true;
			this.butprint.Enabled=false;
			this.cmbtjfs.Focus();
		}

	
		//保存事件
		private void butsave_Click(object sender, System.EventArgs e)
		{

			long djh=0;
            string sdjh = "";
            Guid djid = Guid.Empty ;
			int err_code=0;
			string err_text="";
			string sDate=DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToString();;
            System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
			if (tb.Rows.Count==0) {MessageBox.Show("没有可保存的记录");return;}
			if (cmbtjfs.Text.Trim()=="立即调价") 
			{
				if(MessageBox.Show("您确定要立即进行调价吗 ？","询问窗",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
				return;
			}
			try
			{
				//判断是否存在没有审核的的单据
				if (cmbtjfs.Text.Trim()=="立即调价")
				{
					string ssql="";
					if (tb.Rows.Count>0) ssql=tb.Rows[0]["cjid"].ToString();
					for(int i=1;i<=tb.Rows.Count-1;i++)
					{
						ssql=ssql+","+tb.Rows[i]["cjid"].ToString();
					}
                    System.Data.DataTable tbsh = YF_TJ_TJMX.SelectWsh(ssql, out err_text, InstanceForm.BDatabase, InstanceForm._menuTag.Jgbm);
					if (tbsh.Rows.Count>0)
					{
						Frmwshdj f=new Frmwshdj(_menuTag,_chineseName,_mdiParent);
                        System.Drawing.Point point = new System.Drawing.Point(400, 500);
						f.Location=point;
						f.tb=tbsh;
                        f.lblbz.Text = err_text;
						f.ShowDialog();
                        
						return;
					}
                    if (err_text.Trim() != "")
                    {
                        if (MessageBox.Show(err_text + "\n 您确定继续执行调价吗？", "询问窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            return;
                    }

				}
			}
			catch(System.Exception err)
			{
				MessageBox.Show(err.Message);
				return;
			}
			

			this.butsave.Enabled=false;
            ts_HospData_Share.ts_update_log ts = new ts_HospData_Share.ts_update_log();
            Guid _DJID = Guid.Empty;
            Guid _DJID_ZX = Guid.Empty;

			try
			{
				InstanceForm.BDatabase.BeginTransaction();

				//产生单据号
                djh = this.lbldjh.Text.Trim() == "" ? Yp.SeekNewDjh(_menuTag.FunctionTag.Trim(), InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase) : Convert.ToInt64(this.lbldjh.Text);
				//保存单据表头
				int wcbj=cmbtjfs.Text.Trim()=="立即调价"?1:0;
				YF_TJ_TJMX.SaveDJ(new Guid(Convertor.IsNull(this.groupBox1.Tag,Guid.Empty.ToString())), 
					_menuTag.FunctionTag,
					djh,
					txttjwh.Text.Trim(),
					InstanceForm.BCurrentUser.EmployeeId,
					sDate,
					sDate,
					wcbj,
					0,
					InstanceForm.BCurrentDept.DeptId ,
					txtbz.Text.Trim(),
                    out djid, out err_code, out err_text, InstanceForm._menuTag.Jgbm, InstanceForm.BDatabase);
			
				//如果没有成功，抛出异常
				if (err_code!=0){throw new System.Exception(err_text);}

				int jj=10;
				int ii=100000/jj;
				//保存单据明细
                decimal tjhje = 0;
				for(int i=0;i<=tb.Rows.Count-1;i++)
				{
					decimal tpfje=(Convert.ToDecimal(tb.Rows[i]["现批发价"])-Convert.ToDecimal(tb.Rows[i]["原批发价"]))*Convert.ToDecimal(tb.Rows[i]["库存"]);
                    if (btjhj)
                    {
                        tjhje = (Convert.ToDecimal(tb.Rows[i]["默认进价"]) - Convert.ToDecimal(tb.Rows[i]["上次进价"])) * Convert.ToDecimal(tb.Rows[i]["库存"]);
                    }
                    else
                    {
                        tjhje = 0;
                    }
					YF_TJ_TJMX.SaveDJMX(
                        new Guid(Convertor.IsNull(tb.Rows[i]["id"],
                        Guid.Empty.ToString())),djid,
						Convert.ToInt32(tb.Rows[i]["cjid"]),
						Convert.ToDecimal(tb.Rows[i]["库存"]),
						Convert.ToString(tb.Rows[i]["单位"]),
						1,
						Convert.ToDecimal(tb.Rows[i]["原批发价"]),//kl
						Convert.ToDecimal(tb.Rows[i]["现批发价"]),
						Convert.ToDecimal(tpfje.ToString("0.00")),
						Convert.ToDecimal(tb.Rows[i]["原零售价"]),
						Convert.ToDecimal(tb.Rows[i]["现零售价"]),
						Convert.ToDecimal(tb.Rows[i]["调价金额"]),
						InstanceForm.BCurrentDept.DeptId ,
						djh,
						_menuTag.FunctionTag.Trim(),
						Convert.ToDecimal(tb.Rows[i]["默认进价"]),
						Convert.ToDecimal(tb.Rows[i]["上次进价"]),
						Convert.ToString(tb.Rows[i]["上次供货商"]),
                        out err_code, out err_text,InstanceForm.BDatabase
                       );
                    if (err_code != 0)
                    {
                        throw new Exception(err_text);
                    }
				}

				//如果没有成功，抛出异常
				if (err_code!=0){throw new System.Exception(err_text);}

				if (cmbtjfs.Text.Trim()=="立即调价")
				{
                    YF_TJ_TJMX.ExecQytj(djid, InstanceForm.BCurrentDept.DeptId, out sdjh, out err_code, out err_text, InstanceForm._menuTag.Jgbm, InstanceForm.BDatabase);
					//如果没有成功，抛出异常
					if (err_code!=0){throw new System.Exception(err_text);}

                    //三院数据处理
                    ts.Save_log(ts_HospData_Share.czlx.yp_药品调价, InstanceForm.BCurrentDept.DeptName + "调价,调价文号:" + txttjwh.Text, "YF_TJ", "ID", djid.ToString(), InstanceForm._menuTag.Jgbm, -999, "",out _DJID, InstanceForm.BDatabase);
                    //如果有中心机构且当前机构不是中心机构 则发送调价
                    if (InstanceForm._menuTag.Jgbm != TrasenFrame.Forms.FrmMdiMain.ZxJgbm && TrasenFrame.Forms.FrmMdiMain.ZxJgbm > 0)
                        ts.Save_log(ts_HospData_Share.czlx.yp_药品调价, "调整中心的药品字典价格: 调价科室 " + InstanceForm.BCurrentDept.DeptName + " 调价单号:" + djh + " 调价文号:" + txttjwh.Text, "YF_TJ", "ID", djid.ToString(), InstanceForm._menuTag.Jgbm,TrasenFrame.Forms.FrmMdiMain.ZxJgbm, 0, "仅更新中心药品字典", out _DJID_ZX, InstanceForm.BDatabase);
				}

                

				//提交事务
				InstanceForm.BDatabase.CommitTransaction();
                this.groupBox1.Tag = djid.ToString();
				this.lbldjh.Text=djh.ToString("00000000");
                this.lblsdjh.Text = sdjh;
				this.butadd.Enabled=false;
				this.butdel.Enabled=false;
				this.butmodif.Enabled=false;
				this.butprint.Enabled=true;
                if (cmbtjfs.Text.Trim() != "立即调价") { this.butsave.Enabled = true; FillDj(djid, false); }
				


			}
			catch(System.Exception err)
			{
				InstanceForm.BDatabase.RollbackTransaction();
               
				this.butsave.Enabled=true;
				MessageBox.Show(err.Message);
                return;
             }

            //三院数据处理
            string msg = "";
            string msg_zx="";
            try
            {
                ts_HospData_Share.ts_update_type ty = new ts_HospData_Share.ts_update_type((int)ts_HospData_Share.czlx.yp_药品调价, InstanceForm.BDatabase);
                if (ty.Bzx == 1 && _DJID != Guid.Empty)
                    ts.Pexec_log(_DJID, InstanceForm.BDatabase, out msg);
                if (ty.Bzx == 1 &&  _DJID_ZX != Guid.Empty)
                    ts.Pexec_log(_DJID_ZX, InstanceForm.BDatabase, out msg_zx);
            }
            catch (System.Exception err)
            {
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(err_text + msg+msg_zx);
		}

	
		//退出
		private void butclose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		//修改按钮事件
		private void butmodif_Click(object sender, System.EventArgs e)
		{
			try
			{
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				if (nrow>tb.Rows.Count-1) return;
				DataRow row=tb.Rows[nrow];
				this.Fillrow(row);
				if (row["货号"].ToString().Trim()!="")
				{
					this.Sumje();
					DataRow nullrow=tb.NewRow();
					this.Getrow(nullrow);
					this.butadd.Enabled=true;
				}
				this.txtypdm.Enabled=true;
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		#endregion

		#region 填充数据事
		private void Sumje()
		{
			try
			{
				decimal sumtjje=0;
                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				for( int i=0;i<=tb.Rows.Count-1;i++)
				{
					sumtjje=sumtjje+Convert.ToDecimal(tb.Rows[i]["调价金额"]);
				}
				this.statusBar1.Panels[0].Text ="调价金额: "+sumtjje.ToString("0.00");
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}

		private void csyp(int ggid,int cjid)
		{
			try
			{
				this.csgroupbox2();
				//Ydgg ydgg=new  Ydgg(ggid);
                Ypcj ydcj = new Ypcj(cjid, InstanceForm.BDatabase);
				this.lblypmc.Tag=ydcj.CJID.ToString();
				this.lblypmc.Text=ydcj.S_YPSPM;
				this.lblpm.Text=ydcj.S_YPPM;
				this.lblgg.Text=ydcj.S_YPGG;
				this.lblcj.Text=ydcj.S_SCCJ;
				this.lblhh.Text=ydcj.SHH;
				this.lblypfj.Text=ydcj.PFJ.ToString("0.00");
				this.lblylsj.Text=ydcj.LSJ.ToString("0.00") ;
				this.txtxpfj.Text="";
				this.txtxlsj.Text="";
				
				//DataTable tb=Yp.Selectkc(InstanceForm.BCurrentDept.DeptId,ydcj.CJID,Yp.Seek_kcmx_table(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase));

                string ssql = "select coalesce(sum(kcl/dwbl),0) kcl from " + Yp.Seek_kcmx_table(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase) + "  (nolock) " +
                    " where (deptid=" + InstanceForm.BCurrentDept.DeptId + " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + ") ) and cjid=" + cjid;
                System.Data.DataTable tb = InstanceForm.BDatabase.GetDataTable(ssql);
                if (tb.Rows.Count!=0)
				{
					this.lblkc.Text=Convert.ToString(Math.Round(Convert.ToDecimal(tb.Rows[0]["kcl"]),3));
					//lblscjj.Text=tb.Rows[0]["scjj"].ToString();
					//lblscghdw.Text=Yp.SeekGhdw(Convert.ToInt32(tb.Rows[0]["ghdw"]));
				}
				else
				{
					this.lblkc.Text="0";
					lblscjj.Text="";
					lblscghdw.Text="";
				}
				this.lbldw.Text=ydcj.S_YPDW;
				this.txtmrjj.Text=ydcj.MRJJ.ToString();
                if (btjhj)
                {
                    lblscjj.Text = ydcj.MRJJ.ToString();
                }
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}

		//填充行
		private void Fillrow(System.Data.DataRow row)
		{
				if (Convert.ToInt32(this.lblypmc.Tag)==0) 
				{
					MessageBox.Show("没有可添加的药品");
					return;
				}

				if (Convertor.IsNull(this.txtxlsj.Text,"0")=="0")
				{
					MessageBox.Show("请输入现零售价");
					return;
				}

                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				row["序号"]=tb.Rows.Count+1;
				row["品名"]=this.lblpm.Text.Trim();
				row["商品名"]=this.lblypmc.Text.Trim();
				row["规格"]=this.lblgg.Text.Trim();
				row["厂家"]=this.lblcj.Text.Trim();
				row["库存"]=this.lblkc.Text.Trim();
				row["单位"]=this.lbldw.Text.Trim();
				row["原批发价"]=this.lblypfj.Text.Trim();
				row["现批发价"]=Convertor.IsNull(this.txtxpfj.Text.Trim(),"0");
				row["原零售价"]=this.lblylsj.Text.Trim();
				row["现零售价"]=Convertor.IsNull(this.txtxlsj.Text.Trim(),"0");
				row["调价差价"]=this.lbldwcj.Text.Trim();
				decimal sumtjje=Convert.ToDecimal(Convertor.IsNull(this.lblkc.Text,"0"))*Convert.ToDecimal(Convertor.IsNull(this.lbldwcj.Text.Trim(),"0"));
				row["调价金额"]=sumtjje.ToString("0.00");
				row["货号"]=this.lblhh.Text.Trim();
				row["CJID"]=this.lblypmc.Tag.ToString();
				row["DWBL"]=1;
				row["默认进价"]=Convertor.IsNull(this.txtmrjj.Text.Trim(),"0");
			    row["上次进价"]=Convertor.IsNull(this.lblscjj.Text.Trim(),"0");
				row["上次供货商"]=this.lblscghdw.Text.Trim();
				this.SortRowNO();
		}

		//获取一行
		private void Getrow(DataRow row)
		{
			int cjid=Convert.ToInt32(Convertor.IsNull(row["cjid"],"0"));
            Ypcj ydcj = new Ypcj(cjid, InstanceForm.BDatabase);
			this.lblypmc.Text=row["商品名"].ToString();
			this.lblpm.Text=row["品名"].ToString();
			this.lblypmc.Tag=row["CJID"].ToString();
			this.lblgg.Text=row["规格"].ToString();
			this.lblcj.Text=row["厂家"].ToString();
			this.lblypfj.Text=row["原批发价"].ToString();
			this.txtxpfj.Text=row["现批发价"].ToString();
			this.lblylsj.Text=row["原零售价"].ToString();
			this.txtxlsj.Text=row["现零售价"].ToString();
			
			this.lblkc.Text=row["库存"].ToString();
			this.lbldw.Text=row["单位"].ToString();
			this.lbldwcj.Text=row["调价差价"].ToString();
			this.lblhh.Text=ydcj.SHH;
			
			this.txtmrjj.Text=row["默认进价"].ToString();
			this.lblscjj.Text=row["上次进价"].ToString();
			this.lblscghdw.Text=row["上次供货商"].ToString();
			if (this.checkBox1.Checked==true)
				this.Selectrk(ydcj.CJID);
			
		}

		//重新排序行号
		private void SortRowNO()
		{
            System.Data.DataTable tb1 = (System.Data.DataTable)this.myDataGrid1.DataSource;
			for(int i=0;i<=tb1.Rows.Count-1;i++)
			{
				tb1.Rows[i]["序号"]=i+1;
			}
		}

		//填充单据
		public void FillDj(Guid  id,bool shbz)
		{
			try
			{
				string ssql="select * from yf_tj where id='"+id+"'";
                System.Data.DataTable tb = InstanceForm.BDatabase.GetDataTable(ssql);
				this.groupBox1.Tag=tb.Rows[0]["id"].ToString();
				this.txttjwh.Text=tb.Rows[0]["tjwh"].ToString().Trim();
				this.txtbz.Text=tb.Rows[0]["bz"].ToString();
				this.dtprq.Value=Convert.ToDateTime(tb.Rows[0]["zxrq"]);
				this.dtpsj.Value=Convert.ToDateTime(tb.Rows[0]["zxrq"]);
				long djh=Convert.ToInt64(tb.Rows[0]["djh"]);
				this.lbldjh.Text=djh.ToString("00000000");

                ssql = "select sdjh from vi_yk_dj where ywlx='" + _menuTag.FunctionTag.Trim() + "' and deptid=" + InstanceForm.BCurrentDept.DeptId + " and djh=" + djh + "";
                System.Data.DataTable tab = InstanceForm.BDatabase.GetDataTable(ssql);
                this.lblsdjh.Text = tab.Rows.Count == 0 ? "" : tab.Rows[0]["sdjh"].ToString();

				if (Convert.ToInt32(tb.Rows[0]["wcbj"])==1)
				{
					ssql="select 0 序号,B.s_yppm 品名,b.s_ypspm 商品名,b.s_ypgg 规格,b.s_sccj 厂家,"+
						" a.tjsl 库存,A.YPDW 单位,a.ypfj 原批发价,a.xpfj 现批发价,a.ylsj 原零售价,a.xlsj 现零售价,"+
						" (xlsj-ylsj) 调价差价,tlsje 调价金额,b.shh 货号,"+
						" a.cjid,ydwbl dwbl,a.id,mrjhj 默认进价,scjhj 上次进价,scghdw 上次供货商 from yf_tjmx a,yp_ypcjd b  where a.cjid=b.cjid and  djid='"+new Guid(tb.Rows[0]["id"].ToString())+"' and deptid="+InstanceForm.BCurrentDept.DeptId +" order by a.id ";
				}
				else
				{
					ssql="select 0 序号,B.s_yppm 品名,b.s_ypspm 商品名,b.s_ypgg 规格,b.s_sccj 厂家,"+
						" cast(coalesce(round(c.kcl,3),0) as decimal(15,3)) 库存,A.YPDW 单位,b.pfj 原批发价,a.xpfj 现批发价,b.lsj 原零售价,a.xlsj 现零售价,"+
						" (xlsj-b.lsj) 调价差价,coalesce(round((xlsj-b.lsj)*round(coalesce(c.kcl,0),3),2),0) 调价金额,b.shh 货号,"+
						" a.cjid,1 dwbl,a.id,mrjhj 默认进价,coalesce(scjhj,0) 上次进价,scghdw 上次供货商 "+
                     " from yf_tjmx a inner join yp_ypcjd b on a.cjid=b.cjid  "+
                     " left join "+
                        " ( select cjid,sum(kcl/dwbl) kcl from " + Yp.Seek_KcView_table(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase) +
                        " where deptid=" + InstanceForm.BCurrentDept.DeptId + 
                        " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + ") group by cjid  "+
                        " ) c  " +
                     " on a.cjid=c.cjid where  djid='"+new Guid(tb.Rows[0]["id"].ToString())+"'  order by a.id ";
				}
			System.Data.DataTable tbmx=InstanceForm.BDatabase.GetDataTable(ssql);
				FunBase.AddRowtNo(tbmx);
				tbmx.TableName="tbmx";
				this.myDataGrid1.DataSource=tbmx;
				this.myDataGrid1.TableStyles[0].MappingName ="tbmx";
				
				if (Convert.ToInt32(tb.Rows[0]["wcbj"])==1)
				{
					this.cmbtjfs.Enabled=false;
					this.butsave.Enabled=false;
					this.butadd.Enabled=false;
					this.butdel.Enabled=false;
					this.butmodif.Enabled=false;	
					this.butprint.Enabled=true;
					this.txtxlsj.Enabled=false;
					this.txtxpfj.Enabled=false;
					this.txttjwh.Enabled=false;
					this.txtypdm.Enabled=false;
					this.txtbz.Enabled=false;
					this.txtmrjj.Enabled=false;
				}
				
				this.Sumje();


                if (_menuTag.Function_Name == "Fun_ts_yp_tj_cx")
                {
                    butnew.Visible = false;
                    butsave.Enabled = false;
                }
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}

		}

		#endregion

		#region 界面控制事件
		//回车跳至下一个文本
		private void GotoNext(object sender, KeyPressEventArgs e)
		{ 
			Control control=(Control)sender;
			if (e.KeyChar==13 )
			{
				this.SelectNextControl(control,true,false,true,true);
			}
		}
		private void txtxlsj_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (Convertor.IsNumeric(this.txtxlsj.Text)==false) this.txtxlsj.Text="";
				decimal dwcj=Convert.ToDecimal(Convertor.IsNull(this.txtxlsj.Text,"0"))-Convert.ToDecimal(Convertor.IsNull(this.lblylsj.Text,"0"));
				this.lbldwcj.Text=dwcj.ToString("0.00");

                double kl = Convert.ToDouble(Convertor.IsNull(klcfg.Config, "0"));
                if (kl > 0)
                {
                    double xpfj = Convert.ToDouble(Convertor.IsNull(this.txtxlsj.Text, "0")) / kl;
                    this.txtxpfj.Text = xpfj.ToString("0.00");
                }
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}

		}

		private void txtxpfj_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (Convertor.IsNumeric(this.txtxpfj.Text)==false) this.txtxpfj.Text="";

		}

		private void TextKeyUp(object sender, KeyEventArgs e)//KeyEventArgs
		{

            YpConfig s = new YpConfig(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase);
			int nkey=Convert.ToInt32(e.KeyCode);
			Control control=(Control)sender;

			if (control.Text.Trim()=="" ){control.Text="";control.Tag="0";}

			if ((nkey>=65 &&  nkey<=90) || (nkey>=48 && nkey<=57) || (nkey>=96 && nkey<=105) || nkey==32 || nkey==46||(nkey==13 && (Convert.ToString(control.Tag)=="0" || Convert.ToString(control.Tag)=="")))
			{}else{return;}

			string[] GrdMappingName;
			int[] GrdWidth;
			string[]sfield;
			string ssql="";
			DataRow row;
				
			try
			{
                System.Drawing.Point point = new System.Drawing.Point(this.Location.X + control.Location.X, this.Location.Y + control.Location.Y + control.Height * 3);
				switch(control.TabIndex)
				{
					case 5:
						if (control.Text.Trim()=="") return;
						GrdMappingName=new string[] {"ggid","cjid","行号","品名","规格","厂家","库存量","单位","DWBL","批发价","零售价","货号"};
						GrdWidth=new int[] {0,0,30,140,90,90,60,30,0,60,60,70};
						sfield=new string[] {"wbm","pym","szm","ywm","ypbm"};
						

                        //if (s.是否允许对没有库存记录的药品进行调价==true)
                        //    ssql="select a.ggid,a.cjid,0 rowno,s_yppm,s_ypgg,s_sccj ,coalesce(kcl,null) ,coalesce(dbo.fun_yp_ypdw(zxdw),s_ypdw) ,coalesce(dwbl,1),pfj,lsj,shh from yp_ypcjd a inner join yp_ypbm b on a.ggid=b.ggid " +
                        //         " left join "+Yp.Seek_kcmx_table(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase)+" c on a.cjid=c.cjid and c.deptid="+InstanceForm.BCurrentDept.DeptId+
                        //         "  where a.n_ypzlx in(select ypzlx from yp_gllx where deptid="+InstanceForm.BCurrentDept.DeptId+")";
                        //else
                        //    ssql="select a.ggid,cjid,0 rowno,yppm,ypgg,s_sccj ,kcl ,dbo.fun_yp_ypdw(zxdw) ypdw,dwbl,pfj,lsj,shh from "+Yp.Seek_KcView_table(InstanceForm.BCurrentDept.DeptId)+" a,yp_ypbm b where a.ggid=b.ggid and a.deptid="+InstanceForm.BCurrentDept.DeptId +"  ";


                        ssql = "select distinct a.ggid,a.cjid,0 rowno,s_yppm,s_ypgg,s_sccj ,cast(coalesce(kcl,null) as float) ,s_ypdw ,1,pfj,lsj,shh " +
                            " from yp_ypcjd a left join " +
                            " (select cjid,sum(kcl/dwbl) kcl from yk_kcmx where deptid="+InstanceForm.BCurrentDept.DeptId+" or deptid in(select deptid from yp_yjks_gx where p_deptid="+InstanceForm.BCurrentDept.DeptId+") group by cjid ) b "+
                            " on a.cjid=b.cjid  inner join yp_ypbm c on a.ggid=c.ggid  ";
                        ssql = ssql + "  where a.n_ypzlx in(select ypzlx from yp_gllx where deptid=" + InstanceForm.BCurrentDept.DeptId + " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + "))";
                        TrasenFrame.Forms.Fshowcard f2 = new TrasenFrame.Forms.Fshowcard(GrdMappingName, GrdWidth, sfield, Constant.CustomFilterType, control.Text.Trim(), ssql);
    
						f2.Location=point;
						f2.Width=700;
						f2.Height=300;
						f2.ShowDialog(this);
						row=f2.dataRow;
						if (row!=null) 
						{
							this.csyp(Convert.ToInt32(row["ggid"]),Convert.ToInt32(row["cjid"]));
                            FindRecord(Convert.ToInt32(row["cjid"]), 0);
							this.SelectNextControl((Control)sender,true,false,true,true);
							
						}
						break;
				}
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}

		}

        public void FindRecord(int cjid, int nrow)
        {
            int beginrow = nrow;
            System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
            for (int i = beginrow; i <= tb.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(tb.Rows[i]["cjid"]) == cjid)
                {
                    this.myDataGrid1.CurrentCell = new DataGridCell(i, 0);
                    for (int j = 0; j <= tb.Rows.Count - 1; j++)
                    {
                        this.myDataGrid1.UnSelect(j);
                    }

                    this.myDataGrid1.Select(i);
                    beginrow = i + 1;
                    txtypdm.Focus();
                    return;

                }


            }
        }

		private void csgroupbox1()
		{
			for(int i=0;i<=this.groupBox1.Controls.Count-1;i++)
			{
				if (this.groupBox1.Controls[i].GetType().ToString()=="System.Windows.Forms.TextBox")
				{
					this.groupBox1.Controls[i].Text="";
					this.groupBox1.Controls[i].Tag="0";
					this.groupBox1.Controls[i].Enabled=true;
				}
			}
			this.lbldjh.Text="";
			this.groupBox1.Tag=null;
			this.dtprq.Value=DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase);
			this.dtpsj.Value=DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase);
			this.cmbtjfs.Enabled=true;

		}

		private void csgroupbox2()
		{
			for(int i=0;i<=this.groupBox2.Controls.Count-1;i++)
			{
				if (this.groupBox2.Controls[i].GetType().ToString()=="System.Windows.Forms.TextBox")
				{
					this.groupBox2.Controls[i].Text="";
					this.groupBox2.Controls[i].Tag="0";
					this.groupBox2.Controls[i].Enabled=true;
				}
			}
			this.lblypmc.Text="";
			this.lblypmc.Tag="0";
			this.lblpm.Text="";
			this.lblgg.Text="";
			this.lblcj.Text="";
			this.lblhh.Text="";
			this.lblypfj.Text="";
			this.lblylsj.Text="";
			this.txtxpfj.Text="";
			this.txtxlsj.Text="";
			this.lblkc.Text="";
			this.lbldw.Text="";
			this.lbldwcj.Text="";
			this.lblscjj.Text="";
			this.lblscghdw.Text="";
			this.txtypdm.Focus();
		}

		private void cmbtjfs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cmbtjfs.Text.Trim()=="定期执行")
			{
				this.dtprq.Enabled=true;
				this.dtpsj.Enabled=true;
			}
			else
			{
				this.dtprq.Enabled=false;
				this.dtpsj.Enabled=false;
			}
		}

		//网格单元改变事件
		private void myDataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			try
			{
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				if (nrow>=tb.Rows.Count)
				{
					DataRow nullrow=tb.NewRow();
					this.Getrow(nullrow);
				}
				else
				{
					this.txtypdm.Enabled=false;
					DataRow row=tb.Rows[nrow];
					Getrow(row);
					this.butadd.Enabled=false;
				}
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}

		#endregion

		private void butprint_Click(object sender, System.EventArgs e)
		{
			try
			{
                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
				ts_Yk_ReportView.Dataset1 Dset=new ts_Yk_ReportView.Dataset1();
				DataRow myrow;
				for(int i=0;i<=tb.Rows.Count-1;i++)
				{
					myrow=Dset.药品调价单.NewRow();
					myrow["xh"]=Convert.ToInt32(tb.Rows[i]["序号"]);
					if (ss.网络内容显示商品名==true)
						myrow["ypmc"]=Convert.ToString(tb.Rows[i]["商品名"]);
					else
						myrow["ypmc"]=Convert.ToString(tb.Rows[i]["品名"]);
					myrow["ypgg"]=Convert.ToString(tb.Rows[i]["规格"]);
					myrow["sccj"]=Convert.ToString(tb.Rows[i]["厂家"]);
					myrow["ypsl"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["库存"],"0"));
					myrow["ypdw"]=Convert.ToString(tb.Rows[i]["单位"]);
					myrow["ypfj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["原批发价"],"0"));
					myrow["xpfj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["现批发价"],"0"));
					decimal pfjdwcj=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["现批发价"],"0"))-Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["原批发价"],"0"));
					decimal tpfje=pfjdwcj*(Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["库存"],"0")));
					myrow["pfjdwcj"]=pfjdwcj.ToString("0.00");
					myrow["tpfje"]=tpfje.ToString("0.00");
					myrow["ylsj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["原零售价"],"0"));
					myrow["xlsj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["现零售价"],"0"));
					myrow["lsjdwcj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["调价差价"],"0"));
					myrow["tlsje"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["调价金额"],"0"));
					myrow["shh"]=Convert.ToString(tb.Rows[i]["货号"]);
					myrow["tjwh"]=Convert.ToString(txttjwh.Text);
					myrow["zxrq"]=Convert.ToString(dtprq.Value.ToShortDateString());
					myrow["mrjj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["默认进价"],"0"));
					myrow["scjj"]=Convert.ToDecimal(Convertor.IsNull(tb.Rows[i]["上次进价"],"0"));
					myrow["scghdw"]=tb.Rows[i]["上次供货商"].ToString().Trim();
					Dset.药品调价单.Rows.Add(myrow);

				}

                string djy = InstanceForm.BDatabase.GetDataTable("select dbo.fun_getempname(djy) from yf_tj where id='" + Convertor.IsNull(this.groupBox1.Tag, Guid.Empty.ToString()) + "'").Rows[0][0].ToString();

				ParameterEx[] parameters=new ParameterEx[7];
				parameters[0].Text="DJH";
				parameters[0].Value=this.lbldjh.Text;
				parameters[1].Text="DJY";
                parameters[1].Value = djy + "                                 打印员:" + InstanceForm.BCurrentUser.Name;
				parameters[2].Text="RQ";
				parameters[2].Value=dtprq.Value.ToShortDateString();
				parameters[3].Text="TJWH";
				parameters[3].Value=txttjwh.Text.Trim();
				parameters[4].Text="TITLETEXT";
				parameters[4].Value=TrasenFrame.Classes.Constant.HospitalName+"("+InstanceForm.BCurrentDept.DeptName+")药品调价单";
				parameters[5].Text="BZ";
				parameters[5].Value=txtbz.Text.Trim();
				parameters[6].Text="swhere";
				parameters[6].Value=" No."+lbldjh.Text.Trim()+"     备注:"+txtbz.Text.Trim()+"     调价文号:"+txttjwh.Text.Trim()+"     调价日期:"+dtprq.Value.ToShortDateString()+"   "+lblsdjh.Text.Trim();

                string sDate = DateManager.ServerDateTimeByDBType(InstanceForm.BDatabase).ToString();
                string[] str ={ "" };
                str[0] = " update YF_TJ set bprint=1,DYCZY=" + InstanceForm.BCurrentUser.EmployeeId + " ,DYSJ='" + sDate + "' where id='" + new Guid(Convertor.IsNull(this.groupBox1.Tag, "")) + "'";

                TrasenFrame.Forms.FrmReportView f = new TrasenFrame.Forms.FrmReportView(Dset.药品调价单, Constant.ApplicationDirectory + "\\Report\\YK_药品调价单据.rpt", parameters, false, str, InstanceForm.BDatabase);
                if (f.LoadReportSuccess)
                {
                    f._sqlStr = str;
                    f.Show();
                }
                else
                {
                    f.Dispose();
                }

			}
			catch(System.Exception err)
			{
				MessageBox.Show(err.Message);
			}			

		}


		private void Selectrk(int cjid)
		{
			string ssql="";
            if (YpConfig.是否药库(InstanceForm.BCurrentDept.DeptId, InstanceForm.BDatabase) == true)
			   ssql="select top 3 s_yppm 品名,s_ypgg 规格,s_sccj 厂家,dbo.fun_yp_ghdw(wldw) 供货单位,ypsl 入库数量,ypdw 单位,ypkl 扣率,jhj 进价,jhje 进货金额,lsje 零售金额,a.djh 单据号,a.rq 单据日期 "+
					" from yk_dj a(nolock), yk_djmx b(nolock),yp_ypcjd c(nolock) where a.id=b.djid and b.cjid=c.cjid  and a.ywlx='001' and c.cjid="+cjid+" "+
					" union all"+
					" select top 3  s_yppm 品名,s_ypgg 规格,s_sccj 厂家,dbo.fun_yp_ghdw(wldw) 供货单位,ypsl 入库数量,ypdw 单位,ypkl 扣率,jhj 进价,jhje 进货金额,lsje 零售金额,a.djh 单据号,a.rq 单据日期  "+
					" from yk_dj_h a(nolock), yk_djmx_h b(nolock),yp_ypcjd c(nolock) where a.id=b.djid and b.cjid=c.cjid  and a.ywlx='001' and c.cjid="+cjid+" "+
					" order by 单据号 desc ";
			else
				ssql="select top 3 s_yppm 品名,s_ypgg 规格,s_sccj 厂家,dbo.fun_yp_ghdw(wldw) 供货单位,ypsl 入库数量,ypdw 单位,ypkl 扣率,jhj 进价,jhje 进货金额,lsje 零售金额,a.djh 单据号,a.rq 单据日期 "+
					" from yk_dj a(nolock), yk_djmx b(nolock),yp_ypcjd c(nolock) where a.id=b.djid and b.cjid=c.cjid  and a.ywlx='001' and c.cjid="+cjid+" "+
					" union all"+
					" select top 3  s_yppm 品名,s_ypgg 规格,s_sccj 厂家,dbo.fun_yp_ghdw(wldw) 供货单位,ypsl 入库数量,ypdw 单位,ypkl 扣率,jhj 进价,jhje 进货金额,lsje 零售金额,a.djh 单据号,a.rq 单据日期  "+
					" from yf_dj_h a(nolock), yf_djmx_h b(nolock),yp_ypcjd c(nolock) where a.id=b.djid and b.cjid=c.cjid  and a.ywlx='001' and c.cjid="+cjid+" "+
					" order by 单据号 desc ";
            System.Data.DataTable tbmx = InstanceForm.BDatabase.GetDataTable(ssql);
			tbmx.TableName="Tb1";
			this.myDataGrid2.DataSource=tbmx;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.panel4.Visible=this.checkBox1.Checked==true?true:false;
			this.checkBox1.Text=this.checkBox1.Checked==true?"显示历史入库记录":"隐藏历史入库记录";

		}

		private void txtmrjj_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (Convertor.IsNumeric(this.txtmrjj.Text)==false) this.txtmrjj.Text="";
		}

        private void btn_PL_Click(object sender, EventArgs e)
        {
            string ssql = string.Empty;
            ssql = "select  distinct  '' AS 序号,  a.s_yppm AS 品名,  a.S_YPSPM AS 商品名,  a.s_ypgg AS 规格,  a.s_sccj AS 厂家,  isnull(cast(coalesce(kcl,null) as float),0) AS 库存," +
                     " a.s_ypdw AS 单位,  a.pfj AS 原批发价,  a.pfj AS 现批发价,  a.lsj AS 原零售价,  a.pfj AS 现零售价,"+
                     " (a.pfj-a.lsj) AS 调价差价,  ((isnull(cast(coalesce(kcl,null) as float),0))*(a.pfj-a.lsj)) AS 调价金额," +
                     " shh AS 货号,  a.cjid AS CJID,  '1' AS DWBL,  a.pfj AS 默认进价,  a.pfj AS 上次进价,  '' AS 上次供货商,'' AS ID " +
                            " from yp_ypcjd a left join " +
                            " (select cjid,sum(kcl/dwbl) kcl from yk_kcmx where deptid=" + InstanceForm.BCurrentDept.DeptId + " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + ") group by cjid ) b " +
                            " on a.cjid=b.cjid  inner join yp_ypbm c on a.ggid=c.ggid  ";
            ssql = ssql + "  where a.n_ypzlx in(select ypzlx from yp_gllx where deptid=" + InstanceForm.BCurrentDept.DeptId + " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + "))";

            //DataTable tbmx = InstanceForm.BDatabase.GetDataTable(ssql);
            //tbmx.TableName = "Tb1";
            //this.myDataGrid1.DataSource = tbmx;


            System.Data.DataTable tbmx = InstanceForm.BDatabase.GetDataTable(ssql);
            FunBase.AddRowtNo(tbmx);
           // AddRowtGuid(tbmx);
            tbmx.TableName = "tbmx";
            this.myDataGrid1.DataSource = tbmx;
            this.myDataGrid1.TableStyles[0].MappingName = "tbmx";

           // DataToExcel((System.Windows.Forms.DataGrid)myDataGrid1);
        }     

        /// <summary>
        /// 点击导出按钮把数据导出EXCEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;
            DataGridViewToExcelY(GetTB(tb));
          //  butexcel_Click();

        }

        /// <summary>
        /// 把数据表的数据按一定格式导出到EXCEL中
        /// </summary>
        /// <param name="dgv"></param>
        public static void DataGridViewToExcelY(System.Data.DataTable dgv)
        {

            #region   验证可操作性

            //申明保存对话框   
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀   
            dlg.DefaultExt = "xls ";
            //文件后缀列表   
            //dlg.Filter = "EXCEL文件(*.XLS)|*.xls ";
            dlg.Filter = "Excel文件(*.xls)|*.xls|EXCEL(*.xlsx)|*.xlsx";
            //默然路径是系统当前路径   
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            //打开保存对话框   
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            //返回文件路径   
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效   
            if (fileNameString.Trim() == " ")
            { return; }
            //定义表格内数据的行数和列数   
            int rowscount = dgv.Rows.Count;
            int colscount = dgv.Columns.Count;
            //行数必须大于0   
            if (rowscount <= 0)
            {
                MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //列数必须大于0   
            if (colscount <= 0)
            {
                MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //行数不可以大于65536   
            if (rowscount > 65536)
            {
                MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //列数不可以大于255   
            if (colscount > 255)
            {
                MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它   
            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            #endregion

            

            //Microsoft.Office.Interop.Excel.Application objExcel = null;
            //Microsoft.Office.Interop.Excel.Workbook objWorkbook = null;
            //Microsoft.Office.Interop.Excel.Worksheet objsheet = null;
            try
            {
                //申明对象   
                //objExcel = new Microsoft.Office.Interop.Excel.Application();
                objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                //objsheet = (Microsoft.Office.Interop.Excel.Worksheet)objWorkbook.ActiveSheet;
                //设置EXCEL不可见   
                objExcel.Visible = false;

                //向Excel中写入表格的表头   
                int displayColumnsCount = 1;

                //for (int i = 0; i <= dgv.ColumnCount - 1; i++)
                //{
                //    if (dgv.Columns[i].Visible == true)
                //    {
                //        objExcel.Cells[1, displayColumnsCount] = dgv.Columns[i].HeaderText.Trim();
                //        displayColumnsCount++;
                //    }
                //}


                // 序号 品名，规格，厂家，库存，单位，原批发价，现批发价，原零售价，现零售价，调价差价，调价金额，货号
                //定义特定的列名
               
                //商品名，厂家ID，进货单位ID，药理分类，基本药物，拼音码

                string[] strArrTitle = new string[] { "序号", "品名","规格","厂家","库存","单位","原批发价","现批发价","原零售价","现零售价","调价差价","调价金额","货号"   };
                for (int i = 0; i < strArrTitle.Length; i++)
                {
                    // strLine = strLine + strArrTitle[i] + Convert.ToChar(9);
                    objExcel.Cells[1, displayColumnsCount] = strArrTitle[i];
                    //objExcel.Cells[1, displayColumnsCount] = strArrTitle[i];
                    displayColumnsCount++;
                }

                //设置进度条   
                //tempProgressBar.Refresh();   
                //tempProgressBar.Visible   =   true;   
                //tempProgressBar.Minimum=1;   
                //tempProgressBar.Maximum=dgv.RowCount;   
                //tempProgressBar.Step=1;   
                //向Excel中逐行逐列写入表格中的数据   
                for (int row = 0; row <= dgv.Rows.Count - 1; row++)
                {
                    //tempProgressBar.PerformStep();   

                    displayColumnsCount = 1;
                    for (int col = 0; col < colscount; col++)
                    {
                        // if (dgv.Columns[col].Visible == true) Rows[i][j].ToString();
                        // {
                        try
                        {
                            // objExcel.Cells[row + 2, displayColumnsCount] = dgv.Rows[row].Cells[col].Value.ToString().Trim();
                            objExcel.Cells[row + 2, displayColumnsCount] = dgv.Rows[row][col].ToString();
                            displayColumnsCount++;
                        }
                        catch (Exception)
                        {

                        }

                        // }
                    }
                }
                //隐藏进度条   
                //tempProgressBar.Visible   =   false;   
                //保存文件   
                objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        //Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "警告 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                //关闭Excel应用   
                if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
                //if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
                //if (objExcel != null) objExcel.Quit();

                //objsheet = null;
                //objWorkbook = null;
                objExcel = null;
            }
            MessageBox.Show(fileNameString + "/n/n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// 构造一个表结构特定的格式的表结构与数据
        /// </summary>
        /// <param name="TabTemp"></param>
        /// <returns></returns>
        private System.Data.DataTable GetTB(System.Data.DataTable TabTemp)
        {

            //定义表结构
            System.Data.DataTable dt = new System.Data.DataTable();

            //string strExcel = @"select 序号 品名，规格，厂家，库存，单位，原批发价，现批发价，原零售价，现零售价，调价差价，调价金额，货号   from   [sheet1$]";

            dt.Columns.Add("序号");
            dt.Columns.Add("品名");
            dt.Columns.Add("规格");
            dt.Columns.Add("厂家");
            dt.Columns.Add("库存");
            dt.Columns.Add("单位");
            dt.Columns.Add("原批发价");
            dt.Columns.Add("现批发价");
            dt.Columns.Add("原零售价");
            dt.Columns.Add("现零售价");
            dt.Columns.Add("调价差价");
            dt.Columns.Add("调价金额");
            dt.Columns.Add("货号");            

            dt.TableName = "TabPuchPlan";

            DataRow tr;
            for (int ii = 0; ii < TabTemp.Rows.Count; ii++)
            {
                tr = dt.NewRow();
                tr["序号"] = TabTemp.Rows[ii]["序号"].ToString();
                tr["品名"] = TabTemp.Rows[ii]["品名"].ToString();
                tr["规格"] = TabTemp.Rows[ii]["规格"].ToString();
                tr["厂家"] = TabTemp.Rows[ii]["厂家"].ToString();
                tr["库存"] = TabTemp.Rows[ii]["库存"].ToString();
                tr["单位"] = TabTemp.Rows[ii]["单位"].ToString();
                tr["原批发价"] = TabTemp.Rows[ii]["原批发价"].ToString();
                tr["现批发价"] = TabTemp.Rows[ii]["现批发价"].ToString();
                tr["原零售价"] = TabTemp.Rows[ii]["原零售价"].ToString();
                tr["现零售价"] = TabTemp.Rows[ii]["现零售价"].ToString();
                tr["调价差价"] = TabTemp.Rows[ii]["调价差价"].ToString();
                tr["调价金额"] = TabTemp.Rows[ii]["调价金额"].ToString();
                tr["货号"] = TabTemp.Rows[ii]["货号"].ToString();                

                dt.Rows.Add(tr);
            } 

            return dt;

        }

        private void butexcel_Click()
        {
            try
            {

                System.Data.DataTable tb = (System.Data.DataTable)this.myDataGrid1.DataSource;

                //pym赋值
                //tb = DoSetTablePym(tb);

                // 创建Excel对象                    
                Excel.Application xlApp = new Excel.ApplicationClass();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel无法启动");
                    return;
                }
                // 创建Excel工作薄
                Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
                Excel.Worksheet xlSheet = (Excel.Worksheet)xlBook.Worksheets[1];

                // 列索引，行索引，总列数，总行数
                int colIndex = 0;
                int RowIndex = 0;
                int colCount = 0;
                int RowCount = tb.Rows.Count;

                for (int i = 0; i <= myDataGrid1.TableStyles[0].GridColumnStyles.Count - 1; i++)
                {
                    if (myDataGrid1.TableStyles[0].GridColumnStyles[i].Width > 0)
                        colCount = colCount + 1;
                }

                // 设置标题
                Excel.Range range = xlSheet.get_Range(xlApp.Cells[1, 1], xlApp.Cells[1, colCount]);
                range.MergeCells = true;
                xlApp.ActiveCell.FormulaR1C1 = _chineseName + "一览表";
                xlApp.ActiveCell.Font.Size = 20;
                xlApp.ActiveCell.Font.Bold = true;
                xlApp.ActiveCell.HorizontalAlignment = Excel.Constants.xlCenter;


                // 设置条件
                Excel.Range range1 = xlSheet.get_Range(xlApp.Cells[2, 1], xlApp.Cells[2, colCount]);
                range1.MergeCells = true;
                range1.Value2 = "调价科室:" + InstanceForm.BCurrentDept.DeptName + "   操作员:" + InstanceForm.BCurrentUser.Name;
                xlApp.ActiveCell.Font.Size = 20;
                xlApp.ActiveCell.Font.Bold = true;
                xlApp.ActiveCell.HorizontalAlignment = Excel.Constants.xlCenter;

                // 创建缓存数据
                object[,] objData = new object[RowCount + 1, colCount + 1];
                // 获取列标题
                for (int i = 0; i <= myDataGrid1.TableStyles[0].GridColumnStyles.Count - 1; i++)
                {
                    if (myDataGrid1.TableStyles[0].GridColumnStyles[i].Width > 0)
                        objData[0, colIndex++] = myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
                }

                // 获取数据
                for (int i = 0; i <= tb.Rows.Count - 1; i++)
                {
                    colIndex = 0;
                    for (int j = 0; j <= myDataGrid1.TableStyles[0].GridColumnStyles.Count - 1; j++)
                    {
                        if (myDataGrid1.TableStyles[0].GridColumnStyles[j].Width > 0)
                        {
                            if (myDataGrid1.TableStyles[0].GridColumnStyles[j].HeaderText == "品名" || myDataGrid1.TableStyles[0].GridColumnStyles[j].HeaderText == "商品名" || myDataGrid1.TableStyles[0].GridColumnStyles[j].HeaderText == "规格")
                                objData[i + 1, colIndex++] = "'" + tb.Rows[i][j].ToString().Trim();
                            else
                                objData[i + 1, colIndex++] = "" + tb.Rows[i][j].ToString().Trim();
                        }
                    }
                    System.Windows.Forms.Application.DoEvents();
                }

                int x = 3;
                // 写入Excel
                range = xlSheet.get_Range(xlApp.Cells[x, 1], xlApp.Cells[RowCount + x, colCount]);
                range.Value2 = objData;

                // 
                xlApp.get_Range(xlApp.Cells[x, 1], xlApp.Cells[RowCount + x, colCount]).Borders.LineStyle = 1;

                //设置报表表格为最适应宽度
                xlApp.get_Range(xlApp.Cells[x, 1], xlApp.Cells[RowCount + x, colCount]).Select();
                xlApp.get_Range(xlApp.Cells[x, 1], xlApp.Cells[RowCount + x, colCount]).Columns.AutoFit();
                xlApp.get_Range(xlApp.Cells[x, 1], xlApp.Cells[RowCount + x, colCount]).Font.Size = 9;

                xlApp.Visible = true;
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void AddRowtGuid(System.Data.DataTable tb)
        {

            //if (tb.Columns.Contains("ID") == true)
            //{
            //    for (int i = 0; i <= tb.Rows.Count - 1; i++)
            //       // tb.Rows[i]["ID"] = System.Guid.NewGuid();
            //}
        }

        private void btn_CY_PL_Click(object sender, EventArgs e)
        {
            string ssql = string.Empty;
            ssql = string.Format(@" select  distinct  '' AS 序号, a.s_yppm AS 品名,  a.S_YPSPM AS 商品名,  a.s_ypgg AS 规格,  
                                    a.s_sccj AS 厂家,  isnull(cast(coalesce(kcl,null) as float),0) AS 库存,
                                    a.s_ypdw AS 单位,  a.pfj AS 原批发价,  a.pfj AS 现批发价,  a.lsj AS 原零售价, 
                                    --(a.pfj*1.25) AS 现零售价,(a.pfj*1.25-a.lsj) AS 调价差价, ((isnull(cast(coalesce(kcl,null) as float),0))*(a.pfj-a.lsj)) AS 调价金额,
                                    -- a.pfj*1.25 as '加价后（1.25）', 
                                    substring(cast(a.pfj*1.25 as varchar) ,1,(charindex('.',cast(a.pfj*1.25 as varchar))+2)) AS 现零售价,
                                    (substring(cast(a.pfj*1.25 as varchar),1,(charindex('.',cast(a.pfj*1.25 as varchar))+2))-a.lsj) AS 调价差价, 
                                    ((isnull(cast(coalesce(kcl,null) as float),0))*(substring(cast(a.pfj*1.25 as varchar),1,(charindex('.',cast(a.pfj*1.25 as varchar))+2))-a.lsj)) AS 调价金额,
                                    shh AS 货号, a.cjid AS CJID, '1' AS DWBL,  a.pfj AS 默认进价,  a.pfj AS 上次进价,  '' AS 上次供货商,'' AS ID 
                                     from yp_ypcjd a left join 
                                     (select cjid,sum(kcl/dwbl) kcl from yk_kcmx where deptid='{0}'
                                     or deptid in(select deptid from yp_yjks_gx where p_deptid='{0}') 
                                     group by cjid ) b 
                                    on a.cjid=b.cjid  inner join yp_ypbm c on a.ggid=c.ggid  
                                    where a.n_ypzlx in(select ypzlx from yp_gllx where deptid='{0}' or deptid in(
                                    select deptid from yp_yjks_gx where p_deptid='{0}'))
                                    and a.BDELETE=0 ;", InstanceForm.BCurrentDept.DeptId);

           /* ssql = "select  distinct  '' AS 序号,  a.s_yppm AS 品名,  a.S_YPSPM AS 商品名,  a.s_ypgg AS 规格,  a.s_sccj AS 厂家,  isnull(cast(coalesce(kcl,null) as float),0) AS 库存," +
                     " a.s_ypdw AS 单位,  a.pfj AS 原批发价,  a.pfj AS 现批发价,  a.lsj AS 原零售价,  a.pfj AS 现零售价," +
                     " (a.pfj-a.lsj) AS 调价差价,  ((isnull(cast(coalesce(kcl,null) as float),0))*(a.pfj-a.lsj)) AS 调价金额," +
                     " shh AS 货号,  a.cjid AS CJID,  '1' AS DWBL,  a.pfj AS 默认进价,  a.pfj AS 上次进价,  '' AS 上次供货商,'' AS ID " +
                            " from yp_ypcjd a left join " +
                            " (select cjid,sum(kcl/dwbl) kcl from yk_kcmx where deptid=" + InstanceForm.BCurrentDept.DeptId + " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + ") group by cjid ) b " +
                            " on a.cjid=b.cjid  inner join yp_ypbm c on a.ggid=c.ggid  ";
            ssql = ssql + "  where a.n_ypzlx in(select ypzlx from yp_gllx where deptid=" + InstanceForm.BCurrentDept.DeptId + " or deptid in(select deptid from yp_yjks_gx where p_deptid=" + InstanceForm.BCurrentDept.DeptId + "))";
            */
            //DataTable tbmx = InstanceForm.BDatabase.GetDataTable(ssql);
            //tbmx.TableName = "Tb1";
            //this.myDataGrid1.DataSource = tbmx;

            System.Data.DataTable tbmx = InstanceForm.BDatabase.GetDataTable(ssql);
            FunBase.AddRowtNo(tbmx);           
            tbmx.TableName = "tbmx";
            this.myDataGrid1.DataSource = tbmx;
            this.myDataGrid1.TableStyles[0].MappingName = "tbmx";
           
        }
	}
}
