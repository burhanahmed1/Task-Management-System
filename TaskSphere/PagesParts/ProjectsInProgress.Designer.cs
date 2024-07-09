namespace SE_Project.PagesParts
{
    partial class ProjectsInProgress
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
            this.ProjectsInProgressPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ProjectsInProgressPanel
            // 
            this.ProjectsInProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsInProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectsInProgressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectsInProgressPanel.Name = "ProjectsInProgressPanel";
            this.ProjectsInProgressPanel.Size = new System.Drawing.Size(1338, 735);
            this.ProjectsInProgressPanel.TabIndex = 0;
            // 
            // ProjectsInProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProjectsInProgressPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProjectsInProgress";
            this.Size = new System.Drawing.Size(1338, 735);
            this.Load += new System.EventHandler(this.ProjectsInProgress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProjectsInProgressPanel;
    }
}
