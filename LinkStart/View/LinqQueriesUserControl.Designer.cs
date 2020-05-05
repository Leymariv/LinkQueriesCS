using LinqWinformProject.LinkStart.View;

namespace MyProjects.LinkStart.View
{
    partial class LinqQueriesUserControl
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
            this.selectAQueryView = new LinqWinformProject.LinkStart.View.SelectAQueryView();
            this.displayQueryResultView = new DisplayQueryResultView();
            this.SuspendLayout();
            // 
            // selectAQueryView
            // 
            this.selectAQueryView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAQueryView.Location = new System.Drawing.Point(0, 0);
            this.selectAQueryView.Name = "selectAQueryView";
            this.selectAQueryView.Size = new System.Drawing.Size(400, 200);
            this.selectAQueryView.TabIndex = 1;
            // 
            // displayQueryResultView
            // 
            this.displayQueryResultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayQueryResultView.Location = new System.Drawing.Point(0, 0);
            this.displayQueryResultView.Name = "displayQueryResultView";
            this.displayQueryResultView.Size = new System.Drawing.Size(400, 200);
            this.displayQueryResultView.TabIndex = 0;
            this.displayQueryResultView.Visible = false;
            // 
            // LinqQueriesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectAQueryView);
            this.Controls.Add(this.displayQueryResultView);
            this.Name = "LinqQueriesUserControl";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private DisplayQueryResultView displayQueryResultView;
        private SelectAQueryView selectAQueryView;
    }
}
