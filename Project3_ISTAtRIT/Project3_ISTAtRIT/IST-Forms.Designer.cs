namespace Project3_ISTAtRIT
{
    partial class IST_Forms
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
            this.gradFormsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.undergradFormsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradFormsFlowPanel
            // 
            this.gradFormsFlowPanel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradFormsFlowPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gradFormsFlowPanel.Location = new System.Drawing.Point(163, 120);
            this.gradFormsFlowPanel.Name = "gradFormsFlowPanel";
            this.gradFormsFlowPanel.Size = new System.Drawing.Size(315, 628);
            this.gradFormsFlowPanel.TabIndex = 0;
            // 
            // undergradFormsFlowPanel
            // 
            this.undergradFormsFlowPanel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undergradFormsFlowPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.undergradFormsFlowPanel.Location = new System.Drawing.Point(691, 120);
            this.undergradFormsFlowPanel.Name = "undergradFormsFlowPanel";
            this.undergradFormsFlowPanel.Size = new System.Drawing.Size(314, 628);
            this.undergradFormsFlowPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(163, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graduate Forms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(691, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Undergraduate Forms";
            // 
            // IST_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 813);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.undergradFormsFlowPanel);
            this.Controls.Add(this.gradFormsFlowPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IST_Forms";
            this.Text = "IST_Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel gradFormsFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel undergradFormsFlowPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}