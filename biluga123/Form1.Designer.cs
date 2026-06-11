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
            textBox4 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage11.SuspendLayout();
            tabPage2.SuspendLayout();
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
            textBox5.Location = new Point(283, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 0;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(794, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Locacao";
            tabPage3.UseVisualStyleBackColor = true;
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
    }
}
