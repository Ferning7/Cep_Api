namespace ConsultaCep
{
    public partial class Form1 : Form
    {

        bool mouseDown;
        Point lastLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCep.Text.Equals(""))
                {
                    Endereco endereco = ServerCep.BuscarCep(txtCep.Text);
                    lblMostrarLogradouro.Text = endereco.Logradouro;
                    lblMostrarCidade.Text = endereco.Localidade;
                    lblMostrarBairro.Text = endereco.Bairro;
                    lblMostrarUF.Text = endereco.Uf;
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo de CEP para realizar a busca", "Erro - campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCep.Focus();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Erro ao buscar CEP: " + EX.Message);
                throw;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y
                );

            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
