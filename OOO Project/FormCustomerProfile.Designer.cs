
namespace OOO_Project
{
    partial class FormCustomerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerProfile));
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.DGVProductQuantity = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBuyProductID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productQuantitys1 = new OOO_Project.ProductQuantitys1();
            this.productQuantityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productQuantityTableAdapter = new OOO_Project.ProductQuantitys1TableAdapters.ProductQuantityTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsFeaturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductQuantity)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantitys1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1314, 687);
            this.panel5.TabIndex = 15;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel6);
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.txtBuyProductID);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.groupBox8.Location = new System.Drawing.Point(12, 67);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1265, 649);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "                                                        :";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.DGVProductQuantity);
            this.panel6.Location = new System.Drawing.Point(11, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(755, 514);
            this.panel6.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, -27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bilgisayar";
            // 
            // DGVProductQuantity
            // 
            this.DGVProductQuantity.AutoGenerateColumns = false;
            this.DGVProductQuantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVProductQuantity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.DGVProductQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductQuantity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.tradeMarkDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.productsFeaturesDataGridViewTextBoxColumn});
            this.DGVProductQuantity.DataSource = this.productQuantityBindingSource;
            this.DGVProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProductQuantity.Location = new System.Drawing.Point(0, 0);
            this.DGVProductQuantity.Name = "DGVProductQuantity";
            this.DGVProductQuantity.Size = new System.Drawing.Size(755, 514);
            this.DGVProductQuantity.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1018, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 42);
            this.button6.TabIndex = 19;
            this.button6.Text = "Select";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(801, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(380, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Enter the number of the product you will buy";
            // 
            // txtBuyProductID
            // 
            this.txtBuyProductID.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBuyProductID.Location = new System.Drawing.Point(834, 308);
            this.txtBuyProductID.Name = "txtBuyProductID";
            this.txtBuyProductID.Size = new System.Drawing.Size(178, 41);
            this.txtBuyProductID.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Please Select Product Type ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1222, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1280, 61);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // productQuantitys1
            // 
            this.productQuantitys1.DataSetName = "ProductQuantitys1";
            this.productQuantitys1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productQuantityBindingSource
            // 
            this.productQuantityBindingSource.DataMember = "ProductQuantity";
            this.productQuantityBindingSource.DataSource = this.productQuantitys1;
            // 
            // productQuantityTableAdapter
            // 
            this.productQuantityTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 115;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.Width = 143;
            // 
            // tradeMarkDataGridViewTextBoxColumn
            // 
            this.tradeMarkDataGridViewTextBoxColumn.DataPropertyName = "TradeMark";
            this.tradeMarkDataGridViewTextBoxColumn.HeaderText = "TradeMark";
            this.tradeMarkDataGridViewTextBoxColumn.Name = "tradeMarkDataGridViewTextBoxColumn";
            this.tradeMarkDataGridViewTextBoxColumn.Width = 126;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 88;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 78;
            // 
            // productsFeaturesDataGridViewTextBoxColumn
            // 
            this.productsFeaturesDataGridViewTextBoxColumn.DataPropertyName = "ProductsFeatures";
            this.productsFeaturesDataGridViewTextBoxColumn.HeaderText = "ProductsFeatures";
            this.productsFeaturesDataGridViewTextBoxColumn.Name = "productsFeaturesDataGridViewTextBoxColumn";
            this.productsFeaturesDataGridViewTextBoxColumn.Width = 183;
            // 
            // FormCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerProfile";
            this.Text = "FormCustomerProfile";
            this.Load += new System.EventHandler(this.FormCustomerProfile_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductQuantity)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productQuantitys1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGVProductQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox txtBuyProductID;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.Button button6;
        private ProductQuantitys1 productQuantitys1;
        private System.Windows.Forms.BindingSource productQuantityBindingSource;
        private ProductQuantitys1TableAdapters.ProductQuantityTableAdapter productQuantityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsFeaturesDataGridViewTextBoxColumn;
    }
}