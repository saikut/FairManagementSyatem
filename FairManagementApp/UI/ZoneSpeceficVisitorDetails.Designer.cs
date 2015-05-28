namespace FairManagementApp.UI
{
    partial class ZoneSpeceficVisitorDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.zoneSpecefircVisitorDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVisitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fairManagementSystemDBDataSet1 = new FairManagementApp.FairManagementSystemDBDataSet1();
            this.fairManagementSystemDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fairManagementSystemDBDataSet = new FairManagementApp.FairManagementSystemDBDataSet();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.totalVisitroDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblVisitorTableAdapter = new FairManagementApp.FairManagementSystemDBDataSet1TableAdapters.tblVisitorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zoneSpecefircVisitorDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // SelectZoneComboBox
            // 
            this.SelectZoneComboBox.FormattingEnabled = true;
            this.SelectZoneComboBox.Location = new System.Drawing.Point(108, 14);
            this.SelectZoneComboBox.Name = "SelectZoneComboBox";
            this.SelectZoneComboBox.Size = new System.Drawing.Size(141, 21);
            this.SelectZoneComboBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(273, 13);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // zoneSpecefircVisitorDetailsDataGridView
            // 
            this.zoneSpecefircVisitorDetailsDataGridView.AllowUserToAddRows = false;
            this.zoneSpecefircVisitorDetailsDataGridView.AutoGenerateColumns = false;
            this.zoneSpecefircVisitorDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zoneSpecefircVisitorDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zoneSpecefircVisitorDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn});
            this.zoneSpecefircVisitorDetailsDataGridView.DataSource = this.tblVisitorBindingSource;
            this.zoneSpecefircVisitorDetailsDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zoneSpecefircVisitorDetailsDataGridView.Location = new System.Drawing.Point(12, 81);
            this.zoneSpecefircVisitorDetailsDataGridView.Name = "zoneSpecefircVisitorDetailsDataGridView";
            this.zoneSpecefircVisitorDetailsDataGridView.Size = new System.Drawing.Size(358, 186);
            this.zoneSpecefircVisitorDetailsDataGridView.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // tblVisitorBindingSource
            // 
            this.tblVisitorBindingSource.DataMember = "tblVisitor";
            this.tblVisitorBindingSource.DataSource = this.fairManagementSystemDBDataSet1;
            // 
            // fairManagementSystemDBDataSet1
            // 
            this.fairManagementSystemDBDataSet1.DataSetName = "FairManagementSystemDBDataSet1";
            this.fairManagementSystemDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fairManagementSystemDBDataSetBindingSource
            // 
            this.fairManagementSystemDBDataSetBindingSource.DataSource = this.fairManagementSystemDBDataSet;
            this.fairManagementSystemDBDataSetBindingSource.Position = 0;
            // 
            // fairManagementSystemDBDataSet
            // 
            this.fairManagementSystemDBDataSet.DataSetName = "FairManagementSystemDBDataSet";
            this.fairManagementSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(258, 326);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(101, 23);
            this.exportToExcelButton.TabIndex = 4;
            this.exportToExcelButton.Text = "Export To Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // totalVisitroDetailsTextBox
            // 
            this.totalVisitroDetailsTextBox.Location = new System.Drawing.Point(270, 287);
            this.totalVisitroDetailsTextBox.Name = "totalVisitroDetailsTextBox";
            this.totalVisitroDetailsTextBox.Size = new System.Drawing.Size(89, 20);
            this.totalVisitroDetailsTextBox.TabIndex = 5;
            this.totalVisitroDetailsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // tblVisitorTableAdapter
            // 
            this.tblVisitorTableAdapter.ClearBeforeFill = true;
            // 
            // ZoneSpeceficVisitorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 361);
            this.Controls.Add(this.totalVisitroDetailsTextBox);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.zoneSpecefircVisitorDetailsDataGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.SelectZoneComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpeceficVisitorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Specefic Visitor Details";
            this.Load += new System.EventHandler(this.ZoneSpeceficVisitorDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoneSpecefircVisitorDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectZoneComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView zoneSpecefircVisitorDetailsDataGridView;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.TextBox totalVisitroDetailsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fairManagementSystemDBDataSetBindingSource;
        private FairManagementSystemDBDataSet fairManagementSystemDBDataSet;
        private FairManagementSystemDBDataSet1 fairManagementSystemDBDataSet1;
        private System.Windows.Forms.BindingSource tblVisitorBindingSource;
        private FairManagementSystemDBDataSet1TableAdapters.tblVisitorTableAdapter tblVisitorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
    }
}