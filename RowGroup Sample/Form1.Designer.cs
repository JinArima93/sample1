
namespace RowGroup_Sample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSOANo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAdvance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRebates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(921, 492);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCompany,
            this.gcDate,
            this.gcSOANo,
            this.gcAmount,
            this.gcAdvance,
            this.gcBalance,
            this.gcRebates});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SOA NO.", this.gcSOANo, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMOUNT", this.gcAmount, "(SUM={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ADVANCE", this.gcAdvance, "(SUM={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BALANCE", this.gcBalance, "(SUM={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "REBATES", this.gcRebates, "(SUM={0:0.##})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcCompany, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gcCompany
            // 
            this.gcCompany.Caption = "COMPANY";
            this.gcCompany.FieldName = "COMPANY";
            this.gcCompany.Name = "gcCompany";
            this.gcCompany.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "COMPANY", "{0}")});
            this.gcCompany.Visible = true;
            this.gcCompany.VisibleIndex = 0;
            // 
            // gcDate
            // 
            this.gcDate.Caption = "DATE";
            this.gcDate.FieldName = "DATE";
            this.gcDate.Name = "gcDate";
            this.gcDate.Visible = true;
            this.gcDate.VisibleIndex = 0;
            // 
            // gcSOANo
            // 
            this.gcSOANo.Caption = "SOA NO.";
            this.gcSOANo.FieldName = "SOA NO.";
            this.gcSOANo.Name = "gcSOANo";
            this.gcSOANo.Visible = true;
            this.gcSOANo.VisibleIndex = 1;
            // 
            // gcAmount
            // 
            this.gcAmount.Caption = "AMOUNT";
            this.gcAmount.FieldName = "AMOUNT";
            this.gcAmount.Name = "gcAmount";
            this.gcAmount.Visible = true;
            this.gcAmount.VisibleIndex = 2;
            // 
            // gcAdvance
            // 
            this.gcAdvance.Caption = "ADVANCE";
            this.gcAdvance.FieldName = "ADVANCE";
            this.gcAdvance.Name = "gcAdvance";
            this.gcAdvance.Visible = true;
            this.gcAdvance.VisibleIndex = 3;
            // 
            // gcBalance
            // 
            this.gcBalance.Caption = "BALANCE";
            this.gcBalance.FieldName = "BALANCE";
            this.gcBalance.Name = "gcBalance";
            this.gcBalance.Visible = true;
            this.gcBalance.VisibleIndex = 4;
            // 
            // gcRebates
            // 
            this.gcRebates.Caption = "REBATES";
            this.gcRebates.FieldName = "REBATES";
            this.gcRebates.Name = "gcRebates";
            this.gcRebates.Visible = true;
            this.gcRebates.VisibleIndex = 5;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(10, 10);
            this.gridSplitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(921, 492);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.gridSplitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn gcCompany;
        private DevExpress.XtraGrid.Columns.GridColumn gcDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcSOANo;
        private DevExpress.XtraGrid.Columns.GridColumn gcAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gcAdvance;
        private DevExpress.XtraGrid.Columns.GridColumn gcBalance;
        private DevExpress.XtraGrid.Columns.GridColumn gcRebates;
    }
}

