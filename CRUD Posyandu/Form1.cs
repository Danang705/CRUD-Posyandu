using Npgsql;

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
            var laki = GenderLK.Checked;
            var perempuan = GenderPR.Checked;
            string tgl = tglLahir.Text;
            string ibu = NamaIbu.Text;

            string sql = @"INSERT INTO PesertaPosyandu (Nama, Laki_laki, Perempuan, TanggalLahir, NamaIbu) VALUES (@nama, @laki, @perempuan, @tgl, @ibu)";

            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=12345;Database=pbo_task10");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            {
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("laki",laki);
                cmd.Parameters.AddWithValue("perempuan", perempuan);
                cmd.Parameters.AddWithValue("tgl", tgl);
                cmd.Parameters.AddWithValue("ibu", ibu);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diinput", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
