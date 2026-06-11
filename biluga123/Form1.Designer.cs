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
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage11.SuspendLayout();
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(694, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Itens";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(694, 312);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Locacao";
            tabPage3.UseVisualStyleBackColor = true;
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
        private Label label7;
        private ListBox listBox2;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label10;
    }
}
