namespace Calculator11_13
{
    partial class ConfirmClearForm
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
            lbl1 = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lbl1.ForeColor = Color.Blue;
            lbl1.Location = new Point(76, 64);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(651, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "Ви дійсно бажаєте очистити стан калькулятора?";
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(232, 150);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(112, 34);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "Так";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(439, 150);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(112, 34);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "Ні";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // ConfirmClearForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 205);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(lbl1);
            MaximizeBox = false;
            MaximumSize = new Size(822, 261);
            MinimizeBox = false;
            MinimumSize = new Size(822, 261);
            Name = "ConfirmClearForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пiдтвердження";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button buttonYes;
        private Button buttonNo;
    }
}