using System.Windows.Forms;

namespace ArtGalleryMng.View
{
    partial class EmployeeView
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
            this.labelEmpDash = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NudGallery = new System.Windows.Forms.NumericUpDown();
            this.NudType = new System.Windows.Forms.NumericUpDown();
            this.NudYear = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.labelFormGalleryId = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelFormType = new System.Windows.Forms.Label();
            this.labelFormYear = new System.Windows.Forms.Label();
            this.labelFormArtist = new System.Windows.Forms.Label();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.labelAddForm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpDash
            // 
            this.labelEmpDash.AutoSize = true;
            this.labelEmpDash.Font = new System.Drawing.Font("Verdana", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmpDash.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelEmpDash.Location = new System.Drawing.Point(220, 31);
            this.labelEmpDash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmpDash.Name = "labelEmpDash";
            this.labelEmpDash.Size = new System.Drawing.Size(495, 48);
            this.labelEmpDash.TabIndex = 0;
            this.labelEmpDash.Text = "Employee Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NudGallery);
            this.panel1.Controls.Add(this.NudType);
            this.panel1.Controls.Add(this.NudYear);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.RemoveBtn);
            this.panel1.Controls.Add(this.labelFormGalleryId);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.txtArtist);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.labelFormType);
            this.panel1.Controls.Add(this.labelFormYear);
            this.panel1.Controls.Add(this.labelFormArtist);
            this.panel1.Controls.Add(this.labelFormTitle);
            this.panel1.Location = new System.Drawing.Point(956, 397);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 415);
            this.panel1.TabIndex = 2;
            // 
            // NudGallery
            // 
            this.NudGallery.Location = new System.Drawing.Point(197, 245);
            this.NudGallery.Name = "NudGallery";
            this.NudGallery.Size = new System.Drawing.Size(224, 26);
            this.NudGallery.TabIndex = 19;
            // 
            // NudType
            // 
            this.NudType.Location = new System.Drawing.Point(197, 196);
            this.NudType.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NudType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudType.Name = "NudType";
            this.NudType.Size = new System.Drawing.Size(224, 26);
            this.NudType.TabIndex = 18;
            this.NudType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudYear
            // 
            this.NudYear.Location = new System.Drawing.Point(197, 143);
            this.NudYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.NudYear.Name = "NudYear";
            this.NudYear.Size = new System.Drawing.Size(224, 26);
            this.NudYear.TabIndex = 17;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Violet;
            this.SaveBtn.Location = new System.Drawing.Point(145, 321);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(84, 43);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.Purple;
            this.RemoveBtn.Location = new System.Drawing.Point(250, 321);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(104, 43);
            this.RemoveBtn.TabIndex = 15;
            this.RemoveBtn.Text = "Delete";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // labelFormGalleryId
            // 
            this.labelFormGalleryId.AutoSize = true;
            this.labelFormGalleryId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFormGalleryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelFormGalleryId.Location = new System.Drawing.Point(23, 239);
            this.labelFormGalleryId.Name = "labelFormGalleryId";
            this.labelFormGalleryId.Size = new System.Drawing.Size(149, 29);
            this.labelFormGalleryId.TabIndex = 13;
            this.labelFormGalleryId.Text = "Gallery ID";
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditBtn.ForeColor = System.Drawing.Color.Purple;
            this.EditBtn.Location = new System.Drawing.Point(145, 321);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(84, 43);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddBtn.ForeColor = System.Drawing.Color.Purple;
            this.AddBtn.Location = new System.Drawing.Point(32, 322);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 42);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(197, 93);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(224, 26);
            this.txtArtist.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(197, 41);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(224, 26);
            this.txtTitle.TabIndex = 6;
            // 
            // labelFormType
            // 
            this.labelFormType.AutoSize = true;
            this.labelFormType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelFormType.Location = new System.Drawing.Point(23, 190);
            this.labelFormType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormType.Name = "labelFormType";
            this.labelFormType.Size = new System.Drawing.Size(119, 29);
            this.labelFormType.TabIndex = 4;
            this.labelFormType.Text = "Type ID";
            // 
            // labelFormYear
            // 
            this.labelFormYear.AutoSize = true;
            this.labelFormYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelFormYear.Location = new System.Drawing.Point(23, 142);
            this.labelFormYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormYear.Name = "labelFormYear";
            this.labelFormYear.Size = new System.Drawing.Size(75, 29);
            this.labelFormYear.TabIndex = 3;
            this.labelFormYear.Text = "Year";
            // 
            // labelFormArtist
            // 
            this.labelFormArtist.AutoSize = true;
            this.labelFormArtist.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelFormArtist.Location = new System.Drawing.Point(23, 88);
            this.labelFormArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormArtist.Name = "labelFormArtist";
            this.labelFormArtist.Size = new System.Drawing.Size(88, 29);
            this.labelFormArtist.TabIndex = 2;
            this.labelFormArtist.Text = "Artist";
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelFormTitle.Location = new System.Drawing.Point(23, 36);
            this.labelFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(72, 29);
            this.labelFormTitle.TabIndex = 1;
            this.labelFormTitle.Text = "Title";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Purple;
            this.DeleteBtn.Location = new System.Drawing.Point(1159, 769);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 43);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // labelAddForm
            // 
            this.labelAddForm.AutoSize = true;
            this.labelAddForm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelAddForm.Location = new System.Drawing.Point(950, 329);
            this.labelAddForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddForm.Name = "labelAddForm";
            this.labelAddForm.Size = new System.Drawing.Size(162, 34);
            this.labelAddForm.TabIndex = 3;
            this.labelAddForm.Text = "Add form";
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1603, 843);
            this.Controls.Add(this.labelAddForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEmpDash);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.Controls.SetChildIndex(this.labelEmpDash, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelAddForm, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpDash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFormType;
        private System.Windows.Forms.Label labelFormYear;
        private System.Windows.Forms.Label labelFormArtist;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelAddForm;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label labelFormGalleryId;
        private Button RemoveBtn;
        private Button SaveBtn;
        private NumericUpDown NudYear;
        private NumericUpDown NudGallery;
        private NumericUpDown NudType;
    }
}