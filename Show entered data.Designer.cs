namespace WindowsFormsApp4
{
    partial class Show_entered_data
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
            this.PopulateCitiesComboBox = new System.Windows.Forms.ComboBox();
            this.ShowDataInGridView = new System.Windows.Forms.DataGridView();
            this.Cities = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataInGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PopulateCitiesComboBox
            // 
            this.PopulateCitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PopulateCitiesComboBox.FormattingEnabled = true;
            this.PopulateCitiesComboBox.Items.AddRange(new object[] {
            "Pune"});
            this.PopulateCitiesComboBox.Location = new System.Drawing.Point(273, 71);
            this.PopulateCitiesComboBox.Name = "PopulateCitiesComboBox";
            this.PopulateCitiesComboBox.Size = new System.Drawing.Size(121, 24);
            this.PopulateCitiesComboBox.TabIndex = 0;
            this.PopulateCitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.PopulateCitiesComboBox_SelectedIndexChanged);
            // 
            // ShowDataInGridView
            // 
            this.ShowDataInGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataInGridView.Location = new System.Drawing.Point(273, 140);
            this.ShowDataInGridView.Name = "ShowDataInGridView";
            this.ShowDataInGridView.RowHeadersWidth = 51;
            this.ShowDataInGridView.RowTemplate.Height = 24;
            this.ShowDataInGridView.Size = new System.Drawing.Size(296, 221);
            this.ShowDataInGridView.TabIndex = 1;
            this.ShowDataInGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDataInGridView_CellContentClick);
            // 
            // Cities
            // 
            this.Cities.AutoSize = true;
            this.Cities.Location = new System.Drawing.Point(85, 74);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(161, 16);
            this.Cities.TabIndex = 2;
            this.Cities.Text = "PopulateCitiesComboBox";
            // 
            // Show_entered_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.ShowDataInGridView);
            this.Controls.Add(this.PopulateCitiesComboBox);
            this.Name = "Show_entered_data";
            this.Text = "Show_entered_data";
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataInGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PopulateCitiesComboBox;
        private System.Windows.Forms.DataGridView ShowDataInGridView;
        private System.Windows.Forms.Label Cities;
    }
}