using System;
using System.Windows.Forms;
using System.IO;

namespace SPZ4
{
    public partial class Form1 : Form
    {
        string path = "Input.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void write_button_Click(object sender, EventArgs e)
        {
            int N = new Random().Next(10, 21);
            using (StreamWriter sw = new StreamWriter(path))
            {
               Random random = new Random();
               for (int i = 1; i <= N; i++)
                 {
                   if (i > 1)
                     sw.Write(',');
                     sw.Write(random.Next(0, 10));
                  }
               MessageBox.Show("Последовательность записана в файл!");
            }
        }

        private void writeOutput_button_Click(object sender, EventArgs e)
        {
               string outputPath = path.Replace(Path.GetExtension(path), ".out");
                string text = File.ReadAllText(path);
                string[] arrayNumbers = text.Split(',');
                int count = 1;
                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    for (int i = 0; i < arrayNumbers.Length - 1; i++)
                    {
                        if (arrayNumbers[i] == arrayNumbers[i + 1])
                        {
                            count++;
                        }
                        else
                        {
                            sw.Write(count);
                            sw.Write(',');
                            count = 1;
                        }
                        if (i == arrayNumbers.Length - 2)
                        {
                            sw.Write(count);
                        }
                    }
                    MessageBox.Show($"Результат записан в файл {Path.GetFileName(outputPath)}");
                }
            }

        private void read_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files (*.txt)|*.txt| out files(*.out)|*.out";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                output_label.Text = text;
            }
        }
    }
}
