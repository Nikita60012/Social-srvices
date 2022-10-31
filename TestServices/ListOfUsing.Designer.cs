
namespace TestServices
{
    partial class ListOfUsing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfUsing));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeOfService_comboBox = new System.Windows.Forms.ComboBox();
            this.currentDate = new System.Windows.Forms.DateTimePicker();
            this.FIO_field = new System.Windows.Forms.TextBox();
            this.chooseService_label = new System.Windows.Forms.Label();
            this.FIO_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PeopleName,
            this.TypeOfService,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(543, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // typeOfService_comboBox
            // 
            this.typeOfService_comboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.typeOfService_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfService_comboBox.FormattingEnabled = true;
            this.typeOfService_comboBox.Location = new System.Drawing.Point(670, 139);
            this.typeOfService_comboBox.Name = "typeOfService_comboBox";
            this.typeOfService_comboBox.Size = new System.Drawing.Size(219, 21);
            this.typeOfService_comboBox.TabIndex = 1;
            // 
            // currentDate
            // 
            this.currentDate.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.currentDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.currentDate.Location = new System.Drawing.Point(670, 217);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(219, 20);
            this.currentDate.TabIndex = 2;
            // 
            // FIO_field
            // 
            this.FIO_field.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FIO_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO_field.Location = new System.Drawing.Point(670, 78);
            this.FIO_field.Name = "FIO_field";
            this.FIO_field.Size = new System.Drawing.Size(219, 20);
            this.FIO_field.TabIndex = 3;
            // 
            // chooseService_label
            // 
            this.chooseService_label.AutoSize = true;
            this.chooseService_label.BackColor = System.Drawing.Color.Transparent;
            this.chooseService_label.Location = new System.Drawing.Point(596, 142);
            this.chooseService_label.Name = "chooseService_label";
            this.chooseService_label.Size = new System.Drawing.Size(62, 13);
            this.chooseService_label.TabIndex = 4;
            this.chooseService_label.Text = "Вид услуги";
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.BackColor = System.Drawing.Color.Transparent;
            this.FIO_label.Location = new System.Drawing.Point(596, 81);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(34, 13);
            this.FIO_label.TabIndex = 5;
            this.FIO_label.Text = "ФИО";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.BackColor = System.Drawing.Color.Transparent;
            this.date_label.Location = new System.Drawing.Point(596, 217);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(33, 13);
            this.date_label.TabIndex = 6;
            this.date_label.Text = "Дата";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(670, 270);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(97, 34);
            this.Delete_button.TabIndex = 8;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(792, 270);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(97, 34);
            this.Save_button.TabIndex = 9;
            this.Save_button.Text = "Добавить новую запись";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back_button.Location = new System.Drawing.Point(892, 415);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 30;
            // 
            // PeopleName
            // 
            this.PeopleName.Frozen = true;
            this.PeopleName.HeaderText = "ФИО";
            this.PeopleName.Name = "PeopleName";
            this.PeopleName.ReadOnly = true;
            this.PeopleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PeopleName.Width = 120;
            // 
            // TypeOfService
            // 
            this.TypeOfService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeOfService.Frozen = true;
            this.TypeOfService.HeaderText = "Вид услуги";
            this.TypeOfService.Name = "TypeOfService";
            this.TypeOfService.ReadOnly = true;
            this.TypeOfService.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeOfService.Width = 289;
            // 
            // Date
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.Width = 71;
            // 
            // ListOfUsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestServices.Properties.Resources.main_background;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.FIO_label);
            this.Controls.Add(this.chooseService_label);
            this.Controls.Add(this.FIO_field);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.typeOfService_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(995, 488);
            this.MinimumSize = new System.Drawing.Size(995, 488);
            this.Name = "ListOfUsing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список записей запросов услуг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox typeOfService_comboBox;
        private System.Windows.Forms.DateTimePicker currentDate;
        private System.Windows.Forms.TextBox FIO_field;
        private System.Windows.Forms.Label chooseService_label;
        private System.Windows.Forms.Label FIO_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}