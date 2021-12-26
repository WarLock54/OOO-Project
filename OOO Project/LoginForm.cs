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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=OOOProjects;Integrated Security=True");
        public void EnterSelect()
        {
            if (rdbtnCustomer.Checked == true)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From CustomerLogin Where CustomerUserID=@p1 and CustomerPassword=@p2", connection);
                FormCustomerProfile formmusteri = new FormCustomerProfile();
                command.Parameters.AddWithValue("@p1", txtUserName.Text);
                command.Parameters.AddWithValue("@p2", txtPassword.Text);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    FormCustomerProfile CustomerProfile = new FormCustomerProfile();
                    CustomerProfile.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali Kullanici Adi veya Şifre");
                }
                connection.Close(); 
            }
            if (rdbtnOwner.Checked == true)
            {
                connection.Open();
                SqlCommand commandCustomer = new SqlCommand("Select * From CompanyLogin Where CompanyLoginID=@l1,CompanyPassword=@l2", connection);
                FormOwnnerControlPanel OwnerPanel = new FormOwnnerControlPanel();
                commandCustomer.Parameters.AddWithValue("@l1", txtUserName.Text);
                commandCustomer.Parameters.AddWithValue("@l2", txtPassword.Text);

                OwnerPanel.Show();
                this.Hide();
            }
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            EnterSelect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCustomerSave CustomerSave = new FormCustomerSave();
            CustomerSave.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
