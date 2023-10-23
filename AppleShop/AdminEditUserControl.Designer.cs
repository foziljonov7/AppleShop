namespace AppleShop
{
    partial class AdminEditUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminEditlbl = new System.Windows.Forms.Label();
            this.RoleCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.regiontxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AgeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.IdTxt);
            this.panel3.Controls.Add(this.RoleCombo);
            this.panel3.Controls.Add(this.CancelBtn);
            this.panel3.Controls.Add(this.SubmitBtn);
            this.panel3.Controls.Add(this.regiontxt);
            this.panel3.Controls.Add(this.PhoneTxt);
            this.panel3.Controls.Add(this.AgeTxt);
            this.panel3.Controls.Add(this.FullnameTxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 352);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AdminEditlbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 48);
            this.panel2.TabIndex = 0;
            // 
            // AdminEditlbl
            // 
            this.AdminEditlbl.AutoSize = true;
            this.AdminEditlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminEditlbl.Location = new System.Drawing.Point(367, 9);
            this.AdminEditlbl.Name = "AdminEditlbl";
            this.AdminEditlbl.Size = new System.Drawing.Size(51, 30);
            this.AdminEditlbl.TabIndex = 0;
            this.AdminEditlbl.Text = "Edit";
            // 
            // RoleCombo
            // 
            this.RoleCombo.AutoRoundedCorners = true;
            this.RoleCombo.BackColor = System.Drawing.Color.Transparent;
            this.RoleCombo.BorderColor = System.Drawing.Color.Gray;
            this.RoleCombo.BorderRadius = 17;
            this.RoleCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleCombo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.RoleCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoleCombo.ItemHeight = 30;
            this.RoleCombo.Items.AddRange(new object[] {
            "Admin",
            "Super Admin",
            "Boss"});
            this.RoleCombo.Location = new System.Drawing.Point(259, 201);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(266, 36);
            this.RoleCombo.TabIndex = 17;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BorderRadius = 10;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(402, 298);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(123, 44);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BorderRadius = 10;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SubmitBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.Black;
            this.SubmitBtn.Location = new System.Drawing.Point(259, 298);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(123, 44);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // regiontxt
            // 
            this.regiontxt.BorderColor = System.Drawing.Color.Gray;
            this.regiontxt.BorderRadius = 10;
            this.regiontxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regiontxt.DefaultText = "";
            this.regiontxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regiontxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regiontxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regiontxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regiontxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regiontxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.regiontxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regiontxt.Location = new System.Drawing.Point(259, 252);
            this.regiontxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.regiontxt.Name = "regiontxt";
            this.regiontxt.PasswordChar = '\0';
            this.regiontxt.PlaceholderText = "Region";
            this.regiontxt.SelectedText = "";
            this.regiontxt.Size = new System.Drawing.Size(266, 35);
            this.regiontxt.TabIndex = 14;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.BorderColor = System.Drawing.Color.Gray;
            this.PhoneTxt.BorderRadius = 10;
            this.PhoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTxt.DefaultText = "";
            this.PhoneTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PhoneTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxt.Location = new System.Drawing.Point(259, 152);
            this.PhoneTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.PasswordChar = '\0';
            this.PhoneTxt.PlaceholderText = "Phone";
            this.PhoneTxt.SelectedText = "";
            this.PhoneTxt.Size = new System.Drawing.Size(266, 35);
            this.PhoneTxt.TabIndex = 13;
            // 
            // AgeTxt
            // 
            this.AgeTxt.BorderColor = System.Drawing.Color.Gray;
            this.AgeTxt.BorderRadius = 10;
            this.AgeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTxt.DefaultText = "";
            this.AgeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.AgeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTxt.Location = new System.Drawing.Point(259, 104);
            this.AgeTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.PasswordChar = '\0';
            this.AgeTxt.PlaceholderText = "Age";
            this.AgeTxt.SelectedText = "";
            this.AgeTxt.Size = new System.Drawing.Size(266, 35);
            this.AgeTxt.TabIndex = 12;
            // 
            // FullnameTxt
            // 
            this.FullnameTxt.BorderColor = System.Drawing.Color.Gray;
            this.FullnameTxt.BorderRadius = 10;
            this.FullnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullnameTxt.DefaultText = "";
            this.FullnameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullnameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullnameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullnameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullnameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullnameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.FullnameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullnameTxt.Location = new System.Drawing.Point(259, 55);
            this.FullnameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FullnameTxt.Name = "FullnameTxt";
            this.FullnameTxt.PasswordChar = '\0';
            this.FullnameTxt.PlaceholderText = "Fullname";
            this.FullnameTxt.SelectedText = "";
            this.FullnameTxt.Size = new System.Drawing.Size(266, 35);
            this.FullnameTxt.TabIndex = 11;
            // 
            // IdTxt
            // 
            this.IdTxt.BorderColor = System.Drawing.Color.Gray;
            this.IdTxt.BorderRadius = 10;
            this.IdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTxt.DefaultText = "";
            this.IdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.IdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.Location = new System.Drawing.Point(259, 7);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.PasswordChar = '\0';
            this.IdTxt.PlaceholderText = "Id";
            this.IdTxt.SelectedText = "";
            this.IdTxt.Size = new System.Drawing.Size(266, 35);
            this.IdTxt.TabIndex = 18;
            // 
            // AdminEditUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "AdminEditUserControl";
            this.Size = new System.Drawing.Size(785, 400);
            this.Load += new System.EventHandler(this.AdminEditUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminEditlbl;
        private Guna.UI2.WinForms.Guna2TextBox IdTxt;
        private Guna.UI2.WinForms.Guna2ComboBox RoleCombo;
        private Guna.UI2.WinForms.Guna2GradientButton CancelBtn;
        private Guna.UI2.WinForms.Guna2GradientButton SubmitBtn;
        private Guna.UI2.WinForms.Guna2TextBox regiontxt;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTxt;
        private Guna.UI2.WinForms.Guna2TextBox AgeTxt;
        private Guna.UI2.WinForms.Guna2TextBox FullnameTxt;
    }
}
