
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLbl.Location = new System.Drawing.Point(408, 110);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(210, 33);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Bejelentkezés";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.usernameLbl.Location = new System.Drawing.Point(400, 172);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameLbl.Size = new System.Drawing.Size(81, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Felhasználónév";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(404, 188);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(404, 296);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(105, 35);
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
            this.passwordLbl.Location = new System.Drawing.Point(400, 216);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BackColor = System.Drawing.Color.White;
            this.passwordtextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordtextBox.Location = new System.Drawing.Point(404, 232);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(218, 20);
            this.passwordtextBox.TabIndex = 9;
            // 
            // showPassCheck
            // 
            this.showPassCheck.AutoSize = true;
            this.showPassCheck.Location = new System.Drawing.Point(520, 258);
            this.showPassCheck.Name = "showPassCheck";
            this.showPassCheck.Size = new System.Drawing.Size(98, 17);
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
            this.cleanBtn.Location = new System.Drawing.Point(517, 296);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(105, 35);
            this.cleanBtn.TabIndex = 11;
            this.cleanBtn.Text = "TÖRLÉS";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(-51, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(407, 459);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(472, 368);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 21;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cleanBtn);
            this.Controls.Add(this.showPassCheck);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.welcomeLbl);
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
        private System.Windows.Forms.TextBox textBoxId;
    }
}

