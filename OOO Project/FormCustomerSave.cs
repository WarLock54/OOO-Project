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
    public partial class FormCustomerSave : Form
    {
        public FormCustomerSave()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=OOOProjects;Integrated Security=True");
        public void CustomerSave()
        {
            Customer customer = new Customer();
            customer.Name = txtbxCustName.Text;
            customer.Surname = txtbxCustSurname.Text;
            customer.PhoneNumber = Convert.ToDouble(txtbxCustPNumber.Text);
            customer.Adress = Convert.ToString(txtbxCustAdress.Text);
            customer.UserID = txtBxCustomerLogin.Text;
            customer.Password = txtbxCustomerLogPassword.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CustomerInformation (CustomerName,CustomerSurname,CustomerAdress,CustomerPhnNmbr) values (@c2,@c3,@c4,@c5) ", connection);
            command.Parameters.AddWithValue("@c2", customer.Name);
            command.Parameters.AddWithValue("@c3", customer.Surname);
            command.Parameters.AddWithValue("@c4", customer.Adress); // string karakterin belli siniri var !!
            command.Parameters.AddWithValue("@c5", customer.PhoneNumber);
            command.ExecuteNonQuery();

            SqlCommand commandLogin = new SqlCommand("insert into CustomerLogin (CustomerUserID,CustomerPassword) values (@l1,@l2)", connection);
            commandLogin.Parameters.AddWithValue("@l1", customer.UserID);
            commandLogin.Parameters.AddWithValue("@l2", customer.Password);
            commandLogin.ExecuteNonQuery();
            connection.Close();
            SuccesfulySave();
        }
        public void SuccesfulySave()
        {
            MessageBox.Show("Başarıyla Kaydedildi !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
