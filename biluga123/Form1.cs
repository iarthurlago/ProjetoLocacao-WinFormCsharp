using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Locacao
{
    public partial class Form1 : Form
    {
        // 1.lista aqui fora para guardar os dados na memória do Form de Clientes
        List<Cliente> ClienteList = new List<Cliente>();
        //List<Cliente> ContactList = new List<Cliente>();
        // 2.lista aqui fora para guardar os dados na memória do Form de Itens
        List<Item> ItemList = new List<Item>();
        //List <Item>ValueList = new List<Item>();
        List<Locacao> LocacaoList = new List<Locacao>();
        //lista para a listBox de locações saiba exatamente qual linha o usuário clicou para devolver
        List<Locacao> locacoesAtivasExibidas = new List<Locacao>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Dados
            string nameType = textBox1.Text;
            string ContactType = textBox2.Text;

            if (!string.IsNullOrEmpty(nameType) && !string.IsNullOrEmpty(ContactType))
            {
                Cliente novoCliente = new Cliente { Name = nameType, Contact = ContactType };
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
                AtualizarTelaClientes();

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
        private void AtualizarTelaClientes()
        {
            // 1. Limpa o que estava na tela antes
            listBox1.Items.Clear();
            comboBoxClientes.Items.Clear(); // ✨ ADICIONE ISSO: Limpa a caixinha de seleção da Aba 3

            // 2. Passa de cliente em cliente na memória
            foreach (Cliente c in ClienteList)
            {
                // Coloca o cliente na lista visual da Aba 1
                listBox1.Items.Add($"{c.Name} - {c.Contact}");

                // ✨ ADICIONE ISSO: Coloca o nome do cliente na caixinha de seleção da Aba 3!
                comboBoxClientes.Items.Add(c.Name);
            }
        }

        // ==================== ABA 2: ITENS ====================
        private async void button2_Click(object sender, EventArgs e)
        {
            //Dados
            string nameItem = textBox5.Text;
            decimal valorDiaria;

            // Valida se o nome não está vazio e se o valor digitado no textBox3 é um número válido
            if (!string.IsNullOrEmpty(nameItem) && decimal.TryParse(textBox3.Text, out valorDiaria))
            {
                Item novoItem = new Item { NameI = nameItem, ValueI = valorDiaria };
                novoItem.CadastrarItem(ItemList);


                //Fields and customs
                button2.Enabled = false;
                MessageBox.Show("Você cadastrou o item: " + nameItem + Environment.NewLine + "Valor digitado: " + valorDiaria);

                textBox5.Clear();
                textBox3.Clear();
                AtualizarTelaItens();

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

        private void SandyAtualizarTelaItens() // AtualizarTelaI
        {
            // 1. Limpa o que estava na tela antes
            listBox2.Items.Clear();
            comboBoxItens.Items.Clear(); // ✨ ADICIONE ISSO: Limpa a caixinha de seleção da Aba 3

            // 2. Passa de item em item na memória
            foreach (Item item in ItemList)
            {
                // Coloca o item na lista visual da Aba 2
                listBox2.Items.Add($"{item.NameI} - {item.ValueI:C} / dia");

                // ✨ ADICIONE ISSO: Coloca o nome do item na caixinha de seleção da Aba 3!
                comboBoxItens.Items.Add(item.NameI);
            }
        }

        private void AtualizarTelaItens() => SandyAtualizarTelaItens();

        // ==================== ABA 3: LOCAÇÕES (Para você associar aos seus controles) ====================
        private void RegistrarNovaLocacao(Cliente cliente, Item item, DateTime inicio, DateTime fim)
        {
            Locacao novaLocacao = new Locacao
            {
                ClienteLocacao = cliente,
                ItemLocacao = item,
                DataRetirada = inicio,
                DataPrevistaDevolucao = fim,
                DataDevolucao = null // Nova locação entra como ativa
            };

            LocacaoList.Add(novaLocacao);

            decimal valorTotal = novaLocacao.CalcularValorTotal();
            MessageBox.Show($"Locação realizada!{Environment.NewLine}Total estimado: {valorTotal:C}");

            AtualizarTelaLocacoes();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Validação: Verifica se o usuário realmente selecionado um cliente e um item nos Comboboxes
            if (comboBoxClientes.SelectedIndex == -1 || comboBoxItens.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um Cliente e um Item antes de alugar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Procura os objetos reais nas listas usando a posição (índice) que o usuário clicou na tela
            Cliente clienteSelecionado = ClienteList[comboBoxClientes.SelectedIndex];
            Item itemSelecionado = ItemList[comboBoxItens.SelectedIndex];

            // 3. Pega as datas que o usuário escolheu nos calendários (DateTimePicker)
            DateTime dataInicio = dateTimePickerInicio.Value;
            DateTime dataFim = dateTimePickerFim.Value;

            // 4. Chama o método de registro que criamos antes!
            RegistrarNovaLocacao(clienteSelecionado, itemSelecionado, dataInicio, dataFim);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou alguma locação na lista para devolver
            if (listBox3.SelectedIndex != -1)
            {
                // Encontra a locação correspondente que foi clicada
                Locacao locacaoSelecionada = locacoesAtivasExibidas[listBox3.SelectedIndex];

                // Registra a devolução colocando a data de hoje (deixa de ser Ativa!)
                locacaoSelecionada.DataDevolucao = DateTime.Now;

                MessageBox.Show("Devolução registrada com sucesso! O item foi devolvido.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarrega a tela. Como ela não é mais ativa, ela vai sumir da listagem!
                AtualizarTelaLocacoes();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma locação ativa na lista para realizar a devolução.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chame este método para listar apenas as locações que ainda estão ativas (requisito do briefing)
        private void AtualizarTelaLocacoes()
        {
            listBox3.Items.Clear();       // Limpa o visual da lista na tela
            locacoesAtivasExibidas.Clear();      // Limpa o nosso controle interno

            foreach (Locacao loc in LocacaoList)
            {
                // Critério de Aceite: Só mostra se a locação estiver ATIVA (sem data de devolução)
                if (loc.Ativa)
                {
                    locacoesAtivasExibidas.Add(loc); // Guarda a referência dela    

                    // Calcula o valor estimado para mostrar na listagem
                    decimal valorEstimado = loc.CalcularValorTotal();

                    listBox3.Items.Add($"{loc.ClienteLocacao.Name} -> {loc.ItemLocacao.NameI} (Total: {valorEstimado:C})");
                }
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
        //private void AtualizarTela()
        //{
        //    // PASSO CRUCIAL: Limpa a ListBox antes de redesenhar.
        //    // Se não fizermos isso, toda vez que clicarmos no botão, 
        //    // os nomes antigos seriam duplicados na tela.
        //    listBox1.Items.Clear();


        //    foreach (Cliente clienteSalvo in ClienteList)
        //    {
        //        // Aqui sim você junta os dados para mostrar para o usuário!
        //        string textoParaExibir = clienteSalvo.Name + " - " + clienteSalvo.Contact;
        //        listBox1.Items.Add(textoParaExibir);
        //    }

        //    foreach (Cliente contatinho in ContactList)
        //    {
        //        // ...e adiciona na ListBox da tela!
        //        listBox1.Items.Add(contatinho);
        //    }

        //}

        //private void AtualizarTelaI()
        //{
        //    // PASSO CRUCIAL: Limpa a ListBox antes de redesenhar.
        //    // Se não fizermos isso, toda vez que clicarmos no botão, 
        //    // os nomes antigos seriam duplicados na tela.
        //    listBox2.Items.Clear();

        //    // Passa de item em item da nossa lista da memória...
        //    foreach (Item itens in ItemList)
        //    {
        //        // ...e adiciona na ListBox da tela!
        //        string textoParaExibirI = itens.NameI + " - " + itens.ValueI;
        //        listBox2.Items.Add(textoParaExibirI);

        //    }
        //    foreach (Item itenzinhos in ValueList)
        //    {
        //        // ...e adiciona na ListBox da tela!
        //        listBox1.Items.Add(itenzinhos);
        //    }

        //}

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
