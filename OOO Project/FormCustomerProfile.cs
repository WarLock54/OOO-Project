using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Project
{
    public partial class FormCustomerProfile : Form
    {
        public FormCustomerProfile()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        { //normalde burada item sınıfının product id isini kullanmayı düşünüyoduk
          //ama form değiştirirken sürekli 0 olarak değeri dönderdi ve bu çözümü bulduk 
            FormBuyCustomer buycostomer = new FormBuyCustomer();
            buycostomer.label16.Text= txtBuyProductID.Text;
            buycostomer.ShowDialog();
            this.Hide();
        }

        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {
            this.productQuantityTableAdapter.Fill(this.productQuantitys1.ProductQuantity);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
