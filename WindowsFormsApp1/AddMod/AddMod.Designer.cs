namespace WindowsFormsApp1
{
    partial class AddMod
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
            this.res_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.coof_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оМетодеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // res_button
            // 
            this.res_button.Location = new System.Drawing.Point(101, 265);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(112, 38);
            this.res_button.TabIndex = 0;
            this.res_button.Text = "Просмотр результатов";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.Res_button_Click);
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(101, 86);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(112, 38);
            this.new_button.TabIndex = 1;
            this.new_button.Text = "Новый компонент";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(101, 143);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(112, 38);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "Очистить все";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // coof_button
            // 
            this.coof_button.Location = new System.Drawing.Point(101, 203);
            this.coof_button.Name = "coof_button";
            this.coof_button.Size = new System.Drawing.Size(112, 38);
            this.coof_button.TabIndex = 3;
            this.coof_button.Text = "Общие показатели весомости";
            this.coof_button.UseVisualStyleBackColor = true;
            this.coof_button.Click += new System.EventHandler(this.Coof_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "Аддитивная модель";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьВсеToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.ОчиститьВсеToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьToolStripMenuItem_Click);
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
            // оМетодеToolStripMenuItem
            // 
            this.оМетодеToolStripMenuItem.Name = "оМетодеToolStripMenuItem";
            this.оМетодеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оМетодеToolStripMenuItem.Text = "О методе";
            this.оМетодеToolStripMenuItem.Click += new System.EventHandler(this.ОМетодеToolStripMenuItem_Click);
            // 
            // AddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 355);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.coof_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddMod";
            this.Text = "Аддитивная модель";
            this.Load += new System.EventHandler(this.AddMod_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button coof_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оМетодеToolStripMenuItem;
    }
}