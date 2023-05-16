
using KP.Classes;

namespace KP
{
    partial class AdminsActionsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsActionsForm));
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            actionsAdmBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            operationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            operationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actionsAdmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Час";
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn2, timeDataGridViewTextBoxColumn3, Column2, Column1 });
            dataGridView1.DataSource = actionsAdmBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(445, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Назва аукціону";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn3
            // 
            timeDataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeDataGridViewTextBoxColumn3.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn3.HeaderText = "Час";
            timeDataGridViewTextBoxColumn3.Name = "timeDataGridViewTextBoxColumn3";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "action";
            Column2.HeaderText = "Дія";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Перегляд";
            Column1.Name = "Column1";
            Column1.Text = "Переглянути";
            Column1.UseColumnTextForButtonValue = true;
            // 
            // actionsAdmBindingSource
            // 
            actionsAdmBindingSource.DataSource = typeof(Administrator.Actions);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn2
            // 
            timeDataGridViewTextBoxColumn2.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn2.HeaderText = "Time";
            timeDataGridViewTextBoxColumn2.Name = "timeDataGridViewTextBoxColumn2";
            // 
            // operationDataGridViewTextBoxColumn1
            // 
            operationDataGridViewTextBoxColumn1.DataPropertyName = "Operation";
            operationDataGridViewTextBoxColumn1.HeaderText = "Operation";
            operationDataGridViewTextBoxColumn1.Name = "operationDataGridViewTextBoxColumn1";
            operationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Назва аукціону";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn1.HeaderText = "Час";
            timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            // 
            // operationDataGridViewTextBoxColumn
            // 
            operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            operationDataGridViewTextBoxColumn.HeaderText = "Операція";
            operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            operationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminsActionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 275);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminsActionsForm";
            Text = "Історія дій адміністратора";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)actionsAdmBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn actionpropertyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn auctionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private BindingSource actionsAdmBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column1;
    }
}