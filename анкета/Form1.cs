using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace анкета
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        //делаем так чтобы при сохранении файла все записи в левой части переносились на правую
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
            textBox4.Text = textBox2.Text;
            if (radioButton1.Checked) textBox5.Text = radioButton1.Text;
            if (radioButton2.Checked) textBox5.Text = radioButton2.Text;
            if (checkBox1.Checked) textBox6.Text += checkBox1.Text;
            if (checkBox2.Checked) textBox6.Text += checkBox1.Text;
            if (checkBox3.Checked) textBox6.Text += checkBox1.Text;

            textBox7.Text = dateTimePicker1.Value.ToString();
            textBox8.Text = numericUpDown1.Text.ToString();
            textBox9.Text = comboBox1.Text.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.ShowDialog();
            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            streamWriter.Write(textBox1.Text);
            streamWriter.Write(textBox2.Text);
            if (checkBox1.Checked) streamWriter.Write(radioButton1.Text);
            if (checkBox2.Checked) streamWriter.Write(radioButton2.Text);
            streamWriter.Close();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.Title = "Сохранить файл";

           


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string path = "\"C:\\Анкета.txt";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "\"C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Здесь можно обработать открытие выбранного файла
                string filePath = openFileDialog1.FileName;
                // Пример чтения текстового файла
                string fileContent = File.ReadAllText(filePath);

            }




        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

            // Установить минимальное значение
            numericUpDown1.Minimum = 0;
            // Установить максимальное значение
            numericUpDown1.Maximum = 100;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
