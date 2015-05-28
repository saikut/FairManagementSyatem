﻿namespace FairManagementApp.UI
{
    partial class ZoneTypeEntry
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zoneTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.zoneTypeEntryDataGridView = new System.Windows.Forms.DataGridView();
            this.zoneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblZoneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fairManagementSystemDBDataSet = new FairManagementApp.FairManagementSystemDBDataSet();
            this.tblZoneTypeTableAdapter = new FairManagementApp.FairManagementSystemDBDataSetTableAdapters.tblZoneTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneTypeEntryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblZoneTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zoneTypeNameTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone Type";
            // 
            // zoneTypeNameTextBox
            // 
            this.zoneTypeNameTextBox.Location = new System.Drawing.Point(110, 27);
            this.zoneTypeNameTextBox.Name = "zoneTypeNameTextBox";
            this.zoneTypeNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.zoneTypeNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(210, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zoneTypeEntryDataGridView
            // 
            this.zoneTypeEntryDataGridView.AutoGenerateColumns = false;
            this.zoneTypeEntryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zoneTypeEntryDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zoneTypeEntryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zoneTypeEntryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zoneTypeDataGridViewTextBoxColumn});
            this.zoneTypeEntryDataGridView.DataSource = this.tblZoneTypeBindingSource;
            this.zoneTypeEntryDataGridView.Location = new System.Drawing.Point(12, 162);
            this.zoneTypeEntryDataGridView.Name = "zoneTypeEntryDataGridView";
            this.zoneTypeEntryDataGridView.Size = new System.Drawing.Size(334, 149);
            this.zoneTypeEntryDataGridView.TabIndex = 3;
            // 
            // zoneTypeDataGridViewTextBoxColumn
            // 
            this.zoneTypeDataGridViewTextBoxColumn.DataPropertyName = "ZoneType";
            this.zoneTypeDataGridViewTextBoxColumn.HeaderText = "ZoneType";
            this.zoneTypeDataGridViewTextBoxColumn.Name = "zoneTypeDataGridViewTextBoxColumn";
            // 
            // tblZoneTypeBindingSource
            // 
            this.tblZoneTypeBindingSource.DataMember = "tblZoneType";
            this.tblZoneTypeBindingSource.DataSource = this.fairManagementSystemDBDataSet;
            // 
            // fairManagementSystemDBDataSet
            // 
            this.fairManagementSystemDBDataSet.DataSetName = "FairManagementSystemDBDataSet";
            this.fairManagementSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblZoneTypeTableAdapter
            // 
            this.tblZoneTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ZoneTypeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 359);
            this.Controls.Add(this.zoneTypeEntryDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneTypeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Type Entry";
            this.Load += new System.EventHandler(this.ZoneTypeEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneTypeEntryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblZoneTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fairManagementSystemDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox zoneTypeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView zoneTypeEntryDataGridView;
        private FairManagementSystemDBDataSet fairManagementSystemDBDataSet;
        private System.Windows.Forms.BindingSource tblZoneTypeBindingSource;
        private FairManagementSystemDBDataSetTableAdapters.tblZoneTypeTableAdapter tblZoneTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneTypeDataGridViewTextBoxColumn;
    }
}