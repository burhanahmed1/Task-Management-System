namespace SE_Project.PagesParts
{
    partial class AllProjects
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
            this.AllProjectsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AllProjectsPanel
            // 
            this.AllProjectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllProjectsPanel.Location = new System.Drawing.Point(0, 0);
            this.AllProjectsPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.AllProjectsPanel.Name = "AllProjectsPanel";
            this.AllProjectsPanel.Size = new System.Drawing.Size(892, 478);
            this.AllProjectsPanel.TabIndex = 0;
            // 
            // AllProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AllProjectsPanel);
            this.Name = "AllProjects";
            this.Size = new System.Drawing.Size(892, 478);
            this.Load += new System.EventHandler(this.AllProjects_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AllProjectsPanel;
    }
}
