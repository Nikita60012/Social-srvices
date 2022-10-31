
namespace TestServices
{
    partial class ListOfServices
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfServices));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save_button = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.TextBox();
            this.Types = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.identific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_of_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.identific,
            this.type_of_service,
            this.total_count});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(627, 488);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(800, 242);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(90, 52);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Добавить новый вид услуг";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Count.Location = new System.Drawing.Point(843, 205);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(90, 20);
            this.Count.TabIndex = 3;
            // 
            // Types
            // 
            this.Types.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Types.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Types.Location = new System.Drawing.Point(785, 170);
            this.Types.Name = "Types";
            this.Types.Size = new System.Drawing.Size(202, 20);
            this.Types.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(686, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вид услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(686, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Общее количество запросов";
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(671, 242);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(90, 52);
            this.Delete_button.TabIndex = 7;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.Location = new System.Drawing.Point(928, 242);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(90, 52);
            this.SaveChanges_button.TabIndex = 8;
            this.SaveChanges_button.Text = "Сохранить изменения";
            this.SaveChanges_button.UseVisualStyleBackColor = true;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back_button.Location = new System.Drawing.Point(946, 452);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 9;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // identific
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.identific.DefaultCellStyle = dataGridViewCellStyle1;
            this.identific.Frozen = true;
            this.identific.HeaderText = "ID";
            this.identific.Name = "identific";
            this.identific.ReadOnly = true;
            this.identific.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.identific.Width = 40;
            // 
            // type_of_service
            // 
            this.type_of_service.Frozen = true;
            this.type_of_service.HeaderText = "Вид услуги";
            this.type_of_service.Name = "type_of_service";
            this.type_of_service.ReadOnly = true;
            this.type_of_service.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.type_of_service.Width = 415;
            // 
            // total_count
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.total_count.DefaultCellStyle = dataGridViewCellStyle2;
            this.total_count.Frozen = true;
            this.total_count.HeaderText = "Общее количество запросов услуги";
            this.total_count.Name = "total_count";
            this.total_count.ReadOnly = true;
            this.total_count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_count.Width = 130;
            // 
            // ListOfServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestServices.Properties.Resources.main_background;
            this.CancelButton = this.Back_button;
            this.ClientSize = new System.Drawing.Size(1033, 487);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.SaveChanges_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Types);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1049, 525);
            this.MinimumSize = new System.Drawing.Size(1049, 525);
            this.Name = "ListOfServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список видов услуг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Types;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn identific;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_of_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_count;
    }
}

