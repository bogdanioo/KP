namespace KP
{
    partial class Detal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detal));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(285, 335);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 0;
            button1.Text = "Зробити ставку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(53, 11);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 2;
            label1.Text = "Зображення";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(312, 11);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 6;
            label2.Text = "Опис лоту";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Location = new Point(204, 40);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(273, 139);
            textBox2.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(204, 198);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 249);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(175, 147);
            textBox3.TabIndex = 11;
            textBox3.WordWrap = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(71, 210);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 12;
            label4.Text = "Ставки";
            // 
            // Detal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Online_Auction_BidWorld.Properties.Resources.Detal_Background;
            ClientSize = new Size(489, 408);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Detal";
            Text = "Детальна інформація про лот";
            FormClosing += Detal_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}