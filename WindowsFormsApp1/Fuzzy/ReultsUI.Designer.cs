namespace WindowsFormsApp1
{
    partial class ReultsUI
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
            this.CrispView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CrispPan = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.DeFuzzPan = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.EnginePan = new System.Windows.Forms.TableLayoutPanel();
            this.FuzzPan = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InTxT = new System.Windows.Forms.TextBox();
            this.VarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrispView
            // 
            this.CrispView.HideSelection = false;
            this.CrispView.Location = new System.Drawing.Point(138, 75);
            this.CrispView.MultiSelect = false;
            this.CrispView.Name = "CrispView";
            this.CrispView.Size = new System.Drawing.Size(530, 45);
            this.CrispView.TabIndex = 16;
            this.CrispView.UseCompatibleStateImageBehavior = false;
            this.CrispView.View = System.Windows.Forms.View.Tile;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выходные параметры";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(690, 29);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CrispPan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DeFuzzPan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EnginePan);
            this.groupBox1.Controls.Add(this.FuzzPan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 350);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет";
            // 
            // CrispPan
            // 
            this.CrispPan.AutoScroll = true;
            this.CrispPan.ColumnCount = 1;
            this.CrispPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CrispPan.Location = new System.Drawing.Point(10, 43);
            this.CrispPan.Name = "CrispPan";
            this.CrispPan.RowCount = 1;
            this.CrispPan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CrispPan.Size = new System.Drawing.Size(131, 233);
            this.CrispPan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Выходные переменные";
            // 
            // DeFuzzPan
            // 
            this.DeFuzzPan.AutoScroll = true;
            this.DeFuzzPan.ColumnCount = 1;
            this.DeFuzzPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DeFuzzPan.Location = new System.Drawing.Point(536, 43);
            this.DeFuzzPan.Name = "DeFuzzPan";
            this.DeFuzzPan.RowCount = 1;
            this.DeFuzzPan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DeFuzzPan.Size = new System.Drawing.Size(195, 233);
            this.DeFuzzPan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Правила";
            // 
            // EnginePan
            // 
            this.EnginePan.AutoScroll = true;
            this.EnginePan.ColumnCount = 1;
            this.EnginePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EnginePan.Location = new System.Drawing.Point(378, 43);
            this.EnginePan.Name = "EnginePan";
            this.EnginePan.RowCount = 1;
            this.EnginePan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EnginePan.Size = new System.Drawing.Size(136, 233);
            this.EnginePan.TabIndex = 4;
            // 
            // FuzzPan
            // 
            this.FuzzPan.AutoScroll = true;
            this.FuzzPan.ColumnCount = 1;
            this.FuzzPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FuzzPan.Location = new System.Drawing.Point(164, 43);
            this.FuzzPan.Name = "FuzzPan";
            this.FuzzPan.RowCount = 1;
            this.FuzzPan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FuzzPan.Size = new System.Drawing.Size(192, 233);
            this.FuzzPan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Фаззификация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Входные переменные";
            // 
            // InTxT
            // 
            this.InTxT.Location = new System.Drawing.Point(138, 32);
            this.InTxT.Name = "InTxT";
            this.InTxT.Size = new System.Drawing.Size(530, 20);
            this.InTxT.TabIndex = 12;
            this.InTxT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InTxT_KeyUp);
            // 
            // VarLabel
            // 
            this.VarLabel.AutoSize = true;
            this.VarLabel.Location = new System.Drawing.Point(135, 16);
            this.VarLabel.Name = "VarLabel";
            this.VarLabel.Size = new System.Drawing.Size(0, 13);
            this.VarLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Входные параметры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить результаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ReultsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CrispView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InTxT);
            this.Controls.Add(this.VarLabel);
            this.Controls.Add(this.label1);
            this.Name = "ReultsUI";
            this.Size = new System.Drawing.Size(782, 492);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CrispView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel CrispPan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel DeFuzzPan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel EnginePan;
        private System.Windows.Forms.TableLayoutPanel FuzzPan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InTxT;
        private System.Windows.Forms.Label VarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
