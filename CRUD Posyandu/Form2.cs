using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CRUD_Posyandu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost; Username=postgres; Password=12345; Database=pbo_task10");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT Id, Nama, TanggalLahir, Gender, NamaIbu from PesertaPosyandu";


            NpgsqlDataReader read = comm.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(read);
            dataGridView1.DataSource = data;






        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Salah Satu Baris Untuk Mengubah Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var warn = MessageBox.Show("Yakin Ingin Merubah Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                var row = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["id"].Value);

                Form1 ubahForm = new Form1();
                ubahForm.Tag = id;
                ubahForm.Text = "Mode Edit"; // pakai judul form sebagai penanda mode

                ubahForm.Show();
                this.Hide();
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var caution = MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (caution == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih Baris Yang Ingin Dihapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deleteindex = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=12345;Database=pbo_task10");
                    {
                        conn.Open();
                        string query = "DELETE FROM PesertaPosyandu WHERE id = @id";
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("id", deleteindex);
                            int affectedRows = cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil dihapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Rows.Remove(selectedRow);
                        }
                    }
                }
            }
        }
    }
}
