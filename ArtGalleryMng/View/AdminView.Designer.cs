using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.labelAdminDash = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.NudAccessId = new System.Windows.Forms.NumericUpDown();
            this.AccessLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAccessId)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminDash
            // 
            this.labelAdminDash.AutoSize = true;
            this.labelAdminDash.Font = new System.Drawing.Font("Verdana", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdminDash.ForeColor = System.Drawing.Color.PowderBlue;
            this.labelAdminDash.Location = new System.Drawing.Point(219, 26);
            this.labelAdminDash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdminDash.Name = "labelAdminDash";
            this.labelAdminDash.Size = new System.Drawing.Size(462, 53);
            this.labelAdminDash.TabIndex = 0;
            this.labelAdminDash.Text = "Admin Dashboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Email,
            this.Password,
            this.AccessTypeId});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(1014, 613);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 27;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FullName.Frozen = true;
            this.FullName.HeaderText = "Name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 27;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Email.Frozen = true;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 27;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Password.Frozen = true;
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 27;
            // 
            // AccessTypeId
            // 
            this.AccessTypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.AccessTypeId.Frozen = true;
            this.AccessTypeId.HeaderText = "Access Type";
            this.AccessTypeId.MinimumWidth = 8;
            this.AccessTypeId.Name = "AccessTypeId";
            this.AccessTypeId.ReadOnly = true;
            this.AccessTypeId.Width = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtFullName);
            this.panel1.Controls.Add(this.NudAccessId);
            this.panel1.Controls.Add(this.AccessLabel);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(1305, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 430);
            this.panel1.TabIndex = 16;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SaveBtn.Location = new System.Drawing.Point(160, 364);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 50);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Purple;
            this.DeleteBtn.Location = new System.Drawing.Point(285, 364);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(92, 50);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditBtn.ForeColor = System.Drawing.Color.Purple;
            this.EditBtn.Location = new System.Drawing.Point(160, 364);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 50);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBtn.ForeColor = System.Drawing.Color.Purple;
            this.AddBtn.Location = new System.Drawing.Point(29, 364);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 50);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(147, 194);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(230, 26);
            this.TxtPassword.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(147, 131);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(230, 26);
            this.TxtEmail.TabIndex = 6;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(147, 60);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(230, 26);
            this.TxtFullName.TabIndex = 5;
            // 
            // NudAccessId
            // 
            this.NudAccessId.Location = new System.Drawing.Point(174, 257);
            this.NudAccessId.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudAccessId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAccessId.Name = "NudAccessId";
            this.NudAccessId.Size = new System.Drawing.Size(58, 26);
            this.NudAccessId.TabIndex = 4;
            this.NudAccessId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AccessLabel
            // 
            this.AccessLabel.AutoSize = true;
            this.AccessLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AccessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AccessLabel.Location = new System.Drawing.Point(18, 261);
            this.AccessLabel.Name = "AccessLabel";
            this.AccessLabel.Size = new System.Drawing.Size(135, 22);
            this.AccessLabel.TabIndex = 3;
            this.AccessLabel.Text = "Access Type";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PasswordLabel.Location = new System.Drawing.Point(18, 193);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(109, 22);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(18, 131);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 22);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NameLabel.Location = new System.Drawing.Point(18, 64);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(111, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(1007, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Users";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAdminDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Controls.SetChildIndex(this.labelAdminDash, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAccessId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminDash;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label NameLabel;
        private NumericUpDown NudAccessId;
        private Label AccessLabel;
        private Label PasswordLabel;
        private Label EmailLabel;
        private TextBox TxtPassword;
        private TextBox TxtEmail;
        private TextBox TxtFullName;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn AccessTypeId;
        private Button SaveBtn;
    }
}