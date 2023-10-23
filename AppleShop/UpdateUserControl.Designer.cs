﻿namespace AppleShop
{
    partial class UpdateUserControl
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
            this.CancelBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SizeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.MadeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
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
            this.CancelBtn.Location = new System.Drawing.Point(430, 461);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(154, 53);
            this.CancelBtn.TabIndex = 15;
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
            this.SubmitBtn.Location = new System.Drawing.Point(251, 461);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(154, 53);
            this.SubmitBtn.TabIndex = 14;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // SizeTxt
            // 
            this.SizeTxt.BorderRadius = 10;
            this.SizeTxt.BorderThickness = 0;
            this.SizeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SizeTxt.DefaultText = "";
            this.SizeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SizeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SizeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SizeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SizeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SizeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.SizeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SizeTxt.Location = new System.Drawing.Point(251, 324);
            this.SizeTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.PasswordChar = '\0';
            this.SizeTxt.PlaceholderText = "Size ...";
            this.SizeTxt.SelectedText = "";
            this.SizeTxt.Size = new System.Drawing.Size(333, 43);
            this.SizeTxt.TabIndex = 12;
            // 
            // MadeTxt
            // 
            this.MadeTxt.BorderRadius = 10;
            this.MadeTxt.BorderThickness = 0;
            this.MadeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MadeTxt.DefaultText = "";
            this.MadeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MadeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MadeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MadeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MadeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MadeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.MadeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MadeTxt.Location = new System.Drawing.Point(251, 259);
            this.MadeTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MadeTxt.Name = "MadeTxt";
            this.MadeTxt.PasswordChar = '\0';
            this.MadeTxt.PlaceholderText = "Made ...";
            this.MadeTxt.SelectedText = "";
            this.MadeTxt.Size = new System.Drawing.Size(333, 43);
            this.MadeTxt.TabIndex = 11;
            // 
            // PriceTxt
            // 
            this.PriceTxt.BorderRadius = 10;
            this.PriceTxt.BorderThickness = 0;
            this.PriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTxt.DefaultText = "";
            this.PriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTxt.Location = new System.Drawing.Point(251, 195);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.PasswordChar = '\0';
            this.PriceTxt.PlaceholderText = "Price ...";
            this.PriceTxt.SelectedText = "";
            this.PriceTxt.Size = new System.Drawing.Size(333, 43);
            this.PriceTxt.TabIndex = 10;
            // 
            // NameTxt
            // 
            this.NameTxt.BorderRadius = 10;
            this.NameTxt.BorderThickness = 0;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.DefaultText = "";
            this.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.Location = new System.Drawing.Point(251, 129);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = '\0';
            this.NameTxt.PlaceholderText = "Name ...";
            this.NameTxt.SelectedText = "";
            this.NameTxt.Size = new System.Drawing.Size(333, 43);
            this.NameTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit window";
            // 
            // IdTxt
            // 
            this.IdTxt.BorderRadius = 10;
            this.IdTxt.BorderThickness = 0;
            this.IdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTxt.DefaultText = "";
            this.IdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.IdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdTxt.Location = new System.Drawing.Point(251, 63);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.PasswordChar = '\0';
            this.IdTxt.PlaceholderText = "Id ...";
            this.IdTxt.SelectedText = "";
            this.IdTxt.Size = new System.Drawing.Size(333, 43);
            this.IdTxt.TabIndex = 16;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.AutoRoundedCorners = true;
            this.CategoryCombo.BackColor = System.Drawing.Color.Transparent;
            this.CategoryCombo.BorderRadius = 17;
            this.CategoryCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCombo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.CategoryCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CategoryCombo.ItemHeight = 30;
            this.CategoryCombo.Items.AddRange(new object[] {
            "Gazlangan",
            "Shakarsiz",
            "Classic",
            "Mineral",
            "Sharbat",
            "Kampot",
            "Energetik"});
            this.CategoryCombo.Location = new System.Drawing.Point(251, 388);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(333, 36);
            this.CategoryCombo.TabIndex = 17;
            // 
            // UpdateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.SizeTxt);
            this.Controls.Add(this.MadeTxt);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label1);
            this.Name = "UpdateUserControl";
            this.Size = new System.Drawing.Size(835, 530);
            this.Load += new System.EventHandler(this.UpdateUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton CancelBtn;
        private Guna.UI2.WinForms.Guna2GradientButton SubmitBtn;
        private Guna.UI2.WinForms.Guna2TextBox SizeTxt;
        private Guna.UI2.WinForms.Guna2TextBox MadeTxt;
        private Guna.UI2.WinForms.Guna2TextBox PriceTxt;
        private Guna.UI2.WinForms.Guna2TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox IdTxt;
        private Guna.UI2.WinForms.Guna2ComboBox CategoryCombo;
    }
}
