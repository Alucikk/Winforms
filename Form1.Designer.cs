namespace Calculator11_13
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
            pnlDisplay = new Panel();
            lblDisplay = new Label();
            tlpButtonsPanel = new TableLayoutPanel();
            btnCE = new Button();
            btnBack = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            pnl2 = new Panel();
            radioOff = new RadioButton();
            radioOn = new RadioButton();
            pnlDisplay.SuspendLayout();
            tlpButtonsPanel.SuspendLayout();
            pnl2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(lblDisplay);
            pnlDisplay.Dock = DockStyle.Top;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Padding = new Padding(5);
            pnlDisplay.Size = new Size(428, 80);
            pnlDisplay.TabIndex = 0;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.White;
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Font = new Font("Segoe UI", 24F);
            lblDisplay.Location = new Point(5, 5);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(418, 70);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            lblDisplay.TextChanged += lblDisplay_TextChanged;
            // 
            // tlpButtonsPanel
            // 
            tlpButtonsPanel.BackColor = Color.White;
            tlpButtonsPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpButtonsPanel.ColumnCount = 4;
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.Controls.Add(btnCE, 0, 0);
            tlpButtonsPanel.Controls.Add(btnBack, 1, 0);
            tlpButtonsPanel.Controls.Add(btnPercent, 2, 0);
            tlpButtonsPanel.Controls.Add(btnDivide, 3, 0);
            tlpButtonsPanel.Controls.Add(btn7, 0, 1);
            tlpButtonsPanel.Controls.Add(btn8, 1, 1);
            tlpButtonsPanel.Controls.Add(btn9, 2, 1);
            tlpButtonsPanel.Controls.Add(btnMultiply, 3, 1);
            tlpButtonsPanel.Controls.Add(btn4, 0, 2);
            tlpButtonsPanel.Controls.Add(btn5, 1, 2);
            tlpButtonsPanel.Controls.Add(btn6, 2, 2);
            tlpButtonsPanel.Controls.Add(btnMinus, 3, 2);
            tlpButtonsPanel.Controls.Add(btn1, 0, 3);
            tlpButtonsPanel.Controls.Add(btn2, 1, 3);
            tlpButtonsPanel.Controls.Add(btn3, 2, 3);
            tlpButtonsPanel.Controls.Add(btnPlus, 3, 3);
            tlpButtonsPanel.Controls.Add(btn0, 0, 4);
            tlpButtonsPanel.Controls.Add(btnDot, 1, 4);
            tlpButtonsPanel.Controls.Add(btnEquals, 2, 4);
            tlpButtonsPanel.Dock = DockStyle.Bottom;
            tlpButtonsPanel.Font = new Font("Segoe UI", 14F);
            tlpButtonsPanel.Location = new Point(0, 130);
            tlpButtonsPanel.Margin = new Padding(2);
            tlpButtonsPanel.Name = "tlpButtonsPanel";
            tlpButtonsPanel.RowCount = 5;
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.Size = new Size(428, 314);
            tlpButtonsPanel.TabIndex = 1;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.White;
            btnCE.Dock = DockStyle.Fill;
            btnCE.Font = new Font("Segoe UI", 14F);
            btnCE.ForeColor = Color.OrangeRed;
            btnCE.Location = new Point(3, 3);
            btnCE.Margin = new Padding(2);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(101, 57);
            btnCE.TabIndex = 0;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Dock = DockStyle.Fill;
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.Location = new Point(109, 3);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 57);
            btnBack.TabIndex = 1;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBackspace_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.White;
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI", 14F);
            btnPercent.Location = new Point(215, 3);
            btnPercent.Margin = new Padding(2);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(101, 57);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.White;
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI", 14F);
            btnDivide.Location = new Point(321, 3);
            btnDivide.Margin = new Padding(2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(104, 57);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14F);
            btn7.Location = new Point(3, 65);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(101, 57);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14F);
            btn8.Location = new Point(109, 65);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(101, 57);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14F);
            btn9.Location = new Point(215, 65);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(101, 57);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumber_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.White;
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI", 14F);
            btnMultiply.Location = new Point(321, 65);
            btnMultiply.Margin = new Padding(2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(104, 57);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14F);
            btn4.Location = new Point(3, 127);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(101, 57);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14F);
            btn5.Location = new Point(109, 127);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(101, 57);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14F);
            btn6.Location = new Point(215, 127);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(101, 57);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumber_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.White;
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new Font("Segoe UI", 14F);
            btnMinus.Location = new Point(321, 127);
            btnMinus.Margin = new Padding(2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(104, 57);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14F);
            btn1.Location = new Point(3, 189);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(101, 57);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14F);
            btn2.Location = new Point(109, 189);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(101, 57);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14F);
            btn3.Location = new Point(215, 189);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(101, 57);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumber_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.White;
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new Font("Segoe UI", 14F);
            btnPlus.Location = new Point(321, 189);
            btnPlus.Margin = new Padding(2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(104, 57);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14F);
            btn0.Location = new Point(3, 251);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(101, 60);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumber_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.Dock = DockStyle.Fill;
            btnDot.Font = new Font("Segoe UI", 14F);
            btnDot.Location = new Point(109, 251);
            btnDot.Margin = new Padding(2);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(101, 60);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnNumber_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.White;
            tlpButtonsPanel.SetColumnSpan(btnEquals, 2);
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Font = new Font("Segoe UI", 14F);
            btnEquals.Location = new Point(215, 251);
            btnEquals.Margin = new Padding(2);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(210, 60);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // pnl2
            // 
            pnl2.Controls.Add(radioOff);
            pnl2.Controls.Add(radioOn);
            pnl2.Dock = DockStyle.Top;
            pnl2.Location = new Point(0, 80);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(428, 50);
            pnl2.TabIndex = 2;
            // 
            // radioOff
            // 
            radioOff.AutoSize = true;
            radioOff.ForeColor = Color.FromArgb(192, 0, 0);
            radioOff.Location = new Point(75, 6);
            radioOff.Name = "radioOff";
            radioOff.Size = new Size(69, 29);
            radioOff.TabIndex = 1;
            radioOff.TabStop = true;
            radioOff.Text = "OFF";
            radioOff.UseVisualStyleBackColor = true;
            radioOff.CheckedChanged += radioOff_CheckedChanged;
            // 
            // radioOn
            // 
            radioOn.AutoSize = true;
            radioOn.ForeColor = Color.FromArgb(0, 192, 0);
            radioOn.Location = new Point(5, 6);
            radioOn.Name = "radioOn";
            radioOn.Size = new Size(64, 29);
            radioOn.TabIndex = 0;
            radioOn.TabStop = true;
            radioOn.Text = "ON";
            radioOn.UseVisualStyleBackColor = true;
            radioOn.CheckedChanged += radioOn_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 444);
            Controls.Add(pnl2);
            Controls.Add(tlpButtonsPanel);
            Controls.Add(pnlDisplay);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Калькулятор";
            Load += Form1_Load;
            Click += btnNumber_Click;
            KeyDown += Form1_KeyDown;
            pnlDisplay.ResumeLayout(false);
            tlpButtonsPanel.ResumeLayout(false);
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblDisplay;
        private TableLayoutPanel tlpButtonsPanel;
        private Button btnCE;
        private Button btnBack;
        private Button btnPercent;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;
        private Panel pnl2;
        private RadioButton radioOff;
        private RadioButton radioOn;
    }
}
