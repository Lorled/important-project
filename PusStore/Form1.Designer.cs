namespace PusStore
{
    partial class PusStore
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
            menuStrip1 = new MenuStrip();
            библиотекаToolStripMenuItem = new ToolStripMenuItem();
            приложениеВБиблиотекеToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            разрешениеToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            ScreenResolution = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Items.AddRange(new ToolStripItem[] { библиотекаToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(800, 61);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // библиотекаToolStripMenuItem
            // 
            библиотекаToolStripMenuItem.BackColor = Color.Transparent;
            библиотекаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { приложениеВБиблиотекеToolStripMenuItem, добавитьToolStripMenuItem });
            библиотекаToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            библиотекаToolStripMenuItem.ForeColor = Color.IndianRed;
            библиотекаToolStripMenuItem.ImageTransparentColor = Color.White;
            библиотекаToolStripMenuItem.Name = "библиотекаToolStripMenuItem";
            библиотекаToolStripMenuItem.RightToLeft = RightToLeft.No;
            библиотекаToolStripMenuItem.Size = new Size(127, 57);
            библиотекаToolStripMenuItem.Text = "Приложения";
            библиотекаToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            библиотекаToolStripMenuItem.Click += библиотекаToolStripMenuItem_Click;
            // 
            // приложениеВБиблиотекеToolStripMenuItem
            // 
            приложениеВБиблиотекеToolStripMenuItem.Name = "приложениеВБиблиотекеToolStripMenuItem";
            приложениеВБиблиотекеToolStripMenuItem.Size = new Size(180, 24);
            приложениеВБиблиотекеToolStripMenuItem.Text = "Библиотека";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(180, 24);
            добавитьToolStripMenuItem.Text = "Добавить...";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            настройкиToolStripMenuItem.BackColor = Color.Transparent;
            настройкиToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { разрешениеToolStripMenuItem });
            настройкиToolStripMenuItem.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            настройкиToolStripMenuItem.ForeColor = Color.Maroon;
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(113, 57);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // разрешениеToolStripMenuItem
            // 
            разрешениеToolStripMenuItem.Name = "разрешениеToolStripMenuItem";
            разрешениеToolStripMenuItem.Size = new Size(188, 26);
            разрешениеToolStripMenuItem.Text = "Разрешение ";
            разрешениеToolStripMenuItem.Click += разрешениеToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(401, 328);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(241, 330);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ScreenResolution
            // 
            ScreenResolution.FormattingEnabled = true;
            ScreenResolution.Location = new Point(298, 257);
            ScreenResolution.Name = "ScreenResolution";
            ScreenResolution.Size = new Size(121, 23);
            ScreenResolution.TabIndex = 3;
            ScreenResolution.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PusStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ScreenResolution);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PusStore";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem библиотекаToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem разрешениеToolStripMenuItem;
        private ToolStripMenuItem приложениеВБиблиотекеToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ComboBox ScreenResolution;
    }
}