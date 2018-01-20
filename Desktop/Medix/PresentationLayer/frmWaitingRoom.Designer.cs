﻿namespace PresentationLayer
{
    partial class frmWaitingRoom
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
            this.MBLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientBirthDateLabel = new System.Windows.Forms.Label();
            this.buttonNewExamination = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.findingsButton = new System.Windows.Forms.Button();
            this.waitingRoomListLabel = new System.Windows.Forms.Label();
            this.searchPatientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.dataGridViewWaitingRoom = new System.Windows.Forms.DataGridView();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExaminationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalExaminationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalExaminationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaitingRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MBLabel
            // 
            this.MBLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MBLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.MBLabel.Location = new System.Drawing.Point(106, 9);
            this.MBLabel.Name = "MBLabel";
            this.MBLabel.Size = new System.Drawing.Size(92, 20);
            this.MBLabel.TabIndex = 0;
            this.MBLabel.Text = "MB123456789";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.patientNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(189, 9);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(327, 20);
            this.patientNameLabel.TabIndex = 1;
            this.patientNameLabel.Text = "IME PREZIME";
            // 
            // patientBirthDateLabel
            // 
            this.patientBirthDateLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.patientBirthDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientBirthDateLabel.Location = new System.Drawing.Point(490, 9);
            this.patientBirthDateLabel.Name = "patientBirthDateLabel";
            this.patientBirthDateLabel.Size = new System.Drawing.Size(95, 20);
            this.patientBirthDateLabel.TabIndex = 2;
            this.patientBirthDateLabel.Text = "dd.mm.yyyy";
            // 
            // buttonNewExamination
            // 
            this.buttonNewExamination.Location = new System.Drawing.Point(106, 135);
            this.buttonNewExamination.Name = "buttonNewExamination";
            this.buttonNewExamination.Size = new System.Drawing.Size(75, 23);
            this.buttonNewExamination.TabIndex = 5;
            this.buttonNewExamination.Text = "UPUTNICA";
            this.buttonNewExamination.UseVisualStyleBackColor = true;
            this.buttonNewExamination.Click += new System.EventHandler(this.buttonNewExamination_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(198, 135);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(136, 23);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "POVIJEST BOLESTI";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // findingsButton
            // 
            this.findingsButton.Location = new System.Drawing.Point(352, 135);
            this.findingsButton.Name = "findingsButton";
            this.findingsButton.Size = new System.Drawing.Size(75, 23);
            this.findingsButton.TabIndex = 7;
            this.findingsButton.Text = "NALAZI";
            this.findingsButton.UseVisualStyleBackColor = true;
            // 
            // waitingRoomListLabel
            // 
            this.waitingRoomListLabel.AutoSize = true;
            this.waitingRoomListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingRoomListLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.waitingRoomListLabel.Location = new System.Drawing.Point(348, 238);
            this.waitingRoomListLabel.Name = "waitingRoomListLabel";
            this.waitingRoomListLabel.Size = new System.Drawing.Size(249, 24);
            this.waitingRoomListLabel.TabIndex = 8;
            this.waitingRoomListLabel.Text = "PACIJENTI U ČEKAONICI";
            this.waitingRoomListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchPatientLabel
            // 
            this.searchPatientLabel.AutoSize = true;
            this.searchPatientLabel.Location = new System.Drawing.Point(213, 179);
            this.searchPatientLabel.Name = "searchPatientLabel";
            this.searchPatientLabel.Size = new System.Drawing.Size(110, 13);
            this.searchPatientLabel.TabIndex = 9;
            this.searchPatientLabel.Text = "Upišite ime pacijenta: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(441, 174);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(75, 23);
            this.searchPatientButton.TabIndex = 11;
            this.searchPatientButton.Text = "Traži";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWaitingRoom
            // 
            this.dataGridViewWaitingRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridViewWaitingRoom.AutoGenerateColumns = false;
            this.dataGridViewWaitingRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWaitingRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaitingRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientDataGridViewTextBoxColumn,
            this.examinationDateDataGridViewTextBoxColumn,
            this.ExaminationType});
            this.dataGridViewWaitingRoom.DataSource = this.medicalExaminationBindingSource1;
            this.dataGridViewWaitingRoom.Location = new System.Drawing.Point(95, 306);
            this.dataGridViewWaitingRoom.Name = "dataGridViewWaitingRoom";
            this.dataGridViewWaitingRoom.Size = new System.Drawing.Size(756, 257);
            this.dataGridViewWaitingRoom.TabIndex = 14;
            // 
            // buttonExamine
            // 
            this.buttonExamine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExamine.Location = new System.Drawing.Point(717, 624);
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.Size = new System.Drawing.Size(102, 37);
            this.buttonExamine.TabIndex = 15;
            this.buttonExamine.Text = "Pregledaj";
            this.buttonExamine.UseVisualStyleBackColor = true;
            this.buttonExamine.Click += new System.EventHandler(this.buttonExamine_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ExaminationType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tip";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Pacijent";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            // 
            // examinationDateDataGridViewTextBoxColumn
            // 
            this.examinationDateDataGridViewTextBoxColumn.DataPropertyName = "ExaminationDate";
            this.examinationDateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.examinationDateDataGridViewTextBoxColumn.Name = "examinationDateDataGridViewTextBoxColumn";
            // 
            // ExaminationType
            // 
            this.ExaminationType.DataPropertyName = "ExaminationType";
            this.ExaminationType.HeaderText = "Tip";
            this.ExaminationType.Name = "ExaminationType";
            this.ExaminationType.Width = 200;
            // 
            // medicalExaminationBindingSource1
            // 
            this.medicalExaminationBindingSource1.DataSource = typeof(Model.MedicalExamination);
            // 
            // medicalExaminationBindingSource
            // 
            this.medicalExaminationBindingSource.DataSource = typeof(Model.MedicalExamination);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Model.Patient);
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataSource = typeof(Model.Patient);
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataSource = typeof(Model.Patient);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPatientDate);
            this.panel1.Controls.Add(this.labelPatientName);
            this.panel1.Controls.Add(this.labelPatientId);
            this.panel1.Location = new System.Drawing.Point(200, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 30);
            this.panel1.TabIndex = 16;
            // 
            // labelPatientId
            // 
            this.labelPatientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelPatientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientId.ForeColor = System.Drawing.Color.Maroon;
            this.labelPatientId.Location = new System.Drawing.Point(0, 0);
            this.labelPatientId.Name = "labelPatientId";
            this.labelPatientId.Size = new System.Drawing.Size(150, 30);
            this.labelPatientId.TabIndex = 0;
            this.labelPatientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPatientName
            // 
            this.labelPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.ForeColor = System.Drawing.Color.Maroon;
            this.labelPatientName.Location = new System.Drawing.Point(150, 0);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(350, 30);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "NIJE ODABRAN PACIJENT!";
            this.labelPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPatientDate
            // 
            this.labelPatientDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelPatientDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatientDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientDate.ForeColor = System.Drawing.Color.Maroon;
            this.labelPatientDate.Location = new System.Drawing.Point(500, 0);
            this.labelPatientDate.Name = "labelPatientDate";
            this.labelPatientDate.Size = new System.Drawing.Size(100, 30);
            this.labelPatientDate.TabIndex = 2;
            this.labelPatientDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmWaitingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExamine);
            this.Controls.Add(this.dataGridViewWaitingRoom);
            this.Controls.Add(this.searchPatientButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchPatientLabel);
            this.Controls.Add(this.waitingRoomListLabel);
            this.Controls.Add(this.findingsButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.buttonNewExamination);
            this.Controls.Add(this.patientBirthDateLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.MBLabel);
            this.MaximizeBox = false;
            this.Name = "frmWaitingRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWaitingRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaitingRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientBirthDateLabel;
        private System.Windows.Forms.Button buttonNewExamination;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button findingsButton;
        private System.Windows.Forms.Label waitingRoomListLabel;
        private System.Windows.Forms.Label searchPatientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private System.Windows.Forms.BindingSource medicalExaminationBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewWaitingRoom;
        private System.Windows.Forms.BindingSource medicalExaminationBindingSource1;
        private System.Windows.Forms.Button buttonExamine;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPatientDate;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Label labelPatientId;
    }
}