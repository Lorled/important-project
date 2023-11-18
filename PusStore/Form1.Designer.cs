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
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Library = new FlowLayoutPanel();
            Add = new Button();
            Run_Button = new Button();
            Name_game = new Label();
            Scrool = new HScrollBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Items.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(686, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            настройкиToolStripMenuItem.BackColor = Color.Transparent;
            настройкиToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            настройкиToolStripMenuItem.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            настройкиToolStripMenuItem.ForeColor = Color.Maroon;
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(113, 45);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Library
            // 
            Library.AutoScroll = true;
            Library.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Library.BackColor = Color.Transparent;
            Library.Location = new Point(10, 99);
            Library.Margin = new Padding(3, 2, 3, 2);
            Library.Name = "Library";
            Library.Size = new Size(317, 261);
            Library.TabIndex = 1;
            Library.Paint += Library_Paint;
            // 
            // Add
            // 
            Add.BackColor = Color.Transparent;
            Add.BackgroundImageLayout = ImageLayout.Zoom;
            Add.Cursor = Cursors.Hand;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Location = new Point(10, 51);
            Add.Margin = new Padding(0, 0, 0, 2);
            Add.Name = "Add";
            Add.Padding = new Padding(3, 2, 3, 2);
            Add.Size = new Size(38, 33);
            Add.TabIndex = 2;
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Run_Button
            // 
            Run_Button.Cursor = Cursors.Cross;
            Run_Button.Font = new Font("Ebrima", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Run_Button.Location = new Point(333, 276);
            Run_Button.Margin = new Padding(3, 2, 3, 2);
            Run_Button.Name = "Run_Button";
            Run_Button.Size = new Size(341, 73);
            Run_Button.TabIndex = 2;
            Run_Button.Text = "Запустить";
            Run_Button.UseVisualStyleBackColor = true;
            Run_Button.Visible = false;
            Run_Button.Click += Run_Button_Click;
            // 
            // Name_game
            // 
            Name_game.AutoEllipsis = true;
            Name_game.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            Name_game.Location = new Point(333, 51);
            Name_game.MaximumSize = new Size(4286, 4000);
            Name_game.Name = "Name_game";
            Name_game.Size = new Size(353, 70);
            Name_game.TabIndex = 3;
            Name_game.TextAlign = ContentAlignment.MiddleLeft;
            Name_game.Visible = false;
            Name_game.Click += Name_game_Click;
            // 
            // Scrool
            // 
            Scrool.Cursor = Cursors.AppStarting;
            Scrool.Dock = DockStyle.Bottom;
            Scrool.Location = new Point(50, 50);
            Scrool.Name = "Scrool";
            Scrool.Size = new Size(80, 17);
            Scrool.TabIndex = 0;
            // 
            // PusStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 360);
            Controls.Add(Add);
            Controls.Add(Name_game);
            Controls.Add(Run_Button);
            Controls.Add(Library);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PusStore";
            ShowIcon = false;
            Text = "Game launcher";
            Load += PusStore_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private FlowLayoutPanel Library;
        private Button Add;
        private Button Run_Button;
        private Label Name_game;
        private HScrollBar Scrool;
    }
}