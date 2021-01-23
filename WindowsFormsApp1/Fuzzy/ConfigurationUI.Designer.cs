namespace WindowsFormsApp1
{
    partial class ConfigurationUI
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DefuzCombo = new System.Windows.Forms.ComboBox();
            this.ImplCombo = new System.Windows.Forms.ComboBox();
            this.AndCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DefuzCombo);
            this.groupBox1.Controls.Add(this.ImplCombo);
            this.groupBox1.Controls.Add(this.AndCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(64, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // DefuzCombo
            // 
            this.DefuzCombo.FormattingEnabled = true;
            this.DefuzCombo.Items.AddRange(new object[] {
            "Modified Heigh Defuzzification",
            "Centroid"});
            this.DefuzCombo.Location = new System.Drawing.Point(149, 101);
            this.DefuzCombo.Name = "DefuzCombo";
            this.DefuzCombo.Size = new System.Drawing.Size(175, 21);
            this.DefuzCombo.TabIndex = 5;
            this.DefuzCombo.SelectedIndexChanged += new System.EventHandler(this.DefuzCombo_SelectedIndexChanged);
            // 
            // ImplCombo
            // 
            this.ImplCombo.FormattingEnabled = true;
            this.ImplCombo.Items.AddRange(new object[] {
            "Min",
            "Prod"});
            this.ImplCombo.Location = new System.Drawing.Point(149, 63);
            this.ImplCombo.Name = "ImplCombo";
            this.ImplCombo.Size = new System.Drawing.Size(175, 21);
            this.ImplCombo.TabIndex = 4;
            this.ImplCombo.SelectedIndexChanged += new System.EventHandler(this.ImplCombo_SelectedIndexChanged);
            // 
            // AndCombo
            // 
            this.AndCombo.FormattingEnabled = true;
            this.AndCombo.Items.AddRange(new object[] {
            "Min",
            "Prod"});
            this.AndCombo.Location = new System.Drawing.Point(149, 24);
            this.AndCombo.Name = "AndCombo";
            this.AndCombo.Size = new System.Drawing.Size(175, 21);
            this.AndCombo.TabIndex = 3;
            this.AndCombo.SelectedIndexChanged += new System.EventHandler(this.AndCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Defuzzification Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Implication Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "And Method";
            // 
            // ConfigurationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigurationUI";
            this.Size = new System.Drawing.Size(532, 360);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DefuzCombo;
        private System.Windows.Forms.ComboBox ImplCombo;
        private System.Windows.Forms.ComboBox AndCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
