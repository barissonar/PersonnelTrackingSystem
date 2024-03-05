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

namespace PersonalTrackingSystem
{
    public partial class Frmgraphic : Form
    {
        public Frmgraphic()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection = new SqlConnection("Data Source=LAPTOP-VKUUP6M9;Initial Catalog=PersonelDb;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

        private void Frmgraphic_Load(object sender, EventArgs e)
        {
            dbconnection.Open();
            SqlCommand command = new SqlCommand("SELECT PerSehir, COUNT(*) FROM Tbl_Personel GROUP BY PerSehir",dbconnection);
            SqlDataReader dr1 = command.ExecuteReader();
            while (dr1.Read()) 
            {
                chart1.Series["Sehirler-Psayisi"].Points.AddXY(dr1[0], dr1[1]);
            }
            dbconnection.Close();

            dbconnection.Open();
            SqlCommand command2 = new SqlCommand("SELECT PerMeslek, AVG(PerMaas) FROM Tbl_Personel GROUP BY PerMeslek", dbconnection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read()) 
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            dbconnection.Close();
        }
    }
}
