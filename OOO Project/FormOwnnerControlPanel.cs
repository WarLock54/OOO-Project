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
    public partial class FormOwnnerControlPanel : Form
    {
        public FormOwnnerControlPanel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=THEKUMRAL;Initial Catalog=OOOProjects;Integrated Security=True");
        void StaffSave()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into ProductQuantity (ProductType,TradeMark,Model,Price,ProductsFeatures) values (@p1,@p2,@p3,@p4,@p5)", connection);
            command.Parameters.AddWithValue("@p1", txtPType.Text);
            command.Parameters.AddWithValue("@p2", txtTradeMark.Text);
            command.Parameters.AddWithValue("@p3", txtPModel.Text);
            command.Parameters.AddWithValue("@p4", txtPprice.Text);
            command.Parameters.AddWithValue("@p5", txtPFeatures.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Eklendi!!!", "Başarıyla Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void UpdateProduct()
        {
            connection.Open();
            SqlCommand CommandUpdate = new SqlCommand("Update ProductQuantity Set ProductType=@a2,TradeMark=@a3,Model=@a4,Price=@a5,ProductsFeatures=@a6 Where ProductId=@a1", connection);
            CommandUpdate.Parameters.AddWithValue("@a2", txtPType.Text);
            CommandUpdate.Parameters.AddWithValue("@a3", txtTradeMark.Text);
            CommandUpdate.Parameters.AddWithValue("@a4", txtPModel.Text);
            CommandUpdate.Parameters.AddWithValue("@a5", txtPprice.Text);
            CommandUpdate.Parameters.AddWithValue("@a6", txtPFeatures.Text);
            CommandUpdate.Parameters.AddWithValue("@a1", txtID.Text);
            CommandUpdate.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarıyla Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void Delete()
        {
            connection.Open();
            SqlCommand commandDelet = new SqlCommand("Delete From ProductQuantity Where ProductId=@k1", connection);
            commandDelet.Parameters.AddWithValue("k1", txtID.Text);
            commandDelet.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarıyla Silindi", "Tebriksler", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void FormOwnnerControlPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oOOProjectsDataSet.ProductQuantity' table. You can move, or remove it, as needed.
            this.productQuantityTableAdapter.Fill(this.oOOProjectsDataSet.ProductQuantity);
            // TODO: DataGridView Product İnformation Table
            this.productQuantityTableAdapter.Fill(this.oOOProjectsDataSet.ProductQuantity);
            
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVProductControlPanel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SecilenDeger = DGVProductControlPanel.SelectedCells[0].RowIndex;
            txtID.Text = DGVProductControlPanel.Rows[SecilenDeger].Cells[0].Value.ToString();
            txtPType.Text = DGVProductControlPanel.Rows[SecilenDeger].Cells[1].Value.ToString();
            txtTradeMark.Text = DGVProductControlPanel.Rows[SecilenDeger].Cells[2].Value.ToString();
            txtPModel.Text = DGVProductControlPanel.Rows[SecilenDeger].Cells[3].Value.ToString();
            txtPprice.Text = DGVProductControlPanel.Rows[SecilenDeger].Cells[4].Value.ToString();
            txtPFeatures.Text = DGVProductControlPanel.Rows[SecilenDeger].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffSave();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            this.productQuantityTableAdapter.Fill(this.oOOProjectsDataSet.ProductQuantity);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
