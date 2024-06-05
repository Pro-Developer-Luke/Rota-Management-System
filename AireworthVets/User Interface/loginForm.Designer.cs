
namespace AireworthVets
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPassTextBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.passPanel = new System.Windows.Forms.Panel();
            this.logoPicturebox = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userNameTextBox.Location = new System.Drawing.Point(62, 188);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(303, 23);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.Text = "Username";
            this.userNameTextBox.Click += new System.EventHandler(this.usernameClick);
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // userPassTextBox
            // 
            this.userPassTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.userPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userPassTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userPassTextBox.Location = new System.Drawing.Point(62, 243);
            this.userPassTextBox.Name = "userPassTextBox";
            this.userPassTextBox.Size = new System.Drawing.Size(303, 23);
            this.userPassTextBox.TabIndex = 3;
            this.userPassTextBox.Text = "Password";
            this.userPassTextBox.Click += new System.EventHandler(this.passwordClick);
            this.userPassTextBox.TextChanged += new System.EventHandler(this.passChar);
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.Green;
            this.namePanel.Location = new System.Drawing.Point(62, 216);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(303, 2);
            this.namePanel.TabIndex = 6;
            // 
            // passPanel
            // 
            this.passPanel.BackColor = System.Drawing.Color.Green;
            this.passPanel.Location = new System.Drawing.Point(62, 270);
            this.passPanel.Name = "passPanel";
            this.passPanel.Size = new System.Drawing.Size(303, 2);
            this.passPanel.TabIndex = 7;
            // 
            // logoPicturebox
            // 
            this.logoPicturebox.Image = global::AireworthVets.Properties.Resources.AVlogo;
            this.logoPicturebox.Location = new System.Drawing.Point(62, 36);
            this.logoPicturebox.Name = "logoPicturebox";
            this.logoPicturebox.Size = new System.Drawing.Size(303, 120);
            this.logoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicturebox.TabIndex = 8;
            this.logoPicturebox.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundImage = global::AireworthVets.Properties.Resources.btnBorder1;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginBtn.ForeColor = System.Drawing.Color.Green;
            this.loginBtn.Location = new System.Drawing.Point(62, 278);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 30);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 344);
            this.Controls.Add(this.logoPicturebox);
            this.Controls.Add(this.passPanel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPassTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Aireworth Veterinary Practice | Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox userNameTextBox;
        public System.Windows.Forms.TextBox userPassTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel passPanel;
        private System.Windows.Forms.PictureBox logoPicturebox;
    }
}

