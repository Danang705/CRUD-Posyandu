using Microsoft.Win32.SafeHandles;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CRUD_Posyandu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 liatData = new Form2();
            liatData.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NamaAnak_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            string nama = NamaAnak.Text;
            string gender = GenderBox.Text;
            string tgl = tglLahir.Text;
            string ibu = NamaIbu.Text;

            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=12345;Database=pbo_task10") ;

            {
                conn.Open();



                if (this.Text == "Mode Edit" )
                {

                    string id = this.Tag.ToString();
                    string sql = @"UPDATE PesertaPosyandu SET Nama = @nama, Gender = @gender, TanggalLahir = @tgl, NamaIbu = @ibu WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))

                    {
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("gender", gender);
                        cmd.Parameters.AddWithValue("tgl", tgl);
                        cmd.Parameters.AddWithValue("ibu", ibu);
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(this.Tag));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diperbarui!");
                    }
                }

                else
                {

                    string sql = @"INSERT INTO PesertaPosyandu (Nama, Gender, TanggalLahir, NamaIbu) VALUES (@nama, @gender, @tgl, @ibu)";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    {
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("gender", gender);
                        cmd.Parameters.AddWithValue("tgl", tgl);
                        cmd.Parameters.AddWithValue("ibu", ibu);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diinput", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }

            




        }
    }
}
