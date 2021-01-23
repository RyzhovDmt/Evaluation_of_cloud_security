namespace WindowsFormsApp1
{
    partial class RuleUI
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RulePan = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutRulePan = new System.Windows.Forms.FlowLayoutPanel();
            this.InRulePan = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearRuleBtn = new System.Windows.Forms.Button();
            this.addRuleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VarTree = new System.Windows.Forms.TreeView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RulePan);
            this.groupBox3.Location = new System.Drawing.Point(3, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 218);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Правила";
            // 
            // RulePan
            // 
            this.RulePan.AutoScroll = true;
            this.RulePan.ColumnCount = 1;
            this.RulePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.RulePan.Location = new System.Drawing.Point(6, 19);
            this.RulePan.Name = "RulePan";
            this.RulePan.RowCount = 1;
            this.RulePan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RulePan.Size = new System.Drawing.Size(836, 193);
            this.RulePan.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.OutRulePan);
            this.groupBox2.Controls.Add(this.addRuleBtn);
            this.groupBox2.Controls.Add(this.InRulePan);
            this.groupBox2.Controls.Add(this.ClearRuleBtn);
            this.groupBox2.Location = new System.Drawing.Point(166, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Текущее правило";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ТО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ЕСЛИ";
            // 
            // OutRulePan
            // 
            this.OutRulePan.AutoScroll = true;
            this.OutRulePan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutRulePan.Location = new System.Drawing.Point(7, 124);
            this.OutRulePan.Name = "OutRulePan";
            this.OutRulePan.Size = new System.Drawing.Size(530, 76);
            this.OutRulePan.TabIndex = 3;
            // 
            // InRulePan
            // 
            this.InRulePan.AutoScroll = true;
            this.InRulePan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InRulePan.Location = new System.Drawing.Point(7, 33);
            this.InRulePan.Name = "InRulePan";
            this.InRulePan.Size = new System.Drawing.Size(530, 72);
            this.InRulePan.TabIndex = 2;
            // 
            // ClearRuleBtn
            // 
            this.ClearRuleBtn.Location = new System.Drawing.Point(586, 177);
            this.ClearRuleBtn.Name = "ClearRuleBtn";
            this.ClearRuleBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearRuleBtn.TabIndex = 1;
            this.ClearRuleBtn.Text = "Очистить";
            this.ClearRuleBtn.UseVisualStyleBackColor = true;
            this.ClearRuleBtn.Click += new System.EventHandler(this.ClearRuleBtn_Click);
            // 
            // addRuleBtn
            // 
            this.addRuleBtn.Location = new System.Drawing.Point(586, 15);
            this.addRuleBtn.Name = "addRuleBtn";
            this.addRuleBtn.Size = new System.Drawing.Size(75, 23);
            this.addRuleBtn.TabIndex = 0;
            this.addRuleBtn.Text = "Добавить";
            this.addRuleBtn.UseVisualStyleBackColor = true;
            this.addRuleBtn.Click += new System.EventHandler(this.AddRuleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VarTree);
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Переменные";
            // 
            // VarTree
            // 
            this.VarTree.HotTracking = true;
            this.VarTree.Location = new System.Drawing.Point(6, 20);
            this.VarTree.Name = "VarTree";
            this.VarTree.Size = new System.Drawing.Size(140, 156);
            this.VarTree.TabIndex = 0;
            this.VarTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.VarTree_NodeMouseDoubleClick);
            // 
            // RuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RuleUI";
            this.Size = new System.Drawing.Size(864, 450);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel RulePan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel OutRulePan;
        private System.Windows.Forms.FlowLayoutPanel InRulePan;
        private System.Windows.Forms.Button ClearRuleBtn;
        private System.Windows.Forms.Button addRuleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView VarTree;
    }
}
