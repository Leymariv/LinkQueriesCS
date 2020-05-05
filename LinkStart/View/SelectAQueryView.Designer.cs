namespace LinqWinformProject.LinkStart.View
{
    partial class SelectAQueryView
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
            this.queriesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // queriesComboBox
            // 
            this.queriesComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.queriesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queriesComboBox.FormattingEnabled = true;
            this.queriesComboBox.Items.AddRange(new object[] {
            "Print how many tuples each table contain",
            "Print sales from the last 50 days",
            "Print the top 10 brands since the opening of the store",
            "Print the best selling color of each year ",
            "Print all the brands that have sold more than 500 k€ the past 90 days"});
            this.queriesComboBox.Location = new System.Drawing.Point(35, 80);
            this.queriesComboBox.Name = "queriesComboBox";
            this.queriesComboBox.Size = new System.Drawing.Size(323, 28);
            this.queriesComboBox.TabIndex = 0;
            this.queriesComboBox.SelectedIndexChanged += new System.EventHandler(this.QueriesComboBoxSelectedIndexChanged);
            // 
            // SelectAQueryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queriesComboBox);
            this.Name = "SelectAQueryView";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox queriesComboBox;


    }
}
