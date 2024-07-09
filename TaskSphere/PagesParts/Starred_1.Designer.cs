namespace SE_Project.PagesParts
{
    partial class Starred_1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StarredPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // StarredPanel
            // 
            this.StarredPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StarredPanel.Location = new System.Drawing.Point(0, 0);
            this.StarredPanel.Margin = new System.Windows.Forms.Padding(0);
            this.StarredPanel.Name = "StarredPanel";
            this.StarredPanel.Size = new System.Drawing.Size(1338, 735);
            this.StarredPanel.TabIndex = 0;
            // 
            // Starred_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StarredPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Starred_1";
            this.Size = new System.Drawing.Size(1338, 735);
            this.Load += new System.EventHandler(this.Starred_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel StarredPanel;
    }
}
