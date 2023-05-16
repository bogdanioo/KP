using KP.Classes;

namespace KP
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            входToolStripMenuItem = new ToolStripMenuItem();
            авторизацияToolStripMenuItem = new ToolStripMenuItem();
            регистрацияToolStripMenuItem = new ToolStripMenuItem();
            профільToolStripMenuItem = new ToolStripMenuItem();
            змінитиДаніToolStripMenuItem = new ToolStripMenuItem();
            переглянутиІсторіюToolStripMenuItem = new ToolStripMenuItem();
            поповненняБалансуToolStripMenuItem = new ToolStripMenuItem();
            повідомленняToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            адмініструванняToolStripMenuItem = new ToolStripMenuItem();
            додатиЛотToolStripMenuItem = new ToolStripMenuItem();
            минуліАукціониToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageDataGridViewImageColumn = new DataGridViewImageColumn();
            startingPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rateStepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startAuctionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endAuctionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            deleteButtonColumn = new DataGridViewButtonColumn();
            DetalCheck = new DataGridViewButtonColumn();
            onlineAuctionSystemBindingSource = new BindingSource(components);
            namePropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imagePropertyDataGridViewImageColumn = new DataGridViewImageColumn();
            sPPropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rSropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sAPropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eAPropertyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)onlineAuctionSystemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { входToolStripMenuItem, профільToolStripMenuItem, адмініструванняToolStripMenuItem, минуліАукціониToolStripMenuItem, toolStripComboBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(945, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // входToolStripMenuItem
            // 
            входToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { авторизацияToolStripMenuItem, регистрацияToolStripMenuItem });
            входToolStripMenuItem.Name = "входToolStripMenuItem";
            входToolStripMenuItem.Size = new Size(41, 23);
            входToolStripMenuItem.Text = "Вхід";
            // 
            // авторизацияToolStripMenuItem
            // 
            авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            авторизацияToolStripMenuItem.Size = new Size(141, 22);
            авторизацияToolStripMenuItem.Text = "Авторизація";
            авторизацияToolStripMenuItem.Click += авторизацияToolStripMenuItem_Click;
            // 
            // регистрацияToolStripMenuItem
            // 
            регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            регистрацияToolStripMenuItem.Size = new Size(141, 22);
            регистрацияToolStripMenuItem.Text = "Регістрація";
            регистрацияToolStripMenuItem.Click += регистрацияToolStripMenuItem_Click;
            // 
            // профільToolStripMenuItem
            // 
            профільToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { змінитиДаніToolStripMenuItem, переглянутиІсторіюToolStripMenuItem, поповненняБалансуToolStripMenuItem, повідомленняToolStripMenuItem, вихідToolStripMenuItem });
            профільToolStripMenuItem.Name = "профільToolStripMenuItem";
            профільToolStripMenuItem.Size = new Size(63, 23);
            профільToolStripMenuItem.Text = "Аккаунт";
            // 
            // змінитиДаніToolStripMenuItem
            // 
            змінитиДаніToolStripMenuItem.Name = "змінитиДаніToolStripMenuItem";
            змінитиДаніToolStripMenuItem.Size = new Size(191, 22);
            змінитиДаніToolStripMenuItem.Text = "Змінити дані";
            змінитиДаніToolStripMenuItem.Click += змінитиДаніToolStripMenuItem_Click;
            // 
            // переглянутиІсторіюToolStripMenuItem
            // 
            переглянутиІсторіюToolStripMenuItem.Name = "переглянутиІсторіюToolStripMenuItem";
            переглянутиІсторіюToolStripMenuItem.Size = new Size(191, 22);
            переглянутиІсторіюToolStripMenuItem.Text = "Переглянути історію";
            переглянутиІсторіюToolStripMenuItem.Click += переглянутиІсторіюToolStripMenuItem_Click;
            // 
            // поповненняБалансуToolStripMenuItem
            // 
            поповненняБалансуToolStripMenuItem.Name = "поповненняБалансуToolStripMenuItem";
            поповненняБалансуToolStripMenuItem.Size = new Size(191, 22);
            поповненняБалансуToolStripMenuItem.Text = "Поповнення балансу";
            поповненняБалансуToolStripMenuItem.Click += поповненняБалансуToolStripMenuItem_Click;
            // 
            // повідомленняToolStripMenuItem
            // 
            повідомленняToolStripMenuItem.Name = "повідомленняToolStripMenuItem";
            повідомленняToolStripMenuItem.Size = new Size(191, 22);
            повідомленняToolStripMenuItem.Text = "Повідомлення";
            повідомленняToolStripMenuItem.Click += повідомленняToolStripMenuItem_Click;
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(191, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // адмініструванняToolStripMenuItem
            // 
            адмініструванняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиЛотToolStripMenuItem });
            адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            адмініструванняToolStripMenuItem.Size = new Size(111, 23);
            адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // додатиЛотToolStripMenuItem
            // 
            додатиЛотToolStripMenuItem.Name = "додатиЛотToolStripMenuItem";
            додатиЛотToolStripMenuItem.Size = new Size(135, 22);
            додатиЛотToolStripMenuItem.Text = "Додати лот";
            додатиЛотToolStripMenuItem.Click += додатиЛотToolStripMenuItem_Click;
            // 
            // минуліАукціониToolStripMenuItem
            // 
            минуліАукціониToolStripMenuItem.Name = "минуліАукціониToolStripMenuItem";
            минуліАукціониToolStripMenuItem.Size = new Size(112, 23);
            минуліАукціониToolStripMenuItem.Text = "Минулі аукціони";
            минуліАукціониToolStripMenuItem.Click += минуліАукціониToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = SystemColors.Control;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.FlatStyle = FlatStyle.Standard;
            toolStripComboBox1.Items.AddRange(new object[] { "Все", "Малювання", "Скульптура", "Ювелірні вироби", "Антикваріат", "Колекціонування", "Мода", "Технології", "Інше" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(700, 5);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, imageDataGridViewImageColumn, startingPriceDataGridViewTextBoxColumn, rateStepDataGridViewTextBoxColumn, startAuctionDataGridViewTextBoxColumn, endAuctionDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, deleteButtonColumn, DetalCheck });
            dataGridView1.DataSource = onlineAuctionSystemBindingSource;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Size = new Size(945, 431);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nameDataGridViewTextBoxColumn.HeaderText = "Назва лоту";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            imageDataGridViewImageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imageDataGridViewImageColumn.DataPropertyName = "image";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(4);
            imageDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle3;
            imageDataGridViewImageColumn.HeaderText = "Зображення";
            imageDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // startingPriceDataGridViewTextBoxColumn
            // 
            startingPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            startingPriceDataGridViewTextBoxColumn.DataPropertyName = "startingPrice";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            startingPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            startingPriceDataGridViewTextBoxColumn.FillWeight = 80F;
            startingPriceDataGridViewTextBoxColumn.HeaderText = "Початкова ціна (грн)";
            startingPriceDataGridViewTextBoxColumn.Name = "startingPriceDataGridViewTextBoxColumn";
            // 
            // rateStepDataGridViewTextBoxColumn
            // 
            rateStepDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rateStepDataGridViewTextBoxColumn.DataPropertyName = "rateStep";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rateStepDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            rateStepDataGridViewTextBoxColumn.FillWeight = 80F;
            rateStepDataGridViewTextBoxColumn.HeaderText = "Крок ставки(грн)";
            rateStepDataGridViewTextBoxColumn.Name = "rateStepDataGridViewTextBoxColumn";
            // 
            // startAuctionDataGridViewTextBoxColumn
            // 
            startAuctionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            startAuctionDataGridViewTextBoxColumn.DataPropertyName = "startAuction";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            startAuctionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            startAuctionDataGridViewTextBoxColumn.HeaderText = "Дата початку аукціону";
            startAuctionDataGridViewTextBoxColumn.Name = "startAuctionDataGridViewTextBoxColumn";
            // 
            // endAuctionDataGridViewTextBoxColumn
            // 
            endAuctionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            endAuctionDataGridViewTextBoxColumn.DataPropertyName = "endAuction";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            endAuctionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            endAuctionDataGridViewTextBoxColumn.HeaderText = "Дата кінця аукціону";
            endAuctionDataGridViewTextBoxColumn.Name = "endAuctionDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "ItemType";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn2.HeaderText = "Тип аукціону";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new Padding(9);
            deleteButtonColumn.DefaultCellStyle = dataGridViewCellStyle9;
            deleteButtonColumn.HeaderText = "Видалення";
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.Text = "Видалити";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // DetalCheck
            // 
            DetalCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Padding = new Padding(9);
            DetalCheck.DefaultCellStyle = dataGridViewCellStyle10;
            DetalCheck.HeaderText = "Детальна інформація";
            DetalCheck.Name = "DetalCheck";
            DetalCheck.Text = "Перегляд";
            DetalCheck.UseColumnTextForButtonValue = true;
            // 
            // onlineAuctionSystemBindingSource
            // 
            onlineAuctionSystemBindingSource.DataSource = typeof(OnlineAuctionSystem);
            // 
            // namePropertyDataGridViewTextBoxColumn
            // 
            namePropertyDataGridViewTextBoxColumn.DataPropertyName = "NameProperty";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            namePropertyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            namePropertyDataGridViewTextBoxColumn.HeaderText = "Название";
            namePropertyDataGridViewTextBoxColumn.Name = "namePropertyDataGridViewTextBoxColumn";
            // 
            // imagePropertyDataGridViewImageColumn
            // 
            imagePropertyDataGridViewImageColumn.DataPropertyName = "imageProperty";
            imagePropertyDataGridViewImageColumn.HeaderText = "Изображение";
            imagePropertyDataGridViewImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imagePropertyDataGridViewImageColumn.Name = "imagePropertyDataGridViewImageColumn";
            imagePropertyDataGridViewImageColumn.Width = 91;
            // 
            // sPPropertyDataGridViewTextBoxColumn
            // 
            sPPropertyDataGridViewTextBoxColumn.DataPropertyName = "SPProperty";
            sPPropertyDataGridViewTextBoxColumn.HeaderText = "Начальная цена(грн)";
            sPPropertyDataGridViewTextBoxColumn.Name = "sPPropertyDataGridViewTextBoxColumn";
            // 
            // rSropertyDataGridViewTextBoxColumn
            // 
            rSropertyDataGridViewTextBoxColumn.DataPropertyName = "RSroperty";
            rSropertyDataGridViewTextBoxColumn.HeaderText = "Шаг ставки(грн)";
            rSropertyDataGridViewTextBoxColumn.Name = "rSropertyDataGridViewTextBoxColumn";
            // 
            // sAPropertyDataGridViewTextBoxColumn
            // 
            sAPropertyDataGridViewTextBoxColumn.DataPropertyName = "SAProperty";
            sAPropertyDataGridViewTextBoxColumn.HeaderText = "Начало аукциона";
            sAPropertyDataGridViewTextBoxColumn.Name = "sAPropertyDataGridViewTextBoxColumn";
            // 
            // eAPropertyDataGridViewTextBoxColumn
            // 
            eAPropertyDataGridViewTextBoxColumn.DataPropertyName = "EAProperty";
            eAPropertyDataGridViewTextBoxColumn.HeaderText = "Конец ауциона";
            eAPropertyDataGridViewTextBoxColumn.Name = "eAPropertyDataGridViewTextBoxColumn";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Для перегляду повідомлення перейдіть у Аккаунт-Повідомлення!";
            notifyIcon1.BalloonTipTitle = "Нове повідомлення!";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Online Auction";
            notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(945, 458);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Онлайн аукціон Bid World";
            FormClosed += MainForm_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)onlineAuctionSystemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem входToolStripMenuItem;
        private ToolStripMenuItem авторизацияToolStripMenuItem;
        private ToolStripMenuItem регистрацияToolStripMenuItem;
        private ToolStripMenuItem профільToolStripMenuItem;
        private ToolStripMenuItem змінитиДаніToolStripMenuItem;
        private ToolStripMenuItem переглянутиІсторіюToolStripMenuItem;
        private ToolStripMenuItem адмініструванняToolStripMenuItem;
        private ToolStripMenuItem додатиЛотToolStripMenuItem;
        private ToolStripMenuItem минуліАукціониToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private Label label1;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPPropertyDataGridViewTextBoxColumn;
        private ToolStripMenuItem поповненняБалансуToolStripMenuItem;
        private DataGridViewTextBoxColumn namePropertyDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imagePropertyDataGridViewImageColumn;
        private DataGridViewTextBoxColumn sPPropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rSropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sAPropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eAPropertyDataGridViewTextBoxColumn;
        private ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem повідомленняToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private BindingSource onlineAuctionSystemBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn startingPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateStepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startAuctionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endAuctionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn deleteButtonColumn;
        private DataGridViewButtonColumn DetalCheck;
    }
}