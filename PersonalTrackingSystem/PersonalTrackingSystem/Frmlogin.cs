using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonalTrackingSystem
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }
        SqlConnection dbconnection = new SqlConnection("Data Source=LAPTOP-VKUUP6M9;Initial Catalog=PersonelDb;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            dbconnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Admin where username=@username and password=@password",dbconnection);
            command.Parameters.AddWithValue("@username", TxtUsername.Text);
            command.Parameters.AddWithValue("@password", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader(); 
            if (dr.Read()) 
            {
                Form1 frmmain = new Form1();
                frmmain.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı kullanıcı Adı veya şifre");
            }
            dbconnection.Close();

        }
    }
}
