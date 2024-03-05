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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection dbconnection = new SqlConnection("Data Source=LAPTOP-VKUUP6M9;Initial Catalog=PersonelDb;Persist Security Info=True;User ID=sa;Password=123456;TrustServerCertificate=True");

        void clear()
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            CmbCity.Text = "";
            TxtWage.Text = "";
            RdMarried.Checked = true;
            TxtJob.Text = "";
            TxtName.Focus();
        }         

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDbDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelDbDataSet.Tbl_Personel);

        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            dbconnection.Open();
            SqlCommand command = new SqlCommand("insert into Tbl_Personel (Perad,Persoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@name,@surname,@city,@wage,@status,@job)", dbconnection);
            command.Parameters.AddWithValue("@name", TxtName.Text);
            command.Parameters.AddWithValue("@surname", TxtSurname.Text);
            command.Parameters.AddWithValue("@city", CmbCity.Text);
            command.Parameters.AddWithValue("@wage", TxtWage.Text);
            command.Parameters.AddWithValue("@status", CheckedStatus.Text);
            command.Parameters.AddWithValue("@job", TxtJob.Text);
            command.ExecuteNonQuery();
            dbconnection.Close();
            MessageBox.Show("Personel Eklendi.");

        }

        private void RdMarried_CheckedChanged(object sender, EventArgs e)
        {
            CheckedStatus.Text = "True";
        }

        private void RdSingle_CheckedChanged(object sender, EventArgs e)
        {
            CheckedStatus.Text = "False";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDbDataSet.Tbl_Personel);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex; // secili hücrelerden 0. indexteki hücreyi al.
            TxtId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbCity.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            TxtWage.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            if (dataGridView1.Rows[selected].Cells[5].Value.ToString() == "True")
            {
                RdMarried.Checked = true;
            }
            else
            {
                RdSingle.Checked = true;
            }
            TxtJob.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string personalId = TxtId.Text;
            dbconnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Tbl_Personel WHERE Perid = @id", dbconnection);
            command.Parameters.AddWithValue("@id", personalId);
            command.ExecuteNonQuery();
            dbconnection.Close();
            clear();
            MessageBox.Show("Personel Silindi.");


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string personalId = TxtId.Text;
            dbconnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Tbl_Personel SET Perad = @name, Persoyad = @surname, PerSehir = @city, PerMaas = @wage, PerDurum = @status, PerMeslek = @job WHERE Perid = @id", dbconnection);
            command.Parameters.AddWithValue("@id", TxtId.Text);
            command.Parameters.AddWithValue("@name", TxtName.Text);
            command.Parameters.AddWithValue("@surname", TxtSurname.Text);
            command.Parameters.AddWithValue("@city", CmbCity.Text);
            command.Parameters.AddWithValue("wage", TxtWage.Text);
            if (CheckedStatus.Text == "True")
            {
                command.Parameters.AddWithValue("@status", true);
            }
            else
            {
                command.Parameters.AddWithValue("@status", false);

            }
            command.Parameters.AddWithValue("@job", TxtJob.Text);
            command.ExecuteNonQuery();
            dbconnection.Close();
            MessageBox.Show("Personel Güncellendi.");

        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            
            Frmstatistic statisticfrm = new Frmstatistic();
            statisticfrm.Show();

            
        }

        private void BtnGraphic_Click(object sender, EventArgs e)
        {
            Frmgraphic graphicfrm = new Frmgraphic();
            graphicfrm.Show();

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {

            FrmReport reportfrm = new FrmReport();
            reportfrm.Show();   
        }
    }
}
