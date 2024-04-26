
namespace admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.showPassCheck = new System.Windows.Forms.CheckBox();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLbl.Location = new System.Drawing.Point(544, 135);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(265, 42);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Bejelentkezés";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.usernameLbl.Location = new System.Drawing.Point(533, 212);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameLbl.Size = new System.Drawing.Size(107, 17);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Felhasználónév";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(539, 231);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(289, 24);
            this.nameTextBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(539, 364);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(140, 43);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "BELÉPÉS";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passwordLbl.Location = new System.Drawing.Point(533, 266);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BackColor = System.Drawing.Color.White;
            this.passwordtextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordtextBox.Location = new System.Drawing.Point(539, 286);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(289, 22);
            this.passwordtextBox.TabIndex = 9;
            // 
            // showPassCheck
            // 
            this.showPassCheck.AutoSize = true;
            this.showPassCheck.Location = new System.Drawing.Point(693, 318);
            this.showPassCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPassCheck.Name = "showPassCheck";
            this.showPassCheck.Size = new System.Drawing.Size(128, 21);
            this.showPassCheck.TabIndex = 10;
            this.showPassCheck.Text = "jelszó mutatása";
            this.showPassCheck.UseVisualStyleBackColor = true;
            this.showPassCheck.CheckedChanged += new System.EventHandler(this.showPassCheck_CheckedChanged);
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackColor = System.Drawing.Color.DarkGray;
            this.cleanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cleanBtn.ForeColor = System.Drawing.Color.White;
            this.cleanBtn.Location = new System.Drawing.Point(689, 364);
            this.cleanBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(140, 43);
            this.cleanBtn.TabIndex = 11;
            this.cleanBtn.Text = "TÖRLÉS";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(-68, -1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(543, 565);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 554);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.showPassCheck);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Bejelentkezés";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.CheckBox showPassCheck;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

