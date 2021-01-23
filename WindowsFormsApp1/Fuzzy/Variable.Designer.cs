namespace WindowsFormsApp1
{
    partial class Variable
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
            this.RemMFBtn = new System.Windows.Forms.Button();
            this.MfBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveMFBtn = new System.Windows.Forms.Button();
            this.MFTypeCombo = new System.Windows.Forms.ComboBox();
            this.MFParamTxT = new System.Windows.Forms.TextBox();
            this.MFNameTxT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MFView = new System.Windows.Forms.ListView();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.RangeTxT = new System.Windows.Forms.TextBox();
            this.Range = new System.Windows.Forms.Label();
            this.VarTxT = new System.Windows.Forms.TextBox();
            this.VarName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemMFBtn
            // 
            this.RemMFBtn.Location = new System.Drawing.Point(182, 365);
            this.RemMFBtn.Name = "RemMFBtn";
            this.RemMFBtn.Size = new System.Drawing.Size(183, 37);
            this.RemMFBtn.TabIndex = 24;
            this.RemMFBtn.Text = "Удалить функцию принадлежности ";
            this.RemMFBtn.UseVisualStyleBackColor = true;
            this.RemMFBtn.Click += new System.EventHandler(this.RemMFBtn_Click);
            // 
            // MfBtn
            // 
            this.MfBtn.Location = new System.Drawing.Point(182, 318);
            this.MfBtn.Name = "MfBtn";
            this.MfBtn.Size = new System.Drawing.Size(183, 37);
            this.MfBtn.TabIndex = 23;
            this.MfBtn.Text = "Добавить функцию принадлежности ";
            this.MfBtn.UseVisualStyleBackColor = true;
            this.MfBtn.Click += new System.EventHandler(this.MfBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveMFBtn);
            this.groupBox1.Controls.Add(this.MFTypeCombo);
            this.groupBox1.Controls.Add(this.MFParamTxT);
            this.groupBox1.Controls.Add(this.MFNameTxT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(411, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 133);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбраная функция";
            // 
            // SaveMFBtn
            // 
            this.SaveMFBtn.Location = new System.Drawing.Point(251, 23);
            this.SaveMFBtn.Name = "SaveMFBtn";
            this.SaveMFBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveMFBtn.TabIndex = 7;
            this.SaveMFBtn.Text = "Сохранить";
            this.SaveMFBtn.UseVisualStyleBackColor = true;
            this.SaveMFBtn.Click += new System.EventHandler(this.SaveMFBtn_Click);
            // 
            // MFTypeCombo
            // 
            this.MFTypeCombo.FormattingEnabled = true;
            this.MFTypeCombo.Items.AddRange(new object[] {
            "Trimf",
            "Trapmf"});
            this.MFTypeCombo.Location = new System.Drawing.Point(88, 61);
            this.MFTypeCombo.Name = "MFTypeCombo";
            this.MFTypeCombo.Size = new System.Drawing.Size(157, 21);
            this.MFTypeCombo.TabIndex = 6;
            // 
            // MFParamTxT
            // 
            this.MFParamTxT.Location = new System.Drawing.Point(88, 97);
            this.MFParamTxT.Name = "MFParamTxT";
            this.MFParamTxT.Size = new System.Drawing.Size(157, 20);
            this.MFParamTxT.TabIndex = 5;
            // 
            // MFNameTxT
            // 
            this.MFNameTxT.Location = new System.Drawing.Point(88, 26);
            this.MFNameTxT.Name = "MFNameTxT";
            this.MFNameTxT.Size = new System.Drawing.Size(157, 20);
            this.MFNameTxT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Параметры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Функции принадлежности ";
            // 
            // MFView
            // 
            this.MFView.HideSelection = false;
            this.MFView.Location = new System.Drawing.Point(15, 317);
            this.MFView.MultiSelect = false;
            this.MFView.Name = "MFView";
            this.MFView.Size = new System.Drawing.Size(146, 129);
            this.MFView.TabIndex = 20;
            this.MFView.UseCompatibleStateImageBehavior = false;
            this.MFView.SelectedIndexChanged += new System.EventHandler(this.MFView_SelectedIndexChanged);
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.TypeCombo.Location = new System.Drawing.Point(556, 13);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип";
            // 
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChartPanel.Location = new System.Drawing.Point(19, 49);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(724, 237);
            this.ChartPanel.TabIndex = 17;
            // 
            // RangeTxT
            // 
            this.RangeTxT.Location = new System.Drawing.Point(356, 14);
            this.RangeTxT.Name = "RangeTxT";
            this.RangeTxT.Size = new System.Drawing.Size(120, 20);
            this.RangeTxT.TabIndex = 16;
            // 
            // Range
            // 
            this.Range.AutoSize = true;
            this.Range.Location = new System.Drawing.Point(294, 17);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(56, 13);
            this.Range.TabIndex = 15;
            this.Range.Text = "Интервал";
            // 
            // VarTxT
            // 
            this.VarTxT.Location = new System.Drawing.Point(128, 14);
            this.VarTxT.Name = "VarTxT";
            this.VarTxT.Size = new System.Drawing.Size(143, 20);
            this.VarTxT.TabIndex = 14;
            // 
            // VarName
            // 
            this.VarName.AutoSize = true;
            this.VarName.Location = new System.Drawing.Point(28, 17);
            this.VarName.Name = "VarName";
            this.VarName.Size = new System.Drawing.Size(94, 13);
            this.VarName.TabIndex = 13;
            this.VarName.Text = "Имя переменной";
            // 
            // Variable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemMFBtn);
            this.Controls.Add(this.MfBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MFView);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.RangeTxT);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.VarTxT);
            this.Controls.Add(this.VarName);
            this.Name = "Variable";
            this.Size = new System.Drawing.Size(792, 457);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemMFBtn;
        private System.Windows.Forms.Button MfBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveMFBtn;
        private System.Windows.Forms.ComboBox MFTypeCombo;
        private System.Windows.Forms.TextBox MFParamTxT;
        private System.Windows.Forms.TextBox MFNameTxT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView MFView;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.TextBox RangeTxT;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.TextBox VarTxT;
        private System.Windows.Forms.Label VarName;
    }
}
