
namespace admin
{
    partial class Delete
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
            this.deleteFormBtn = new System.Windows.Forms.Button();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteFormBtn
            // 
            this.deleteFormBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFormBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteFormBtn.ForeColor = System.Drawing.Color.White;
            this.deleteFormBtn.Location = new System.Drawing.Point(49, 187);
            this.deleteFormBtn.Name = "deleteFormBtn";
            this.deleteFormBtn.Size = new System.Drawing.Size(207, 35);
            this.deleteFormBtn.TabIndex = 15;
            this.deleteFormBtn.Text = "Termék törlése";
            this.deleteFormBtn.UseVisualStyleBackColor = false;
            this.deleteFormBtn.Click += new System.EventHandler(this.deleteFormBtn_Click);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(156, 73);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteTextBox.TabIndex = 16;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 248);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.deleteFormBtn);
            this.Name = "Delete";
            this.Text = "Termék törlése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteFormBtn;
        private System.Windows.Forms.TextBox deleteTextBox;
    }
}