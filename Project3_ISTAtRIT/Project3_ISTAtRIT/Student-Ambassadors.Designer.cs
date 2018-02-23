namespace Project3_ISTAtRIT
{
    partial class Student_Ambassadors
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
            this.studentAmbRTB = new System.Windows.Forms.RichTextBox();
            this.studentAmbapplyLink = new System.Windows.Forms.LinkLabel();
            this.studentAmbNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(304, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Ambassador Information and Application";
            // 
            // studentAmbRTB
            // 
            this.studentAmbRTB.BackColor = System.Drawing.Color.White;
            this.studentAmbRTB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAmbRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.studentAmbRTB.Location = new System.Drawing.Point(79, 103);
            this.studentAmbRTB.Name = "studentAmbRTB";
            this.studentAmbRTB.ReadOnly = true;
            this.studentAmbRTB.Size = new System.Drawing.Size(1011, 421);
            this.studentAmbRTB.TabIndex = 1;
            this.studentAmbRTB.Text = "";
            // 
            // studentAmbapplyLink
            // 
            this.studentAmbapplyLink.AutoSize = true;
            this.studentAmbapplyLink.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAmbapplyLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.studentAmbapplyLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.studentAmbapplyLink.Location = new System.Drawing.Point(429, 549);
            this.studentAmbapplyLink.Name = "studentAmbapplyLink";
            this.studentAmbapplyLink.Size = new System.Drawing.Size(310, 19);
            this.studentAmbapplyLink.TabIndex = 2;
            this.studentAmbapplyLink.TabStop = true;
            this.studentAmbapplyLink.Text = "Apply to become a Student Ambassador !";
            // 
            // studentAmbNote
            // 
            this.studentAmbNote.AutoSize = true;
            this.studentAmbNote.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAmbNote.Location = new System.Drawing.Point(169, 600);
            this.studentAmbNote.Name = "studentAmbNote";
            this.studentAmbNote.Size = new System.Drawing.Size(39, 14);
            this.studentAmbNote.TabIndex = 3;
            this.studentAmbNote.Text = "label2";
            // 
            // Student_Ambassadors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 625);
            this.Controls.Add(this.studentAmbNote);
            this.Controls.Add(this.studentAmbapplyLink);
            this.Controls.Add(this.studentAmbRTB);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Ambassadors";
            this.Text = "Student_Ambassadors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox studentAmbRTB;
        private System.Windows.Forms.LinkLabel studentAmbapplyLink;
        private System.Windows.Forms.Label studentAmbNote;
    }
}