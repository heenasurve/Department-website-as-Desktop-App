namespace Project3_ISTAtRIT
{
    partial class Coop_Enrollment
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
            this.label1 = new System.Windows.Forms.Label();
            this.coopInfoRTB = new System.Windows.Forms.RichTextBox();
            this.coopJobZoneLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(495, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co-op Enrollment";
            // 
            // coopInfoRTB
            // 
            this.coopInfoRTB.BackColor = System.Drawing.Color.White;
            this.coopInfoRTB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coopInfoRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coopInfoRTB.Location = new System.Drawing.Point(81, 82);
            this.coopInfoRTB.Name = "coopInfoRTB";
            this.coopInfoRTB.ReadOnly = true;
            this.coopInfoRTB.Size = new System.Drawing.Size(1007, 487);
            this.coopInfoRTB.TabIndex = 1;
            this.coopInfoRTB.Text = "";
            // 
            // coopJobZoneLink
            // 
            this.coopJobZoneLink.AutoSize = true;
            this.coopJobZoneLink.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coopJobZoneLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coopJobZoneLink.Location = new System.Drawing.Point(507, 594);
            this.coopJobZoneLink.Name = "coopJobZoneLink";
            this.coopJobZoneLink.Size = new System.Drawing.Size(146, 19);
            this.coopJobZoneLink.TabIndex = 2;
            this.coopJobZoneLink.TabStop = true;
            this.coopJobZoneLink.Text = "RIT JobZone Guide";
            // 
            // Coop_Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 635);
            this.Controls.Add(this.coopJobZoneLink);
            this.Controls.Add(this.coopInfoRTB);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coop_Enrollment";
            this.Text = "Coop_Enrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox coopInfoRTB;
        private System.Windows.Forms.LinkLabel coopJobZoneLink;
    }
}