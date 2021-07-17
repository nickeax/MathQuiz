
namespace MathQuiz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlusRight = new System.Windows.Forms.Label();
            this.numCtrlSum = new System.Windows.Forms.NumericUpDown();
            this.numCtrlDifference = new System.Windows.Forms.NumericUpDown();
            this.lblMinusRight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMinusLeft = new System.Windows.Forms.Label();
            this.numCtrlProduct = new System.Windows.Forms.NumericUpDown();
            this.lblTimesRight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimesLeft = new System.Windows.Forms.Label();
            this.numCtrlQuotient = new System.Windows.Forms.NumericUpDown();
            this.lblDividedRight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDividedLeft = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlQuotient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(268, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 30);
            this.lblTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPlusLeft
            // 
            this.lblPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusLeft.Location = new System.Drawing.Point(68, 74);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblPlusLeft.TabIndex = 2;
            this.lblPlusLeft.Text = "?";
            this.lblPlusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusRight
            // 
            this.lblPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusRight.Location = new System.Drawing.Point(200, 74);
            this.lblPlusRight.Name = "lblPlusRight";
            this.lblPlusRight.Size = new System.Drawing.Size(60, 50);
            this.lblPlusRight.TabIndex = 5;
            this.lblPlusRight.Text = "?";
            this.lblPlusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCtrlSum
            // 
            this.numCtrlSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCtrlSum.Location = new System.Drawing.Point(332, 83);
            this.numCtrlSum.Name = "numCtrlSum";
            this.numCtrlSum.Size = new System.Drawing.Size(100, 35);
            this.numCtrlSum.TabIndex = 2;
            // 
            // numCtrlDifference
            // 
            this.numCtrlDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCtrlDifference.Location = new System.Drawing.Point(332, 134);
            this.numCtrlDifference.Name = "numCtrlDifference";
            this.numCtrlDifference.Size = new System.Drawing.Size(100, 35);
            this.numCtrlDifference.TabIndex = 3;
            // 
            // lblMinusRight
            // 
            this.lblMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusRight.Location = new System.Drawing.Point(200, 125);
            this.lblMinusRight.Name = "lblMinusRight";
            this.lblMinusRight.Size = new System.Drawing.Size(60, 50);
            this.lblMinusRight.TabIndex = 10;
            this.lblMinusRight.Text = "?";
            this.lblMinusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinusLeft
            // 
            this.lblMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusLeft.Location = new System.Drawing.Point(68, 125);
            this.lblMinusLeft.Name = "lblMinusLeft";
            this.lblMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblMinusLeft.TabIndex = 7;
            this.lblMinusLeft.Text = "?";
            this.lblMinusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCtrlProduct
            // 
            this.numCtrlProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCtrlProduct.Location = new System.Drawing.Point(332, 185);
            this.numCtrlProduct.Name = "numCtrlProduct";
            this.numCtrlProduct.Size = new System.Drawing.Size(100, 35);
            this.numCtrlProduct.TabIndex = 4;
            // 
            // lblTimesRight
            // 
            this.lblTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesRight.Location = new System.Drawing.Point(200, 176);
            this.lblTimesRight.Name = "lblTimesRight";
            this.lblTimesRight.Size = new System.Drawing.Size(60, 50);
            this.lblTimesRight.TabIndex = 15;
            this.lblTimesRight.Text = "?";
            this.lblTimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 13;
            this.label8.Text = "×";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimesLeft
            // 
            this.lblTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesLeft.Location = new System.Drawing.Point(68, 176);
            this.lblTimesLeft.Name = "lblTimesLeft";
            this.lblTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lblTimesLeft.TabIndex = 12;
            this.lblTimesLeft.Text = "?";
            this.lblTimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCtrlQuotient
            // 
            this.numCtrlQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCtrlQuotient.Location = new System.Drawing.Point(332, 236);
            this.numCtrlQuotient.Name = "numCtrlQuotient";
            this.numCtrlQuotient.Size = new System.Drawing.Size(100, 35);
            this.numCtrlQuotient.TabIndex = 5;
            // 
            // lblDividedRight
            // 
            this.lblDividedRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividedRight.Location = new System.Drawing.Point(200, 227);
            this.lblDividedRight.Name = "lblDividedRight";
            this.lblDividedRight.Size = new System.Drawing.Size(60, 50);
            this.lblDividedRight.TabIndex = 20;
            this.lblDividedRight.Text = "?";
            this.lblDividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(266, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 19;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(134, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 18;
            this.label12.Text = "÷";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDividedLeft
            // 
            this.lblDividedLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividedLeft.Location = new System.Drawing.Point(68, 227);
            this.lblDividedLeft.Name = "lblDividedLeft";
            this.lblDividedLeft.Size = new System.Drawing.Size(60, 50);
            this.lblDividedLeft.TabIndex = 17;
            this.lblDividedLeft.Text = "?";
            this.lblDividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(165, 311);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start the quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numCtrlQuotient);
            this.Controls.Add(this.lblDividedRight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDividedLeft);
            this.Controls.Add(this.numCtrlProduct);
            this.Controls.Add(this.lblTimesRight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTimesLeft);
            this.Controls.Add(this.numCtrlDifference);
            this.Controls.Add(this.lblMinusRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinusLeft);
            this.Controls.Add(this.numCtrlSum);
            this.Controls.Add(this.lblPlusRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCtrlQuotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlusRight;
        private System.Windows.Forms.NumericUpDown numCtrlSum;
        private System.Windows.Forms.NumericUpDown numCtrlDifference;
        private System.Windows.Forms.Label lblMinusRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMinusLeft;
        private System.Windows.Forms.NumericUpDown numCtrlProduct;
        private System.Windows.Forms.Label lblTimesRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimesLeft;
        private System.Windows.Forms.NumericUpDown numCtrlQuotient;
        private System.Windows.Forms.Label lblDividedRight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDividedLeft;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

