namespace HastaneOtomasyon
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.logName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.logPass = new System.Windows.Forms.TextBox();
            this.logButton = new Guna.UI.WinForms.GunaButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logClear = new System.Windows.Forms.Label();
            this.passsecret = new System.Windows.Forms.CheckBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 25;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(137)))));
            this.gunaPanel1.Controls.Add(this.gunaPictureBox3);
            this.gunaPanel1.Controls.Add(this.label4);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(420, 81);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(383, 12);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(25, 26);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 18;
            this.gunaPictureBox3.TabStop = false;
            this.gunaPictureBox3.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(225)))), ((int)(((byte)(248)))));
            this.label4.Location = new System.Drawing.Point(121, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 46);
            this.label4.TabIndex = 19;
            this.label4.Text = "ABM Hospital \r\nManagement System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(32, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(51, 54);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(180, 97);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(76, 82);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 1;
            this.gunaPictureBox2.TabStop = false;
            // 
            // roleCB
            // 
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "Admin",
            "Doktor",
            "Resepsiyonist"});
            this.roleCB.Location = new System.Drawing.Point(110, 218);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(211, 24);
            this.roleCB.TabIndex = 2;
            this.roleCB.SelectedIndexChanged += new System.EventHandler(this.roleCB_SelectedIndexChanged);
            // 
            // logName
            // 
            this.logName.Location = new System.Drawing.Point(110, 305);
            this.logName.Name = "logName";
            this.logName.Size = new System.Drawing.Size(211, 22);
            this.logName.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(106, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = " Adı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(106, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 24);
            this.label17.TabIndex = 17;
            this.label17.Text = "Password";
            // 
            // logPass
            // 
            this.logPass.Location = new System.Drawing.Point(110, 390);
            this.logPass.Name = "logPass";
            this.logPass.Size = new System.Drawing.Size(211, 22);
            this.logPass.TabIndex = 4;
            // 
            // logButton
            // 
            this.logButton.AnimationHoverSpeed = 0.07F;
            this.logButton.AnimationSpeed = 0.03F;
            this.logButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(75)))), ((int)(((byte)(137)))));
            this.logButton.BorderColor = System.Drawing.Color.Black;
            this.logButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logButton.FocusedColor = System.Drawing.Color.Empty;
            this.logButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logButton.ForeColor = System.Drawing.Color.White;
            this.logButton.Image = ((System.Drawing.Image)(resources.GetObject("logButton.Image")));
            this.logButton.ImageSize = new System.Drawing.Size(20, 20);
            this.logButton.Location = new System.Drawing.Point(166, 458);
            this.logButton.Name = "logButton";
            this.logButton.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.logButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logButton.OnHoverForeColor = System.Drawing.Color.White;
            this.logButton.OnHoverImage = null;
            this.logButton.OnPressedColor = System.Drawing.Color.Black;
            this.logButton.Size = new System.Drawing.Size(105, 42);
            this.logButton.TabIndex = 18;
            this.logButton.Text = "GİRİŞ";
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.logButton;
            // 
            // logClear
            // 
            this.logClear.AutoSize = true;
            this.logClear.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logClear.ForeColor = System.Drawing.Color.DimGray;
            this.logClear.Location = new System.Drawing.Point(188, 512);
            this.logClear.Name = "logClear";
            this.logClear.Size = new System.Drawing.Size(62, 20);
            this.logClear.TabIndex = 17;
            this.logClear.Text = "Temizle";
            this.logClear.Click += new System.EventHandler(this.logClear_Click);
            // 
            // passsecret
            // 
            this.passsecret.AutoSize = true;
            this.passsecret.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passsecret.ForeColor = System.Drawing.Color.DimGray;
            this.passsecret.Location = new System.Drawing.Point(112, 419);
            this.passsecret.Name = "passsecret";
            this.passsecret.Size = new System.Drawing.Size(65, 22);
            this.passsecret.TabIndex = 19;
            this.passsecret.Text = "Gizle";
            this.passsecret.UseVisualStyleBackColor = true;
            this.passsecret.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(225)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(420, 595);
            this.Controls.Add(this.passsecret);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.logClear);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logPass);
            this.Controls.Add(this.logName);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.TextBox logName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox logPass;
        private Guna.UI.WinForms.GunaButton logButton;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private System.Windows.Forms.Label logClear;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.CheckBox passsecret;
    }
}