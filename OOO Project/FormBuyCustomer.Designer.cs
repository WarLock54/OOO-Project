
namespace OOO_Project
{
    partial class FormBuyCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbtnHandDelivery = new System.Windows.Forms.RadioButton();
            this.rdbtnCargo = new System.Windows.Forms.RadioButton();
            this.grpCash = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpCheck = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckBankName = new System.Windows.Forms.TextBox();
            this.txtCheckCode = new System.Windows.Forms.TextBox();
            this.grpCreditCard = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.ProductQuantity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductFeatures = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPType = new System.Windows.Forms.TextBox();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.txtTradeMark = new System.Windows.Forms.TextBox();
            this.txtPModel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbtnCreditCart = new System.Windows.Forms.RadioButton();
            this.rdbtnCheck = new System.Windows.Forms.RadioButton();
            this.rdbtnCash = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpCash.SuspendLayout();
            this.grpCheck.SuspendLayout();
            this.grpCreditCard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 64);
            this.panel1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1219, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 50);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.rdbtnHandDelivery);
            this.groupBox5.Controls.Add(this.rdbtnCargo);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.groupBox5.Location = new System.Drawing.Point(630, 521);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 87);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose a Product Delivery Format";
            // 
            // rdbtnHandDelivery
            // 
            this.rdbtnHandDelivery.AutoSize = true;
            this.rdbtnHandDelivery.Location = new System.Drawing.Point(155, 42);
            this.rdbtnHandDelivery.Name = "rdbtnHandDelivery";
            this.rdbtnHandDelivery.Size = new System.Drawing.Size(136, 25);
            this.rdbtnHandDelivery.TabIndex = 9;
            this.rdbtnHandDelivery.TabStop = true;
            this.rdbtnHandDelivery.Text = "Hand Delivery";
            this.rdbtnHandDelivery.UseVisualStyleBackColor = true;
            this.rdbtnHandDelivery.CheckedChanged += new System.EventHandler(this.rdbtnHandDelivery_CheckedChanged);
            // 
            // rdbtnCargo
            // 
            this.rdbtnCargo.AutoSize = true;
            this.rdbtnCargo.Location = new System.Drawing.Point(20, 42);
            this.rdbtnCargo.Name = "rdbtnCargo";
            this.rdbtnCargo.Size = new System.Drawing.Size(78, 25);
            this.rdbtnCargo.TabIndex = 7;
            this.rdbtnCargo.TabStop = true;
            this.rdbtnCargo.Text = "Cargo";
            this.rdbtnCargo.UseVisualStyleBackColor = true;
            this.rdbtnCargo.CheckedChanged += new System.EventHandler(this.rdbtnCargo_CheckedChanged);
            // 
            // grpCash
            // 
            this.grpCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCash.Controls.Add(this.label13);
            this.grpCash.Controls.Add(this.txtAmount);
            this.grpCash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.grpCash.Location = new System.Drawing.Point(1066, 192);
            this.grpCash.Name = "grpCash";
            this.grpCash.Size = new System.Drawing.Size(198, 323);
            this.grpCash.TabIndex = 18;
            this.grpCash.TabStop = false;
            this.grpCash.Text = "Please Enter Payment Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(14, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Enter Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(10, 166);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(169, 33);
            this.txtAmount.TabIndex = 25;
            // 
            // grpCheck
            // 
            this.grpCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCheck.Controls.Add(this.label11);
            this.grpCheck.Controls.Add(this.label10);
            this.grpCheck.Controls.Add(this.txtCheckBankName);
            this.grpCheck.Controls.Add(this.txtCheckCode);
            this.grpCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.grpCheck.Location = new System.Drawing.Point(852, 192);
            this.grpCheck.Name = "grpCheck";
            this.grpCheck.Size = new System.Drawing.Size(198, 323);
            this.grpCheck.TabIndex = 17;
            this.grpCheck.TabStop = false;
            this.grpCheck.Text = "Please Enter Payment Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Check Code :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bank Name :";
            // 
            // txtCheckBankName
            // 
            this.txtCheckBankName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtCheckBankName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckBankName.ForeColor = System.Drawing.Color.White;
            this.txtCheckBankName.Location = new System.Drawing.Point(6, 119);
            this.txtCheckBankName.Name = "txtCheckBankName";
            this.txtCheckBankName.Size = new System.Drawing.Size(169, 33);
            this.txtCheckBankName.TabIndex = 23;
            // 
            // txtCheckCode
            // 
            this.txtCheckCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtCheckCode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckCode.ForeColor = System.Drawing.Color.White;
            this.txtCheckCode.Location = new System.Drawing.Point(6, 202);
            this.txtCheckCode.Name = "txtCheckCode";
            this.txtCheckCode.Size = new System.Drawing.Size(169, 33);
            this.txtCheckCode.TabIndex = 22;
            // 
            // grpCreditCard
            // 
            this.grpCreditCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCreditCard.Controls.Add(this.label9);
            this.grpCreditCard.Controls.Add(this.txtYear);
            this.grpCreditCard.Controls.Add(this.txtCvc);
            this.grpCreditCard.Controls.Add(this.label8);
            this.grpCreditCard.Controls.Add(this.label3);
            this.grpCreditCard.Controls.Add(this.txtCardNumber);
            this.grpCreditCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.grpCreditCard.Location = new System.Drawing.Point(630, 190);
            this.grpCreditCard.Name = "grpCreditCard";
            this.grpCreditCard.Size = new System.Drawing.Size(198, 325);
            this.grpCreditCard.TabIndex = 16;
            this.grpCreditCard.TabStop = false;
            this.grpCreditCard.Text = "Please Enter Payment Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Expiration Year:";
            // 
            // txtCvc
            // 
            this.txtCvc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtCvc.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCvc.ForeColor = System.Drawing.Color.White;
            this.txtCvc.Location = new System.Drawing.Point(6, 202);
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(169, 33);
            this.txtCvc.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "CVC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtCardNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCardNumber.ForeColor = System.Drawing.Color.White;
            this.txtCardNumber.Location = new System.Drawing.Point(6, 119);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(169, 33);
            this.txtCardNumber.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtProductQuantity);
            this.groupBox1.Controls.Add(this.ProductQuantity);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtProductFeatures);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPType);
            this.groupBox1.Controls.Add(this.txtPprice);
            this.groupBox1.Controls.Add(this.txtTradeMark);
            this.groupBox1.Controls.Add(this.txtPModel);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 593);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Enter Product Quantity";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtProductQuantity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductQuantity.ForeColor = System.Drawing.Color.White;
            this.txtProductQuantity.Location = new System.Drawing.Point(247, 516);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(169, 33);
            this.txtProductQuantity.TabIndex = 26;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoSize = true;
            this.ProductQuantity.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductQuantity.Location = new System.Drawing.Point(2, 514);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(221, 30);
            this.ProductQuantity.TabIndex = 25;
            this.ProductQuantity.Text = "Product Quantity:";
            this.ProductQuantity.Click += new System.EventHandler(this.ProductQuantity_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(31, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 30);
            this.label12.TabIndex = 24;
            this.label12.Text = "Features :";
            // 
            // txtProductFeatures
            // 
            this.txtProductFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtProductFeatures.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductFeatures.ForeColor = System.Drawing.Color.White;
            this.txtProductFeatures.Location = new System.Drawing.Point(247, 311);
            this.txtProductFeatures.Multiline = true;
            this.txtProductFeatures.Name = "txtProductFeatures";
            this.txtProductFeatures.Size = new System.Drawing.Size(169, 188);
            this.txtProductFeatures.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "Price :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(247, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 33);
            this.txtID.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "TradeMark :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "ProductType :";
            // 
            // txtPType
            // 
            this.txtPType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtPType.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPType.ForeColor = System.Drawing.Color.White;
            this.txtPType.Location = new System.Drawing.Point(247, 101);
            this.txtPType.Name = "txtPType";
            this.txtPType.Size = new System.Drawing.Size(169, 33);
            this.txtPType.TabIndex = 7;
            // 
            // txtPprice
            // 
            this.txtPprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtPprice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPprice.ForeColor = System.Drawing.Color.White;
            this.txtPprice.Location = new System.Drawing.Point(247, 259);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(169, 33);
            this.txtPprice.TabIndex = 10;
            // 
            // txtTradeMark
            // 
            this.txtTradeMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtTradeMark.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTradeMark.ForeColor = System.Drawing.Color.White;
            this.txtTradeMark.Location = new System.Drawing.Point(247, 159);
            this.txtTradeMark.Name = "txtTradeMark";
            this.txtTradeMark.Size = new System.Drawing.Size(169, 33);
            this.txtTradeMark.TabIndex = 8;
            // 
            // txtPModel
            // 
            this.txtPModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtPModel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPModel.ForeColor = System.Drawing.Color.White;
            this.txtPModel.Location = new System.Drawing.Point(247, 209);
            this.txtPModel.Name = "txtPModel";
            this.txtPModel.Size = new System.Drawing.Size(169, 33);
            this.txtPModel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1066, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "  BUY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbtnCreditCart
            // 
            this.rdbtnCreditCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnCreditCart.AutoSize = true;
            this.rdbtnCreditCart.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnCreditCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.rdbtnCreditCart.Location = new System.Drawing.Point(659, 142);
            this.rdbtnCreditCart.Name = "rdbtnCreditCart";
            this.rdbtnCreditCart.Size = new System.Drawing.Size(136, 26);
            this.rdbtnCreditCart.TabIndex = 21;
            this.rdbtnCreditCart.TabStop = true;
            this.rdbtnCreditCart.Text = "Credit Card";
            this.rdbtnCreditCart.UseVisualStyleBackColor = true;
            this.rdbtnCreditCart.CheckedChanged += new System.EventHandler(this.rdbtnCreditCart_CheckedChanged);
            // 
            // rdbtnCheck
            // 
            this.rdbtnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnCheck.AutoSize = true;
            this.rdbtnCheck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.rdbtnCheck.Location = new System.Drawing.Point(873, 141);
            this.rdbtnCheck.Name = "rdbtnCheck";
            this.rdbtnCheck.Size = new System.Drawing.Size(89, 26);
            this.rdbtnCheck.TabIndex = 22;
            this.rdbtnCheck.TabStop = true;
            this.rdbtnCheck.Text = "Check";
            this.rdbtnCheck.UseVisualStyleBackColor = true;
            this.rdbtnCheck.CheckedChanged += new System.EventHandler(this.rdbtnCheck_CheckedChanged);
            // 
            // rdbtnCash
            // 
            this.rdbtnCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnCash.AutoSize = true;
            this.rdbtnCash.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.rdbtnCash.Location = new System.Drawing.Point(1084, 143);
            this.rdbtnCash.Name = "rdbtnCash";
            this.rdbtnCash.Size = new System.Drawing.Size(75, 26);
            this.rdbtnCash.TabIndex = 23;
            this.rdbtnCash.TabStop = true;
            this.rdbtnCash.Text = "Cash";
            this.rdbtnCash.UseVisualStyleBackColor = true;
            this.rdbtnCash.CheckedChanged += new System.EventHandler(this.rdbtnCash_CheckedChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(656, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(282, 30);
            this.label14.TabIndex = 25;
            this.label14.Text = "Choose Payment Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(705, 698);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "label16";
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1066, 669);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "label15";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYear.ForeColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(6, 292);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(169, 33);
            this.txtYear.TabIndex = 21;
            // 
            // FormBuyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 799);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rdbtnCash);
            this.Controls.Add(this.rdbtnCheck);
            this.Controls.Add(this.rdbtnCreditCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpCash);
            this.Controls.Add(this.grpCheck);
            this.Controls.Add(this.grpCreditCard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuyCustomer";
            this.Text = "FormBuyCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBuyCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpCash.ResumeLayout(false);
            this.grpCash.PerformLayout();
            this.grpCheck.ResumeLayout(false);
            this.grpCheck.PerformLayout();
            this.grpCreditCard.ResumeLayout(false);
            this.grpCreditCard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdbtnCargo;
        private System.Windows.Forms.GroupBox grpCash;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox grpCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheckBankName;
        private System.Windows.Forms.TextBox txtCheckCode;
        private System.Windows.Forms.GroupBox grpCreditCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProductFeatures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPType;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.TextBox txtTradeMark;
        private System.Windows.Forms.TextBox txtPModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbtnCreditCart;
        private System.Windows.Forms.RadioButton rdbtnCheck;
        private System.Windows.Forms.RadioButton rdbtnCash;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rdbtnHandDelivery;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label ProductQuantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtYear;
    }
}