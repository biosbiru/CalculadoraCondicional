namespace CalculadoraCondicional
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
            txtNum1 = new TextBox();
            txtOperator = new TextBox();
            txtNum2 = new TextBox();
            lblEqual = new Label();
            pnlResult = new Panel();
            lblResult = new Label();
            btnCalculate = new Button();
            pnlResult.SuspendLayout();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 12);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(118, 12);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(27, 23);
            txtOperator.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(151, 12);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // lblEqual
            // 
            lblEqual.AutoSize = true;
            lblEqual.Location = new Point(257, 15);
            lblEqual.Name = "lblEqual";
            lblEqual.Size = new Size(15, 15);
            lblEqual.TabIndex = 3;
            lblEqual.Text = "=";
            // 
            // pnlResult
            // 
            pnlResult.BackColor = SystemColors.ScrollBar;
            pnlResult.Controls.Add(lblResult);
            pnlResult.Location = new Point(278, 12);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(108, 23);
            pnlResult.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(27, 1);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 41);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(374, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 73);
            Controls.Add(btnCalculate);
            Controls.Add(pnlResult);
            Controls.Add(lblEqual);
            Controls.Add(txtNum2);
            Controls.Add(txtOperator);
            Controls.Add(txtNum1);
            Name = "Form1";
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtOperator;
        private TextBox txtNum2;
        private Label lblEqual;
        private Panel pnlResult;
        private Label lblResult;
        private Button btnCalculate;
    }
}
