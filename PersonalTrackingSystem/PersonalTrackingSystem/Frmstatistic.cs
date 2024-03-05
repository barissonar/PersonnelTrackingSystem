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
    public partial class Frmstatistic : Form
    {
        public Frmstatistic()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection = new SqlConnection("Data Source=LAPTOP-VKUUP6M9;Initial Catalog=PersonelDb;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

        private void Frmstatistic_Load(object sender, EventArgs e)
        {
            // Total personal count
            dbconnection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Tbl_Personel", dbconnection);
            SqlDataReader dr1 = command.ExecuteReader();        
            while(dr1.Read())
            {
                LblTotalPersonal.Text = dr1[0].ToString();
            }
            dbconnection.Close();

            // Married personel count

            dbconnection.Open();
            SqlCommand command2 = new SqlCommand("SELECT COUNT (*) FROM Tbl_Personel WHERE PerDurum=1",dbconnection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                LblMarriedPersonal.Text = dr2[0].ToString();

            }
            dbconnection.Close();

            // Single personel count

            dbconnection.Open();
            SqlCommand command3 = new SqlCommand("SELECT COUNT (*) FROM Tbl_Personel WHERE PerDurum=0", dbconnection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                LblSinglePersonal.Text = dr3[0].ToString();

            }
            dbconnection.Close();

            // Different Cities

            dbconnection.Open();
            SqlCommand command4 = new SqlCommand("SELECT COUNT(distinct(PerSehir)) FROM Tbl_Personel", dbconnection);
            SqlDataReader dr4 = command4.ExecuteReader();   
            while (dr4.Read())
            {
                LblCountCity.Text = dr4[0].ToString();
            }
            dbconnection.Close();

            // Personal Total Wage

            dbconnection.Open();
            SqlCommand command5 = new SqlCommand("SELECT SUM(PerMaas) FROM Tbl_Personel", dbconnection);
            SqlDataReader dr5 = command5.ExecuteReader();   
            while (dr5.Read()) 
            { 
               LblTotalWage.Text = dr5[0].ToString() + " ₺";
            }
            dbconnection.Close();

            dbconnection.Open();
            SqlCommand command6 = new SqlCommand("SELECT AVG(PerMaas) FROM Tbl_Personel", dbconnection);
            SqlDataReader dr6 = command6.ExecuteReader();
            while (dr6.Read())
            {
                LblAvg.Text = dr6[0].ToString() + " ₺";
            }
               
            
            



        }

       
    }
}
