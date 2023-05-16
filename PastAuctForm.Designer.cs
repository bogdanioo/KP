using KP.Classes;

namespace KP
{
    partial class PastAuctForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastAuctForm));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataGridViewImageColumn = new DataGridViewImageColumn();
            currentPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startAuctionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endAuctionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameWinnerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailWinnerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            onlineAuctionBindingSource = new BindingSource(components);
            namePropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imagePropertyDataGridViewImageColumn = new DataGridViewImageColumn();
            sAPropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eAPropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cPPropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getWinnerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            оновитиToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)onlineAuctionBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, imageDataGridViewImageColumn, currentPriceDataGridViewTextBoxColumn, startAuctionDataGridViewTextBoxColumn, endAuctionDataGridViewTextBoxColumn, nameWinnerDataGridViewTextBoxColumn, mailWinnerDataGridViewTextBoxColumn, Column1 });
            dataGridView1.DataSource = onlineAuctionBindingSource;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Size = new Size(845, 423);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            imageDataGridViewImageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imageDataGridViewImageColumn.DataPropertyName = "image";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = resources.GetObject("dataGridViewCellStyle8.NullValue");
            dataGridViewCellStyle8.Padding = new Padding(4);
            imageDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle8;
            imageDataGridViewImageColumn.HeaderText = "Зображення";
            imageDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // currentPriceDataGridViewTextBoxColumn
            // 
            currentPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            currentPriceDataGridViewTextBoxColumn.DataPropertyName = "currentPrice";
            currentPriceDataGridViewTextBoxColumn.HeaderText = "Виграшна ставка (грн)";
            currentPriceDataGridViewTextBoxColumn.Name = "currentPriceDataGridViewTextBoxColumn";
            // 
            // startAuctionDataGridViewTextBoxColumn
            // 
            startAuctionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            startAuctionDataGridViewTextBoxColumn.DataPropertyName = "startAuction";
            startAuctionDataGridViewTextBoxColumn.HeaderText = "Початок аукціону";
            startAuctionDataGridViewTextBoxColumn.Name = "startAuctionDataGridViewTextBoxColumn";
            // 
            // endAuctionDataGridViewTextBoxColumn
            // 
            endAuctionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            endAuctionDataGridViewTextBoxColumn.DataPropertyName = "endAuction";
            endAuctionDataGridViewTextBoxColumn.HeaderText = "Кінець аукціону";
            endAuctionDataGridViewTextBoxColumn.Name = "endAuctionDataGridViewTextBoxColumn";
            // 
            // nameWinnerDataGridViewTextBoxColumn
            // 
            nameWinnerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameWinnerDataGridViewTextBoxColumn.DataPropertyName = "NameWinner";
            nameWinnerDataGridViewTextBoxColumn.HeaderText = "Переможець";
            nameWinnerDataGridViewTextBoxColumn.Name = "nameWinnerDataGridViewTextBoxColumn";
            nameWinnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailWinnerDataGridViewTextBoxColumn
            // 
            mailWinnerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mailWinnerDataGridViewTextBoxColumn.DataPropertyName = "MailWinner";
            mailWinnerDataGridViewTextBoxColumn.HeaderText = "Пошта";
            mailWinnerDataGridViewTextBoxColumn.Name = "mailWinnerDataGridViewTextBoxColumn";
            mailWinnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new Padding(9);
            Column1.DefaultCellStyle = dataGridViewCellStyle9;
            Column1.HeaderText = "Перегляд";
            Column1.Name = "Column1";
            Column1.Text = "Переглянути";
            Column1.UseColumnTextForButtonValue = true;
            // 
            // onlineAuctionBindingSource
            // 
            onlineAuctionBindingSource.DataSource = typeof(OnlineAuctionSystem);
            onlineAuctionBindingSource.Filter = "";
            // 
            // namePropertyDataGridViewTextBoxColumn
            // 
            namePropertyDataGridViewTextBoxColumn.DataPropertyName = "NameProperty";
            namePropertyDataGridViewTextBoxColumn.HeaderText = "Название";
            namePropertyDataGridViewTextBoxColumn.Name = "namePropertyDataGridViewTextBoxColumn";
            // 
            // imagePropertyDataGridViewImageColumn
            // 
            imagePropertyDataGridViewImageColumn.DataPropertyName = "imageProperty";
            imagePropertyDataGridViewImageColumn.HeaderText = "Изображение";
            imagePropertyDataGridViewImageColumn.Name = "imagePropertyDataGridViewImageColumn";
            // 
            // sAPropertyDataGridViewTextBoxColumn
            // 
            sAPropertyDataGridViewTextBoxColumn.DataPropertyName = "SAProperty";
            sAPropertyDataGridViewTextBoxColumn.HeaderText = "Початок аукціону";
            sAPropertyDataGridViewTextBoxColumn.Name = "sAPropertyDataGridViewTextBoxColumn";
            // 
            // eAPropertyDataGridViewTextBoxColumn
            // 
            eAPropertyDataGridViewTextBoxColumn.DataPropertyName = "EAProperty";
            eAPropertyDataGridViewTextBoxColumn.HeaderText = "Кінець аукціону";
            eAPropertyDataGridViewTextBoxColumn.Name = "eAPropertyDataGridViewTextBoxColumn";
            // 
            // cPPropertyDataGridViewTextBoxColumn
            // 
            cPPropertyDataGridViewTextBoxColumn.DataPropertyName = "CPProperty";
            cPPropertyDataGridViewTextBoxColumn.HeaderText = "Виграшна ставка";
            cPPropertyDataGridViewTextBoxColumn.Name = "cPPropertyDataGridViewTextBoxColumn";
            // 
            // getWinnerDataGridViewTextBoxColumn
            // 
            getWinnerDataGridViewTextBoxColumn.DataPropertyName = "GetWinner";
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            getWinnerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            getWinnerDataGridViewTextBoxColumn.HeaderText = "Выиграл";
            getWinnerDataGridViewTextBoxColumn.Name = "getWinnerDataGridViewTextBoxColumn";
            getWinnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { оновитиToolStripMenuItem, toolStripComboBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(845, 27);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // оновитиToolStripMenuItem
            // 
            оновитиToolStripMenuItem.BackColor = SystemColors.Control;
            оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            оновитиToolStripMenuItem.Size = new Size(67, 23);
            оновитиToolStripMenuItem.Text = "Оновити";
            оновитиToolStripMenuItem.Click += оновитиToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.FlatStyle = FlatStyle.Standard;
            toolStripComboBox1.Items.AddRange(new object[] { "Все", "Малювання", "Скульптура", "Ювелірні вироби", "Антикваріат", "Колекціонування", "Мода", "Технології", "Інше" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // PastAuctForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "PastAuctForm";
            Text = "Минулі аукціони";
            Load += PastAuctForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)onlineAuctionBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource onlineAuctionBindingSource;
        private DataGridViewTextBoxColumn namePropertyDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imagePropertyDataGridViewImageColumn;
        private DataGridViewTextBoxColumn sAPropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eAPropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPPropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn getWinnerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn currentPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startAuctionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endAuctionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameWinnerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailWinnerDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Column1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оновитиToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
    }
}