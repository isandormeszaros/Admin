
namespace admin
{
    partial class AddUser
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordLbl2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newUserLbl = new System.Windows.Forms.Label();
            this.addNewUser = new System.Windows.Forms.Button();
            this.confPasswordTextBox = new System.Windows.Forms.TextBox();
            this.allusersviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.deleteIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idLbl = new System.Windows.Forms.Label();
            this.modifyIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteAddressTextBox = new System.Windows.Forms.TextBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.modifyUser = new System.Windows.Forms.Label();
            this.deleteNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deletePassTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deletePhoneTextBox = new System.Windows.Forms.TextBox();
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.backToThePage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.watchesDataSet31 = new admin.watchesDataSet3();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allusersviewBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchesDataSet31)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(90, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(90, 60);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(204, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(90, 86);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(90, 190);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(204, 21);
            this.roleComboBox.TabIndex = 4;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(14, 34);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(56, 13);
            this.nameLbl.TabIndex = 7;
            this.nameLbl.Text = "Teljes név";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(14, 60);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 13);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email cím";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(15, 86);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(36, 13);
            this.passwordLbl.TabIndex = 9;
            this.passwordLbl.Text = "Jelszó";
            // 
            // passwordLbl2
            // 
            this.passwordLbl2.AutoSize = true;
            this.passwordLbl2.Location = new System.Drawing.Point(14, 112);
            this.passwordLbl2.Name = "passwordLbl2";
            this.passwordLbl2.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl2.TabIndex = 10;
            this.passwordLbl2.Text = "Jelszó újra";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(90, 138);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(204, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // userPhone
            // 
            this.userPhone.AutoSize = true;
            this.userPhone.Location = new System.Drawing.Point(15, 138);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(67, 13);
            this.userPhone.TabIndex = 12;
            this.userPhone.Text = "Telefonszám";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(15, 164);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(43, 13);
            this.addressLbl.TabIndex = 13;
            this.addressLbl.Text = "Lakcím";
            // 
            // roles
            // 
            this.roles.AutoSize = true;
            this.roles.Location = new System.Drawing.Point(14, 191);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(63, 13);
            this.roles.TabIndex = 14;
            this.roles.Text = "Jogosultság";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(90, 164);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(204, 20);
            this.addressTextBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.newUserLbl);
            this.panel1.Controls.Add(this.addNewUser);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.roles);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.addressLbl);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.userPhone);
            this.panel1.Controls.Add(this.confPasswordTextBox);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.roleComboBox);
            this.panel1.Controls.Add(this.passwordLbl2);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 287);
            this.panel1.TabIndex = 17;
            // 
            // newUserLbl
            // 
            this.newUserLbl.AutoSize = true;
            this.newUserLbl.Location = new System.Drawing.Point(88, 8);
            this.newUserLbl.Name = "newUserLbl";
            this.newUserLbl.Size = new System.Drawing.Size(133, 13);
            this.newUserLbl.TabIndex = 18;
            this.newUserLbl.Text = "Új felhasználó hozzáadása";
            // 
            // addNewUser
            // 
            this.addNewUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.addNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewUser.ForeColor = System.Drawing.Color.White;
            this.addNewUser.Location = new System.Drawing.Point(18, 226);
            this.addNewUser.Name = "addNewUser";
            this.addNewUser.Size = new System.Drawing.Size(276, 35);
            this.addNewUser.TabIndex = 20;
            this.addNewUser.Text = "Felhasználó hozzáadása";
            this.addNewUser.UseVisualStyleBackColor = false;
            this.addNewUser.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // confPasswordTextBox
            // 
            this.confPasswordTextBox.Location = new System.Drawing.Point(90, 112);
            this.confPasswordTextBox.Name = "confPasswordTextBox";
            this.confPasswordTextBox.Size = new System.Drawing.Size(204, 20);
            this.confPasswordTextBox.TabIndex = 3;
            this.confPasswordTextBox.TextChanged += new System.EventHandler(this.confPasswordTextBox_TextChanged);
            // 
            // allusersviewBindingSource
            // 
            this.allusersviewBindingSource.DataMember = "allusersview";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.deleteLbl);
            this.panel2.Controls.Add(this.deleteUserBtn);
            this.panel2.Controls.Add(this.deleteIdTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 140);
            this.panel2.TabIndex = 21;
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Location = new System.Drawing.Point(111, 21);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(97, 13);
            this.deleteLbl.TabIndex = 18;
            this.deleteLbl.Text = "Felhasználó törlése";
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.deleteUserBtn.Location = new System.Drawing.Point(18, 85);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(276, 35);
            this.deleteUserBtn.TabIndex = 20;
            this.deleteUserBtn.Text = "Felhasználó törlése";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // deleteIdTextBox
            // 
            this.deleteIdTextBox.Location = new System.Drawing.Point(90, 49);
            this.deleteIdTextBox.Name = "deleteIdTextBox";
            this.deleteIdTextBox.Size = new System.Drawing.Size(204, 20);
            this.deleteIdTextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Id";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.idLbl);
            this.panel3.Controls.Add(this.modifyIdTextBox);
            this.panel3.Controls.Add(this.deleteAddressTextBox);
            this.panel3.Controls.Add(this.modifyBtn);
            this.panel3.Controls.Add(this.modifyUser);
            this.panel3.Controls.Add(this.deleteNameTextBox);
            this.panel3.Controls.Add(this.deleteEmailTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.deletePassTextBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.deletePhoneTextBox);
            this.panel3.Controls.Add(this.deleteComboBox);
            this.panel3.Location = new System.Drawing.Point(333, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 287);
            this.panel3.TabIndex = 22;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(26, 34);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(16, 13);
            this.idLbl.TabIndex = 36;
            this.idLbl.Text = "Id";
            // 
            // modifyIdTextBox
            // 
            this.modifyIdTextBox.Location = new System.Drawing.Point(95, 32);
            this.modifyIdTextBox.Name = "modifyIdTextBox";
            this.modifyIdTextBox.Size = new System.Drawing.Size(155, 20);
            this.modifyIdTextBox.TabIndex = 35;
            // 
            // deleteAddressTextBox
            // 
            this.deleteAddressTextBox.Location = new System.Drawing.Point(95, 136);
            this.deleteAddressTextBox.Name = "deleteAddressTextBox";
            this.deleteAddressTextBox.Size = new System.Drawing.Size(155, 20);
            this.deleteAddressTextBox.TabIndex = 34;
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.modifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modifyBtn.ForeColor = System.Drawing.Color.White;
            this.modifyBtn.Location = new System.Drawing.Point(5, 226);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(276, 35);
            this.modifyBtn.TabIndex = 20;
            this.modifyBtn.Text = "Felhasználó módosítása";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // modifyUser
            // 
            this.modifyUser.AutoSize = true;
            this.modifyUser.Location = new System.Drawing.Point(93, 8);
            this.modifyUser.Name = "modifyUser";
            this.modifyUser.Size = new System.Drawing.Size(121, 13);
            this.modifyUser.TabIndex = 18;
            this.modifyUser.Text = "Felhasználó módosítása";
            // 
            // deleteNameTextBox
            // 
            this.deleteNameTextBox.Location = new System.Drawing.Point(95, 58);
            this.deleteNameTextBox.Name = "deleteNameTextBox";
            this.deleteNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.deleteNameTextBox.TabIndex = 21;
            // 
            // deleteEmailTextBox
            // 
            this.deleteEmailTextBox.Location = new System.Drawing.Point(95, 84);
            this.deleteEmailTextBox.Name = "deleteEmailTextBox";
            this.deleteEmailTextBox.Size = new System.Drawing.Size(155, 20);
            this.deleteEmailTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Jogosultság";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Teljes név";
            // 
            // deletePassTextBox
            // 
            this.deletePassTextBox.Location = new System.Drawing.Point(95, 110);
            this.deletePassTextBox.Name = "deletePassTextBox";
            this.deletePassTextBox.Size = new System.Drawing.Size(155, 20);
            this.deletePassTextBox.TabIndex = 23;
            this.deletePassTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Email cím";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Lakcím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Telefonszám";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Jelszó";
            // 
            // deletePhoneTextBox
            // 
            this.deletePhoneTextBox.Location = new System.Drawing.Point(95, 161);
            this.deletePhoneTextBox.Name = "deletePhoneTextBox";
            this.deletePhoneTextBox.Size = new System.Drawing.Size(155, 20);
            this.deletePhoneTextBox.TabIndex = 30;
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(95, 185);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(155, 21);
            this.deleteComboBox.TabIndex = 25;
            // 
            // backToThePage
            // 
            this.backToThePage.BackColor = System.Drawing.Color.ForestGreen;
            this.backToThePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToThePage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backToThePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToThePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backToThePage.ForeColor = System.Drawing.Color.White;
            this.backToThePage.Location = new System.Drawing.Point(5, 84);
            this.backToThePage.Name = "backToThePage";
            this.backToThePage.Size = new System.Drawing.Size(276, 35);
            this.backToThePage.TabIndex = 37;
            this.backToThePage.Text = "Vissza az oldalra";
            this.backToThePage.UseVisualStyleBackColor = false;
            this.backToThePage.Click += new System.EventHandler(this.backToThePage_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.backToThePage);
            this.panel4.Location = new System.Drawing.Point(333, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 139);
            this.panel4.TabIndex = 22;
            // 
            // watchesDataSet31
            // 
            this.watchesDataSet31.DataSetName = "watchesDataSet3";
            this.watchesDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 454);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUser";
            this.Text = "Új felhasználó hozzáadása";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allusersviewBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchesDataSet31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label passwordLbl2;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label userPhone;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label roles;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label newUserLbl;
        private System.Windows.Forms.Button addNewUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label deleteLbl;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.TextBox deleteIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label modifyUser;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.TextBox deleteNameTextBox;
        private System.Windows.Forms.TextBox deleteEmailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deleteAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deletePassTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deletePhoneTextBox;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confPasswordTextBox;
        private watchesDataSet3 watchesDataSet3;
        private System.Windows.Forms.BindingSource allusersviewBindingSource;
        private System.Windows.Forms.TextBox modifyIdTextBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button backToThePage;
        private System.Windows.Forms.Panel panel4;
        private watchesDataSet3 watchesDataSet31;
    }
}