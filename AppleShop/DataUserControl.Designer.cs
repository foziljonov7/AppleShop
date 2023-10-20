namespace AppleShop
{
    partial class DataUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridBackPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryCombo4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.BackPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DataGridBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.panel1);
            this.BackPanel.Controls.Add(this.TopPanel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(835, 530);
            this.BackPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridBackPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 466);
            this.panel1.TabIndex = 1;
            // 
            // DataGridBackPanel
            // 
            this.DataGridBackPanel.BorderRadius = 10;
            this.DataGridBackPanel.Controls.Add(this.ProductDataGridView);
            this.DataGridBackPanel.FillColor = System.Drawing.Color.White;
            this.DataGridBackPanel.Location = new System.Drawing.Point(17, 10);
            this.DataGridBackPanel.Name = "DataGridBackPanel";
            this.DataGridBackPanel.Size = new System.Drawing.Size(790, 428);
            this.DataGridBackPanel.TabIndex = 0;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDataGridView.ColumnHeadersHeight = 4;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowHeadersVisible = false;
            this.ProductDataGridView.Size = new System.Drawing.Size(784, 395);
            this.ProductDataGridView.TabIndex = 0;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.ProductDataGridView.ThemeStyle.ReadOnly = false;
            this.ProductDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ProductDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SearchTxt);
            this.TopPanel.Controls.Add(this.CategoryCombo4);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(835, 64);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data window";
            // 
            // CategoryCombo4
            // 
            this.CategoryCombo4.AutoRoundedCorners = true;
            this.CategoryCombo4.BackColor = System.Drawing.Color.Transparent;
            this.CategoryCombo4.BorderRadius = 17;
            this.CategoryCombo4.BorderThickness = 0;
            this.CategoryCombo4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoryCombo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCombo4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCombo4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.CategoryCombo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CategoryCombo4.ItemHeight = 30;
            this.CategoryCombo4.Items.AddRange(new object[] {
            "Gazlangan",
            "Shakarsiz",
            "Classic",
            "Mineral",
            "Sharbat",
            "Kampot"});
            this.CategoryCombo4.Location = new System.Drawing.Point(93, 15);
            this.CategoryCombo4.Name = "CategoryCombo4";
            this.CategoryCombo4.Size = new System.Drawing.Size(178, 36);
            this.CategoryCombo4.TabIndex = 2;
            this.CategoryCombo4.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BorderRadius = 10;
            this.SearchTxt.BorderThickness = 0;
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.DefaultText = "";
            this.SearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.SearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.Location = new System.Drawing.Point(561, 15);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PlaceholderText = "Search...";
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.Size = new System.Drawing.Size(188, 36);
            this.SearchTxt.TabIndex = 3;
            this.SearchTxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // DataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BackPanel);
            this.Name = "DataUserControl";
            this.Size = new System.Drawing.Size(835, 530);
            this.Load += new System.EventHandler(this.DataUserControl_Load);
            this.BackPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.DataGridBackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel DataGridBackPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDataGridView;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryCombo4;
        private Guna.UI2.WinForms.Guna2TextBox SearchTxt;
    }
}
