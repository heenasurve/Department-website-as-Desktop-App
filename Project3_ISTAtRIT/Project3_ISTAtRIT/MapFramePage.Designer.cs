namespace Project3_ISTAtRIT
{
    partial class MapFramePage
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
            this.mapContainer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // mapContainer
            // 
            this.mapContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapContainer.Location = new System.Drawing.Point(0, 0);
            this.mapContainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapContainer.Name = "mapContainer";
            this.mapContainer.Size = new System.Drawing.Size(1062, 636);
            this.mapContainer.TabIndex = 0;
            // 
            // MapFramePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 636);
            this.Controls.Add(this.mapContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapFramePage";
            this.Text = "MapFramePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser mapContainer;
    }
}