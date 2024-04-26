
namespace admin
{
    partial class Menufrom
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchesDataSet2 = new admin.watchesDataSet2();
            this.baseTableAdapter = new admin.watchesDataSet2TableAdapters.baseTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.felhasználóváltásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alapadatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapcsolatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elérhetőségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactNameText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contactTelText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contactEmailText = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.usersManagementBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.watchesBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.noResultsLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.paperComboBox = new System.Windows.Forms.ComboBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.boxComboBox = new System.Windows.Forms.ComboBox();
            this.dialComboBox = new System.Windows.Forms.ComboBox();
            this.movementComboBox = new System.Windows.Forms.ComboBox();
            this.strapMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.caseDiameterComboBox = new System.Windows.Forms.ComboBox();
            this.caseMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.caseThicknessComboBox = new System.Windows.Forms.ComboBox();
            this.dialMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.bandWidthComboBox = new System.Windows.Forms.ComboBox();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addNewUser = new System.Windows.Forms.Button();
            this.orderDeleteBtn = new System.Windows.Forms.Button();
            this.deleteOrderIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchesDataSet2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(553, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataMember = "base";
            this.baseBindingSource.DataSource = this.watchesDataSet2;
            // 
            // watchesDataSet2
            // 
            this.watchesDataSet2.DataSetName = "watchesDataSet2";
            this.watchesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseTableAdapter
            // 
            this.baseTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználóváltásToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 26);
            // 
            // felhasználóváltásToolStripMenuItem
            // 
            this.felhasználóváltásToolStripMenuItem.Name = "felhasználóváltásToolStripMenuItem";
            this.felhasználóváltásToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.felhasználóváltásToolStripMenuItem.Text = "Felhasználóváltás";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználókToolStripMenuItem,
            this.alapadatokToolStripMenuItem,
            this.kapcsolatToolStripMenuItem,
            this.elérhetőségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.felhasználókToolStripMenuItem.Text = "Felhasználóváltás";
            this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
            // 
            // alapadatokToolStripMenuItem
            // 
            this.alapadatokToolStripMenuItem.Name = "alapadatokToolStripMenuItem";
            this.alapadatokToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.alapadatokToolStripMenuItem.Text = "Alapadatok";
            this.alapadatokToolStripMenuItem.Click += new System.EventHandler(this.alapadatokToolStripMenuItem_Click);
            // 
            // kapcsolatToolStripMenuItem
            // 
            this.kapcsolatToolStripMenuItem.Name = "kapcsolatToolStripMenuItem";
            this.kapcsolatToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kapcsolatToolStripMenuItem.Text = "Kapcsolat";
            this.kapcsolatToolStripMenuItem.Click += new System.EventHandler(this.kapcsolatToolStripMenuItem_Click);
            // 
            // elérhetőségToolStripMenuItem
            // 
            this.elérhetőségToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactNameText,
            this.toolStripSeparator1,
            this.contactTelText,
            this.toolStripSeparator2,
            this.contactEmailText});
            this.elérhetőségToolStripMenuItem.Name = "elérhetőségToolStripMenuItem";
            this.elérhetőségToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.elérhetőségToolStripMenuItem.Text = "Elérhetőség";
            this.elérhetőségToolStripMenuItem.Click += new System.EventHandler(this.elérhetőségToolStripMenuItem_Click);
            // 
            // contactNameText
            // 
            this.contactNameText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactNameText.Name = "contactNameText";
            this.contactNameText.ReadOnly = true;
            this.contactNameText.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // contactTelText
            // 
            this.contactTelText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactTelText.Name = "contactTelText";
            this.contactTelText.ReadOnly = true;
            this.contactTelText.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // contactEmailText
            // 
            this.contactEmailText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactEmailText.Name = "contactEmailText";
            this.contactEmailText.ReadOnly = true;
            this.contactEmailText.Size = new System.Drawing.Size(200, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.usersManagementBtn);
            this.panel1.Controls.Add(this.ordersBtn);
            this.panel1.Controls.Add(this.watchesBtn);
            this.panel1.Controls.Add(this.welcomeLbl);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 555);
            this.panel1.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Firebrick;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(12, 502);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(207, 35);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.Text = "Kijelentkezés";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // usersManagementBtn
            // 
            this.usersManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.usersManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.usersManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersManagementBtn.ForeColor = System.Drawing.Color.White;
            this.usersManagementBtn.Location = new System.Drawing.Point(12, 254);
            this.usersManagementBtn.Name = "usersManagementBtn";
            this.usersManagementBtn.Size = new System.Drawing.Size(207, 35);
            this.usersManagementBtn.TabIndex = 11;
            this.usersManagementBtn.Text = "Felhasználókezelés";
            this.usersManagementBtn.UseVisualStyleBackColor = false;
            this.usersManagementBtn.Click += new System.EventHandler(this.usersManagementBtn_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.Transparent;
            this.ordersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ordersBtn.ForeColor = System.Drawing.Color.White;
            this.ordersBtn.Location = new System.Drawing.Point(12, 213);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(207, 35);
            this.ordersBtn.TabIndex = 9;
            this.ordersBtn.Text = "Rendelések";
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // watchesBtn
            // 
            this.watchesBtn.BackColor = System.Drawing.Color.Transparent;
            this.watchesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.watchesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.watchesBtn.ForeColor = System.Drawing.Color.White;
            this.watchesBtn.Location = new System.Drawing.Point(12, 172);
            this.watchesBtn.Name = "watchesBtn";
            this.watchesBtn.Size = new System.Drawing.Size(207, 35);
            this.watchesBtn.TabIndex = 8;
            this.watchesBtn.Text = "Órák";
            this.watchesBtn.UseVisualStyleBackColor = false;
            this.watchesBtn.Click += new System.EventHandler(this.watchesBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLbl.Location = new System.Drawing.Point(3, 71);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(96, 20);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Üdvözöljük";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Location = new System.Drawing.Point(253, 98);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(196, 21);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(455, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Keresés";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // noResultsLbl
            // 
            this.noResultsLbl.AutoSize = true;
            this.noResultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noResultsLbl.ForeColor = System.Drawing.Color.Red;
            this.noResultsLbl.Location = new System.Drawing.Point(525, 439);
            this.noResultsLbl.Name = "noResultsLbl";
            this.noResultsLbl.Size = new System.Drawing.Size(0, 13);
            this.noResultsLbl.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.countryComboBox);
            this.panel2.Controls.Add(this.clearFilterBtn);
            this.panel2.Controls.Add(this.paperComboBox);
            this.panel2.Controls.Add(this.filterBtn);
            this.panel2.Controls.Add(this.boxComboBox);
            this.panel2.Controls.Add(this.dialComboBox);
            this.panel2.Controls.Add(this.movementComboBox);
            this.panel2.Controls.Add(this.strapMaterialComboBox);
            this.panel2.Controls.Add(this.caseDiameterComboBox);
            this.panel2.Controls.Add(this.caseMaterialComboBox);
            this.panel2.Controls.Add(this.caseThicknessComboBox);
            this.panel2.Controls.Add(this.dialMaterialComboBox);
            this.panel2.Controls.Add(this.bandWidthComboBox);
            this.panel2.Controls.Add(this.dateComboBox);
            this.panel2.Location = new System.Drawing.Point(820, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 369);
            this.panel2.TabIndex = 17;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(13, 310);
            this.countryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(160, 21);
            this.countryComboBox.TabIndex = 22;
            this.countryComboBox.Text = "Gyártás helye";
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.BackColor = System.Drawing.Color.Firebrick;
            this.clearFilterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearFilterBtn.ForeColor = System.Drawing.Color.White;
            this.clearFilterBtn.Location = new System.Drawing.Point(11, 337);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(77, 28);
            this.clearFilterBtn.TabIndex = 30;
            this.clearFilterBtn.Text = "Törlés";
            this.clearFilterBtn.UseVisualStyleBackColor = false;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            // 
            // paperComboBox
            // 
            this.paperComboBox.FormattingEnabled = true;
            this.paperComboBox.Location = new System.Drawing.Point(13, 285);
            this.paperComboBox.Name = "paperComboBox";
            this.paperComboBox.Size = new System.Drawing.Size(160, 21);
            this.paperComboBox.TabIndex = 22;
            this.paperComboBox.Text = "Papír";
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.filterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Location = new System.Drawing.Point(94, 337);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(77, 28);
            this.filterBtn.TabIndex = 18;
            this.filterBtn.Text = "Szűrés";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click_1);
            // 
            // boxComboBox
            // 
            this.boxComboBox.FormattingEnabled = true;
            this.boxComboBox.Location = new System.Drawing.Point(13, 258);
            this.boxComboBox.Name = "boxComboBox";
            this.boxComboBox.Size = new System.Drawing.Size(160, 21);
            this.boxComboBox.TabIndex = 21;
            this.boxComboBox.Text = "Doboz";
            // 
            // dialComboBox
            // 
            this.dialComboBox.FormattingEnabled = true;
            this.dialComboBox.Location = new System.Drawing.Point(13, 15);
            this.dialComboBox.Name = "dialComboBox";
            this.dialComboBox.Size = new System.Drawing.Size(160, 21);
            this.dialComboBox.TabIndex = 19;
            this.dialComboBox.Text = "Számlap színe";
            // 
            // movementComboBox
            // 
            this.movementComboBox.FormattingEnabled = true;
            this.movementComboBox.Location = new System.Drawing.Point(13, 231);
            this.movementComboBox.Name = "movementComboBox";
            this.movementComboBox.Size = new System.Drawing.Size(160, 21);
            this.movementComboBox.TabIndex = 25;
            this.movementComboBox.Text = "Óramű";
            // 
            // strapMaterialComboBox
            // 
            this.strapMaterialComboBox.FormattingEnabled = true;
            this.strapMaterialComboBox.Location = new System.Drawing.Point(13, 150);
            this.strapMaterialComboBox.Name = "strapMaterialComboBox";
            this.strapMaterialComboBox.Size = new System.Drawing.Size(160, 21);
            this.strapMaterialComboBox.TabIndex = 24;
            this.strapMaterialComboBox.Text = "Szíj anyaga";
            // 
            // caseDiameterComboBox
            // 
            this.caseDiameterComboBox.FormattingEnabled = true;
            this.caseDiameterComboBox.Location = new System.Drawing.Point(13, 96);
            this.caseDiameterComboBox.Name = "caseDiameterComboBox";
            this.caseDiameterComboBox.Size = new System.Drawing.Size(160, 21);
            this.caseDiameterComboBox.TabIndex = 26;
            this.caseDiameterComboBox.Text = "Tok diaméter";
            // 
            // caseMaterialComboBox
            // 
            this.caseMaterialComboBox.FormattingEnabled = true;
            this.caseMaterialComboBox.Location = new System.Drawing.Point(13, 69);
            this.caseMaterialComboBox.Name = "caseMaterialComboBox";
            this.caseMaterialComboBox.Size = new System.Drawing.Size(160, 21);
            this.caseMaterialComboBox.TabIndex = 23;
            this.caseMaterialComboBox.Text = "Tok anyaga";
            // 
            // caseThicknessComboBox
            // 
            this.caseThicknessComboBox.FormattingEnabled = true;
            this.caseThicknessComboBox.Location = new System.Drawing.Point(13, 123);
            this.caseThicknessComboBox.Name = "caseThicknessComboBox";
            this.caseThicknessComboBox.Size = new System.Drawing.Size(160, 21);
            this.caseThicknessComboBox.TabIndex = 27;
            this.caseThicknessComboBox.Text = "Tok vastagság";
            // 
            // dialMaterialComboBox
            // 
            this.dialMaterialComboBox.FormattingEnabled = true;
            this.dialMaterialComboBox.Location = new System.Drawing.Point(13, 42);
            this.dialMaterialComboBox.Name = "dialMaterialComboBox";
            this.dialMaterialComboBox.Size = new System.Drawing.Size(160, 21);
            this.dialMaterialComboBox.TabIndex = 29;
            this.dialMaterialComboBox.Text = "Számlap anyaga";
            // 
            // bandWidthComboBox
            // 
            this.bandWidthComboBox.FormattingEnabled = true;
            this.bandWidthComboBox.Location = new System.Drawing.Point(13, 177);
            this.bandWidthComboBox.Name = "bandWidthComboBox";
            this.bandWidthComboBox.Size = new System.Drawing.Size(160, 21);
            this.bandWidthComboBox.TabIndex = 28;
            this.bandWidthComboBox.Text = "Szíj szélessége";
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(13, 204);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(160, 21);
            this.dateComboBox.TabIndex = 20;
            this.dateComboBox.Text = "Dátum ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 55);
            this.panel3.TabIndex = 18;
            // 
            // addNewUser
            // 
            this.addNewUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.addNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewUser.ForeColor = System.Drawing.Color.White;
            this.addNewUser.Location = new System.Drawing.Point(253, 529);
            this.addNewUser.Name = "addNewUser";
            this.addNewUser.Size = new System.Drawing.Size(207, 35);
            this.addNewUser.TabIndex = 19;
            this.addNewUser.Text = "Felhasználó hozzáadása";
            this.addNewUser.UseVisualStyleBackColor = false;
            this.addNewUser.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // orderDeleteBtn
            // 
            this.orderDeleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.orderDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orderDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.orderDeleteBtn.Location = new System.Drawing.Point(820, 532);
            this.orderDeleteBtn.Name = "orderDeleteBtn";
            this.orderDeleteBtn.Size = new System.Drawing.Size(186, 35);
            this.orderDeleteBtn.TabIndex = 14;
            this.orderDeleteBtn.Text = "Rendelés törlése";
            this.orderDeleteBtn.UseVisualStyleBackColor = false;
            this.orderDeleteBtn.Click += new System.EventHandler(this.orderDeleteBtn_Click);
            // 
            // deleteOrderIdTextBox
            // 
            this.deleteOrderIdTextBox.Location = new System.Drawing.Point(714, 529);
            this.deleteOrderIdTextBox.Multiline = true;
            this.deleteOrderIdTextBox.Name = "deleteOrderIdTextBox";
            this.deleteOrderIdTextBox.Size = new System.Drawing.Size(92, 35);
            this.deleteOrderIdTextBox.TabIndex = 21;
            // 
            // deleteSearch
            // 
            this.deleteSearch.Location = new System.Drawing.Point(536, 98);
            this.deleteSearch.Name = "deleteSearch";
            this.deleteSearch.Size = new System.Drawing.Size(75, 23);
            this.deleteSearch.TabIndex = 22;
            this.deleteSearch.Text = "Törlés";
            this.deleteSearch.UseVisualStyleBackColor = true;
            this.deleteSearch.Click += new System.EventHandler(this.deleteSearch_Click);
            // 
            // Menufrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 578);
            this.Controls.Add(this.deleteSearch);
            this.Controls.Add(this.deleteOrderIdTextBox);
            this.Controls.Add(this.orderDeleteBtn);
            this.Controls.Add(this.addNewUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.noResultsLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menufrom";
            this.Text = "Admin kezelő felület";
            this.Load += new System.EventHandler(this.Menufrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchesDataSet2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private watchesDataSet2 watchesDataSet2;
        private System.Windows.Forms.BindingSource baseBindingSource;
        private watchesDataSet2TableAdapters.baseTableAdapter baseTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem felhasználóváltásToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button watchesBtn;
        private System.Windows.Forms.Button usersManagementBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label noResultsLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox dialComboBox;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ComboBox dialMaterialComboBox;
        private System.Windows.Forms.ComboBox bandWidthComboBox;
        private System.Windows.Forms.ComboBox caseThicknessComboBox;
        private System.Windows.Forms.ComboBox caseDiameterComboBox;
        private System.Windows.Forms.ComboBox movementComboBox;
        private System.Windows.Forms.ComboBox strapMaterialComboBox;
        private System.Windows.Forms.ComboBox caseMaterialComboBox;
        private System.Windows.Forms.ComboBox paperComboBox;
        private System.Windows.Forms.ComboBox boxComboBox;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem alapadatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapcsolatToolStripMenuItem;
        private System.Windows.Forms.Button clearFilterBtn;
        private System.Windows.Forms.Button addNewUser;
        private System.Windows.Forms.ToolStripMenuItem elérhetőségToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox contactNameText;
        private System.Windows.Forms.ToolStripTextBox contactTelText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox contactEmailText;
        private System.Windows.Forms.Button orderDeleteBtn;
        private System.Windows.Forms.TextBox deleteOrderIdTextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Button deleteSearch;
    }
}