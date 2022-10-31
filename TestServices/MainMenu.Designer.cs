
namespace TestServices
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.List_of_services_button = new System.Windows.Forms.Button();
            this.List_of_using_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_of_services_button
            // 
            this.List_of_services_button.Location = new System.Drawing.Point(21, 57);
            this.List_of_services_button.Name = "List_of_services_button";
            this.List_of_services_button.Size = new System.Drawing.Size(146, 52);
            this.List_of_services_button.TabIndex = 0;
            this.List_of_services_button.Text = "Таблица видов услуг";
            this.List_of_services_button.UseVisualStyleBackColor = true;
            this.List_of_services_button.Click += new System.EventHandler(this.List_of_services_button_Click);
            // 
            // List_of_using_button
            // 
            this.List_of_using_button.Location = new System.Drawing.Point(268, 57);
            this.List_of_using_button.Name = "List_of_using_button";
            this.List_of_using_button.Size = new System.Drawing.Size(146, 52);
            this.List_of_using_button.TabIndex = 1;
            this.List_of_using_button.Text = "Таблица записей запросов услуг";
            this.List_of_using_button.UseVisualStyleBackColor = true;
            this.List_of_using_button.Click += new System.EventHandler(this.List_of_using_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(144, 145);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(146, 52);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestServices.Properties.Resources.main_background;
            this.ClientSize = new System.Drawing.Size(435, 254);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.List_of_using_button);
            this.Controls.Add(this.List_of_services_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(451, 292);
            this.MinimumSize = new System.Drawing.Size(451, 292);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт социальных услуг";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button List_of_services_button;
        private System.Windows.Forms.Button List_of_using_button;
        private System.Windows.Forms.Button Exit_button;
    }
}