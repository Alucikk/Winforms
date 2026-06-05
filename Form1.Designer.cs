namespace MyForm1
{
    partial class MainForm
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
            pnl1 = new Panel();
            lbl1 = new Label();
            txtBox1 = new TextBox();
            btn1 = new Button();
            pnl1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl1.BackColor = SystemColors.ControlDark;
            pnl1.BorderStyle = BorderStyle.FixedSingle;
            pnl1.Controls.Add(txtBox1);
            pnl1.Controls.Add(lbl1);
            pnl1.Location = new Point(12, 12);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(776, 115);
            pnl1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(39, 34);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(148, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Введiть своє iм'я";
            // 
            // txtBox1
            // 
            txtBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox1.Location = new Point(362, 28);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(400, 31);
            txtBox1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn1.Location = new Point(676, 145);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 34);
            btn1.TabIndex = 1;
            btn1.Text = "Привiтати";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 190);
            Controls.Add(btn1);
            Controls.Add(pnl1);
            Name = "MainForm";
            Text = "Форма привітання";
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private Label lbl1;
        private TextBox txtBox1;
        private Button btn1;
    }
}
