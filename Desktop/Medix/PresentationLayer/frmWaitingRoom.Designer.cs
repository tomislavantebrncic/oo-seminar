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
            this.buttonNewExamination = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.waitingRoomListLabel = new System.Windows.Forms.Label();
            this.searchPatientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.dataGridViewWaitingRoom = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalExaminationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPatientDate = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWaitingRoom = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.medicalExaminationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaitingRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewExamination
            // 
            this.buttonNewExamination.Location = new System.Drawing.Point(200, 135);
            this.buttonNewExamination.Name = "buttonNewExamination";
            this.buttonNewExamination.Size = new System.Drawing.Size(75, 23);
            this.buttonNewExamination.TabIndex = 5;
            this.buttonNewExamination.Text = "UPUTNICA";
            this.buttonNewExamination.UseVisualStyleBackColor = true;
            this.buttonNewExamination.Click += new System.EventHandler(this.buttonNewExamination_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(281, 135);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(136, 23);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "POVIJEST BOLESTI";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(423, 135);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 7;
            this.buttonReport.Text = "IZVJEŠTAJ";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // waitingRoomListLabel
            // 
            this.waitingRoomListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingRoomListLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.waitingRoomListLabel.Location = new System.Drawing.Point(375, 212);
            this.waitingRoomListLabel.Name = "waitingRoomListLabel";
            this.waitingRoomListLabel.Size = new System.Drawing.Size(250, 25);
            this.waitingRoomListLabel.TabIndex = 1;
            this.waitingRoomListLabel.Text = "PACIJENTI U ČEKAONICI";
            this.waitingRoomListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchPatientLabel
            // 
            this.searchPatientLabel.AutoSize = true;
            this.searchPatientLabel.Location = new System.Drawing.Point(332, 245);
            this.searchPatientLabel.Name = "searchPatientLabel";
            this.searchPatientLabel.Size = new System.Drawing.Size(110, 13);
            this.searchPatientLabel.TabIndex = 9;
            this.searchPatientLabel.Text = "Upišite ime pacijenta: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.Location = new System.Drawing.Point(574, 240);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(75, 23);
            this.searchPatientButton.TabIndex = 2;
            this.searchPatientButton.Text = "Traži";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWaitingRoom
            // 
            this.dataGridViewWaitingRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridViewWaitingRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewWaitingRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaitingRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridViewWaitingRoom.Location = new System.Drawing.Point(150, 288);
            this.dataGridViewWaitingRoom.MultiSelect = false;
            this.dataGridViewWaitingRoom.Name = "dataGridViewWaitingRoom";
            this.dataGridViewWaitingRoom.ReadOnly = true;
            this.dataGridViewWaitingRoom.Size = new System.Drawing.Size(700, 300);
            this.dataGridViewWaitingRoom.TabIndex = 4;
            this.dataGridViewWaitingRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWaitingRoom_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "time";
            this.Column2.HeaderText = "Datum";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Ime pacijenta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // medicalExaminationBindingSource1
            // 
            this.medicalExaminationBindingSource1.DataSource = typeof(Model.MedicalExamination);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.labelPatientName.Text = "NEMA PACIJENATA NA PREGLEDU!";
            this.labelPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.labelWaitingRoom);
            this.panel2.Controls.Add(this.labelEmployee);
            this.panel2.Location = new System.Drawing.Point(200, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 31);
            this.panel2.TabIndex = 17;
            // 
            // labelWaitingRoom
            // 
            this.labelWaitingRoom.AutoSize = true;
            this.labelWaitingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaitingRoom.Location = new System.Drawing.Point(457, 1);
            this.labelWaitingRoom.Name = "labelWaitingRoom";
            this.labelWaitingRoom.Size = new System.Drawing.Size(55, 24);
            this.labelWaitingRoom.TabIndex = 1;
            this.labelWaitingRoom.Text = "Odjel";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(13, 1);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(102, 24);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "Zaposlenik";
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
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(897, 16);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Odjava";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // frmWaitingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewWaitingRoom);
            this.Controls.Add(this.searchPatientButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchPatientLabel);
            this.Controls.Add(this.waitingRoomListLabel);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.buttonNewExamination);
            this.MaximizeBox = false;
            this.Name = "frmWaitingRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWaitingRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaitingRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalExaminationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewExamination;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button buttonReport;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPatientDate;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Label labelPatientId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWaitingRoom;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationType;
        private System.Windows.Forms.Button buttonLogout;
    }
}