namespace App07
{
    public partial class Form1 : Form
    {
        App06.Utili funzioni = new App06.Utili();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCifra_Click(object sender, EventArgs e)
        {
            txtCifrato.Text = funzioni.Cifra(TxtOriginale.Text, 1);
        }

        private void btnDecifra_Click(object sender, EventArgs e)
        {
            TxtOriginale.Text = funzioni.Cifra(txtCifrato.Text, -1);
        }
    }
}
