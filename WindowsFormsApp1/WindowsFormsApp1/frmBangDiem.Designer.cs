namespace WindowsFormsApp1
{
    partial class frmBangDiem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label dIEMLabel;
            System.Windows.Forms.Label bAITHILabel;
            System.Windows.Forms.Label rowguidLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rowguidTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new WindowsFormsApp1.DS();
            this.bAITHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIEMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mASVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bANGDIEMTableAdapter = new WindowsFormsApp1.DSTableAdapters.BANGDIEMTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DSTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bANGDIEMGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAITHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            mASVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            dIEMLabel = new System.Windows.Forms.Label();
            bAITHILabel = new System.Windows.Forms.Label();
            rowguidLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowguidTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(76, 40);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(38, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(73, 66);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(41, 13);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(84, 92);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(30, 13);
            lANLabel.TabIndex = 4;
            lANLabel.Text = "LAN:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(376, 40);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(55, 13);
            nGAYTHILabel.TabIndex = 6;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // dIEMLabel
            // 
            dIEMLabel.AutoSize = true;
            dIEMLabel.Location = new System.Drawing.Point(395, 66);
            dIEMLabel.Name = "dIEMLabel";
            dIEMLabel.Size = new System.Drawing.Size(36, 13);
            dIEMLabel.TabIndex = 8;
            dIEMLabel.Text = "DIEM:";
            // 
            // bAITHILabel
            // 
            bAITHILabel.AutoSize = true;
            bAITHILabel.Location = new System.Drawing.Point(386, 92);
            bAITHILabel.Name = "bAITHILabel";
            bAITHILabel.Size = new System.Drawing.Size(45, 13);
            bAITHILabel.TabIndex = 10;
            bAITHILabel.Text = "BAITHI:";
            // 
            // rowguidLabel
            // 
            rowguidLabel.AutoSize = true;
            rowguidLabel.Location = new System.Drawing.Point(608, 66);
            rowguidLabel.Name = "rowguidLabel";
            rowguidLabel.Size = new System.Drawing.Size(49, 13);
            rowguidLabel.TabIndex = 12;
            rowguidLabel.Text = "rowguid:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(rowguidLabel);
            this.groupBox1.Controls.Add(this.rowguidTextEdit);
            this.groupBox1.Controls.Add(bAITHILabel);
            this.groupBox1.Controls.Add(this.bAITHITextEdit);
            this.groupBox1.Controls.Add(dIEMLabel);
            this.groupBox1.Controls.Add(this.dIEMSpinEdit);
            this.groupBox1.Controls.Add(nGAYTHILabel);
            this.groupBox1.Controls.Add(this.nGAYTHIDateEdit);
            this.groupBox1.Controls.Add(lANLabel);
            this.groupBox1.Controls.Add(this.lANSpinEdit);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.mAMHTextEdit);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Controls.Add(this.mASVTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết điểm";
            // 
            // rowguidTextEdit
            // 
            this.rowguidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "rowguid", true));
            this.rowguidTextEdit.Location = new System.Drawing.Point(663, 63);
            this.rowguidTextEdit.Name = "rowguidTextEdit";
            this.rowguidTextEdit.Size = new System.Drawing.Size(100, 20);
            this.rowguidTextEdit.TabIndex = 13;
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAITHITextEdit
            // 
            this.bAITHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "BAITHI", true));
            this.bAITHITextEdit.Location = new System.Drawing.Point(437, 89);
            this.bAITHITextEdit.Name = "bAITHITextEdit";
            this.bAITHITextEdit.Size = new System.Drawing.Size(100, 20);
            this.bAITHITextEdit.TabIndex = 11;
            // 
            // dIEMSpinEdit
            // 
            this.dIEMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "DIEM", true));
            this.dIEMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dIEMSpinEdit.Location = new System.Drawing.Point(437, 63);
            this.dIEMSpinEdit.Name = "dIEMSpinEdit";
            this.dIEMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dIEMSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.dIEMSpinEdit.TabIndex = 9;
            // 
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "NGAYTHI", true));
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(437, 37);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(100, 20);
            this.nGAYTHIDateEdit.TabIndex = 7;
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "LAN", true));
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lANSpinEdit.Location = new System.Drawing.Point(120, 89);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.lANSpinEdit.TabIndex = 5;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(120, 63);
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mAMHTextEdit.TabIndex = 3;
            // 
            // mASVTextEdit
            // 
            this.mASVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "MASV", true));
            this.mASVTextEdit.Location = new System.Drawing.Point(120, 37);
            this.mASVTextEdit.Name = "mASVTextEdit";
            this.mASVTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mASVTextEdit.TabIndex = 1;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bANGDIEMGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý bảng điểm";
            // 
            // bANGDIEMGridControl
            // 
            this.bANGDIEMGridControl.DataSource = this.bANGDIEMBindingSource;
            this.bANGDIEMGridControl.Location = new System.Drawing.Point(0, 20);
            this.bANGDIEMGridControl.MainView = this.gridView1;
            this.bANGDIEMGridControl.Name = "bANGDIEMGridControl";
            this.bANGDIEMGridControl.Size = new System.Drawing.Size(830, 298);
            this.bANGDIEMGridControl.TabIndex = 0;
            this.bANGDIEMGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colMAMH,
            this.colLAN,
            this.colNGAYTHI,
            this.colDIEM,
            this.colBAITHI,
            this.colrowguid});
            this.gridView1.GridControl = this.bANGDIEMGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colLAN
            // 
            this.colLAN.Caption = "Lần";
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "Ngày thi";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 3;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 4;
            // 
            // colBAITHI
            // 
            this.colBAITHI.Caption = "Bài thi";
            this.colBAITHI.FieldName = "BAITHI";
            this.colBAITHI.Name = "colBAITHI";
            this.colBAITHI.Visible = true;
            this.colBAITHI.VisibleIndex = 5;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            this.colrowguid.Visible = true;
            this.colrowguid.VisibleIndex = 6;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBangDiem";
            this.Text = "frmBangDiem";
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowguidTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DS dS;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit rowguidTextEdit;
        private DevExpress.XtraEditors.TextEdit bAITHITextEdit;
        private DevExpress.XtraEditors.SpinEdit dIEMSpinEdit;
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraEditors.TextEdit mASVTextEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl bANGDIEMGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colBAITHI;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
    }
}