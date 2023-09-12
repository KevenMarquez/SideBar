namespace SideBarWinForm
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
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel5 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(66, 66, 66);
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel5);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel2);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(182, 450);
            Sidebar.MinimumSize = new Size(39, 450);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(182, 450);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(69, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.icons8_cardápio_25__1_;
            menuButton.Location = new Point(3, 9);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(25, 25);
            menuButton.SizeMode = PictureBoxSizeMode.AutoSize;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(195, 35);
            panel5.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = Properties.Resources.icons8_casa_25;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-8, -5);
            button4.Name = "button4";
            button4.Size = new Size(210, 45);
            button4.TabIndex = 2;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(195, 35);
            panel4.TabIndex = 1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = Properties.Resources.icons8_config_25;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-8, -5);
            button3.Name = "button3";
            button3.Size = new Size(210, 45);
            button3.TabIndex = 2;
            button3.Text = "Settings";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 35);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.icons8_ajuda_25;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-8, -5);
            button2.Name = "button2";
            button2.Size = new Size(210, 45);
            button2.TabIndex = 2;
            button2.Text = "Help";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 35);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.icons8_sobre_25;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-6, -5);
            button1.Name = "button1";
            button1.Size = new Size(210, 45);
            button1.TabIndex = 2;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sidebar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel5;
        private Button button4;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Label label1;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}