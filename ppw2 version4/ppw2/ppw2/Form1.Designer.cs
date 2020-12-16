namespace ppw2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ComboBoxRaceSelector = new System.Windows.Forms.ComboBox();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditRace = new System.Windows.Forms.Button();
            this.btnAddRace = new System.Windows.Forms.Button();
            this.LstboxMainPanel = new System.Windows.Forms.ListBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuPanel.Controls.Add(this.ComboBoxRaceSelector);
            this.MenuPanel.Controls.Add(this.PicBoxLogo);
            this.MenuPanel.Controls.Add(this.btnClose);
            this.MenuPanel.Controls.Add(this.btnSave);
            this.MenuPanel.Controls.Add(this.btnEditRace);
            this.MenuPanel.Controls.Add(this.btnAddRace);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(426, 959);
            this.MenuPanel.TabIndex = 1;
            // 
            // ComboBoxRaceSelector
            // 
            this.ComboBoxRaceSelector.BackColor = System.Drawing.SystemColors.Highlight;
            this.ComboBoxRaceSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRaceSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxRaceSelector.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRaceSelector.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBoxRaceSelector.FormattingEnabled = true;
            this.ComboBoxRaceSelector.Items.AddRange(new object[] {
            "Races",
            "Motor Race",
            "Pedal Race"});
            this.ComboBoxRaceSelector.Location = new System.Drawing.Point(23, 248);
            this.ComboBoxRaceSelector.Name = "ComboBoxRaceSelector";
            this.ComboBoxRaceSelector.Size = new System.Drawing.Size(374, 49);
            this.ComboBoxRaceSelector.TabIndex = 0;
            this.ComboBoxRaceSelector.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRaceSelector_SelectedIndexChanged);
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBoxLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PicBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxLogo.Image")));
            this.PicBoxLogo.Location = new System.Drawing.Point(126, 43);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(171, 147);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogo.TabIndex = 0;
            this.PicBoxLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(0, 833);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(426, 105);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "  &Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(-3, 696);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(426, 105);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "  &Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditRace
            // 
            this.btnEditRace.FlatAppearance.BorderSize = 0;
            this.btnEditRace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRace.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditRace.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRace.Image")));
            this.btnEditRace.Location = new System.Drawing.Point(-3, 571);
            this.btnEditRace.Name = "btnEditRace";
            this.btnEditRace.Size = new System.Drawing.Size(426, 105);
            this.btnEditRace.TabIndex = 2;
            this.btnEditRace.Text = "  &Edit Race";
            this.btnEditRace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditRace.UseVisualStyleBackColor = true;
            this.btnEditRace.Click += new System.EventHandler(this.btnEditRace_Click);
            // 
            // btnAddRace
            // 
            this.btnAddRace.FlatAppearance.BorderSize = 0;
            this.btnAddRace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRace.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddRace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRace.Image")));
            this.btnAddRace.Location = new System.Drawing.Point(-3, 434);
            this.btnAddRace.Name = "btnAddRace";
            this.btnAddRace.Size = new System.Drawing.Size(426, 105);
            this.btnAddRace.TabIndex = 1;
            this.btnAddRace.Text = "  &Add Race";
            this.btnAddRace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRace.UseVisualStyleBackColor = true;
            this.btnAddRace.Click += new System.EventHandler(this.btnAddRace_Click);
            // 
            // LstboxMainPanel
            // 
            this.LstboxMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LstboxMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstboxMainPanel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstboxMainPanel.FormattingEnabled = true;
            this.LstboxMainPanel.ItemHeight = 37;
            this.LstboxMainPanel.Location = new System.Drawing.Point(426, 0);
            this.LstboxMainPanel.Name = "LstboxMainPanel";
            this.LstboxMainPanel.Size = new System.Drawing.Size(1389, 959);
            this.LstboxMainPanel.TabIndex = 2;
 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 959);
            this.Controls.Add(this.LstboxMainPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox PicBoxLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditRace;
        private System.Windows.Forms.Button btnAddRace;
        private System.Windows.Forms.ListBox LstboxMainPanel;
        private System.Windows.Forms.ComboBox ComboBoxRaceSelector;
    }
}

