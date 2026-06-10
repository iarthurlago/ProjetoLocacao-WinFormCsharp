using System.Runtime.CompilerServices;

namespace Locacao
{
    public partial class Form1 : Form
    {
        // 1.lista aqui fora para guardar os dados na memória do Form
        List<string> ClienteList = new List<string>();
        List<int> ContactList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dados
            string nameType = textBox1.Text;
            int pass = 0;

            if (!string.IsNullOrEmpty(nameType))
            {
                ClienteList.Add(nameType);

                pass += 1;
            }
            else
            {
                // Se estiver vazio, avisa o usuário
                MessageBox.Show("Por favor, informe nome na caixa de texto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (Int64.TryParse(textBox2.Text, out Int64 ContactType))
            {

                pass += 1;
            }
            else
            {
                // Se estiver vazio, avisa o usuário
                MessageBox.Show("Por favor, informe seu telefone na caixa de texto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (pass == 2)
            {
                //Fields and customs
                button1.Enabled = false;
                label3.Text = "✔";
                label4.Text = "✔";
                label5.Text = "Cadastrado com Sucesso!";
                label5.ForeColor = Color.Green;
                MessageBox.Show("Você cadastrou o cliente: " + nameType + Environment.NewLine + "Número digitado: " + ContactType);
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                label5.Text = "Seu Nome ou Telefone estão incorretos";
                label5.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FieldName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
