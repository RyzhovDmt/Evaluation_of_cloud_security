namespace WindowsFormsApp1
{
    partial class Fuzzy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.predefinedTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оМетодеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОТестахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конфигурация1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переменныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.configurationUI1 = new WindowsFormsApp1.ConfigurationUI();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.variable1 = new WindowsFormsApp1.Variable();
            this.button1 = new System.Windows.Forms.Button();
            this.InOutTabs = new System.Windows.Forms.TabControl();
            this.Input = new System.Windows.Forms.TabPage();
            this.InputView = new System.Windows.Forms.ListView();
            this.Output = new System.Windows.Forms.TabPage();
            this.OutputView = new System.Windows.Forms.ListView();
            this.AddVariable = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rule1 = new WindowsFormsApp1.RuleUI();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reultsUI1 = new WindowsFormsApp1.ReultsUI();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.InOutTabs.SuspendLayout();
            this.Input.SuspendLayout();
            this.Output.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.predefinedTestsToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.closeToolStripMenuItem.Text = "Очистить";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.closeToolStripMenuItem1.Text = "Закрыть";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem1_Click);
            // 
            // predefinedTestsToolStripMenuItem
            // 
            this.predefinedTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test2ToolStripMenuItem});
            this.predefinedTestsToolStripMenuItem.Name = "predefinedTestsToolStripMenuItem";
            this.predefinedTestsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.predefinedTestsToolStripMenuItem.Text = "Тесты";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.test2ToolStripMenuItem.Text = "Конфигурация 1";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.Test2ToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.оМетодеToolStripMenuItem,
            this.информацияОТестахToolStripMenuItem});
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
            // информацияОТестахToolStripMenuItem
            // 
            this.информацияОТестахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конфигурация1ToolStripMenuItem});
            this.информацияОТестахToolStripMenuItem.Name = "информацияОТестахToolStripMenuItem";
            this.информацияОТестахToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.информацияОТестахToolStripMenuItem.Text = "О тестах";
            // 
            // конфигурация1ToolStripMenuItem
            // 
            this.конфигурация1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переменныеToolStripMenuItem,
            this.правилаToolStripMenuItem});
            this.конфигурация1ToolStripMenuItem.Name = "конфигурация1ToolStripMenuItem";
            this.конфигурация1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.конфигурация1ToolStripMenuItem.Text = "Конфигурация 1";
            this.конфигурация1ToolStripMenuItem.Click += new System.EventHandler(this.Конфигурация1ToolStripMenuItem_Click);
            // 
            // переменныеToolStripMenuItem
            // 
            this.переменныеToolStripMenuItem.Name = "переменныеToolStripMenuItem";
            this.переменныеToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.переменныеToolStripMenuItem.Text = "Переменные";
            this.переменныеToolStripMenuItem.Click += new System.EventHandler(this.ПеременныеToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.ПравилаToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.tabPage5);
            this.MainPanel.Controls.Add(this.tabPage2);
            this.MainPanel.Controls.Add(this.tabPage3);
            this.MainPanel.Controls.Add(this.tabPage4);
            this.MainPanel.Location = new System.Drawing.Point(29, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.SelectedIndex = 0;
            this.MainPanel.Size = new System.Drawing.Size(1005, 527);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.SelectedIndexChanged += new System.EventHandler(this.MainPanel_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.configurationUI1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(997, 501);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Настройки";
            // 
            // configurationUI1
            // 
            this.configurationUI1.Location = new System.Drawing.Point(265, 77);
            this.configurationUI1.Name = "configurationUI1";
            this.configurationUI1.Size = new System.Drawing.Size(532, 360);
            this.configurationUI1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.variable1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.InOutTabs);
            this.tabPage2.Controls.Add(this.AddVariable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Переменные";
            // 
            // variable1
            // 
            this.variable1.Current = null;
            this.variable1.Location = new System.Drawing.Point(158, 17);
            this.variable1.Name = "variable1";
            this.variable1.Size = new System.Drawing.Size(792, 457);
            this.variable1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить переменную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InOutTabs
            // 
            this.InOutTabs.Controls.Add(this.Input);
            this.InOutTabs.Controls.Add(this.Output);
            this.InOutTabs.Location = new System.Drawing.Point(20, 200);
            this.InOutTabs.Name = "InOutTabs";
            this.InOutTabs.SelectedIndex = 0;
            this.InOutTabs.Size = new System.Drawing.Size(117, 258);
            this.InOutTabs.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.InputView);
            this.Input.Location = new System.Drawing.Point(4, 22);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(3);
            this.Input.Size = new System.Drawing.Size(109, 232);
            this.Input.TabIndex = 0;
            this.Input.Text = "Входные";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // InputView
            // 
            this.InputView.HideSelection = false;
            this.InputView.Location = new System.Drawing.Point(1, 0);
            this.InputView.Name = "InputView";
            this.InputView.Size = new System.Drawing.Size(106, 232);
            this.InputView.TabIndex = 1;
            this.InputView.UseCompatibleStateImageBehavior = false;
            this.InputView.SelectedIndexChanged += new System.EventHandler(this.InputView_SelectedIndexChanged);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.OutputView);
            this.Output.Location = new System.Drawing.Point(4, 22);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(3);
            this.Output.Size = new System.Drawing.Size(109, 232);
            this.Output.TabIndex = 1;
            this.Output.Text = "Выходные";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // OutputView
            // 
            this.OutputView.HideSelection = false;
            this.OutputView.Location = new System.Drawing.Point(0, 0);
            this.OutputView.MultiSelect = false;
            this.OutputView.Name = "OutputView";
            this.OutputView.Size = new System.Drawing.Size(109, 182);
            this.OutputView.TabIndex = 0;
            this.OutputView.UseCompatibleStateImageBehavior = false;
            this.OutputView.SelectedIndexChanged += new System.EventHandler(this.OutputView_SelectedIndexChanged);
            // 
            // AddVariable
            // 
            this.AddVariable.Location = new System.Drawing.Point(20, 55);
            this.AddVariable.Name = "AddVariable";
            this.AddVariable.Size = new System.Drawing.Size(98, 37);
            this.AddVariable.TabIndex = 2;
            this.AddVariable.Text = "Новая переменная";
            this.AddVariable.UseVisualStyleBackColor = true;
            this.AddVariable.Click += new System.EventHandler(this.AddVariable_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.rule1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(997, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Правила";
            // 
            // rule1
            // 
            this.rule1.Location = new System.Drawing.Point(33, 17);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(864, 462);
            this.rule1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.reultsUI1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(997, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Результаты";
            // 
            // reultsUI1
            // 
            this.reultsUI1.Location = new System.Drawing.Point(3, 3);
            this.reultsUI1.Name = "reultsUI1";
            this.reultsUI1.Size = new System.Drawing.Size(896, 492);
            this.reultsUI1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(434, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Нечеткая логика";
            // 
            // Fuzzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 594);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Fuzzy";
            this.Text = "Нечеткая логика";
            this.Load += new System.EventHandler(this.Fuzzy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.InOutTabs.ResumeLayout(false);
            this.Input.ResumeLayout(false);
            this.Output.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem predefinedTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.TabControl MainPanel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl InOutTabs;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.ListView InputView;
        private System.Windows.Forms.TabPage Output;
        private System.Windows.Forms.ListView OutputView;
        private System.Windows.Forms.Button AddVariable;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ConfigurationUI configurationUI1;
        private Variable variable1;
        private RuleUI rule1;
        private ReultsUI reultsUI1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem информацияОТестахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конфигурация1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переменныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оМетодеToolStripMenuItem;
    }
}