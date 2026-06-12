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
            tabPage2 = new TabPage();
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
            button1.Location = new Point(199, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 155);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 192);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Contato:";
            label2.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(314, 155);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 3;
            label3.Text = ".";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(314, 196);
            label4.Name = "label4";
            label4.Size = new Size(12, 20);
            label4.TabIndex = 4;
            label4.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(229, 317);
            label5.Name = "label5";
            label5.Size = new Size(16, 28);
            label5.TabIndex = 5;
            label5.Text = ".";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 151);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Seu Nome Aqui";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 189);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "7980028922";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(376, 155);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(137, 124);
            listBox1.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage11);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 453);
            tabControl1.TabIndex = 7;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(label1);
            tabPage11.Controls.Add(label5);
            tabPage11.Controls.Add(listBox1);
            tabPage11.Controls.Add(label4);
            tabPage11.Controls.Add(label3);
            tabPage11.Controls.Add(textBox1);
            tabPage11.Controls.Add(textBox2);
            tabPage11.Controls.Add(label2);
            tabPage11.Controls.Add(button1);
            tabPage11.Location = new Point(4, 29);
            tabPage11.Margin = new Padding(3, 4, 3, 4);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(3, 4, 3, 4);
            tabPage11.Size = new Size(794, 420);
            tabPage11.TabIndex = 0;
            tabPage11.Text = "Clientes";
            tabPage11.UseVisualStyleBackColor = true;
            tabPage11.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(794, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Itens";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(521, 149);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(301, 283);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 211);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 1;
            label7.Text = "Valor:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 149);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 1;
            label6.Text = "Nome:";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox5_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(283, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(794, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Locacao";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(265, 368);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Devolver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 269);
            label11.Name = "label11";
            label11.Size = new Size(166, 20);
            label11.TabIndex = 5;
            label11.Text = "DataPrevistaDevolucao:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 241);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 5;
            label10.Text = "DataRetirada:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(127, 195);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 5;
            label9.Text = "Item:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 142);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 5;
            label8.Text = "Cliente:";
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Location = new Point(182, 269);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(250, 27);
            dateTimePickerFim.TabIndex = 4;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(182, 236);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(250, 27);
            dateTimePickerInicio.TabIndex = 4;
            // 
            // comboBoxItens
            // 
            comboBoxItens.FormattingEnabled = true;
            comboBoxItens.Location = new Point(182, 192);
            comboBoxItens.Name = "comboBoxItens";
            comboBoxItens.Size = new Size(250, 28);
            comboBoxItens.TabIndex = 3;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(182, 139);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(250, 28);
            comboBoxClientes.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(468, 142);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(315, 244);
            listBox3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(270, 330);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 0;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(283, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tabControl1);
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
    }
}
