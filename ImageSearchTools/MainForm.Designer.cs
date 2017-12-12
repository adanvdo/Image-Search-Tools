namespace ImageSearchTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsMainStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.sccMainSplitter = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDirectory = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.txtHeight = new DevExpress.XtraEditors.TextEdit();
            this.txtWidth = new DevExpress.XtraEditors.TextEdit();
            this.cbSizeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSize = new DevExpress.XtraEditors.LabelControl();
            this.lblHeight = new DevExpress.XtraEditors.LabelControl();
            this.lblWidth = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.gcImages = new DevExpress.XtraGrid.GridControl();
            this.bsImages = new System.Windows.Forms.BindingSource(this.components);
            this.imageDataSet = new ImageSearchTools.ImageDataSet();
            this.gvImages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImageNumberOdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectOdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFullPathOdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNumberEven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectEven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullPathEven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNumberOdd2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectOdd2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullPathOdd2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNumberEven2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectEven2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullPathEven2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlActions = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.tsMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter)).BeginInit();
            this.sccMainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSizeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlActions)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainStrip
            // 
            this.tsMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClear});
            this.tsMainStrip.Location = new System.Drawing.Point(0, 0);
            this.tsMainStrip.Name = "tsMainStrip";
            this.tsMainStrip.Size = new System.Drawing.Size(517, 25);
            this.tsMainStrip.TabIndex = 0;
            this.tsMainStrip.Text = "toolStrip1";
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnClear.Image = global::ImageSearchTools.Properties.Resources.wipe;
            this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnClear.Size = new System.Drawing.Size(23, 22);
            this.tsbtnClear.Text = "Clear Entries";
            this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
            // 
            // sccMainSplitter
            // 
            this.sccMainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sccMainSplitter.Horizontal = false;
            this.sccMainSplitter.Location = new System.Drawing.Point(0, 25);
            this.sccMainSplitter.Name = "sccMainSplitter";
            this.sccMainSplitter.Panel1.Controls.Add(this.btnBrowse);
            this.sccMainSplitter.Panel1.Controls.Add(this.labelControl1);
            this.sccMainSplitter.Panel1.Controls.Add(this.txtDirectory);
            this.sccMainSplitter.Panel1.Controls.Add(this.btnSearch);
            this.sccMainSplitter.Panel1.Controls.Add(this.txtSize);
            this.sccMainSplitter.Panel1.Controls.Add(this.txtHeight);
            this.sccMainSplitter.Panel1.Controls.Add(this.txtWidth);
            this.sccMainSplitter.Panel1.Controls.Add(this.cbSizeType);
            this.sccMainSplitter.Panel1.Controls.Add(this.lblSize);
            this.sccMainSplitter.Panel1.Controls.Add(this.lblHeight);
            this.sccMainSplitter.Panel1.Controls.Add(this.lblWidth);
            this.sccMainSplitter.Panel1.Controls.Add(this.lblName);
            this.sccMainSplitter.Panel1.Controls.Add(this.txtName);
            this.sccMainSplitter.Panel1.Text = "Panel1";
            this.sccMainSplitter.Panel2.Controls.Add(this.gcImages);
            this.sccMainSplitter.Panel2.Controls.Add(this.pnlActions);
            this.sccMainSplitter.Panel2.Text = "Panel2";
            this.sccMainSplitter.Size = new System.Drawing.Size(517, 529);
            this.sccMainSplitter.SplitterPosition = 157;
            this.sccMainSplitter.TabIndex = 1;
            this.sccMainSplitter.Text = "splitContainerControl1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(431, 1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Search Directory:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(102, 3);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(323, 20);
            this.txtDirectory.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(431, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(102, 121);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(76, 20);
            this.txtSize.TabIndex = 8;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(102, 89);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(138, 20);
            this.txtHeight.TabIndex = 7;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(102, 60);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(138, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // cbSizeType
            // 
            this.cbSizeType.Location = new System.Drawing.Point(184, 121);
            this.cbSizeType.Name = "cbSizeType";
            this.cbSizeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSizeType.Properties.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cbSizeType.Size = new System.Drawing.Size(56, 20);
            this.cbSizeType.TabIndex = 5;
            this.cbSizeType.SelectedIndexChanged += new System.EventHandler(this.cbSizeType_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(54, 124);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(42, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "File Size:";
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(61, 92);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(35, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.Location = new System.Drawing.Point(64, 63);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(32, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(43, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "File Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 0;
            // 
            // gcImages
            // 
            this.gcImages.DataSource = this.bsImages;
            this.gcImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcImages.Location = new System.Drawing.Point(0, 0);
            this.gcImages.MainView = this.gvImages;
            this.gcImages.Name = "gcImages";
            this.gcImages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckEdit});
            this.gcImages.Size = new System.Drawing.Size(517, 338);
            this.gcImages.TabIndex = 2;
            this.gcImages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImages});
            // 
            // bsImages
            // 
            this.bsImages.DataMember = "Images";
            this.bsImages.DataSource = this.imageDataSet;
            // 
            // imageDataSet
            // 
            this.imageDataSet.DataSetName = "ImageDataSet";
            this.imageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvImages
            // 
            this.gvImages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImageNumberOdd,
            this.colSelectOdd,
            this.colFullPathOdd,
            this.colImageNumberEven,
            this.colSelectEven,
            this.colFullPathEven,
            this.colImageNumberOdd2,
            this.colSelectOdd2,
            this.colFullPathOdd2,
            this.colImageNumberEven2,
            this.colSelectEven2,
            this.colFullPathEven2});
            this.gvImages.GridControl = this.gcImages;
            this.gvImages.Name = "gvImages";
            this.gvImages.OptionsView.ShowColumnHeaders = false;
            this.gvImages.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvImages.OptionsView.ShowGroupPanel = false;
            this.gvImages.OptionsView.ShowIndicator = false;
            this.gvImages.RowHeight = 100;
            this.gvImages.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvImages_CustomDrawCell);
            // 
            // colImageNumberOdd
            // 
            this.colImageNumberOdd.FieldName = "ImageNumberOdd";
            this.colImageNumberOdd.Name = "colImageNumberOdd";
            // 
            // colSelectOdd
            // 
            this.colSelectOdd.ColumnEdit = this.repCheckEdit;
            this.colSelectOdd.FieldName = "SelectOdd";
            this.colSelectOdd.MaxWidth = 24;
            this.colSelectOdd.Name = "colSelectOdd";
            this.colSelectOdd.OptionsColumn.AllowMove = false;
            this.colSelectOdd.OptionsColumn.AllowShowHide = false;
            this.colSelectOdd.OptionsColumn.AllowSize = false;
            this.colSelectOdd.Visible = true;
            this.colSelectOdd.VisibleIndex = 0;
            this.colSelectOdd.Width = 20;
            // 
            // repCheckEdit
            // 
            this.repCheckEdit.AutoHeight = false;
            this.repCheckEdit.Name = "repCheckEdit";
            // 
            // colFullPathOdd
            // 
            this.colFullPathOdd.Caption = "Image";
            this.colFullPathOdd.FieldName = "FullPathOdd";
            this.colFullPathOdd.MinWidth = 100;
            this.colFullPathOdd.Name = "colFullPathOdd";
            this.colFullPathOdd.OptionsColumn.AllowEdit = false;
            this.colFullPathOdd.OptionsColumn.AllowMove = false;
            this.colFullPathOdd.Visible = true;
            this.colFullPathOdd.VisibleIndex = 1;
            this.colFullPathOdd.Width = 100;
            // 
            // colImageNumberEven
            // 
            this.colImageNumberEven.FieldName = "ImageNumberEven";
            this.colImageNumberEven.Name = "colImageNumberEven";
            // 
            // colSelectEven
            // 
            this.colSelectEven.ColumnEdit = this.repCheckEdit;
            this.colSelectEven.FieldName = "SelectEven";
            this.colSelectEven.MaxWidth = 24;
            this.colSelectEven.Name = "colSelectEven";
            this.colSelectEven.OptionsColumn.AllowMove = false;
            this.colSelectEven.OptionsColumn.AllowShowHide = false;
            this.colSelectEven.OptionsColumn.AllowSize = false;
            this.colSelectEven.Visible = true;
            this.colSelectEven.VisibleIndex = 2;
            this.colSelectEven.Width = 20;
            // 
            // colFullPathEven
            // 
            this.colFullPathEven.FieldName = "FullPathEven";
            this.colFullPathEven.MinWidth = 100;
            this.colFullPathEven.Name = "colFullPathEven";
            this.colFullPathEven.OptionsColumn.AllowEdit = false;
            this.colFullPathEven.OptionsColumn.AllowMove = false;
            this.colFullPathEven.Visible = true;
            this.colFullPathEven.VisibleIndex = 3;
            this.colFullPathEven.Width = 100;
            // 
            // colImageNumberOdd2
            // 
            this.colImageNumberOdd2.FieldName = "ImageNumberEven2";
            this.colImageNumberOdd2.Name = "colImageNumberOdd2";
            this.colImageNumberOdd2.OptionsColumn.AllowEdit = false;
            this.colImageNumberOdd2.OptionsColumn.AllowFocus = false;
            this.colImageNumberOdd2.OptionsColumn.AllowMove = false;
            this.colImageNumberOdd2.OptionsColumn.AllowShowHide = false;
            this.colImageNumberOdd2.OptionsColumn.AllowSize = false;
            // 
            // colSelectOdd2
            // 
            this.colSelectOdd2.ColumnEdit = this.repCheckEdit;
            this.colSelectOdd2.FieldName = "SelectOdd2";
            this.colSelectOdd2.MaxWidth = 24;
            this.colSelectOdd2.Name = "colSelectOdd2";
            this.colSelectOdd2.OptionsColumn.AllowMove = false;
            this.colSelectOdd2.OptionsColumn.AllowShowHide = false;
            this.colSelectOdd2.OptionsColumn.AllowSize = false;
            this.colSelectOdd2.Visible = true;
            this.colSelectOdd2.VisibleIndex = 4;
            this.colSelectOdd2.Width = 22;
            // 
            // colFullPathOdd2
            // 
            this.colFullPathOdd2.FieldName = "FullPathOdd2";
            this.colFullPathOdd2.MinWidth = 100;
            this.colFullPathOdd2.Name = "colFullPathOdd2";
            this.colFullPathOdd2.OptionsColumn.AllowEdit = false;
            this.colFullPathOdd2.OptionsColumn.AllowFocus = false;
            this.colFullPathOdd2.OptionsColumn.AllowMove = false;
            this.colFullPathOdd2.OptionsColumn.AllowShowHide = false;
            this.colFullPathOdd2.OptionsColumn.AllowSize = false;
            this.colFullPathOdd2.Visible = true;
            this.colFullPathOdd2.VisibleIndex = 5;
            this.colFullPathOdd2.Width = 100;
            // 
            // colImageNumberEven2
            // 
            this.colImageNumberEven2.FieldName = "ImageNumberEven2";
            this.colImageNumberEven2.Name = "colImageNumberEven2";
            this.colImageNumberEven2.OptionsColumn.AllowEdit = false;
            this.colImageNumberEven2.OptionsColumn.AllowFocus = false;
            this.colImageNumberEven2.OptionsColumn.AllowMove = false;
            this.colImageNumberEven2.OptionsColumn.AllowShowHide = false;
            this.colImageNumberEven2.OptionsColumn.AllowSize = false;
            // 
            // colSelectEven2
            // 
            this.colSelectEven2.ColumnEdit = this.repCheckEdit;
            this.colSelectEven2.FieldName = "SelectEven2";
            this.colSelectEven2.MaxWidth = 24;
            this.colSelectEven2.Name = "colSelectEven2";
            this.colSelectEven2.OptionsColumn.AllowMove = false;
            this.colSelectEven2.OptionsColumn.AllowShowHide = false;
            this.colSelectEven2.OptionsColumn.AllowSize = false;
            this.colSelectEven2.Visible = true;
            this.colSelectEven2.VisibleIndex = 6;
            this.colSelectEven2.Width = 23;
            // 
            // colFullPathEven2
            // 
            this.colFullPathEven2.FieldName = "FullPathEven2";
            this.colFullPathEven2.MinWidth = 100;
            this.colFullPathEven2.Name = "colFullPathEven2";
            this.colFullPathEven2.OptionsColumn.AllowEdit = false;
            this.colFullPathEven2.OptionsColumn.AllowFocus = false;
            this.colFullPathEven2.OptionsColumn.AllowMove = false;
            this.colFullPathEven2.OptionsColumn.AllowShowHide = false;
            this.colFullPathEven2.OptionsColumn.AllowSize = false;
            this.colFullPathEven2.Visible = true;
            this.colFullPathEven2.VisibleIndex = 7;
            this.colFullPathEven2.Width = 100;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.lblStatus);
            this.pnlActions.Controls.Add(this.btnSelectAll);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 338);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(517, 29);
            this.pnlActions.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(93, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Location = new System.Drawing.Point(347, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(168, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "File 0 of 0";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectAll.Location = new System.Drawing.Point(2, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(91, 25);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 554);
            this.Controls.Add(this.sccMainSplitter);
            this.Controls.Add(this.tsMainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Image Search Tools by JAMGALACTIC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsMainStrip.ResumeLayout(false);
            this.tsMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sccMainSplitter)).EndInit();
            this.sccMainSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSizeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlActions)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainStrip;
        private DevExpress.XtraEditors.SplitContainerControl sccMainSplitter;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDirectory;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private DevExpress.XtraEditors.TextEdit txtHeight;
        private DevExpress.XtraEditors.TextEdit txtWidth;
        private DevExpress.XtraEditors.ComboBoxEdit cbSizeType;
        private DevExpress.XtraEditors.LabelControl lblSize;
        private DevExpress.XtraEditors.LabelControl lblHeight;
        private DevExpress.XtraEditors.LabelControl lblWidth;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.PanelControl pnlActions;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private System.Windows.Forms.BindingSource bsImages;
        private ImageDataSet imageDataSet;
        private DevExpress.XtraGrid.GridControl gcImages;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImages;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNumberOdd;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectOdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colFullPathOdd;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNumberEven;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectEven;
        private DevExpress.XtraGrid.Columns.GridColumn colFullPathEven;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNumberOdd2;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectOdd2;
        private DevExpress.XtraGrid.Columns.GridColumn colFullPathOdd2;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNumberEven2;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectEven2;
        private DevExpress.XtraGrid.Columns.GridColumn colFullPathEven2;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
    }
}

