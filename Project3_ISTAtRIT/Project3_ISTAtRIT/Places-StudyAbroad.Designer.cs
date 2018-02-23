namespace Project3_ISTAtRIT
{
    partial class Places_StudyAbroad
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
            this.placesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // placesFlowPanel
            // 
            this.placesFlowPanel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placesFlowPanel.Location = new System.Drawing.Point(37, 40);
            this.placesFlowPanel.Name = "placesFlowPanel";
            this.placesFlowPanel.Size = new System.Drawing.Size(833, 295);
            this.placesFlowPanel.TabIndex = 0;
            // 
            // Places_StudyAbroad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 352);
            this.Controls.Add(this.placesFlowPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Places_StudyAbroad";
            this.Text = "Places_StudyAbroad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel placesFlowPanel;
    }
}