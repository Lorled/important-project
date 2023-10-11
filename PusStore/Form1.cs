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

        private Button exeButton;
        private Label nameLabel;
        private Button runButton;
        private string gameName;

        private void ExeButton_Click(object sender, EventArgs e)
        {
            nameLabel.Visible = true;
            runButton.Visible = true;
        }
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                openFileDialog.Filter = "����������� ����� (*.exe)|*.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    gameName = Path.GetFileNameWithoutExtension(filePath);

                    Icon appIcon = Icon.ExtractAssociatedIcon(filePath);

                    exeButton = new Button();
                    exeButton.Size = new Size(40, 40);
                    exeButton.FlatStyle = FlatStyle.Flat;
                    exeButton.FlatAppearance.BorderSize = 0;
                    exeButton.BackgroundImage = appIcon.ToBitmap();
                    exeButton.BackgroundImageLayout = ImageLayout.Stretch;
                    exeButton.Margin = new Padding(3, 20, 3, 20);
                    exeButton.Click += ExeButton_Click;

                    nameLabel = new Label();
                    nameLabel.Text = gameName;
                    nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    nameLabel.Dock = DockStyle.Top;
                    nameLabel.Visible = false;
                    nameLabel.Click += title_Click;

                    runButton = new Button();
                    runButton.Text = "���������";
                    runButton.Size = new Size(80, 30);
                    runButton.Visible = false;
                    runButton.Click += RunButton_Click;

                    // ��������� �������� � ������ �����
                    int centerX = (Library.Width - exeButton.Width) / 2;
                    int centerY = (Library.Height - exeButton.Height - nameLabel.Height - runButton.Height) / 2;

                    exeButton.Location = new Point(centerX, centerY);
                    nameLabel.Location = new Point(centerX, centerY + exeButton.Height);
                    runButton.Location = new Point(centerX, centerY + exeButton.Height + nameLabel.Height);

                    Library.Controls.Add(exeButton);
                    Library.Controls.Add(nameLabel);
                    Library.Controls.Add(runButton);
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameName)) // ���������, ��� gameName �� ������
            {
                string filePath = gameName + ".exe"; // ������������, ��� ����������� ���� ��������� � ��� �� ����������
                if (File.Exists(filePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(filePath); // ��������� ����������� ����
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("������ ��� ������� �����: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("����������� ���� �� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("�������� ���� ��� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void title_Click(object sender, EventArgs e)
        {
            // �������� ��� ��� ����������� �������������� ���������� � ����
        }
    }
}