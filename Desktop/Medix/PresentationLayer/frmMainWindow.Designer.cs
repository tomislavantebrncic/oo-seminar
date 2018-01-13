namespace PresentationLayer
{
    partial class frmMainWindow
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
            this.waitingRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // waitingRoomButton
            // 
            this.waitingRoomButton.Location = new System.Drawing.Point(31, 35);
            this.waitingRoomButton.Name = "waitingRoomButton";
            this.waitingRoomButton.Size = new System.Drawing.Size(205, 23);
            this.waitingRoomButton.TabIndex = 0;
            this.waitingRoomButton.Text = "ČEKAONICA";
            this.waitingRoomButton.UseVisualStyleBackColor = true;
            this.waitingRoomButton.Click += new System.EventHandler(this.waitingRoomButton_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.waitingRoomButton);
            this.Name = "frmMainWindow";
            this.Text = "frmMainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button waitingRoomButton;
    }
}