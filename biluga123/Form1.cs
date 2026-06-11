using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Locacao
{
    public partial class Form1 : Form
    {
        // 1.lista aqui fora para guardar os dados na memória do Form de Clientes
        List<Cliente> ClienteList = new List<Cliente>();
        List<Cliente> ContactList = new List<Cliente>();
        // 2.lista aqui fora para guardar os dados na memória do Form de Itens
        List<Item>ItemList = new List<Item>();
        List <Item>ValueList = new List<Item>();
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
                Cliente novoCliente = new Cliente { Name = textBox1.Text, Contact = textBox2.Text };
                novoCliente.CadastrarCliente(ClienteList);


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


            foreach (Cliente clienteSalvo in ClienteList)
            {
                // Aqui sim você junta os dados para mostrar para o usuário!
                string textoParaExibir = clienteSalvo.Name + " - " + clienteSalvo.Contact;
                listBox1.Items.Add(textoParaExibir);
            }

            foreach (Cliente contatinho in ContactList)
            {
                // ...e adiciona na ListBox da tela!
                listBox1.Items.Add(contatinho);
            }

        }

        private void AtualizarTelaI()
        {
            // PASSO CRUCIAL: Limpa a ListBox antes de redesenhar.
            // Se não fizermos isso, toda vez que clicarmos no botão, 
            // os nomes antigos seriam duplicados na tela.
            listBox2.Items.Clear();

            // Passa de item em item da nossa lista da memória...
            foreach (Item itens in ItemList)
            {
                // ...e adiciona na ListBox da tela!
                string textoParaExibirI = itens.NameI + " - " + itens.ValueI;
                listBox2.Items.Add(textoParaExibirI);

            }
            foreach (Item itenzinhos in ValueList)
            {
                // ...e adiciona na ListBox da tela!
                listBox1.Items.Add(itenzinhos);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //Dados
            string nameItem = textBox5.Text;
            Int64 Valor;

            if (!string.IsNullOrEmpty(nameItem) && Int64.TryParse(textBox3.Text, out Valor))
            {
                Item novoItem = new Item { NameI = textBox5.Text, ValueI = Valor};

                novoItem.CadastrarItem(ItemList);


                //Fields and customs
                button2.Enabled = false;
                MessageBox.Show("Você cadastrou o item: " + nameItem + Environment.NewLine + "Valor digitado: " + Valor);
                textBox5.Clear();
                textBox3.Clear();
                AtualizarTelaI();

                //await pra evitar miss click
                await Task.Delay(2000);
                button2.Enabled = true;
               

                
            }
            else
            {
                // Se estiver vazio, avisa o usuário
                MessageBox.Show("Nome ou Valor incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }

        }
    
    }
}
