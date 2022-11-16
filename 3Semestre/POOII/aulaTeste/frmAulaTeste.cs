namespace aulaTeste
{
    public partial class frmAulaTeste : Form
    {
        public frmAulaTeste()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Codigo C#
            Close();
        }

        private void frmAulaTeste_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNP1.Text = "";
            txtNP2.Text = "";
            txtNP3.Text = "";
            txtNP4.Text = "";
            txtResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Np1;
            double Np2;
            double Np3;
            double Np4;
            double Resultado;

            Np1 = Convert.ToDouble(txtNP1.Text);
            Np2 = Convert.ToDouble(txtNP2.Text);
            Np3 = Convert.ToDouble(txtNP3.Text);
            Np4 = Convert.ToDouble(txtNP4.Text);

            Resultado = (Np1 + Np2 + Np3 + Np4) / 4;

            txtResultado.Text = Convert.ToString(Resultado);

            if(Resultado >= 7)
            {
                MessageBox.Show("Aluno aprovado!");
            }
            else
            {
                MessageBox.Show("Aluno reprovado!");
            }


        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}