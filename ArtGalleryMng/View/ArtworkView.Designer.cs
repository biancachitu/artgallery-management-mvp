using System.Windows.Forms;

namespace ArtGalleryMng
{
    partial class ArtworkView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtworkView));
            this.txtArtistFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvArtworksList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPickGallery = new System.Windows.Forms.ComboBox();
            this.txtPickGallery = new System.Windows.Forms.Label();
            this.labelArtistFltr = new System.Windows.Forms.Label();
            this.labelTypeFltr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtworksList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArtistFilter
            // 
            this.txtArtistFilter.Location = new System.Drawing.Point(41, 346);
            this.txtArtistFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtArtistFilter.Name = "txtArtistFilter";
            this.txtArtistFilter.Size = new System.Drawing.Size(165, 26);
            this.txtArtistFilter.TabIndex = 3;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DisplayMember = "-";
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(new object[] {
            "Painting",
            "Sculpture",
            "Photography"});
            this.cmbFilterType.Location = new System.Drawing.Point(228, 344);
            this.cmbFilterType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(177, 28);
            this.cmbFilterType.TabIndex = 5;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilters.Location = new System.Drawing.Point(413, 336);
            this.btnResetFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(143, 42);
            this.btnResetFilters.TabIndex = 6;
            this.btnResetFilters.Text = "Reset filters";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Verdana", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelPageTitle.Location = new System.Drawing.Point(32, 116);
            this.labelPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(250, 53);
            this.labelPageTitle.TabIndex = 8;
            this.labelPageTitle.Text = "Artworks";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Purple;
            this.btnBack.Location = new System.Drawing.Point(41, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 53);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvArtworksList
            // 
            this.dgvArtworksList.AllowUserToResizeColumns = false;
            this.dgvArtworksList.AllowUserToResizeRows = false;
            this.dgvArtworksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvArtworksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvArtworksList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvArtworksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtworksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Artist,
            this.Year_made,
            this.TypeId});
            this.dgvArtworksList.GridColor = System.Drawing.SystemColors.Window;
            this.dgvArtworksList.Location = new System.Drawing.Point(41, 408);
            this.dgvArtworksList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtworksList.Name = "dgvArtworksList";
            this.dgvArtworksList.RowHeadersWidth = 51;
            this.dgvArtworksList.RowTemplate.Height = 27;
            this.dgvArtworksList.Size = new System.Drawing.Size(240, 150);
            this.dgvArtworksList.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 59;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Title.Frozen = true;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 74;
            // 
            // Artist
            // 
            this.Artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Artist.Frozen = true;
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Width = 82;
            // 
            // Year_made
            // 
            this.Year_made.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Year_made.Frozen = true;
            this.Year_made.HeaderText = "Year made";
            this.Year_made.MinimumWidth = 6;
            this.Year_made.Name = "Year_made";
            this.Year_made.ReadOnly = true;
            this.Year_made.Width = 123;
            // 
            // TypeId
            // 
            this.TypeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TypeId.Frozen = true;
            this.TypeId.HeaderText = "Type";
            this.TypeId.MinimumWidth = 6;
            this.TypeId.Name = "TypeId";
            this.TypeId.ReadOnly = true;
            this.TypeId.Width = 79;
            // 
            // cmbPickGallery
            // 
            this.cmbPickGallery.FormattingEnabled = true;
            this.cmbPickGallery.Location = new System.Drawing.Point(41, 251);
            this.cmbPickGallery.Name = "cmbPickGallery";
            this.cmbPickGallery.Size = new System.Drawing.Size(245, 28);
            this.cmbPickGallery.TabIndex = 11;
            // 
            // txtPickGallery
            // 
            this.txtPickGallery.AutoSize = true;
            this.txtPickGallery.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPickGallery.ForeColor = System.Drawing.Color.Plum;
            this.txtPickGallery.Location = new System.Drawing.Point(36, 208);
            this.txtPickGallery.Name = "txtPickGallery";
            this.txtPickGallery.Size = new System.Drawing.Size(170, 25);
            this.txtPickGallery.TabIndex = 12;
            this.txtPickGallery.Text = "Pick a gallery ";
            // 
            // labelArtistFltr
            // 
            this.labelArtistFltr.AutoSize = true;
            this.labelArtistFltr.Font = new System.Drawing.Font("Verdana", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArtistFltr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelArtistFltr.Location = new System.Drawing.Point(38, 312);
            this.labelArtistFltr.Name = "labelArtistFltr";
            this.labelArtistFltr.Size = new System.Drawing.Size(165, 18);
            this.labelArtistFltr.TabIndex = 13;
            this.labelArtistFltr.Text = "Search an artist...";
            // 
            // labelTypeFltr
            // 
            this.labelTypeFltr.AutoSize = true;
            this.labelTypeFltr.Font = new System.Drawing.Font("Verdana", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeFltr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTypeFltr.Location = new System.Drawing.Point(225, 312);
            this.labelTypeFltr.Name = "labelTypeFltr";
            this.labelTypeFltr.Size = new System.Drawing.Size(79, 18);
            this.labelTypeFltr.TabIndex = 14;
            this.labelTypeFltr.Text = "Art type";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(985, 397);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 415);
            this.panel1.TabIndex = 2;
            // 
            // ArtworkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1429, 1050);
            this.Controls.Add(this.labelTypeFltr);
            this.Controls.Add(this.labelArtistFltr);
            this.Controls.Add(this.txtPickGallery);
            this.Controls.Add(this.cmbPickGallery);
            this.Controls.Add(this.dgvArtworksList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelPageTitle);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.txtArtistFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArtworkView";
            this.Text = "ArtworkView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtworksList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.TextBox txtArtistFilter;
        private System.Windows.Forms.DataGridView dgvArtworksList;
        private System.Windows.Forms.ComboBox cmbPickGallery;
        private System.Windows.Forms.Label txtPickGallery;
        private System.Windows.Forms.Label labelArtistFltr;
        private System.Windows.Forms.Label labelTypeFltr;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Year_made;
        private DataGridViewTextBoxColumn TypeId;
    }
}