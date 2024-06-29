namespace SPR
{
    partial class MainForm
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
            panel1 = new Panel();
            buttonFifth = new Button();
            buttonSix = new Button();
            buttonFour = new Button();
            buttonThird = new Button();
            buttonSecond = new Button();
            buttonFirst = new Button();
            panel2 = new Panel();
            label3 = new Label();
            numericUpDownMinValue = new NumericUpDown();
            numericUpDownMaxValue = new NumericUpDown();
            numericUpDownNOf2D = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            numericUpDownMOf2D = new NumericUpDown();
            numericUpDownSize1D = new NumericUpDown();
            button2DMassive = new Button();
            button1DMassive = new Button();
            textBoxInitial = new TextBox();
            panel3 = new Panel();
            textBoxOutPutArray = new TextBox();
            buttonPrintArray = new Button();
            textBoxOutPutTask = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNOf2D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMOf2D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize1D).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonFifth);
            panel1.Controls.Add(buttonSix);
            panel1.Controls.Add(buttonFour);
            panel1.Controls.Add(buttonThird);
            panel1.Controls.Add(buttonSecond);
            panel1.Controls.Add(buttonFirst);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // buttonFifth
            // 
            buttonFifth.Location = new Point(26, 87);
            buttonFifth.Name = "buttonFifth";
            buttonFifth.Size = new Size(94, 29);
            buttonFifth.TabIndex = 5;
            buttonFifth.Text = "пятое";
            buttonFifth.UseVisualStyleBackColor = true;
            buttonFifth.Click += buttonFifth_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(126, 87);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(94, 29);
            buttonSix.TabIndex = 4;
            buttonSix.Text = "шестое";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(126, 52);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(94, 29);
            buttonFour.TabIndex = 3;
            buttonFour.Text = "четвертое";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonThird
            // 
            buttonThird.Location = new Point(26, 52);
            buttonThird.Name = "buttonThird";
            buttonThird.Size = new Size(94, 29);
            buttonThird.TabIndex = 2;
            buttonThird.Text = "третье";
            buttonThird.UseVisualStyleBackColor = true;
            buttonThird.Click += buttonThird_Click;
            // 
            // buttonSecond
            // 
            buttonSecond.Location = new Point(126, 17);
            buttonSecond.Name = "buttonSecond";
            buttonSecond.Size = new Size(94, 29);
            buttonSecond.TabIndex = 1;
            buttonSecond.Text = "второе";
            buttonSecond.UseVisualStyleBackColor = true;
            buttonSecond.Click += buttonSecond_Click;
            // 
            // buttonFirst
            // 
            buttonFirst.Location = new Point(26, 17);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(94, 29);
            buttonFirst.TabIndex = 0;
            buttonFirst.Text = "первое";
            buttonFirst.UseVisualStyleBackColor = true;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(numericUpDownMinValue);
            panel2.Controls.Add(numericUpDownMaxValue);
            panel2.Controls.Add(numericUpDownNOf2D);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(numericUpDownMOf2D);
            panel2.Controls.Add(numericUpDownSize1D);
            panel2.Controls.Add(button2DMassive);
            panel2.Controls.Add(button1DMassive);
            panel2.Controls.Add(textBoxInitial);
            panel2.Location = new Point(490, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 217);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 186);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 10;
            label3.Text = "диапозон значений";
            // 
            // numericUpDownMinValue
            // 
            numericUpDownMinValue.Location = new Point(255, 183);
            numericUpDownMinValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownMinValue.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDownMinValue.Name = "numericUpDownMinValue";
            numericUpDownMinValue.Size = new Size(69, 27);
            numericUpDownMinValue.TabIndex = 9;
            numericUpDownMinValue.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // numericUpDownMaxValue
            // 
            numericUpDownMaxValue.Location = new Point(330, 183);
            numericUpDownMaxValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownMaxValue.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            numericUpDownMaxValue.Size = new Size(69, 27);
            numericUpDownMaxValue.TabIndex = 8;
            numericUpDownMaxValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownNOf2D
            // 
            numericUpDownNOf2D.Location = new Point(255, 150);
            numericUpDownNOf2D.Name = "numericUpDownNOf2D";
            numericUpDownNOf2D.Size = new Size(69, 27);
            numericUpDownNOf2D.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 153);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 6;
            label2.Text = "размер двумерного";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 119);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 5;
            label1.Text = "размер одномерного";
            // 
            // numericUpDownMOf2D
            // 
            numericUpDownMOf2D.Location = new Point(330, 150);
            numericUpDownMOf2D.Name = "numericUpDownMOf2D";
            numericUpDownMOf2D.Size = new Size(69, 27);
            numericUpDownMOf2D.TabIndex = 4;
            // 
            // numericUpDownSize1D
            // 
            numericUpDownSize1D.Location = new Point(330, 117);
            numericUpDownSize1D.Name = "numericUpDownSize1D";
            numericUpDownSize1D.Size = new Size(69, 27);
            numericUpDownSize1D.TabIndex = 3;
            // 
            // button2DMassive
            // 
            button2DMassive.Location = new Point(269, 52);
            button2DMassive.Name = "button2DMassive";
            button2DMassive.Size = new Size(128, 29);
            button2DMassive.TabIndex = 2;
            button2DMassive.Text = "2D";
            button2DMassive.UseVisualStyleBackColor = true;
            button2DMassive.Click += button2DMassive_Click;
            // 
            // button1DMassive
            // 
            button1DMassive.Location = new Point(269, 17);
            button1DMassive.Name = "button1DMassive";
            button1DMassive.Size = new Size(128, 29);
            button1DMassive.TabIndex = 1;
            button1DMassive.Text = "1D";
            button1DMassive.UseVisualStyleBackColor = true;
            button1DMassive.Click += button1DMassive_Click;
            // 
            // textBoxInitial
            // 
            textBoxInitial.Location = new Point(22, 17);
            textBoxInitial.Multiline = true;
            textBoxInitial.Name = "textBoxInitial";
            textBoxInitial.Size = new Size(241, 99);
            textBoxInitial.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxOutPutArray);
            panel3.Controls.Add(buttonPrintArray);
            panel3.Controls.Add(textBoxOutPutTask);
            panel3.Location = new Point(490, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 214);
            panel3.TabIndex = 2;
            // 
            // textBoxOutPutArray
            // 
            textBoxOutPutArray.Location = new Point(22, 100);
            textBoxOutPutArray.Multiline = true;
            textBoxOutPutArray.Name = "textBoxOutPutArray";
            textBoxOutPutArray.Size = new Size(275, 108);
            textBoxOutPutArray.TabIndex = 3;
            // 
            // buttonPrintArray
            // 
            buttonPrintArray.Location = new Point(303, 100);
            buttonPrintArray.Name = "buttonPrintArray";
            buttonPrintArray.Size = new Size(94, 29);
            buttonPrintArray.TabIndex = 2;
            buttonPrintArray.Text = "результат";
            buttonPrintArray.UseVisualStyleBackColor = true;
            buttonPrintArray.Click += buttonPrintArray_Click;
            // 
            // textBoxOutPutTask
            // 
            textBoxOutPutTask.Location = new Point(22, 3);
            textBoxOutPutTask.Multiline = true;
            textBoxOutPutTask.Name = "textBoxOutPutTask";
            textBoxOutPutTask.Size = new Size(375, 91);
            textBoxOutPutTask.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 468);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNOf2D).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMOf2D).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize1D).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonFifth;
        private Button buttonSix;
        private Button buttonFour;
        private Button buttonThird;
        private Button buttonSecond;
        private Button buttonFirst;
        private Panel panel2;
        private Button button2DMassive;
        private Button button1DMassive;
        private TextBox textBoxInitial;
        private Label label1;
        private NumericUpDown numericUpDownMOf2D;
        private NumericUpDown numericUpDownSize1D;
        private Label label2;
        private NumericUpDown numericUpDownNOf2D;
        private Label label3;
        private NumericUpDown numericUpDownMinValue;
        private NumericUpDown numericUpDownMaxValue;
        private Panel panel3;
        private TextBox textBoxOutPutArray;
        private Button buttonPrintArray;
        private TextBox textBoxOutPutTask;
    }
}