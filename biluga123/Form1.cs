using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Locacao
{
    public partial class Form1 : Form
    {
        // Listas que funcionam como nosso banco de dados em memória
        List<Cliente> ClienteList = new List<Cliente>();
        List<Item> ItemList = new List<Item>();
        List<Locacao> LocacaoList = new List<Locacao>();

        // Lista auxiliar para referenciar exatamente as locações listadas na tela
        List<Locacao> locacoesAtivasExibidas = new List<Locacao>();

        int indiceParaEditarCliente = -1;
        int indiceParaEditar = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // ==================== ABA 1: CLIENTES ====================

        // Botão de cadastrar cliente
        private async void button1_Click(object sender, EventArgs e)
        {
            // Coleta os dados digitados
            string nameType = textBox1.Text;
            string ContactType = textBox2.Text;


            // Valida se os campos não estão vazios
            if (!string.IsNullOrEmpty(nameType) && !string.IsNullOrEmpty(ContactType))
            {
                // Atualiza o estado da interface (feedback visual de sucesso)
                button1.Enabled = false;
                label3.Text = "✔";
                label4.Text = "✔";
                label5.Text = "Cadastrado com Sucesso!";
                label5.ForeColor = Color.Green;

                if (indiceParaEditarCliente == -1)
                {
                    // === MODO CADASTRO ===
                    button1.Enabled = false;
                    Cliente novoCliente = new Cliente { Name = nameType, Contact = ContactType };
                    novoCliente.CadastrarCliente(ClienteList);
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                {
                    // === MODO EDIÇÃO ===
                    Cliente clienteAtual = ClienteList[indiceParaEditarCliente];
                    clienteAtual.Name = nameType;
                    clienteAtual.Contact = ContactType;

                    MessageBox.Show("Cadastro atualizado com sucesso!");

                    // Reseta o botão para o modo cadastro
                    indiceParaEditarCliente = -1;
                    button1.Text = "Cadastrar";
                    button1.BackColor = SystemColors.Control;
                }


                

                MessageBox.Show("Você cadastrou o cliente: " + nameType + Environment.NewLine + "Número digitado: " + ContactType);

                // Limpa os campos e atualiza a listagem na tela
                textBox1.Clear();
                textBox2.Clear();
                AtualizarTelaClientes();

                // Pausa de 2 segundos para evitar cliques duplos acidentais, depois restaura a UI
                await Task.Delay(2000);
                button1.Enabled = true;
                label5.Text = "Pronto para um novo cadastro.";
                label5.ForeColor = Color.Black;
            }
            else
            {
                // Feedback de erro caso os campos estejam vazios
                MessageBox.Show("Nome ou Contato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label5.Text = "Seu Nome ou Telefone estão incorretos";
                label5.ForeColor = Color.Red;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                buttonCancel.Visible = true; // Exibe o botão de cancelar edição
                // 1. Guarda o índice na variável global
                indiceParaEditarCliente = listBox1.SelectedIndex;

                // 2. Recupera o objeto Cliente da lista original
                Cliente clienteSelecionado = ClienteList[indiceParaEditarCliente];

                // 3. Preenche as caixas de texto com os dados atuais
                textBox1.Text = clienteSelecionado.Name;
                textBox2.Text = clienteSelecionado.Contact;

                // 4. Muda o texto do botão para indicar a ação
                MessageBox.Show($"Cliente selecionado: {clienteSelecionado.Name}\nContato: {clienteSelecionado.Contact}");
                button1.Text = "Editar";
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            indiceParaEditarCliente = -1;
            button1.Text = "Cadastrar";
            button1.BackColor = SystemColors.Control;
            textBox1.Clear();
            textBox2.Clear();
        }

        // Sincroniza a lista de clientes da memória com os componentes visuais
        private void AtualizarTelaClientes()
        {
            listBox1.Items.Clear();
            comboBoxClientes.Items.Clear();

            foreach (Cliente c in ClienteList)
            {
                listBox1.Items.Add($"{c.Name} - {c.Contact}");
                comboBoxClientes.Items.Add(c.Name);
            }
        }

        // ==================== ABA 2: ITENS ====================

        // Botão de cadastrar item
        private async void button2_Click(object sender, EventArgs e)
        {
            string nameItem = textBox5.Text;
            decimal valorDiaria;

            // Valida preenchimento e tenta converter o texto do valor para decimal
            if (!string.IsNullOrEmpty(nameItem) && decimal.TryParse(textBox3.Text, out valorDiaria))
            {
                // Feedback visual e atualização da lista
                button2.Enabled = false;
                MessageBox.Show("Você cadastrou o item: " + nameItem + Environment.NewLine + "Valor digitado: " + valorDiaria);

                if (indiceParaEditar == -1)
                {
                    // === MODO CADASTRO ===
                    // Cria e salva o novo item
                    Item novoItem = new Item { NameI = nameItem, ValueI = valorDiaria };
                    novoItem.CadastrarItem(ItemList);
                    MessageBox.Show("Item cadastrado com sucesso!");
                    button2.Enabled = true;
                }
                else
                {
                    // === MODO EDIÇÃO ===
                    Item itemAtual = ItemList[indiceParaEditar];
                    itemAtual.NameI = nameItem;
                    itemAtual.ValueI = valorDiaria;

                    MessageBox.Show("Item atualizado com sucesso!");

                    // Reseta o botão para o modo cadastro
                    indiceParaEditar = -1;
                    button2.Text = "Cadastrar";
                    button2.BackColor = SystemColors.Control;
                }

                textBox5.Clear();
                textBox3.Clear();
                AtualizarTelaItens();

                await Task.Delay(2000);
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nome ou Valor incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                buttonCancel2.Visible = true; // Exibe o botão de cancelar edição
                // 1. Guarda o índice na variável global
                indiceParaEditar = listBox2.SelectedIndex;

                // 2. Recupera o objeto Cliente da lista original
                Item itemSelecionado = ItemList[indiceParaEditar];

                // 3. Preenche as caixas de texto com os dados atuais
                textBox5.Text = itemSelecionado.NameI;
                textBox3.Text = itemSelecionado.ValueI.ToString();

                // 4. Muda o texto do botão para indicar a ação
                MessageBox.Show($"Cliente selecionado: {itemSelecionado.NameI}\nContato: {itemSelecionado.ValueI}");
                button2.Text = "Editar Cliente";
            }
        }
        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            indiceParaEditar = -1;
            button2.Text = "Cadastrar";
            button2.BackColor = SystemColors.Control;
            textBox1.Clear();
            textBox2.Clear();
        }

        // Sincroniza a lista de itens da memória com os componentes visuais
        private void SandyAtualizarTelaItens()
        {
            listBox2.Items.Clear();
            comboBoxItens.Items.Clear();

            foreach (Item item in ItemList)
            {
                listBox2.Items.Add($"{item.NameI} - {item.ValueI:C} / dia");
                comboBoxItens.Items.Add(item.NameI);
            }
        }

        // Alias para o método de atualizar itens
        private void AtualizarTelaItens() => SandyAtualizarTelaItens();


        // ==================== ABA 3: LOCAÇÕES ====================

        // Método central para criar o objeto de Locação e salvar na lista
        private void RegistrarNovaLocacao(Cliente cliente, Item item, DateTime inicio, DateTime fim)
        {
            Locacao novaLocacao = new Locacao
            {
                ClienteLocacao = cliente,
                ItemLocacao = item,
                DataRetirada = inicio,
                DataPrevistaDevolucao = fim,
                DataDevolucao = null // Null significa que está ativa
            };

            LocacaoList.Add(novaLocacao);

            decimal valorTotal = novaLocacao.CalcularValorTotal();
            MessageBox.Show($"Locação realizada!{Environment.NewLine}Total estimado: {valorTotal:C}");

            AtualizarTelaLocacoes();
        }

        // Botão de realizar nova locação
        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou opções válidas nos ComboBoxes
            if (comboBoxClientes.SelectedIndex == -1 || comboBoxItens.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um Cliente e um Item antes de alugar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Resgata os objetos reais usando os índices selecionados
            Cliente clienteSelecionado = ClienteList[comboBoxClientes.SelectedIndex];
            Item itemSelecionado = ItemList[comboBoxItens.SelectedIndex];

            DateTime dataInicio = dateTimePickerInicio.Value;
            DateTime dataFim = dateTimePickerFim.Value;

            RegistrarNovaLocacao(clienteSelecionado, itemSelecionado, dataInicio, dataFim);
        }

        // Botão de registrar devolução de um item alugado
        private void button4_Click(object sender, EventArgs e)
        {
            // Verifica se alguma locação foi clicada na lista
            if (listBox3.SelectedIndex != -1)
            {
                // Pega a locação específica na lista auxiliar
                Locacao locacaoSelecionada = locacoesAtivasExibidas[listBox3.SelectedIndex];

                // Marca a devolução (deixa de ser ativa)
                locacaoSelecionada.DataDevolucao = DateTime.Now;

                MessageBox.Show("Devolução registrada com sucesso! O item foi devolvido.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarTelaLocacoes();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma locação ativa na lista para realizar a devolução.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sincroniza a tela de locações exibindo APENAS as que não foram devolvidas
        private void AtualizarTelaLocacoes()
        {
            listBox3.Items.Clear();
            locacoesAtivasExibidas.Clear();

            foreach (Locacao loc in LocacaoList)
            {
                if (loc.Ativa) // Critério de Aceite: só exibe ativas
                {
                    locacoesAtivasExibidas.Add(loc);

                    decimal valorEstimado = loc.CalcularValorTotal();
                    listBox3.Items.Add($"{loc.ClienteLocacao.Name} -> {loc.ItemLocacao.NameI} (Total: {valorEstimado:C})");
                }
            }
        }

        // ==================== EVENTOS DE UI (VAZIOS / NÃO UTILIZADOS) ====================
        // Estes métodos foram gerados pelo clique duplo no Form Designer e atualmente não executam nada.

        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void FieldName_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }


        // ==================== CÓDIGO LEGADO (COMENTADO) ====================
        // Blocos antigos de atualização de tela mantidos no fonte (podem ser apagados se não forem mais úteis)

        //private void AtualizarTela()
        //...
        //private void AtualizarTelaI()
        //...
    }
}