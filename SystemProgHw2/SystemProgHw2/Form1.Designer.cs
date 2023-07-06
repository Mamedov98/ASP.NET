namespace SystemProgHw2
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
            this.BtnGenerate_Click = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Restart_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerate_Click
            // 
            this.BtnGenerate_Click.Location = new System.Drawing.Point(55, 28);
            this.BtnGenerate_Click.Name = "BtnGenerate_Click";
            this.BtnGenerate_Click.Size = new System.Drawing.Size(230, 104);
            this.BtnGenerate_Click.TabIndex = 0;
            this.BtnGenerate_Click.Text = "BtnGenerate_Click ";
            this.BtnGenerate_Click.UseVisualStyleBackColor = true;
            this.BtnGenerate_Click.Click += new System.EventHandler(this.BtnGenerate_Click_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(227, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 44);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 104);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fibonacci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fibonacci stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Restart_btn
            // 
            this.Restart_btn.Location = new System.Drawing.Point(278, 179);
            this.Restart_btn.Name = "Restart_btn";
            this.Restart_btn.Size = new System.Drawing.Size(190, 44);
            this.Restart_btn.TabIndex = 7;
            this.Restart_btn.Text = "Restart";
            this.Restart_btn.UseVisualStyleBackColor = true;
            this.Restart_btn.Click += new System.EventHandler(this.Restart_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "End";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restart_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnGenerate_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGenerate_Click;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button Restart_btn;
        private Label label1;
        private Label label2;
    }
}