namespace PresentationLayer
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
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.pacijentLabel = new System.Windows.Forms.Label();
            this.generalInfoButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.findingsButton = new System.Windows.Forms.Button();
            this.waitingRoomListLabel = new System.Windows.Forms.Label();
            this.searchPatientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
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
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(160, 43);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientNameTextBox.TabIndex = 3;
            // 
            // pacijentLabel
            // 
            this.pacijentLabel.AutoSize = true;
            this.pacijentLabel.Location = new System.Drawing.Point(103, 50);
            this.pacijentLabel.Name = "pacijentLabel";
            this.pacijentLabel.Size = new System.Drawing.Size(48, 13);
            this.pacijentLabel.TabIndex = 4;
            this.pacijentLabel.Text = "Pacijent:";
            // 
            // generalInfoButton
            // 
            this.generalInfoButton.Location = new System.Drawing.Point(106, 84);
            this.generalInfoButton.Name = "generalInfoButton";
            this.generalInfoButton.Size = new System.Drawing.Size(75, 23);
            this.generalInfoButton.TabIndex = 5;
            this.generalInfoButton.Text = "OPĆI";
            this.generalInfoButton.UseVisualStyleBackColor = true;
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(187, 84);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(136, 23);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "POVIJEST BOLESTI";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // findingsButton
            // 
            this.findingsButton.Location = new System.Drawing.Point(329, 84);
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
            this.waitingRoomListLabel.Location = new System.Drawing.Point(250, 137);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(Model.Patient);
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataSource = typeof(Model.Patient);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Ime ";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmWaitingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(764, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchPatientButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchPatientLabel);
            this.Controls.Add(this.waitingRoomListLabel);
            this.Controls.Add(this.findingsButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.generalInfoButton);
            this.Controls.Add(this.pacijentLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.patientBirthDateLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.MBLabel);
            this.Name = "frmWaitingRoom";
            this.Text = "frmWaitingRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientBirthDateLabel;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label pacijentLabel;
        private System.Windows.Forms.Button generalInfoButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button findingsButton;
        private System.Windows.Forms.Label waitingRoomListLabel;
        private System.Windows.Forms.Label searchPatientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}