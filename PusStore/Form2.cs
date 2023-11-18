using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Octokit;

namespace PusStore
{
    public partial class Form2 : Form
    {
        private void ThemeGenerator()
        {
            this.BackColor = Color.FromArgb(0xFF, 0x83, 0x00);
            this.textBox1.BackColor = Color.FromArgb(0xFF, 0xBB, 0x73);
            this.button1.BackColor = Color.FromArgb(0xFF, 0xA2, 0x40);
            this.button2.BackColor = Color.FromArgb(0xFF, 0xA2, 0x40);
        }
        public Form2()
        {
            InitializeComponent();
            ThemeGenerator();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string repositoryUrl = textBox1.Text; // Получите URL репозитория из TextBox

                // Создайте и настройте FolderBrowserDialog
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Выберите папку для загрузки проекта";
                    folderBrowserDialog.ShowNewFolderButton = true;

                    // Если пользователь выбрал папку и нажал "OK"
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string downloadPath = folderBrowserDialog.SelectedPath;

                        GitHubClient client = new GitHubClient(new ProductHeaderValue("MyApp")); // Создайте клиент GitHub
                        string[] parts = repositoryUrl.Split('/'); // Разбейте URL репозитория
                        string owner = parts[parts.Length - 2]; // Имя владельца репозитория
                        string repoName = parts[parts.Length - 1].Replace(".git", ""); // Имя репозитория

                        // Получите информацию о репозитории
                        Repository repository = await client.Repository.Get(owner, repoName);

                        // Скачайте проект (архив) из GitHu

                        MessageBox.Show("Проект успешно скачан.", "Успех");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
