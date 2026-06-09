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
            //Fields and customs
            button1.Enabled = false;
            label3.Text = "✔";
            label4.Text = "✔";
            label5.Text = "Cadastrado com Sucesso!";
            label5.ForeColor = Color.Green;

            //Dados
            string nameType = textBox1.Text;
           

            if (!string.IsNullOrEmpty(nameType))
            {
                ClienteList.Add(nameType);
                MessageBox.Show("Você cadastrou o cliente: " + nameType);
                textBox1.Clear();
                textBox2.Clear();

            }
            else
            {
                // Se estiver vazio, avisa o usuário
                MessageBox.Show("Por favor, informe nome na caixa de texto.");
            }

            if (int.TryParse(textBox1.Text, out int ContactType))
            {
                MessageBox.Show($"Número digitado: {ContactType}");
            }

            else
            {
                // Se estiver vazio, avisa o usuário
                MessageBox.Show("Por favor, informe seu telefone na caixa de texto.");
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
    }
}
