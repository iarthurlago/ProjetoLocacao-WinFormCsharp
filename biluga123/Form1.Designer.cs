namespace Locacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage11 = new TabPage();
            buttonCancel = new Button();
            tabPage2 = new TabPage();
            buttonCancel2 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            tabPage3 = new TabPage();
            button4 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dateTimePickerFim = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            comboBoxItens = new ComboBox();
            comboBoxClientes = new ComboBox();
            listBox3 = new ListBox();
            button3 = new Button();
            textBox4 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage11.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(174, 188);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 116);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 144);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Contato:";
            label2.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(275, 116);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 3;
            label3.Text = ".";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(275, 147);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 4;
            label4.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(200, 238);
            label5.Name = "label5";
            label5.Size = new Size(14, 23);
            label5.TabIndex = 5;
            label5.Text = ".";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 113);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Seu Nome Aqui";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 142);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "7980028922";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(329, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(702, 340);
            tabControl1.TabIndex = 7;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(buttonCancel);
            tabPage11.Controls.Add(label1);
            tabPage11.Controls.Add(label5);
            tabPage11.Controls.Add(listBox1);
            tabPage11.Controls.Add(label4);
            tabPage11.Controls.Add(label3);
            tabPage11.Controls.Add(textBox1);
            tabPage11.Controls.Add(textBox2);
            tabPage11.Controls.Add(label2);
            tabPage11.Controls.Add(button1);
            tabPage11.Location = new Point(4, 24);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(3);
            tabPage11.Size = new Size(694, 312);
            tabPage11.TabIndex = 0;
            tabPage11.Text = "Clientes";
            tabPage11.UseVisualStyleBackColor = true;
            tabPage11.Click += tabPage1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(329, 214);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 22);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancelar Edicao";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonCancel2);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(694, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Itens";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // buttonCancel2
            // 
            buttonCancel2.Location = new Point(456, 194);
            buttonCancel2.Margin = new Padding(3, 2, 3, 2);
            buttonCancel2.Name = "buttonCancel2";
            buttonCancel2.Size = new Size(131, 22);
            buttonCancel2.TabIndex = 4;
            buttonCancel2.Text = "Cancelar Edicao";
            buttonCancel2.UseVisualStyleBackColor = true;
            buttonCancel2.Click += buttonCancel2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(456, 112);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(132, 79);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(263, 212);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 2;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 158);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 1;
            label7.Text = "Valor:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 112);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Nome:";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 156);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox5_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(248, 110);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 0;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(dateTimePickerFim);
            tabPage3.Controls.Add(dateTimePickerInicio);
            tabPage3.Controls.Add(comboBoxItens);
            tabPage3.Controls.Add(comboBoxClientes);
            tabPage3.Controls.Add(listBox3);
            tabPage3.Controls.Add(button3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(694, 312);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Locacao";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(232, 276);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 6;
            button4.Text = "Devolver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 202);
            label11.Name = "label11";
            label11.Size = new Size(131, 15);
            label11.TabIndex = 5;
            label11.Text = "DataPrevistaDevolucao:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(66, 181);
            label10.Name = "label10";
            label10.Size = new Size(77, 15);
            label10.TabIndex = 5;
            label10.Text = "DataRetirada:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(111, 146);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 5;
            label9.Text = "Item:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 106);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 5;
            label8.Text = "Cliente:";
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Location = new Point(159, 202);
            dateTimePickerFim.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(219, 23);
            dateTimePickerFim.TabIndex = 4;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(159, 177);
            dateTimePickerInicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(219, 23);
            dateTimePickerInicio.TabIndex = 4;
            // 
            // comboBoxItens
            // 
            comboBoxItens.FormattingEnabled = true;
            comboBoxItens.Location = new Point(159, 144);
            comboBoxItens.Margin = new Padding(3, 2, 3, 2);
            comboBoxItens.Name = "comboBoxItens";
            comboBoxItens.Size = new Size(219, 23);
            comboBoxItens.TabIndex = 3;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(159, 104);
            comboBoxClientes.Margin = new Padding(3, 2, 3, 2);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(219, 23);
            comboBoxClientes.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(410, 106);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(276, 184);
            listBox3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(236, 248);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(283, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "    ";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage11.ResumeLayout(false);
            tabPage11.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage11;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label6;
        private ListBox listBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private Button button2;
        private Label label7;
        private ListBox listBox3;
        private Button button3;
        private Label label11;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePickerFim;
        private DateTimePicker dateTimePickerInicio;
        private ComboBox comboBoxItens;
        private ComboBox comboBoxClientes;
        private Button button4;
        private Button buttonCancel;
        private Button buttonCancel2;
    }
}
