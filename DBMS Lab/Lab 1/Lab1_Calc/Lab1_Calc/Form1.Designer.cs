namespace Lab1_Calc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.x_square = new System.Windows.Forms.Button();
            this.x_cube = new System.Windows.Forms.Button();
            this.Reciprocal = new System.Windows.Forms.Button();
            this.Natural_Log = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.Hexadecimal = new System.Windows.Forms.Button();
            this.Octal = new System.Windows.Forms.Button();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Sine = new System.Windows.Forms.Button();
            this.Cosine = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Modulus = new System.Windows.Forms.Button();
            this.Pi = new System.Windows.Forms.Button();
            this.Sinh = new System.Windows.Forms.Button();
            this.Cosh = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.Exponential = new System.Windows.Forms.Button();
            this.num_sign_button = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.clear_everything = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.decimal_point_button = new System.Windows.Forms.Button();
            this.equal_to_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 67);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // x_square
            // 
            this.x_square.Location = new System.Drawing.Point(618, 89);
            this.x_square.Name = "x_square";
            this.x_square.Size = new System.Drawing.Size(75, 50);
            this.x_square.TabIndex = 6;
            this.x_square.Text = "x^2";
            this.x_square.UseVisualStyleBackColor = true;
            this.x_square.Click += new System.EventHandler(this.x_square_Click);
            // 
            // x_cube
            // 
            this.x_cube.Location = new System.Drawing.Point(619, 145);
            this.x_cube.Name = "x_cube";
            this.x_cube.Size = new System.Drawing.Size(74, 50);
            this.x_cube.TabIndex = 7;
            this.x_cube.Text = "x^3";
            this.x_cube.UseVisualStyleBackColor = true;
            this.x_cube.Click += new System.EventHandler(this.x_cube_Click);
            // 
            // Reciprocal
            // 
            this.Reciprocal.Location = new System.Drawing.Point(619, 201);
            this.Reciprocal.Name = "Reciprocal";
            this.Reciprocal.Size = new System.Drawing.Size(75, 48);
            this.Reciprocal.TabIndex = 8;
            this.Reciprocal.Text = "1/x";
            this.Reciprocal.UseVisualStyleBackColor = true;
            this.Reciprocal.Click += new System.EventHandler(this.Reciprocal_Click);
            // 
            // Natural_Log
            // 
            this.Natural_Log.Location = new System.Drawing.Point(619, 255);
            this.Natural_Log.Name = "Natural_Log";
            this.Natural_Log.Size = new System.Drawing.Size(75, 51);
            this.Natural_Log.TabIndex = 9;
            this.Natural_Log.Text = "ln x";
            this.Natural_Log.UseVisualStyleBackColor = true;
            this.Natural_Log.Click += new System.EventHandler(this.Natural_Log_Click);
            // 
            // Percentage
            // 
            this.Percentage.Location = new System.Drawing.Point(619, 312);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(74, 56);
            this.Percentage.TabIndex = 10;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = true;
            this.Percentage.Click += new System.EventHandler(this.Percentage_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Location = new System.Drawing.Point(537, 89);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(75, 50);
            this.SquareRoot.TabIndex = 11;
            this.SquareRoot.Text = "sqrt";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(537, 145);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(75, 50);
            this.Decimal.TabIndex = 12;
            this.Decimal.Text = "Dec";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Binary
            // 
            this.Binary.Location = new System.Drawing.Point(537, 201);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(75, 48);
            this.Binary.TabIndex = 13;
            this.Binary.Text = "Bin";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.Location = new System.Drawing.Point(537, 255);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(75, 51);
            this.Hexadecimal.TabIndex = 14;
            this.Hexadecimal.Text = "Hex";
            this.Hexadecimal.UseVisualStyleBackColor = true;
            this.Hexadecimal.Click += new System.EventHandler(this.Hexadecimal_Click);
            // 
            // Octal
            // 
            this.Octal.Location = new System.Drawing.Point(537, 312);
            this.Octal.Name = "Octal";
            this.Octal.Size = new System.Drawing.Size(75, 56);
            this.Octal.TabIndex = 15;
            this.Octal.Text = "Oct";
            this.Octal.UseVisualStyleBackColor = true;
            this.Octal.Click += new System.EventHandler(this.Octal_Click);
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(456, 89);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(75, 50);
            this.Logarithm.TabIndex = 16;
            this.Logarithm.Text = "log";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.Logarithm_Click);
            // 
            // Sine
            // 
            this.Sine.Location = new System.Drawing.Point(456, 145);
            this.Sine.Name = "Sine";
            this.Sine.Size = new System.Drawing.Size(75, 50);
            this.Sine.TabIndex = 17;
            this.Sine.Text = "Sin";
            this.Sine.UseVisualStyleBackColor = true;
            this.Sine.Click += new System.EventHandler(this.Sine_Click);
            // 
            // Cosine
            // 
            this.Cosine.Location = new System.Drawing.Point(456, 201);
            this.Cosine.Name = "Cosine";
            this.Cosine.Size = new System.Drawing.Size(75, 48);
            this.Cosine.TabIndex = 18;
            this.Cosine.Text = "Cos";
            this.Cosine.UseVisualStyleBackColor = true;
            this.Cosine.Click += new System.EventHandler(this.Cosine_Click);
            // 
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(456, 255);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(75, 51);
            this.Tangent.TabIndex = 19;
            this.Tangent.Text = "Tan";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.Tangent_Click);
            // 
            // Modulus
            // 
            this.Modulus.Location = new System.Drawing.Point(456, 312);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(75, 56);
            this.Modulus.TabIndex = 20;
            this.Modulus.Text = "Mod";
            this.Modulus.UseVisualStyleBackColor = true;
            this.Modulus.Click += new System.EventHandler(this.Modulus_Click);
            // 
            // Pi
            // 
            this.Pi.Location = new System.Drawing.Point(375, 89);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(75, 50);
            this.Pi.TabIndex = 21;
            this.Pi.Text = "Pi";
            this.Pi.UseVisualStyleBackColor = true;
            this.Pi.Click += new System.EventHandler(this.Pi_Click);
            // 
            // Sinh
            // 
            this.Sinh.Location = new System.Drawing.Point(375, 145);
            this.Sinh.Name = "Sinh";
            this.Sinh.Size = new System.Drawing.Size(75, 50);
            this.Sinh.TabIndex = 22;
            this.Sinh.Text = "Sinh";
            this.Sinh.UseVisualStyleBackColor = true;
            this.Sinh.Click += new System.EventHandler(this.Sinh_Click);
            // 
            // Cosh
            // 
            this.Cosh.Location = new System.Drawing.Point(375, 201);
            this.Cosh.Name = "Cosh";
            this.Cosh.Size = new System.Drawing.Size(75, 48);
            this.Cosh.TabIndex = 23;
            this.Cosh.Text = "Cosh";
            this.Cosh.UseVisualStyleBackColor = true;
            this.Cosh.Click += new System.EventHandler(this.Cosh_Click);
            // 
            // Tanh
            // 
            this.Tanh.Location = new System.Drawing.Point(375, 255);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(75, 51);
            this.Tanh.TabIndex = 24;
            this.Tanh.Text = "Tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // Exponential
            // 
            this.Exponential.Location = new System.Drawing.Point(375, 312);
            this.Exponential.Name = "Exponential";
            this.Exponential.Size = new System.Drawing.Size(75, 56);
            this.Exponential.TabIndex = 25;
            this.Exponential.Text = "Exp";
            this.Exponential.UseVisualStyleBackColor = true;
            this.Exponential.Click += new System.EventHandler(this.Exponential_Click);
            // 
            // num_sign_button
            // 
            this.num_sign_button.Location = new System.Drawing.Point(248, 91);
            this.num_sign_button.Name = "num_sign_button";
            this.num_sign_button.Size = new System.Drawing.Size(76, 48);
            this.num_sign_button.TabIndex = 26;
            this.num_sign_button.Text = "+ -";
            this.num_sign_button.UseVisualStyleBackColor = true;
            this.num_sign_button.Click += new System.EventHandler(this.num_sign_button_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(178, 89);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(64, 50);
            this.Clear.TabIndex = 27;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // clear_everything
            // 
            this.clear_everything.Location = new System.Drawing.Point(97, 91);
            this.clear_everything.Name = "clear_everything";
            this.clear_everything.Size = new System.Drawing.Size(75, 48);
            this.clear_everything.TabIndex = 29;
            this.clear_everything.Text = "CE";
            this.clear_everything.UseVisualStyleBackColor = true;
            this.clear_everything.Click += new System.EventHandler(this.clear_everything_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(16, 91);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 48);
            this.backspace.TabIndex = 30;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(248, 145);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 50);
            this.addition.TabIndex = 31;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(248, 201);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 48);
            this.subtract.TabIndex = 32;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(249, 255);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 51);
            this.multiply.TabIndex = 33;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(249, 312);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 56);
            this.divide.TabIndex = 34;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // nine_button
            // 
            this.nine_button.Location = new System.Drawing.Point(178, 145);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(64, 50);
            this.nine_button.TabIndex = 35;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.nine_button_Click);
            // 
            // eight_button
            // 
            this.eight_button.Location = new System.Drawing.Point(97, 145);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(75, 50);
            this.eight_button.TabIndex = 36;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.eight_button_Click);
            // 
            // seven_button
            // 
            this.seven_button.Location = new System.Drawing.Point(16, 145);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(75, 50);
            this.seven_button.TabIndex = 37;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.seven_button_Click);
            // 
            // four_button
            // 
            this.four_button.Location = new System.Drawing.Point(16, 201);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(75, 48);
            this.four_button.TabIndex = 38;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.four_button_Click);
            // 
            // five_button
            // 
            this.five_button.Location = new System.Drawing.Point(97, 201);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(75, 48);
            this.five_button.TabIndex = 39;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.five_button_Click);
            // 
            // six_button
            // 
            this.six_button.Location = new System.Drawing.Point(178, 201);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(64, 48);
            this.six_button.TabIndex = 40;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.six_button_Click);
            // 
            // one_button
            // 
            this.one_button.Location = new System.Drawing.Point(16, 255);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(75, 51);
            this.one_button.TabIndex = 41;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(97, 255);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(75, 51);
            this.two_button.TabIndex = 42;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.two_button_Click);
            // 
            // three_button
            // 
            this.three_button.Location = new System.Drawing.Point(178, 255);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(64, 51);
            this.three_button.TabIndex = 43;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.three_button_Click);
            // 
            // zero_button
            // 
            this.zero_button.Location = new System.Drawing.Point(16, 312);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(75, 56);
            this.zero_button.TabIndex = 44;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.zero_button_Click);
            // 
            // decimal_point_button
            // 
            this.decimal_point_button.Location = new System.Drawing.Point(97, 312);
            this.decimal_point_button.Name = "decimal_point_button";
            this.decimal_point_button.Size = new System.Drawing.Size(75, 56);
            this.decimal_point_button.TabIndex = 45;
            this.decimal_point_button.Text = ".";
            this.decimal_point_button.UseVisualStyleBackColor = true;
            this.decimal_point_button.Click += new System.EventHandler(this.decimal_point_button_Click);
            // 
            // equal_to_button
            // 
            this.equal_to_button.Location = new System.Drawing.Point(178, 312);
            this.equal_to_button.Name = "equal_to_button";
            this.equal_to_button.Size = new System.Drawing.Size(64, 56);
            this.equal_to_button.TabIndex = 46;
            this.equal_to_button.Text = "=";
            this.equal_to_button.UseVisualStyleBackColor = true;
            this.equal_to_button.Click += new System.EventHandler(this.equal_to_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 382);
            this.Controls.Add(this.equal_to_button);
            this.Controls.Add(this.decimal_point_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear_everything);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.num_sign_button);
            this.Controls.Add(this.Exponential);
            this.Controls.Add(this.Tanh);
            this.Controls.Add(this.Cosh);
            this.Controls.Add(this.Sinh);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Cosine);
            this.Controls.Add(this.Sine);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.Octal);
            this.Controls.Add(this.Hexadecimal);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Natural_Log);
            this.Controls.Add(this.Reciprocal);
            this.Controls.Add(this.x_cube);
            this.Controls.Add(this.x_square);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button x_square;
        private System.Windows.Forms.Button x_cube;
        private System.Windows.Forms.Button Reciprocal;
        private System.Windows.Forms.Button Natural_Log;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Hexadecimal;
        private System.Windows.Forms.Button Octal;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button Sine;
        private System.Windows.Forms.Button Cosine;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Modulus;
        private System.Windows.Forms.Button Pi;
        private System.Windows.Forms.Button Sinh;
        private System.Windows.Forms.Button Cosh;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button Exponential;
        private System.Windows.Forms.Button num_sign_button;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button clear_everything;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button decimal_point_button;
        private System.Windows.Forms.Button equal_to_button;
    }
}

