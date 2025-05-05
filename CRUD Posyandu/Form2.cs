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
            comm.CommandText = "SELECT Id, Nama, Laki_laki, Perempuan, TanggalLahir, NamaIbu from PesertaPosyandu"; 
           

            NpgsqlDataReader read = comm.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(read);
            dataGridView1.DataSource = data;

            




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
