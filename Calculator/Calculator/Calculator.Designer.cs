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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.onButton = new System.Windows.Forms.Button();
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(142, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 52);
            this.button1.TabIndex = 41;
            this.button1.Text = "2nd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OperatorClick);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(20, 22);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(55, 52);
            this.divideButton.TabIndex = 31;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // moduloButton
            // 
            this.moduloButton.Location = new System.Drawing.Point(81, 112);
            this.moduloButton.Name = "moduloButton";
            this.moduloButton.Size = new System.Drawing.Size(55, 52);
            this.moduloButton.TabIndex = 36;
            this.moduloButton.Text = "%";
            this.moduloButton.UseVisualStyleBackColor = true;
            this.moduloButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // cosButton
            // 
            this.cosButton.Location = new System.Drawing.Point(142, 202);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(55, 52);
            this.cosButton.TabIndex = 38;
            this.cosButton.Text = "COS";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 292);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 52);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(20, 112);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(55, 52);
            this.multiplyButton.TabIndex = 32;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // tanButton
            // 
            this.tanButton.Location = new System.Drawing.Point(142, 292);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(55, 52);
            this.tanButton.TabIndex = 40;
            this.tanButton.Text = "TAN";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // fractionButton
            // 
            this.fractionButton.Location = new System.Drawing.Point(81, 292);
            this.fractionButton.Name = "fractionButton";
            this.fractionButton.Size = new System.Drawing.Size(55, 52);
            this.fractionButton.TabIndex = 37;
            this.fractionButton.Text = "1/x";
            this.fractionButton.UseVisualStyleBackColor = true;
            this.fractionButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(20, 202);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(55, 52);
            this.subtractButton.TabIndex = 33;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(142, 112);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(55, 52);
            this.sinButton.TabIndex = 39;
            this.sinButton.Text = "SIN";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // exponentButton
            // 
            this.exponentButton.Location = new System.Drawing.Point(81, 202);
            this.exponentButton.Name = "exponentButton";
            this.exponentButton.Size = new System.Drawing.Size(55, 52);
            this.exponentButton.TabIndex = 30;
            this.exponentButton.Text = "^";
            this.exponentButton.UseVisualStyleBackColor = true;
            this.exponentButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(81, 22);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(55, 52);
            this.sqrtButton.TabIndex = 35;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(296, 202);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(55, 52);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // clearRecentButton
            // 
            this.clearRecentButton.ForeColor = System.Drawing.Color.Red;
            this.clearRecentButton.Location = new System.Drawing.Point(296, 292);
            this.clearRecentButton.Name = "clearRecentButton";
            this.clearRecentButton.Size = new System.Drawing.Size(55, 52);
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
            this.groupBox2.Controls.Add(this.onButton);
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
            this.groupBox2.Location = new System.Drawing.Point(245, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 367);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(129, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "π";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(227, 292);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(55, 52);
            this.enterButton.TabIndex = 25;
            this.enterButton.Text = "=";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.OperatorClick);
            // 
            // decimalButton
            // 
            this.decimalButton.Location = new System.Drawing.Point(158, 292);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(55, 52);
            this.decimalButton.TabIndex = 21;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.Location = new System.Drawing.Point(227, 202);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(55, 52);
            this.memoryClearButton.TabIndex = 24;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = true;
            this.memoryClearButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit0
            // 
            this.buttonDigit0.Location = new System.Drawing.Point(89, 292);
            this.buttonDigit0.Name = "buttonDigit0";
            this.buttonDigit0.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit0.TabIndex = 20;
            this.buttonDigit0.Text = "0";
            this.buttonDigit0.UseVisualStyleBackColor = true;
            this.buttonDigit0.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // onButton
            // 
            this.onButton.ForeColor = System.Drawing.Color.Green;
            this.onButton.Location = new System.Drawing.Point(296, 21);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(55, 52);
            this.onButton.TabIndex = 23;
            this.onButton.Text = "ON";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // posNegButton
            // 
            this.posNegButton.Location = new System.Drawing.Point(20, 292);
            this.posNegButton.Name = "posNegButton";
            this.posNegButton.Size = new System.Drawing.Size(55, 52);
            this.posNegButton.TabIndex = 19;
            this.posNegButton.Text = "+/-";
            this.posNegButton.UseVisualStyleBackColor = true;
            this.posNegButton.Click += new System.EventHandler(this.PosNegButtonClick);
            // 
            // recallMemoryButton
            // 
            this.recallMemoryButton.Location = new System.Drawing.Point(227, 112);
            this.recallMemoryButton.Name = "recallMemoryButton";
            this.recallMemoryButton.Size = new System.Drawing.Size(55, 52);
            this.recallMemoryButton.TabIndex = 22;
            this.recallMemoryButton.Text = "MR";
            this.recallMemoryButton.UseVisualStyleBackColor = true;
            this.recallMemoryButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit8
            // 
            this.buttonDigit8.Location = new System.Drawing.Point(89, 202);
            this.buttonDigit8.Name = "buttonDigit8";
            this.buttonDigit8.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit8.TabIndex = 17;
            this.buttonDigit8.Text = "8";
            this.buttonDigit8.UseVisualStyleBackColor = true;
            this.buttonDigit8.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit9
            // 
            this.buttonDigit9.Location = new System.Drawing.Point(158, 202);
            this.buttonDigit9.Name = "buttonDigit9";
            this.buttonDigit9.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit9.TabIndex = 18;
            this.buttonDigit9.Text = "9";
            this.buttonDigit9.UseVisualStyleBackColor = true;
            this.buttonDigit9.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // addMemoryButton
            // 
            this.addMemoryButton.Location = new System.Drawing.Point(227, 22);
            this.addMemoryButton.Name = "addMemoryButton";
            this.addMemoryButton.Size = new System.Drawing.Size(55, 52);
            this.addMemoryButton.TabIndex = 10;
            this.addMemoryButton.Text = "M+";
            this.addMemoryButton.UseVisualStyleBackColor = true;
            this.addMemoryButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit7
            // 
            this.buttonDigit7.Location = new System.Drawing.Point(20, 202);
            this.buttonDigit7.Name = "buttonDigit7";
            this.buttonDigit7.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit7.TabIndex = 16;
            this.buttonDigit7.Text = "7";
            this.buttonDigit7.UseVisualStyleBackColor = true;
            this.buttonDigit7.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(296, 112);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 52);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.ControlButtonClick);
            // 
            // buttonDigit6
            // 
            this.buttonDigit6.Location = new System.Drawing.Point(158, 112);
            this.buttonDigit6.Name = "buttonDigit6";
            this.buttonDigit6.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit6.TabIndex = 15;
            this.buttonDigit6.Text = "6";
            this.buttonDigit6.UseVisualStyleBackColor = true;
            this.buttonDigit6.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit5
            // 
            this.buttonDigit5.Location = new System.Drawing.Point(89, 112);
            this.buttonDigit5.Name = "buttonDigit5";
            this.buttonDigit5.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit5.TabIndex = 13;
            this.buttonDigit5.Text = "5";
            this.buttonDigit5.UseVisualStyleBackColor = true;
            this.buttonDigit5.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit4
            // 
            this.buttonDigit4.Location = new System.Drawing.Point(20, 112);
            this.buttonDigit4.Name = "buttonDigit4";
            this.buttonDigit4.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit4.TabIndex = 14;
            this.buttonDigit4.Text = "4";
            this.buttonDigit4.UseVisualStyleBackColor = true;
            this.buttonDigit4.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit2
            // 
            this.buttonDigit2.Location = new System.Drawing.Point(89, 22);
            this.buttonDigit2.Name = "buttonDigit2";
            this.buttonDigit2.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit2.TabIndex = 11;
            this.buttonDigit2.Text = "2";
            this.buttonDigit2.UseVisualStyleBackColor = true;
            this.buttonDigit2.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit3
            // 
            this.buttonDigit3.Location = new System.Drawing.Point(158, 22);
            this.buttonDigit3.Name = "buttonDigit3";
            this.buttonDigit3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDigit3.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit3.TabIndex = 12;
            this.buttonDigit3.Text = "3";
            this.buttonDigit3.UseVisualStyleBackColor = true;
            this.buttonDigit3.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // buttonDigit1
            // 
            this.buttonDigit1.Location = new System.Drawing.Point(20, 22);
            this.buttonDigit1.Name = "buttonDigit1";
            this.buttonDigit1.Size = new System.Drawing.Size(55, 52);
            this.buttonDigit1.TabIndex = 10;
            this.buttonDigit1.Text = "1";
            this.buttonDigit1.UseVisualStyleBackColor = true;
            this.buttonDigit1.Click += new System.EventHandler(this.DigitButtonClick);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTextBox.Location = new System.Drawing.Point(25, 11);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTextBox.MaxLength = 200;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(592, 93);
            this.inputTextBox.TabIndex = 20;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputTextBox.WordWrap = false;
            this.inputTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(106, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 158);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 847);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Button onButton;
        public Button recallMemoryButton;
        public Button addMemoryButton;
        public Button decimalButton;
        public Button buttonDigit0;
        public Button posNegButton;
        private Button buttonDigit8;
        private Button buttonDigit9;
        private Button buttonDigit7;
        private Button buttonDigit6;
        public Button buttonDigit5;
        public Button buttonDigit4;
        private Button buttonDigit2;
        private Button buttonDigit3;
        private Button buttonDigit1;
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
        public TextBox inputTextBox;
        private Button enterButton;
        private Label label2;
        private Label label3;
        public Button button1;
        private PictureBox pictureBox1;
    }
}