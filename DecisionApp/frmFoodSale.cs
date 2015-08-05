using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.IO;


namespace DecisionApp
{
	public class frmFoodSale : System.Windows.Forms.Form
	{
		
		#region  Windows 窗体设计器生成的代码
		
		public frmFoodSale()
		{
			
			//该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();
			
			//在 InitializeComponent() 调用之后添加任何初始化
			
		}
		
		//窗体重写 dispose 以清理组件列表。
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改此过程。
		//不要使用代码编辑器修改它。
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker4;
		internal System.Windows.Forms.DateTimePicker DateTimePicker3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmFoodSale));
			this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			base.Closed += new System.EventHandler(frmFoodSale_Closed);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.DateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//CrystalReportViewer1
			//
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			this.CrystalReportViewer1.Anchor = (System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 96);
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.ReportSource = null;
			this.CrystalReportViewer1.Size = new System.Drawing.Size(632, 392);
			this.CrystalReportViewer1.TabIndex = 14;
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox1.Controls.Add(this.DateTimePicker3);
			this.GroupBox1.Controls.Add(this.DateTimePicker4);
			this.GroupBox1.Controls.Add(this.DateTimePicker2);
			this.GroupBox1.Controls.Add(this.DateTimePicker1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Location = new System.Drawing.Point(8, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(616, 83);
			this.GroupBox1.TabIndex = 13;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "查询条件";
			//
			//DateTimePicker3
			//
			this.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker3.Location = new System.Drawing.Point(40, 48);
			this.DateTimePicker3.Name = "DateTimePicker3";
			this.DateTimePicker3.Size = new System.Drawing.Size(96, 21);
			this.DateTimePicker3.TabIndex = 9;
			//
			//DateTimePicker4
			//
			this.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker4.Location = new System.Drawing.Point(144, 48);
			this.DateTimePicker4.Name = "DateTimePicker4";
			this.DateTimePicker4.ShowUpDown = true;
			this.DateTimePicker4.Size = new System.Drawing.Size(88, 21);
			this.DateTimePicker4.TabIndex = 8;
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePicker2.Location = new System.Drawing.Point(144, 24);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.ShowUpDown = true;
			this.DateTimePicker2.Size = new System.Drawing.Size(88, 21);
			this.DateTimePicker2.TabIndex = 1;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePicker1.Location = new System.Drawing.Point(40, 24);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(96, 21);
			this.DateTimePicker1.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(24, 23);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "从";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(16, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(24, 23);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "到";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Button1
			//
			this.Button1.Image = (System.Drawing.Image) (resources.GetObject("Button1.Image"));
			this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Button1.Location = new System.Drawing.Point(248, 24);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(88, 48);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "查询(&Q)";
			this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//frmFoodSale
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(632, 486);
			this.Controls.Add(this.CrystalReportViewer1);
			this.Controls.Add(this.GroupBox1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmFoodSale";
			this.Text = "菜品销售报表";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			
			string sqlstr;
			sqlstr = "select typename,foodname,sum(addquantity-decquantity) as quantity from view_salelist " + " where begintime>='" + DateTimePicker1.Text + " " + DateTimePicker2.Text + "' and begintime<='" + DateTimePicker3.Text + " " + DateTimePicker4.Text + "'" + " group by typename,foodname order by typename,quantity";
			
			ParameterFieldDefinitions crParameterFieldDefinitions;
			ParameterFieldDefinition crParameterFieldDefinition;
			ParameterValues crParameterValues;
			ParameterDiscreteValue crParameterDiscreteValue;
			ReportDocument cr_foodsale_tmp = new ReportDocument();
			
			//检测报表文件是否存在
			if (File.Exists(rms_var.GetReportPath() + report_var.foodsale_rpt_filename))
			{
				cr_foodsale_tmp = report_var.LoadReport(rms_var.GetReportPath() + report_var.foodsale_rpt_filename, sqlstr, "view_salelist");
			}
			else
			{
				MessageBox.Show("报表文件不存在，请检查系统初始化中的设置是否正确。如果问题依然存在，请联系系统供应商。");
				return;
			}
			
			crParameterFieldDefinitions = cr_foodsale_tmp.DataDefinition.ParameterFields;
			
			crParameterFieldDefinition = crParameterFieldDefinitions["begindate"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = DateTimePicker1.Text + " " + DateTimePicker2.Text;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			crParameterFieldDefinition = crParameterFieldDefinitions["enddate"];
			crParameterValues = crParameterFieldDefinition.CurrentValues;
			crParameterDiscreteValue = new ParameterDiscreteValue();
			crParameterDiscreteValue.Value = DateTimePicker3.Text + " " + DateTimePicker4.Text;
			crParameterValues.Add(crParameterDiscreteValue);
			crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
			
			CrystalReportViewer1.ReportSource = cr_foodsale_tmp;
			
			Cursor = Cursors.Default;
		}
		
		private void frmFoodSale_Closed(object sender, System.EventArgs e)
		{
			rms_var.frmRptFoodSale = null;
		}
	}
	
}
