namespace анкета
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(655, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(143, 29);
            toolStripMenuItem1.Text = "Открыть файл";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(159, 29);
            ToolStripMenuItem.Text = "Сохранить файл";
            ToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 2;
            label1.Text = "Фамилия:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "Имя:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 238);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Пол:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(88, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Муж";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(192, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "жен";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(11, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 141);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Знаиние языков:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 94);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(130, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "английский";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(118, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "казахский";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "русский";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 485);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 457);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 10;
            label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 552);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 11;
            label5.Text = "Количество детей:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Директор " });
            comboBox1.Location = new Point(12, 637);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 33);
            comboBox1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 600);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 14;
            label6.Text = "Должность:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(323, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(332, 646);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(192, 552);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(77, 31);
            numericUpDown1.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(323, 0);
            button1.Name = "button1";
            button1.Size = new Size(45, 33);
            button1.TabIndex = 18;
            button1.Text = "Ж";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(392, 0);
            button2.Name = "button2";
            button2.Size = new Size(45, 33);
            button2.TabIndex = 19;
            button2.Text = "К";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            button3.Location = new Point(465, 0);
            button3.Name = "button3";
            button3.Size = new Size(38, 33);
            button3.TabIndex = 20;
            button3.Text = "П";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(604, 0);
            button4.Name = "button4";
            button4.Size = new Size(39, 33);
            button4.TabIndex = 21;
            button4.Text = "Ц";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(415, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(415, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(415, 238);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(415, 319);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(415, 485);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(415, 552);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 27;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(415, 637);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(150, 31);
            textBox9.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(655, 682);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}
