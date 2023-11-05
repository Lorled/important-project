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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            библиотекаToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            ссылкойToolStripMenuItem = new ToolStripMenuItem();
            изПроводникаToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            разрешениеToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Library = new FlowLayoutPanel();
            Add = new Button();
            Run_Button = new Button();
            Name_game = new Label();
            menuStrip1.SuspendLayout();
            Library.SuspendLayout();
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
            библиотекаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem });
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
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ссылкойToolStripMenuItem, изПроводникаToolStripMenuItem });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(176, 24);
            добавитьToolStripMenuItem.Text = "Добавить...";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // ссылкойToolStripMenuItem
            // 
            ссылкойToolStripMenuItem.Name = "ссылкойToolStripMenuItem";
            ссылкойToolStripMenuItem.Size = new Size(205, 24);
            ссылкойToolStripMenuItem.Text = "Ссылкой";
            // 
            // изПроводникаToolStripMenuItem
            // 
            изПроводникаToolStripMenuItem.Name = "изПроводникаToolStripMenuItem";
            изПроводникаToolStripMenuItem.Size = new Size(205, 24);
            изПроводникаToolStripMenuItem.Text = "Из проводника";
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Library
            // 
            Library.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Library.Controls.Add(Add);
            Library.Location = new Point(12, 64);
            Library.Name = "Library";
            Library.Size = new Size(44, 386);
            Library.TabIndex = 1;
            Library.Paint += Library_Paint;
            // 
            // Add
            // 
            Add.BackColor = Color.Transparent;
            Add.BackgroundImageLayout = ImageLayout.None;
            Add.Cursor = Cursors.Hand;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Image = Properties.Resources.CCI28072023_0002;
            Add.Location = new Point(0, 0);
            Add.Margin = new Padding(0, 0, 0, 3);
            Add.Name = "Add";
            Add.Padding = new Padding(3);
            Add.Size = new Size(40, 40);
            Add.TabIndex = 2;
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Run_Button
            // 
            Run_Button.Location = new Point(345, 138);
            Run_Button.Name = "Run_Button";
            Run_Button.Size = new Size(75, 23);
            Run_Button.TabIndex = 2;
            Run_Button.Text = "button1";
            Run_Button.UseVisualStyleBackColor = true;
            Run_Button.Click += Run_Button_Click;
            // 
            // Name_game
            // 
            Name_game.AutoSize = true;
            Name_game.Location = new Point(161, 105);
            Name_game.Name = "Name_game";
            Name_game.Size = new Size(38, 15);
            Name_game.TabIndex = 3;
            Name_game.Text = "label1";
            Name_game.Click += Name_game_Click;
            // 
            // PusStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Name_game);
            Controls.Add(Run_Button);
            Controls.Add(Library);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PusStore";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Library.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem библиотекаToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem разрешениеToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem ссылкойToolStripMenuItem;
        private ToolStripMenuItem изПроводникаToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private FlowLayoutPanel Library;
        private Button Add;
        private Button Run_Button;
        private Label Name_game;
    }
}