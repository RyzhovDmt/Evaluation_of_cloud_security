namespace WindowsFormsApp1
{
    partial class Ontolog
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
            this.dng_button = new System.Windows.Forms.Button();
            this.component_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.угрозыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУгрозуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйКомпонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.оМетодеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dng_button
            // 
            this.dng_button.Location = new System.Drawing.Point(49, 122);
            this.dng_button.Name = "dng_button";
            this.dng_button.Size = new System.Drawing.Size(115, 36);
            this.dng_button.TabIndex = 0;
            this.dng_button.Text = "Угрозы";
            this.dng_button.UseVisualStyleBackColor = true;
            this.dng_button.Click += new System.EventHandler(this.Dng_button_Click);
            // 
            // component_button
            // 
            this.component_button.Location = new System.Drawing.Point(49, 206);
            this.component_button.Name = "component_button";
            this.component_button.Size = new System.Drawing.Size(115, 36);
            this.component_button.TabIndex = 1;
            this.component_button.Text = "Компоненты";
            this.component_button.UseVisualStyleBackColor = true;
            this.component_button.Click += new System.EventHandler(this.Component_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.функцииToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(224, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.угрозыToolStripMenuItem,
            this.компонентыToolStripMenuItem});
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.новыйToolStripMenuItem.Text = "Очистить";
            // 
            // угрозыToolStripMenuItem
            // 
            this.угрозыToolStripMenuItem.Name = "угрозыToolStripMenuItem";
            this.угрозыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.угрозыToolStripMenuItem.Text = "Угрозы";
            this.угрозыToolStripMenuItem.Click += new System.EventHandler(this.УгрозыToolStripMenuItem_Click);
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.КомпонентыToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУгрозуToolStripMenuItem,
            this.новыйКомпонентToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.функцииToolStripMenuItem.Text = "Добавить";
            // 
            // добавитьУгрозуToolStripMenuItem
            // 
            this.добавитьУгрозуToolStripMenuItem.Name = "добавитьУгрозуToolStripMenuItem";
            this.добавитьУгрозуToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьУгрозуToolStripMenuItem.Text = "Новая угроза";
            this.добавитьУгрозуToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьУгрозуToolStripMenuItem_Click);
            // 
            // новыйКомпонентToolStripMenuItem
            // 
            this.новыйКомпонентToolStripMenuItem.Name = "новыйКомпонентToolStripMenuItem";
            this.новыйКомпонентToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.новыйКомпонентToolStripMenuItem.Text = "Новый компонент";
            this.новыйКомпонентToolStripMenuItem.Click += new System.EventHandler(this.НовыйКомпонентToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оМетодеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Онтологический подход";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "Новая угроза";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 55;
            this.button2.Text = "Новый компонент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // оМетодеToolStripMenuItem
            // 
            this.оМетодеToolStripMenuItem.Name = "оМетодеToolStripMenuItem";
            this.оМетодеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оМетодеToolStripMenuItem.Text = "О методе";
            this.оМетодеToolStripMenuItem.Click += new System.EventHandler(this.ОМетодеToolStripMenuItem_Click);
            // 
            // Ontolog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.component_button);
            this.Controls.Add(this.dng_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ontolog";
            this.Text = "Ontolog";
            this.Load += new System.EventHandler(this.Ontolog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dng_button;
        private System.Windows.Forms.Button component_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУгрозуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйКомпонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem угрозыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оМетодеToolStripMenuItem;
    }
}