namespace LinqWinformProject.LinkStart.View
{
    partial class DisplayQueryResultView
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
            this.components = new System.ComponentModel.Container();
            this.returnPreviousMenu = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.queryFourTupleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marqueCountTupleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryFourTupleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueCountTupleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // returnPreviousMenu
            // 
            this.returnPreviousMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnPreviousMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnPreviousMenu.Location = new System.Drawing.Point(3, 3);
            this.returnPreviousMenu.Name = "returnPreviousMenu";
            this.returnPreviousMenu.Size = new System.Drawing.Size(38, 23);
            this.returnPreviousMenu.TabIndex = 1;
            this.returnPreviousMenu.Text = "←";
            this.returnPreviousMenu.UseVisualStyleBackColor = true;
            this.returnPreviousMenu.Click += new System.EventHandler(this.ReturnPreviousMenuClick);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(394, 159);
            this.dataGridView.TabIndex = 0;
            // 
            // queryFourTupleBindingSource
            // 
            this.queryFourTupleBindingSource.DataSource = typeof(LinqWinformProject.LinkStart.Model.QueryFourTuple);
            // 
            // marqueCountTupleBindingSource
            // 
            this.marqueCountTupleBindingSource.DataSource = typeof(LinqWinformProject.LinkStart.Model.MarqueCountTuple);
            // 
            // DisplayQueryResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.returnPreviousMenu);
            this.Name = "DisplayQueryResultView";
            this.Size = new System.Drawing.Size(400, 200);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryFourTupleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueCountTupleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnPreviousMenu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource marqueCountTupleBindingSource;
        private System.Windows.Forms.BindingSource queryFourTupleBindingSource;
    }
}
