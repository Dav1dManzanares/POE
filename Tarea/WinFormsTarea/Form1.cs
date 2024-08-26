namespace WinFormsTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RowsEscribir = dataGridView1.Rows.Count - 1;

            dataGridView1.Rows.Add(1);

            dataGridView1.Rows[RowsEscribir].Cells[0].Value = name.Text;
            dataGridView1.Rows[RowsEscribir].Cells[1].Value = carrera.Text;
            dataGridView1.Rows[RowsEscribir].Cells[2].Value = txtmat.Text;
            dataGridView1.Rows[RowsEscribir].Cells[3].Value = direccion.Text;
            dataGridView1.Rows[RowsEscribir].Cells[4].Value = telefono.Text;
            dataGridView1.Rows[RowsEscribir].Cells[5].Value = correo.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Detalles ob = new Detalles();
            ob.name2.Text = name.Text;
            ob.carrera2.Text = carrera.Text;
            ob.txtmat2.Text = txtmat.Text;
            ob.dirrecion2.Text = direccion.Text;
            ob.telefono2.Text = telefono.Text;
            ob.correo2.Text = correo.Text;

            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name.Text = "";
            carrera.Text = "";
            txtmat.Text = "";
            direccion.Text = "";
            telefono.Text = "";
            correo.Text = "";
        }
    }
}
