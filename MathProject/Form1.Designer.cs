namespace MathProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tabRules = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackRules = new System.Windows.Forms.Button();
            this.tabScoreBoard = new System.Windows.Forms.TabPage();
            this.lsbScore = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackScore = new System.Windows.Forms.Button();
            this.tabGameSettings = new System.Windows.Forms.TabPage();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTypeOfMath = new System.Windows.Forms.ComboBox();
            this.cbxDifficulty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackSettings = new System.Windows.Forms.Button();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblStreak = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabRules.SuspendLayout();
            this.tabScoreBoard.SuspendLayout();
            this.tabGameSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabRules);
            this.tabControl.Controls.Add(this.tabScoreBoard);
            this.tabControl.Controls.Add(this.tabGameSettings);
            this.tabControl.Controls.Add(this.tabGame);
            this.tabControl.Location = new System.Drawing.Point(67, 56);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(420, 329);
            this.tabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Black;
            this.tabHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.btnScoreBoard);
            this.tabHome.Controls.Add(this.btnRules);
            this.tabHome.Controls.Add(this.btnNewGame);
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(412, 301);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Math Practice";
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScoreBoard.Location = new System.Drawing.Point(140, 218);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(113, 52);
            this.btnScoreBoard.TabIndex = 2;
            this.btnScoreBoard.Text = "Score Board";
            this.btnScoreBoard.UseVisualStyleBackColor = true;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRules.Location = new System.Drawing.Point(140, 149);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(113, 52);
            this.btnRules.TabIndex = 1;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.Location = new System.Drawing.Point(140, 80);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(113, 52);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tabRules
            // 
            this.tabRules.BackColor = System.Drawing.Color.Black;
            this.tabRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRules.Controls.Add(this.listBox1);
            this.tabRules.Controls.Add(this.label2);
            this.tabRules.Controls.Add(this.btnBackRules);
            this.tabRules.Location = new System.Drawing.Point(4, 24);
            this.tabRules.Name = "tabRules";
            this.tabRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabRules.Size = new System.Drawing.Size(412, 301);
            this.tabRules.TabIndex = 1;
            this.tabRules.Text = "Rules";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "- You have three lives",
            "",
            "- You have 60 seconds per a question",
            "",
            "- You can select between Easy and Hard difficulties",
            "",
            "- You can choose between 4 types of math"});
            this.listBox1.Location = new System.Drawing.Point(62, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 139);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(164, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rules";
            // 
            // btnBackRules
            // 
            this.btnBackRules.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackRules.Location = new System.Drawing.Point(145, 225);
            this.btnBackRules.Name = "btnBackRules";
            this.btnBackRules.Size = new System.Drawing.Size(120, 55);
            this.btnBackRules.TabIndex = 0;
            this.btnBackRules.Text = "Back";
            this.btnBackRules.UseVisualStyleBackColor = false;
            this.btnBackRules.Click += new System.EventHandler(this.btnBackRules_Click);
            // 
            // tabScoreBoard
            // 
            this.tabScoreBoard.BackColor = System.Drawing.Color.Black;
            this.tabScoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabScoreBoard.Controls.Add(this.lsbScore);
            this.tabScoreBoard.Controls.Add(this.label3);
            this.tabScoreBoard.Controls.Add(this.btnBackScore);
            this.tabScoreBoard.Location = new System.Drawing.Point(4, 24);
            this.tabScoreBoard.Name = "tabScoreBoard";
            this.tabScoreBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabScoreBoard.Size = new System.Drawing.Size(412, 301);
            this.tabScoreBoard.TabIndex = 2;
            this.tabScoreBoard.Text = "Score Board";
            // 
            // lsbScore
            // 
            this.lsbScore.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lsbScore.FormattingEnabled = true;
            this.lsbScore.ItemHeight = 15;
            this.lsbScore.Location = new System.Drawing.Point(69, 69);
            this.lsbScore.Name = "lsbScore";
            this.lsbScore.Size = new System.Drawing.Size(266, 139);
            this.lsbScore.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score-Board";
            // 
            // btnBackScore
            // 
            this.btnBackScore.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackScore.Location = new System.Drawing.Point(145, 225);
            this.btnBackScore.Name = "btnBackScore";
            this.btnBackScore.Size = new System.Drawing.Size(120, 55);
            this.btnBackScore.TabIndex = 0;
            this.btnBackScore.Text = "Back";
            this.btnBackScore.UseVisualStyleBackColor = false;
            this.btnBackScore.Click += new System.EventHandler(this.btnBackScore_Click);
            // 
            // tabGameSettings
            // 
            this.tabGameSettings.BackColor = System.Drawing.Color.Black;
            this.tabGameSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGameSettings.Controls.Add(this.btnStartGame);
            this.tabGameSettings.Controls.Add(this.groupBox1);
            this.tabGameSettings.Controls.Add(this.label4);
            this.tabGameSettings.Controls.Add(this.btnBackSettings);
            this.tabGameSettings.Location = new System.Drawing.Point(4, 24);
            this.tabGameSettings.Name = "tabGameSettings";
            this.tabGameSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameSettings.Size = new System.Drawing.Size(412, 301);
            this.tabGameSettings.TabIndex = 3;
            this.tabGameSettings.Text = " Game Settings";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(211, 224);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(120, 55);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxTypeOfMath);
            this.groupBox1.Controls.Add(this.cbxDifficulty);
            this.groupBox1.Location = new System.Drawing.Point(53, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name of player:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Difficulty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type of math:";
            // 
            // cbxTypeOfMath
            // 
            this.cbxTypeOfMath.FormattingEnabled = true;
            this.cbxTypeOfMath.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Mixed"});
            this.cbxTypeOfMath.Location = new System.Drawing.Point(158, 120);
            this.cbxTypeOfMath.Name = "cbxTypeOfMath";
            this.cbxTypeOfMath.Size = new System.Drawing.Size(121, 23);
            this.cbxTypeOfMath.TabIndex = 1;
            // 
            // cbxDifficulty
            // 
            this.cbxDifficulty.FormattingEnabled = true;
            this.cbxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Hard"});
            this.cbxDifficulty.Location = new System.Drawing.Point(157, 78);
            this.cbxDifficulty.Name = "cbxDifficulty";
            this.cbxDifficulty.Size = new System.Drawing.Size(121, 23);
            this.cbxDifficulty.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(145, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Settings";
            // 
            // btnBackSettings
            // 
            this.btnBackSettings.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackSettings.Location = new System.Drawing.Point(72, 224);
            this.btnBackSettings.Name = "btnBackSettings";
            this.btnBackSettings.Size = new System.Drawing.Size(120, 55);
            this.btnBackSettings.TabIndex = 0;
            this.btnBackSettings.Text = "Back";
            this.btnBackSettings.UseVisualStyleBackColor = false;
            this.btnBackSettings.Click += new System.EventHandler(this.btnBackSettings_Click);
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.Black;
            this.tabGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGame.Controls.Add(this.lblTimer);
            this.tabGame.Controls.Add(this.label12);
            this.tabGame.Controls.Add(this.label13);
            this.tabGame.Controls.Add(this.lblLife);
            this.tabGame.Controls.Add(this.lblStreak);
            this.tabGame.Controls.Add(this.btnSubmit);
            this.tabGame.Controls.Add(this.txtQuestion);
            this.tabGame.Controls.Add(this.label11);
            this.tabGame.Controls.Add(this.label10);
            this.tabGame.Controls.Add(this.txtAnswer);
            this.tabGame.Controls.Add(this.label8);
            this.tabGame.Controls.Add(this.label9);
            this.tabGame.Controls.Add(this.btnHome);
            this.tabGame.Location = new System.Drawing.Point(4, 24);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(412, 301);
            this.tabGame.TabIndex = 4;
            this.tabGame.Text = "Game";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;           
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(63, 74);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 15);
            this.lblTimer.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(8, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(63, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 2;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;            
            this.lblLife.ForeColor = System.Drawing.Color.Red;
            this.lblLife.Location = new System.Drawing.Point(63, 5);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(0, 15);
            this.lblLife.TabIndex = 8;
            // 
            // lblStreak
            // 
            this.lblStreak.AutoSize = true;
            
            this.lblStreak.ForeColor = System.Drawing.Color.Red;
            this.lblStreak.Location = new System.Drawing.Point(63, 39);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(0, 15);
            this.lblStreak.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(145, 222);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 55);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(145, 113);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(120, 23);
            this.txtQuestion.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(78, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Answer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(68, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Question:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(145, 151);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(120, 23);
            this.txtAnswer.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Streak:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lifes: ";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.IndianRed;
            this.btnHome.Location = new System.Drawing.Point(288, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 55);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabRules.ResumeLayout(false);
            this.tabRules.PerformLayout();
            this.tabScoreBoard.ResumeLayout(false);
            this.tabScoreBoard.PerformLayout();
            this.tabGameSettings.ResumeLayout(false);
            this.tabGameSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabHome;
        private TabPage tabRules;
        private Label label1;
        private Button btnScoreBoard;
        private Button btnRules;
        private Button btnNewGame;
        private TabPage tabScoreBoard;
        private TabPage tabGameSettings;
        private TabPage tabGame;
        private Label label2;
        private Button btnBackRules;
        private Button btnBackScore;
        private Button btnBackSettings;
        private Label label3;
        private Label label4;
        private Button btnHome;
        private Button btnStartGame;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private ComboBox cbxTypeOfMath;
        private ComboBox cbxDifficulty;
        private TextBox txtName;
        private Label label7;
        private ListBox listBox1;
        private ListBox lsbScore;
        private Label label8;
        private Label label9;
        private TextBox txtAnswer;
        private Label label11;
        private Label label10;
        private Button btnSubmit;
        private TextBox txtQuestion;
        private Label lblLife;
        private Label lblStreak;
        private System.Windows.Forms.Timer timer1;
        private Label label12;
        private Label label13;
        private Label lblTimer;
    }
}