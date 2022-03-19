namespace sqlite_mtm_winform_demo
{
    partial class DemoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_AddNewMerchant = new System.Windows.Forms.Button();
            this.DGW_Merchant = new System.Windows.Forms.DataGridView();
            this.merchantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gb_Merchant = new System.Windows.Forms.GroupBox();
            this.Lbl_NewMerchantName = new System.Windows.Forms.Label();
            this.Tb_NewMerchantName = new System.Windows.Forms.TextBox();
            this.Gb_Ware = new System.Windows.Forms.GroupBox();
            this.Lbl_NewWareName = new System.Windows.Forms.Label();
            this.Tb_NewWareName = new System.Windows.Forms.TextBox();
            this.DGW_Ware = new System.Windows.Forms.DataGridView();
            this.WareId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_AddNewWare = new System.Windows.Forms.Button();
            this.Gb_MerchantHasWares = new System.Windows.Forms.GroupBox();
            this.Lbl_WareAmount = new System.Windows.Forms.Label();
            this.Nud_WareAmount = new System.Windows.Forms.NumericUpDown();
            this.Btn_RemoveSelectedWare = new System.Windows.Forms.Button();
            this.DGW_MerchantHasWares = new System.Windows.Forms.DataGridView();
            this.Btn_AddSelectedWare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Merchant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).BeginInit();
            this.Gb_Merchant.SuspendLayout();
            this.Gb_Ware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Ware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareBindingSource)).BeginInit();
            this.Gb_MerchantHasWares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_WareAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_MerchantHasWares)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_AddNewMerchant
            // 
            this.Btn_AddNewMerchant.Location = new System.Drawing.Point(346, 46);
            this.Btn_AddNewMerchant.Name = "Btn_AddNewMerchant";
            this.Btn_AddNewMerchant.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddNewMerchant.TabIndex = 0;
            this.Btn_AddNewMerchant.Text = "Add";
            this.Btn_AddNewMerchant.UseVisualStyleBackColor = true;
            this.Btn_AddNewMerchant.Click += new System.EventHandler(this.Btn_AddNewMerchant_Click);
            // 
            // DGW_Merchant
            // 
            this.DGW_Merchant.AllowUserToAddRows = false;
            this.DGW_Merchant.AllowUserToDeleteRows = false;
            this.DGW_Merchant.AutoGenerateColumns = false;
            this.DGW_Merchant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Merchant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.merchantIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DGW_Merchant.DataSource = this.merchantBindingSource;
            this.DGW_Merchant.Location = new System.Drawing.Point(18, 89);
            this.DGW_Merchant.MultiSelect = false;
            this.DGW_Merchant.Name = "DGW_Merchant";
            this.DGW_Merchant.ReadOnly = true;
            this.DGW_Merchant.RowHeadersVisible = false;
            this.DGW_Merchant.RowTemplate.Height = 25;
            this.DGW_Merchant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_Merchant.Size = new System.Drawing.Size(417, 381);
            this.DGW_Merchant.TabIndex = 1;
            // 
            // merchantIdDataGridViewTextBoxColumn
            // 
            this.merchantIdDataGridViewTextBoxColumn.DataPropertyName = "MerchantId";
            this.merchantIdDataGridViewTextBoxColumn.HeaderText = "MerchantId";
            this.merchantIdDataGridViewTextBoxColumn.Name = "merchantIdDataGridViewTextBoxColumn";
            this.merchantIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // merchantBindingSource
            // 
            this.merchantBindingSource.DataSource = typeof(sqlite_mtm_winform_demo.Merchant);
            // 
            // Gb_Merchant
            // 
            this.Gb_Merchant.Controls.Add(this.Lbl_NewMerchantName);
            this.Gb_Merchant.Controls.Add(this.Tb_NewMerchantName);
            this.Gb_Merchant.Controls.Add(this.DGW_Merchant);
            this.Gb_Merchant.Controls.Add(this.Btn_AddNewMerchant);
            this.Gb_Merchant.Location = new System.Drawing.Point(12, 12);
            this.Gb_Merchant.Name = "Gb_Merchant";
            this.Gb_Merchant.Size = new System.Drawing.Size(441, 487);
            this.Gb_Merchant.TabIndex = 2;
            this.Gb_Merchant.TabStop = false;
            this.Gb_Merchant.Text = "Merchants";
            // 
            // Lbl_NewMerchantName
            // 
            this.Lbl_NewMerchantName.AutoSize = true;
            this.Lbl_NewMerchantName.Location = new System.Drawing.Point(16, 24);
            this.Lbl_NewMerchantName.Name = "Lbl_NewMerchantName";
            this.Lbl_NewMerchantName.Size = new System.Drawing.Size(139, 15);
            this.Lbl_NewMerchantName.TabIndex = 3;
            this.Lbl_NewMerchantName.Text = "Name for new merchant:";
            // 
            // Tb_NewMerchantName
            // 
            this.Tb_NewMerchantName.Location = new System.Drawing.Point(17, 46);
            this.Tb_NewMerchantName.Name = "Tb_NewMerchantName";
            this.Tb_NewMerchantName.Size = new System.Drawing.Size(323, 23);
            this.Tb_NewMerchantName.TabIndex = 2;
            // 
            // Gb_Ware
            // 
            this.Gb_Ware.Controls.Add(this.Lbl_NewWareName);
            this.Gb_Ware.Controls.Add(this.Tb_NewWareName);
            this.Gb_Ware.Controls.Add(this.DGW_Ware);
            this.Gb_Ware.Controls.Add(this.Btn_AddNewWare);
            this.Gb_Ware.Location = new System.Drawing.Point(1120, 12);
            this.Gb_Ware.Name = "Gb_Ware";
            this.Gb_Ware.Size = new System.Drawing.Size(441, 487);
            this.Gb_Ware.TabIndex = 4;
            this.Gb_Ware.TabStop = false;
            this.Gb_Ware.Text = "Wares";
            // 
            // Lbl_NewWareName
            // 
            this.Lbl_NewWareName.AutoSize = true;
            this.Lbl_NewWareName.Location = new System.Drawing.Point(16, 24);
            this.Lbl_NewWareName.Name = "Lbl_NewWareName";
            this.Lbl_NewWareName.Size = new System.Drawing.Size(113, 15);
            this.Lbl_NewWareName.TabIndex = 3;
            this.Lbl_NewWareName.Text = "Name for new ware:";
            // 
            // Tb_NewWareName
            // 
            this.Tb_NewWareName.Location = new System.Drawing.Point(17, 46);
            this.Tb_NewWareName.Name = "Tb_NewWareName";
            this.Tb_NewWareName.Size = new System.Drawing.Size(323, 23);
            this.Tb_NewWareName.TabIndex = 2;
            // 
            // DGW_Ware
            // 
            this.DGW_Ware.AllowUserToAddRows = false;
            this.DGW_Ware.AllowUserToDeleteRows = false;
            this.DGW_Ware.AutoGenerateColumns = false;
            this.DGW_Ware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Ware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WareId,
            this.dataGridViewTextBoxColumn2});
            this.DGW_Ware.DataSource = this.wareBindingSource;
            this.DGW_Ware.Location = new System.Drawing.Point(18, 89);
            this.DGW_Ware.MultiSelect = false;
            this.DGW_Ware.Name = "DGW_Ware";
            this.DGW_Ware.ReadOnly = true;
            this.DGW_Ware.RowHeadersVisible = false;
            this.DGW_Ware.RowTemplate.Height = 25;
            this.DGW_Ware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_Ware.Size = new System.Drawing.Size(417, 381);
            this.DGW_Ware.TabIndex = 1;
            // 
            // WareId
            // 
            this.WareId.DataPropertyName = "WareId";
            this.WareId.HeaderText = "WareId";
            this.WareId.Name = "WareId";
            this.WareId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // wareBindingSource
            // 
            this.wareBindingSource.DataSource = typeof(sqlite_mtm_winform_demo.Ware);
            // 
            // Btn_AddNewWare
            // 
            this.Btn_AddNewWare.Location = new System.Drawing.Point(346, 46);
            this.Btn_AddNewWare.Name = "Btn_AddNewWare";
            this.Btn_AddNewWare.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddNewWare.TabIndex = 0;
            this.Btn_AddNewWare.Text = "Add";
            this.Btn_AddNewWare.UseVisualStyleBackColor = true;
            this.Btn_AddNewWare.Click += new System.EventHandler(this.Btn_AddNewWare_Click);
            // 
            // Gb_MerchantHasWares
            // 
            this.Gb_MerchantHasWares.Controls.Add(this.Lbl_WareAmount);
            this.Gb_MerchantHasWares.Controls.Add(this.Nud_WareAmount);
            this.Gb_MerchantHasWares.Controls.Add(this.Btn_RemoveSelectedWare);
            this.Gb_MerchantHasWares.Controls.Add(this.DGW_MerchantHasWares);
            this.Gb_MerchantHasWares.Controls.Add(this.Btn_AddSelectedWare);
            this.Gb_MerchantHasWares.Location = new System.Drawing.Point(468, 12);
            this.Gb_MerchantHasWares.Name = "Gb_MerchantHasWares";
            this.Gb_MerchantHasWares.Size = new System.Drawing.Size(646, 487);
            this.Gb_MerchantHasWares.TabIndex = 5;
            this.Gb_MerchantHasWares.TabStop = false;
            this.Gb_MerchantHasWares.Text = "Wares";
            // 
            // Lbl_WareAmount
            // 
            this.Lbl_WareAmount.AutoSize = true;
            this.Lbl_WareAmount.Location = new System.Drawing.Point(495, 50);
            this.Lbl_WareAmount.Name = "Lbl_WareAmount";
            this.Lbl_WareAmount.Size = new System.Drawing.Size(134, 15);
            this.Lbl_WareAmount.TabIndex = 4;
            this.Lbl_WareAmount.Text = "Select ware add amount";
            // 
            // Nud_WareAmount
            // 
            this.Nud_WareAmount.Location = new System.Drawing.Point(509, 75);
            this.Nud_WareAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_WareAmount.Name = "Nud_WareAmount";
            this.Nud_WareAmount.Size = new System.Drawing.Size(120, 23);
            this.Nud_WareAmount.TabIndex = 3;
            this.Nud_WareAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btn_RemoveSelectedWare
            // 
            this.Btn_RemoveSelectedWare.Location = new System.Drawing.Point(527, 172);
            this.Btn_RemoveSelectedWare.Name = "Btn_RemoveSelectedWare";
            this.Btn_RemoveSelectedWare.Size = new System.Drawing.Size(75, 23);
            this.Btn_RemoveSelectedWare.TabIndex = 2;
            this.Btn_RemoveSelectedWare.Text = "🡺";
            this.Btn_RemoveSelectedWare.UseVisualStyleBackColor = true;
            this.Btn_RemoveSelectedWare.Click += new System.EventHandler(this.Btn_RemoveSelectedWare_Click);
            // 
            // DGW_MerchantHasWares
            // 
            this.DGW_MerchantHasWares.AllowUserToAddRows = false;
            this.DGW_MerchantHasWares.AllowUserToDeleteRows = false;
            this.DGW_MerchantHasWares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_MerchantHasWares.Location = new System.Drawing.Point(6, 89);
            this.DGW_MerchantHasWares.MultiSelect = false;
            this.DGW_MerchantHasWares.Name = "DGW_MerchantHasWares";
            this.DGW_MerchantHasWares.ReadOnly = true;
            this.DGW_MerchantHasWares.RowHeadersVisible = false;
            this.DGW_MerchantHasWares.RowTemplate.Height = 25;
            this.DGW_MerchantHasWares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_MerchantHasWares.Size = new System.Drawing.Size(481, 381);
            this.DGW_MerchantHasWares.TabIndex = 1;
            // 
            // Btn_AddSelectedWare
            // 
            this.Btn_AddSelectedWare.Location = new System.Drawing.Point(527, 126);
            this.Btn_AddSelectedWare.Name = "Btn_AddSelectedWare";
            this.Btn_AddSelectedWare.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddSelectedWare.TabIndex = 0;
            this.Btn_AddSelectedWare.Text = "🡸";
            this.Btn_AddSelectedWare.UseVisualStyleBackColor = true;
            this.Btn_AddSelectedWare.Click += new System.EventHandler(this.Btn_AddSelectedWare_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 507);
            this.Controls.Add(this.Gb_MerchantHasWares);
            this.Controls.Add(this.Gb_Ware);
            this.Controls.Add(this.Gb_Merchant);
            this.Name = "DemoForm";
            this.Text = "sqlite-mtm-winform-demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DemoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Merchant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).EndInit();
            this.Gb_Merchant.ResumeLayout(false);
            this.Gb_Merchant.PerformLayout();
            this.Gb_Ware.ResumeLayout(false);
            this.Gb_Ware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Ware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareBindingSource)).EndInit();
            this.Gb_MerchantHasWares.ResumeLayout(false);
            this.Gb_MerchantHasWares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_WareAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_MerchantHasWares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_AddNewMerchant;
        private DataGridView DGW_Merchant;
        private BindingSource merchantBindingSource;
        private GroupBox Gb_Merchant;
        private Label Lbl_NewMerchantName;
        private TextBox Tb_NewMerchantName;
        private GroupBox Gb_Ware;
        private Label Lbl_NewWareName;
        private TextBox Tb_NewWareName;
        private DataGridView DGW_Ware;
        private Button Btn_AddNewWare;
        private BindingSource wareBindingSource;
        private GroupBox Gb_MerchantHasWares;
        private DataGridView DGW_MerchantHasWares;
        private Button Btn_AddSelectedWare;
        private Button Btn_RemoveSelectedWare;
        private Label Lbl_WareAmount;
        private NumericUpDown Nud_WareAmount;
        private DataGridViewTextBoxColumn merchantIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn WareId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}