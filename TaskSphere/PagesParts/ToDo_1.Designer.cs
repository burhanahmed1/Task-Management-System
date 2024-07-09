namespace SE_Project.PagesParts
{
    partial class ToDo_1
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
            this.ToDoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ToDoPanel
            // 
            this.ToDoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDoPanel.Location = new System.Drawing.Point(0, 0);
            this.ToDoPanel.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.ToDoPanel.Name = "ToDoPanel";
            this.ToDoPanel.Size = new System.Drawing.Size(1338, 735);
            this.ToDoPanel.TabIndex = 0;
            this.ToDoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ToDoPanel_Paint);
            // 
            // ToDo_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ToDoPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ToDo_1";
            this.Size = new System.Drawing.Size(1338, 735);
            this.Load += new System.EventHandler(this.ToDo_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ToDoPanel;
    }
}
