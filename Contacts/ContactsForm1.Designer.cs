namespace Contacts
{
    partial class ContactsForm1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(44, 96);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(44, 193);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(58, 13);
            this.lblCellphone.TabIndex = 3;
            this.lblCellphone.Text = "Cell Phone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 89);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(156, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(110, 186);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(156, 20);
            this.txtCell.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(331, 35);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(185, 277);
            this.lstContacts.TabIndex = 9;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContact.Location = new System.Drawing.Point(578, 35);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(281, 277);
            this.txtContact.TabIndex = 10;
            // 
            // ContactsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 359);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCellphone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "ContactsForm1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.TextBox txtContact;
    }
}

