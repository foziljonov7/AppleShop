namespace AppleShop
{
    partial class DashboardWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.TopBackPanel = new System.Windows.Forms.Panel();
            this.TopRigthPanel = new System.Windows.Forms.Panel();
            this.DashboaardLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.TopBackPanel.SuspendLayout();
            this.TopRigthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Controls.Add(this.LeftPanel);
            this.panel1.Controls.Add(this.TopBackPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 611);
            this.panel1.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(173, 81);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(835, 530);
            this.MenuPanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CloseBtn);
            this.LeftPanel.Controls.Add(this.AdminBtn);
            this.LeftPanel.Controls.Add(this.RemoveBtn);
            this.LeftPanel.Controls.Add(this.RefreshBtn);
            this.LeftPanel.Controls.Add(this.EditBtn);
            this.LeftPanel.Controls.Add(this.CreateBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 81);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(173, 530);
            this.LeftPanel.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(-1, 358);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(173, 42);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminBtn.FlatAppearance.BorderSize = 0;
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminBtn.Location = new System.Drawing.Point(0, 299);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(173, 42);
            this.AdminBtn.TabIndex = 4;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBtn.Location = new System.Drawing.Point(0, 234);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(173, 42);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshBtn.Location = new System.Drawing.Point(-1, 167);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(173, 42);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(0, 104);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(173, 42);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit Product";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateBtn.Location = new System.Drawing.Point(0, 44);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(173, 42);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create Product";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // TopBackPanel
            // 
            this.TopBackPanel.Controls.Add(this.TopRigthPanel);
            this.TopBackPanel.Controls.Add(this.DashboaardLbl);
            this.TopBackPanel.Controls.Add(this.pictureBox1);
            this.TopBackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBackPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBackPanel.Name = "TopBackPanel";
            this.TopBackPanel.Size = new System.Drawing.Size(1008, 81);
            this.TopBackPanel.TabIndex = 0;
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Controls.Add(this.label1);
            this.TopRigthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopRigthPanel.Location = new System.Drawing.Point(173, 0);
            this.TopRigthPanel.Name = "TopRigthPanel";
            this.TopRigthPanel.Size = new System.Drawing.Size(835, 81);
            this.TopRigthPanel.TabIndex = 2;
            this.TopRigthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopRigthPanel_Paint);
            // 
            // DashboaardLbl
            // 
            this.DashboaardLbl.AutoSize = true;
            this.DashboaardLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DashboaardLbl.Location = new System.Drawing.Point(75, 20);
            this.DashboaardLbl.Name = "DashboaardLbl";
            this.DashboaardLbl.Size = new System.Drawing.Size(97, 40);
            this.DashboaardLbl.TabIndex = 1;
            this.DashboaardLbl.Text = "Apple";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to out shopping!";
            // 
            // DashboardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.TopBackPanel.ResumeLayout(false);
            this.TopBackPanel.PerformLayout();
            this.TopRigthPanel.ResumeLayout(false);
            this.TopRigthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopBackPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopRigthPanel;
        private System.Windows.Forms.Label DashboaardLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label1;
    }
}

