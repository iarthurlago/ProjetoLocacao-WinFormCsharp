using System.Runtime.CompilerServices;

namespace Locacao
{
    public partial class Form1 : Form
    {
        // 1.lista aqui fora para guardar os dados na memória do Form
        List<string> ClienteList = new List<string>();
        List<long> ContactList = new List<long>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Dados
            string nameType = textBox1.Text;
            Int64 ContactType;

            if (!string.IsNullOrEmpty(nameType) && Int64.TryParse(textBox2.Text, out ContactType))
            {

                string clienteCompleto = nameType + " - " + ContactType;
                ClienteList.Add(clienteCompleto);

                //Fields and customs
                button1.Enabled = false;
                label3.Text = "✔";
                label4.Text = "✔";
                label5.Text = "Cadastrado com Sucesso!";
                label5.ForeColor = Color.Green;
                MessageBox.Show("Você cadastrou o cliente: " + nameType + Environment.NewLine + "Número digitado: " + ContactType);
                textBox1.Clear();
                textBox2.Clear();
                AtualizarTela();

                //await pra evitar miss click
                await Task.Delay(2000);
                button1.Enabled = true;
                label5.Text = "Pronto para um novo cadastro.";
                label5.ForeColor = Color.Black;
                // Criando o objeto e passando o texto dos inputs direto para o construtor

                Cliente novoCliente = new Cliente { Name = textBox1.Text, Contact = textBox2.Text };

            }
            else
            {
                // Se estiver vazio, avisa o usuário
                MessageBox.Show("Nome ou Contato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarTela()
        {
            // PASSO CRUCIAL: Limpa a ListBox antes de redesenhar.
            // Se não fizermos isso, toda vez que clicarmos no botão, 
            // os nomes antigos seriam duplicados na tela.
            listBox1.Items.Clear();

            // Passa de item em item da nossa lista da memória...
            foreach (string cliente in ClienteList)
            {
                // ...e adiciona na ListBox da tela!
                listBox1.Items.Add(cliente);

            }
            foreach (int contatinho in ContactList)
            {
                // ...e adiciona na ListBox da tela!
                listBox1.Items.Add(contatinho);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
