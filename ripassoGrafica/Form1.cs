namespace ripassoGrafica
{
    public partial class Form1 : Form
    {
        string Nome = "cristian bertoli";
        string Password = "Cristian.2009!"
        string Mail = "bertolicristian65@gmail.com";
        public Form1()
        {
            InitializeComponent();
        }

        private void utente_TextChanged(object sender, EventArgs e)
        {
            string dato1 = utente.Text;
            accesso.Visible = false;
            errore.Visible = false;
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            string dato2 = pass.Text;
        }

        private void gmail_TextChanged(object sender, EventArgs e)
        {
            string dato3 = gmail.Text;
        }

        private void accedi_Click(object sender, EventArgs e)
        {
            if (dato1 == Nome && dato2 == Password && dato3 == Mail)
            {
                accesso.Visible = true;
            }

            else
            {
                errore.Visible = true;
            }
        }
    }
}
