namespace MyProjects.LinkStart.View
{
    partial class LinkQueriesForm
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
            this.linqQueriesUserControl = new MyProjects.LinkStart.View.LinqQueriesUserControl();
            this.SuspendLayout();
            // 
            // linqQueriesUserControl
            // 
            this.linqQueriesUserControl.AllowDrop = true;
            this.linqQueriesUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linqQueriesUserControl.Location = new System.Drawing.Point(12, 43);
            this.linqQueriesUserControl.Name = "linqQueriesUserControl";
            this.linqQueriesUserControl.Size = new System.Drawing.Size(586, 192);
            this.linqQueriesUserControl.TabIndex = 0;
            // 
            // LinkQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 276);
            this.Controls.Add(this.linqQueriesUserControl);
            this.Name = "LinkQueriesForm";
            this.Text = "LinkQueriesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LinqQueriesUserControl linqQueriesUserControl;
    }
}