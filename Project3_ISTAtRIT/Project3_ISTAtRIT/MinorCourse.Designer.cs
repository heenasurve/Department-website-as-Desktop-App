namespace Project3_ISTAtRIT
{
    partial class MinorCourse
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
            this.courseTitle = new System.Windows.Forms.Label();
            this.courseDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseTitle
            // 
            this.courseTitle.AutoSize = true;
            this.courseTitle.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.courseTitle.Location = new System.Drawing.Point(49, 52);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(70, 25);
            this.courseTitle.TabIndex = 0;
            this.courseTitle.Text = "label1";
            // 
            // courseDesc
            // 
            this.courseDesc.AutoSize = true;
            this.courseDesc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.courseDesc.Location = new System.Drawing.Point(50, 129);
            this.courseDesc.MaximumSize = new System.Drawing.Size(300, 0);
            this.courseDesc.Name = "courseDesc";
            this.courseDesc.Size = new System.Drawing.Size(51, 19);
            this.courseDesc.TabIndex = 1;
            this.courseDesc.Text = "label2";
            // 
            // MinorCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 492);
            this.Controls.Add(this.courseDesc);
            this.Controls.Add(this.courseTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MinorCourse";
            this.Text = "MinorCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseTitle;
        private System.Windows.Forms.Label courseDesc;
    }
}