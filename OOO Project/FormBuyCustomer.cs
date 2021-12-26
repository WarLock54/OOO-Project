using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOO_Project
{
    public partial class FormBuyCustomer : Form
    {
        public FormBuyCustomer()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=OOOProjects;Integrated Security=True");
        public void ProductInfo()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From ProductQuantity Where ProductId like'" + txtID.Text + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtPType.Text = read["ProductType"].ToString();
                txtTradeMark.Text = read["TradeMark"].ToString();
                txtPModel.Text = read["Model"].ToString();
                txtPprice.Text = read["Price"].ToString();
                txtProductFeatures.Text = read["ProductsFeatures"].ToString();
            }
            connection.Close();
        }
        public void CreditCardSave()
        {
            CreditCardPayment cardPayment = new CreditCardPayment();
            cardPayment.CardNumber = Convert.ToDouble(txtCardNumber.Text);
            cardPayment.Cvc = Convert.ToInt32(txtCvc.Text);
            cardPayment.year = Convert.ToInt32(txtYear.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CreditCardinfo (CardNumber,Cvc,ExpirationDate) values (@c2,@c3,@c4) ", connection);
            command.Parameters.AddWithValue("@c2", cardPayment.CardNumber);
            command.Parameters.AddWithValue("@c3", cardPayment.Cvc);
            command.Parameters.AddWithValue("@c4", cardPayment.year);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void CheckSave()
        {
            CheckPayment chech = new CheckPayment();
            chech.BankName = txtCheckBankName.Text;
            chech.CheckCode = Convert.ToInt32(txtCheckCode.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Checkinfo (BankName,CheckCode) values (@c2,@c3) ", connection);
            command.Parameters.AddWithValue("@c2", chech.BankName);
            command.Parameters.AddWithValue("@c3", chech.CheckCode);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void DeliveryFormat()
        {
            if (rdbtnCargo.Checked == true)
            {
                MessageBox.Show("Your Product has been sent to your address by courier\n", "Succesfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbtnHandDelivery.Checked == true)
            {
                MessageBox.Show("You can come and get your product from our company.\n", "Succesfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormBuyCustomer_Load(object sender, EventArgs e)
        {
            txtID.Text = label16.Text;
            ProductInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void rdbtnCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCheck.Checked == true)
            {
                grpCheck.Enabled = true;
                grpCash.Enabled = false;
                grpCreditCard.Enabled = false;
            }
            
        }

        private void rdbtnCreditCart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCreditCart.Checked == true)
            {
                grpCreditCard.Enabled = true;
                grpCheck.Enabled = false;
                grpCash.Enabled = false;
            }
            
            
        }

        private void rdbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCash.Checked == true)
            {
                grpCash.Enabled = true;
                grpCheck.Enabled = false;
                grpCreditCard.Enabled = false;
            }
        }

        private void rdbtnCargo_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnHandDelivery.Enabled = false;
        }

        private void rdbtnHandDelivery_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnCargo.Enabled = false;
        }
        CashPayment cash = new CashPayment();
        CreditCardPayment credit = new CreditCardPayment();
        CheckPayment check = new CheckPayment();
        private int g;
        private int h;

        private void button1_Click(object sender, EventArgs e)
        {
            g = Convert.ToInt32(txtPprice.Text);
            h = Convert.ToInt32(txtProductQuantity.Text);
            DeliveryFormat();
            if (rdbtnCash.Checked == true)
            {
                cash.Pay(g, h);
                cash.PaymentScreen();
                MessageBox.Show(cash.Pay(g, h).ToString() + cash.PaymentScreen()+cash.Stringİnformation1+"\n","Buy Succesfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else if (rdbtnCreditCart.Checked == true)
            {
                credit.Pay(g, h);
               credit.PaymentScreen();
                MessageBox.Show(credit.Pay(g, h).ToString() +"\n"+ credit.PaymentScreen()+credit.Stringİnformation1+"\n", "Buy Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CreditCardSave();
            }
            else if (rdbtnCheck.Checked == true)
            {
               check.Pay(g, h);
                check.PaymentScreen();
                MessageBox.Show(check.Pay(g, h).ToString() + check.PaymentScreen()+check.Stringİnformation1+"\n", "Buy Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error");
        }

        private void ProductQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}
