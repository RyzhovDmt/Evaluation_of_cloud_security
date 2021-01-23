namespace WindowsFormsApp1
{
    partial class RuleItemUI
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
            this.MFCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VarText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MFCombo
            // 
            this.MFCombo.FormattingEnabled = true;
            this.MFCombo.Location = new System.Drawing.Point(131, 97);
            this.MFCombo.Name = "MFCombo";
            this.MFCombo.Size = new System.Drawing.Size(105, 21);
            this.MFCombo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "is";
            // 
            // VarText
            // 
            this.VarText.AutoSize = true;
            this.VarText.Location = new System.Drawing.Point(53, 100);
            this.VarText.Name = "VarText";
            this.VarText.Size = new System.Drawing.Size(35, 13);
            this.VarText.TabIndex = 3;
            this.VarText.Text = "label1";
            // 
            // RuleItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MFCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VarText);
            this.Name = "RuleItemUI";
            this.Size = new System.Drawing.Size(289, 215);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MFCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VarText;
    }
}
