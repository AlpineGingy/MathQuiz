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
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.lblPlusEqual = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblPlusRight = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.lblMinusRight = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblMinusEqual = new System.Windows.Forms.Label();
            this.lblMinusLeft = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.lblTimesRight = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblTimesEqual = new System.Windows.Forms.Label();
            this.lblTimesLeft = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDivideRight = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.lblDivideEqual = new System.Windows.Forms.Label();
            this.lblDivideLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTimeLeft.Location = new System.Drawing.Point(339, 24);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(127, 31);
            this.lblTimeLeft.TabIndex = 0;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(249, 414);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(219, 47);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Location = new System.Drawing.Point(472, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 30);
            this.lblTime.TabIndex = 2;
            // 
            // lblPlusLeft
            // 
            this.lblPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusLeft.Location = new System.Drawing.Point(85, 118);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblPlusLeft.TabIndex = 3;
            this.lblPlusLeft.Text = "?";
            this.lblPlusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusEqual
            // 
            this.lblPlusEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusEqual.Location = new System.Drawing.Point(416, 118);
            this.lblPlusEqual.Name = "lblPlusEqual";
            this.lblPlusEqual.Size = new System.Drawing.Size(60, 50);
            this.lblPlusEqual.TabIndex = 4;
            this.lblPlusEqual.Text = "=";
            this.lblPlusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(193, 118);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(60, 50);
            this.lblPlus.TabIndex = 6;
            this.lblPlus.Text = "+";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusRight
            // 
            this.lblPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusRight.Location = new System.Drawing.Point(305, 118);
            this.lblPlusRight.Name = "lblPlusRight";
            this.lblPlusRight.Size = new System.Drawing.Size(60, 50);
            this.lblPlusRight.TabIndex = 7;
            this.lblPlusRight.Text = "?";
            this.lblPlusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(531, 123);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 41);
            this.sum.TabIndex = 8;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(531, 189);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 41);
            this.difference.TabIndex = 13;
            // 
            // lblMinusRight
            // 
            this.lblMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusRight.Location = new System.Drawing.Point(305, 184);
            this.lblMinusRight.Name = "lblMinusRight";
            this.lblMinusRight.Size = new System.Drawing.Size(60, 50);
            this.lblMinusRight.TabIndex = 12;
            this.lblMinusRight.Text = "?";
            this.lblMinusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinus
            // 
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(193, 184);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(60, 50);
            this.lblMinus.TabIndex = 11;
            this.lblMinus.Text = "-";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinusEqual
            // 
            this.lblMinusEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusEqual.Location = new System.Drawing.Point(416, 184);
            this.lblMinusEqual.Name = "lblMinusEqual";
            this.lblMinusEqual.Size = new System.Drawing.Size(60, 50);
            this.lblMinusEqual.TabIndex = 10;
            this.lblMinusEqual.Text = "=";
            this.lblMinusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinusLeft
            // 
            this.lblMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusLeft.Location = new System.Drawing.Point(85, 184);
            this.lblMinusLeft.Name = "lblMinusLeft";
            this.lblMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblMinusLeft.TabIndex = 9;
            this.lblMinusLeft.Text = "?";
            this.lblMinusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(531, 264);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 41);
            this.product.TabIndex = 18;
            // 
            // lblTimesRight
            // 
            this.lblTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesRight.Location = new System.Drawing.Point(305, 259);
            this.lblTimesRight.Name = "lblTimesRight";
            this.lblTimesRight.Size = new System.Drawing.Size(60, 50);
            this.lblTimesRight.TabIndex = 17;
            this.lblTimesRight.Text = "?";
            this.lblTimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimes
            // 
            this.lblTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(193, 259);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(60, 50);
            this.lblTimes.TabIndex = 16;
            this.lblTimes.Text = "*";
            this.lblTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimesEqual
            // 
            this.lblTimesEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesEqual.Location = new System.Drawing.Point(416, 259);
            this.lblTimesEqual.Name = "lblTimesEqual";
            this.lblTimesEqual.Size = new System.Drawing.Size(60, 50);
            this.lblTimesEqual.TabIndex = 15;
            this.lblTimesEqual.Text = "=";
            this.lblTimesEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimesLeft
            // 
            this.lblTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesLeft.Location = new System.Drawing.Point(85, 259);
            this.lblTimesLeft.Name = "lblTimesLeft";
            this.lblTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lblTimesLeft.TabIndex = 14;
            this.lblTimesLeft.Text = "?";
            this.lblTimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(531, 340);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 41);
            this.numericUpDown1.TabIndex = 23;
            // 
            // lblDivideRight
            // 
            this.lblDivideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideRight.Location = new System.Drawing.Point(305, 335);
            this.lblDivideRight.Name = "lblDivideRight";
            this.lblDivideRight.Size = new System.Drawing.Size(60, 50);
            this.lblDivideRight.TabIndex = 22;
            this.lblDivideRight.Text = "?";
            this.lblDivideRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivide
            // 
            this.lblDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivide.Location = new System.Drawing.Point(193, 335);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(60, 50);
            this.lblDivide.TabIndex = 21;
            this.lblDivide.Text = "/";
            this.lblDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivideEqual
            // 
            this.lblDivideEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideEqual.Location = new System.Drawing.Point(416, 335);
            this.lblDivideEqual.Name = "lblDivideEqual";
            this.lblDivideEqual.Size = new System.Drawing.Size(60, 50);
            this.lblDivideEqual.TabIndex = 20;
            this.lblDivideEqual.Text = "=";
            this.lblDivideEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivideLeft
            // 
            this.lblDivideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivideLeft.Location = new System.Drawing.Point(85, 335);
            this.lblDivideLeft.Name = "lblDivideLeft";
            this.lblDivideLeft.Size = new System.Drawing.Size(60, 50);
            this.lblDivideLeft.TabIndex = 19;
            this.lblDivideLeft.Text = "?";
            this.lblDivideLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 474);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblDivideRight);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblDivideEqual);
            this.Controls.Add(this.lblDivideLeft);
            this.Controls.Add(this.product);
            this.Controls.Add(this.lblTimesRight);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblTimesEqual);
            this.Controls.Add(this.lblTimesLeft);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.lblMinusRight);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblMinusEqual);
            this.Controls.Add(this.lblMinusLeft);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.lblPlusRight);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblPlusEqual);
            this.Controls.Add(this.lblPlusLeft);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblTimeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Label lblPlusEqual;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblPlusRight;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label lblMinusRight;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblMinusEqual;
        private System.Windows.Forms.Label lblMinusLeft;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label lblTimesRight;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblTimesEqual;
        private System.Windows.Forms.Label lblTimesLeft;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblDivideRight;
        private System.Windows.Forms.Label lblDivide;
        private System.Windows.Forms.Label lblDivideEqual;
        private System.Windows.Forms.Label lblDivideLeft;
    }
}

