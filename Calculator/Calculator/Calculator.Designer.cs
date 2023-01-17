namespace Calculator
{
    partial class Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.switchButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.moduloButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.fractionButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.exponentButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearRecentButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.memoryClearButton = new System.Windows.Forms.Button();
            this.buttonDigit0 = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.posNegButton = new System.Windows.Forms.Button();
            this.recallMemoryButton = new System.Windows.Forms.Button();
            this.buttonDigit8 = new System.Windows.Forms.Button();
            this.buttonDigit9 = new System.Windows.Forms.Button();
            this.addMemoryButton = new System.Windows.Forms.Button();
            this.buttonDigit7 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonDigit6 = new System.Windows.Forms.Button();
            this.buttonDigit5 = new System.Windows.Forms.Button();
            this.buttonDigit4 = new System.Windows.Forms.Button();
            this.buttonDigit2 = new System.Windows.Forms.Button();
            this.buttonDigit3 = new System.Windows.Forms.Button();
            this.buttonDigit1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.switchButton);
            this.groupBox1.Controls.Add(this.divideButton);
            this.groupBox1.Controls.Add(this.moduloButton);
            this.groupBox1.Controls.Add(this.cosButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.multiplyButton);
            this.groupBox1.Controls.Add(this.tanButton);
            this.groupBox1.Controls.Add(this.fractionButton);
            this.groupBox1.Controls.Add(this.subtractButton);
            this.groupBox1.Controls.Add(this.sinButton);
            this.groupBox1.Controls.Add(this.exponentButton);
            this.groupBox1.Controls.Add(this.sqrtButton);
            this.groupBox1.Location = new System.Drawing.Point(29, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(243, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // switchButton
            // 
            this.switchButton.ForeColor = System.Drawing.Color.Blue;
            this.switchButton.Location = new System.Drawing.Point(162, 29);
            this.switchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(63, 69);
            this.switchButton.TabIndex = 41;
            this.switchButton.Text = "2nd";
            this.switchButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(23, 29);
            this.divideButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(63, 69);
            this.divideButton.TabIndex = 31;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // moduloButton
            // 
            this.moduloButton.Location = new System.Drawing.Point(93, 149);
            this.moduloButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moduloButton.Name = "moduloButton";
            this.moduloButton.Size = new System.Drawing.Size(63, 69);
            this.moduloButton.TabIndex = 36;
            this.moduloButton.Text = "%";
            this.moduloButton.UseVisualStyleBackColor = true;
            this.moduloButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // cosButton
            // 
            this.cosButton.Location = new System.Drawing.Point(162, 269);
            this.cosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(63, 69);
            this.cosButton.TabIndex = 38;
            this.cosButton.Text = "COS";
            this.cosButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(23, 389);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 69);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(23, 149);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(63, 69);
            this.multiplyButton.TabIndex = 32;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // tanButton
            // 
            this.tanButton.Location = new System.Drawing.Point(162, 389);
            this.tanButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(63, 69);
            this.tanButton.TabIndex = 40;
            this.tanButton.Text = "TAN";
            this.tanButton.UseVisualStyleBackColor = true;
            // 
            // fractionButton
            // 
            this.fractionButton.Location = new System.Drawing.Point(93, 389);
            this.fractionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fractionButton.Name = "fractionButton";
            this.fractionButton.Size = new System.Drawing.Size(63, 69);
            this.fractionButton.TabIndex = 37;
            this.fractionButton.Text = "1/x";
            this.fractionButton.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(23, 269);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(63, 69);
            this.subtractButton.TabIndex = 33;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(162, 149);
            this.sinButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(63, 69);
            this.sinButton.TabIndex = 39;
            this.sinButton.Text = "SIN";
            this.sinButton.UseVisualStyleBackColor = true;
            // 
            // exponentButton
            // 
            this.exponentButton.Location = new System.Drawing.Point(93, 269);
            this.exponentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exponentButton.Name = "exponentButton";
            this.exponentButton.Size = new System.Drawing.Size(63, 69);
            this.exponentButton.TabIndex = 30;
            this.exponentButton.Text = "^";
            this.exponentButton.UseVisualStyleBackColor = true;
            this.exponentButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(93, 29);
            this.sqrtButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(63, 69);
            this.sqrtButton.TabIndex = 35;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(338, 269);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 69);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // clearRecentButton
            // 
            this.clearRecentButton.ForeColor = System.Drawing.Color.Red;
            this.clearRecentButton.Location = new System.Drawing.Point(338, 389);
            this.clearRecentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearRecentButton.Name = "clearRecentButton";
            this.clearRecentButton.Size = new System.Drawing.Size(63, 69);
            this.clearRecentButton.TabIndex = 15;
            this.clearRecentButton.Text = "CE";
            this.clearRecentButton.UseVisualStyleBackColor = true;
            this.clearRecentButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.enterButton);
            this.groupBox2.Controls.Add(this.decimalButton);
            this.groupBox2.Controls.Add(this.memoryClearButton);
            this.groupBox2.Controls.Add(this.buttonDigit0);
            this.groupBox2.Controls.Add(this.offButton);
            this.groupBox2.Controls.Add(this.posNegButton);
            this.groupBox2.Controls.Add(this.recallMemoryButton);
            this.groupBox2.Controls.Add(this.buttonDigit8);
            this.groupBox2.Controls.Add(this.buttonDigit9);
            this.groupBox2.Controls.Add(this.addMemoryButton);
            this.groupBox2.Controls.Add(this.buttonDigit7);
            this.groupBox2.Controls.Add(this.backButton);
            this.groupBox2.Controls.Add(this.buttonDigit6);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.buttonDigit5);
            this.groupBox2.Controls.Add(this.clearRecentButton);
            this.groupBox2.Controls.Add(this.buttonDigit4);
            this.groupBox2.Controls.Add(this.buttonDigit2);
            this.groupBox2.Controls.Add(this.buttonDigit3);
            this.groupBox2.Controls.Add(this.buttonDigit1);
            this.groupBox2.Location = new System.Drawing.Point(280, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(425, 489);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(147, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(68, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "π";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(259, 389);
            this.enterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(63, 69);
            this.enterButton.TabIndex = 25;
            this.enterButton.Text = "=";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // decimalButton
            // 
            this.decimalButton.Location = new System.Drawing.Point(181, 389);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(63, 69);
            this.decimalButton.TabIndex = 21;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.Location = new System.Drawing.Point(259, 269);
            this.memoryClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(63, 69);
            this.memoryClearButton.TabIndex = 24;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = true;
            this.memoryClearButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit0
            // 
            this.buttonDigit0.Location = new System.Drawing.Point(102, 389);
            this.buttonDigit0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit0.Name = "buttonDigit0";
            this.buttonDigit0.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit0.TabIndex = 20;
            this.buttonDigit0.Text = "0";
            this.buttonDigit0.UseVisualStyleBackColor = true;
            this.buttonDigit0.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // offButton
            // 
            this.offButton.ForeColor = System.Drawing.Color.Red;
            this.offButton.Location = new System.Drawing.Point(338, 28);
            this.offButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(63, 69);
            this.offButton.TabIndex = 23;
            this.offButton.Text = "OFF";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // posNegButton
            // 
            this.posNegButton.Location = new System.Drawing.Point(23, 389);
            this.posNegButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.posNegButton.Name = "posNegButton";
            this.posNegButton.Size = new System.Drawing.Size(63, 69);
            this.posNegButton.TabIndex = 19;
            this.posNegButton.Text = "+/-";
            this.posNegButton.UseVisualStyleBackColor = true;
            this.posNegButton.Click += new System.EventHandler(this.PosNegButtonClick);
            // 
            // recallMemoryButton
            // 
            this.recallMemoryButton.Location = new System.Drawing.Point(259, 149);
            this.recallMemoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recallMemoryButton.Name = "recallMemoryButton";
            this.recallMemoryButton.Size = new System.Drawing.Size(63, 69);
            this.recallMemoryButton.TabIndex = 22;
            this.recallMemoryButton.Text = "MR";
            this.recallMemoryButton.UseVisualStyleBackColor = true;
            this.recallMemoryButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit8
            // 
            this.buttonDigit8.Location = new System.Drawing.Point(102, 269);
            this.buttonDigit8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit8.Name = "buttonDigit8";
            this.buttonDigit8.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit8.TabIndex = 17;
            this.buttonDigit8.Text = "8";
            this.buttonDigit8.UseVisualStyleBackColor = true;
            this.buttonDigit8.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit9
            // 
            this.buttonDigit9.Location = new System.Drawing.Point(181, 269);
            this.buttonDigit9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit9.Name = "buttonDigit9";
            this.buttonDigit9.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit9.TabIndex = 18;
            this.buttonDigit9.Text = "9";
            this.buttonDigit9.UseVisualStyleBackColor = true;
            this.buttonDigit9.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // addMemoryButton
            // 
            this.addMemoryButton.Location = new System.Drawing.Point(259, 29);
            this.addMemoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addMemoryButton.Name = "addMemoryButton";
            this.addMemoryButton.Size = new System.Drawing.Size(63, 69);
            this.addMemoryButton.TabIndex = 10;
            this.addMemoryButton.Text = "M+";
            this.addMemoryButton.UseVisualStyleBackColor = true;
            this.addMemoryButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit7
            // 
            this.buttonDigit7.Location = new System.Drawing.Point(23, 269);
            this.buttonDigit7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit7.Name = "buttonDigit7";
            this.buttonDigit7.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit7.TabIndex = 16;
            this.buttonDigit7.Text = "7";
            this.buttonDigit7.UseVisualStyleBackColor = true;
            this.buttonDigit7.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(338, 149);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 69);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit6
            // 
            this.buttonDigit6.Location = new System.Drawing.Point(181, 149);
            this.buttonDigit6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit6.Name = "buttonDigit6";
            this.buttonDigit6.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit6.TabIndex = 15;
            this.buttonDigit6.Text = "6";
            this.buttonDigit6.UseVisualStyleBackColor = true;
            this.buttonDigit6.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit5
            // 
            this.buttonDigit5.Location = new System.Drawing.Point(102, 149);
            this.buttonDigit5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit5.Name = "buttonDigit5";
            this.buttonDigit5.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit5.TabIndex = 13;
            this.buttonDigit5.Text = "5";
            this.buttonDigit5.UseVisualStyleBackColor = true;
            this.buttonDigit5.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit4
            // 
            this.buttonDigit4.Location = new System.Drawing.Point(23, 149);
            this.buttonDigit4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit4.Name = "buttonDigit4";
            this.buttonDigit4.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit4.TabIndex = 14;
            this.buttonDigit4.Text = "4";
            this.buttonDigit4.UseVisualStyleBackColor = true;
            this.buttonDigit4.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit2
            // 
            this.buttonDigit2.Location = new System.Drawing.Point(102, 29);
            this.buttonDigit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit2.Name = "buttonDigit2";
            this.buttonDigit2.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit2.TabIndex = 11;
            this.buttonDigit2.Text = "2";
            this.buttonDigit2.UseVisualStyleBackColor = true;
            this.buttonDigit2.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit3
            // 
            this.buttonDigit3.Location = new System.Drawing.Point(181, 29);
            this.buttonDigit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit3.Name = "buttonDigit3";
            this.buttonDigit3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDigit3.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit3.TabIndex = 12;
            this.buttonDigit3.Text = "3";
            this.buttonDigit3.UseVisualStyleBackColor = true;
            this.buttonDigit3.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit1
            // 
            this.buttonDigit1.Location = new System.Drawing.Point(23, 29);
            this.buttonDigit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDigit1.Name = "buttonDigit1";
            this.buttonDigit1.Size = new System.Drawing.Size(63, 69);
            this.buttonDigit1.TabIndex = 10;
            this.buttonDigit1.Text = "1";
            this.buttonDigit1.UseVisualStyleBackColor = true;
            this.buttonDigit1.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(29, 15);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter Here";
            this.textBox1.Size = new System.Drawing.Size(676, 114);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 691);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button clearRecentButton;
        private Button clearButton;
        private GroupBox groupBox2;
        private Button backButton;
        private Button memoryClearButton;
        private Button offButton;
        private Button recallMemoryButton;
        private Button addMemoryButton;
        private Button decimalButton;
        private Button buttonDigit0;
        private Button posNegButton;
        private Button buttonDigit8;
        private Button buttonDigit9;
        private Button buttonDigit7;
        private Button buttonDigit6;
        private Button buttonDigit5;
        private Button buttonDigit4;
        private Button buttonDigit2;
        private Button buttonDigit3;
        private Button buttonDigit1;
        private Button switchButton;
        private Button cosButton;
        private Button tanButton;
        private Button sinButton;
        private Button exponentButton;
        private Button fractionButton;
        private Button addButton;
        private Button moduloButton;
        private Button sqrtButton;
        private Button divideButton;
        private Button multiplyButton;
        private Button subtractButton;
        private TextBox textBox1;
        private Button enterButton;
        private Label label2;
        private Label label3;
    }
}