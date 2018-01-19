namespace PresentationLayer
{
    partial class frmMedicalRecords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPatientId = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelPatientName);
            this.panel1.Controls.Add(this.labelPatientId);
            this.panel1.Location = new System.Drawing.Point(61, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 46);
            this.panel1.TabIndex = 0;
            // 
            // labelPatientId
            // 
            this.labelPatientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatientId.Location = new System.Drawing.Point(14, 15);
            this.labelPatientId.Name = "labelPatientId";
            this.labelPatientId.Size = new System.Drawing.Size(173, 23);
            this.labelPatientId.TabIndex = 0;
            this.labelPatientId.Text = "label1";
            this.labelPatientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPatientName
            // 
            this.labelPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPatientName.Location = new System.Drawing.Point(188, 15);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(496, 23);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "label1";
            this.labelPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Location = new System.Drawing.Point(685, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(139, 23);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label1";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 789);
            this.Controls.Add(this.panel1);
            this.Name = "frmMedicalRecords";
            this.Text = "frmMedicalRecords";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Label labelPatientId;
    }
}