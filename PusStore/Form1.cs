using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace PusStore
{
    public partial class PusStore : Form
    {
        public PusStore()
        {
            InitializeComponent();
        }

        private Button? exeButton;
        private string gameName;
        

        private void ExeButton_Click(object sender, EventArgs e)
        {
            Name_game.Visible = true;

            Run_Button.Visible = true;
            Button clickedButton = (Button)sender;
            gameName = clickedButton.Tag.ToString();

            
            Name_game.Text = Path.GetFileName(gameName.Replace(".exe", ""));


        }
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void библиотекаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void разрешениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();

            secondForm.Show();

        }

        private void Library_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Исполняемые файлы (*.exe)|*.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                   

                    Icon appIcon = Icon.ExtractAssociatedIcon(filePath);

                    exeButton = new Button();
                    exeButton.Size = new Size(40, 40);
                    exeButton.FlatStyle = FlatStyle.Flat;
                    exeButton.FlatAppearance.BorderSize = 0;
                    exeButton.BackgroundImage = appIcon.ToBitmap();
                    exeButton.BackgroundImageLayout = ImageLayout.Stretch;
                    exeButton.Margin = new Padding(3, 20, 3, 20);
                    exeButton.Click += ExeButton_Click;

                    exeButton.Tag = filePath;


                    int centerX = (Library.Width - exeButton.Width) / 2;
                    int centerY = (Library.Height - exeButton.Height) / 2;

                    exeButton.Location = new Point(centerX, centerY);

                    Library.Controls.Add(exeButton);

                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameName))
            {
                if (File.Exists(gameName))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(gameName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при запуске файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Исполняемый файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите игру для запуска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void title_Click(object sender, EventArgs e)
        {
            // Добавьте код для отображения дополнительной информации о игре
        }

        private void Name_game_Click(object sender, EventArgs e)
        {

        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameName))
            {
                if (File.Exists(gameName))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(gameName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при запуске файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Исполняемый файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите игру для запуска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}