namespace lab4_LambDelegaty
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.but_Pow = new System.Windows.Forms.Button();
            this.but_Con = new System.Windows.Forms.Button();
            this.but_Rand = new System.Windows.Forms.Button();
            this.but_Tab = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.but_SortMethod = new System.Windows.Forms.Button();
            this.but_Sort_Asc_Desc = new System.Windows.Forms.Button();
            this.but_Sort_Even_Odd = new System.Windows.Forms.Button();
            this.but_9 = new System.Windows.Forms.Button();
            this.but_Sort_Alfabet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 111);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 102);
            this.textBox3.TabIndex = 2;
            // 
            // but_Pow
            // 
            this.but_Pow.Location = new System.Drawing.Point(208, 20);
            this.but_Pow.Name = "but_Pow";
            this.but_Pow.Size = new System.Drawing.Size(131, 35);
            this.but_Pow.TabIndex = 3;
            this.but_Pow.Text = "Pow";
            this.but_Pow.UseVisualStyleBackColor = true;
            this.but_Pow.Click += new System.EventHandler(this.but_Pow_Click);
            // 
            // but_Con
            // 
            this.but_Con.Location = new System.Drawing.Point(208, 61);
            this.but_Con.Name = "but_Con";
            this.but_Con.Size = new System.Drawing.Size(131, 35);
            this.but_Con.TabIndex = 4;
            this.but_Con.Text = "Concat";
            this.but_Con.UseVisualStyleBackColor = true;
            this.but_Con.Click += new System.EventHandler(this.but_Con_Click);
            // 
            // but_Rand
            // 
            this.but_Rand.Location = new System.Drawing.Point(208, 103);
            this.but_Rand.Name = "but_Rand";
            this.but_Rand.Size = new System.Drawing.Size(131, 35);
            this.but_Rand.TabIndex = 5;
            this.but_Rand.Text = "Random";
            this.but_Rand.UseVisualStyleBackColor = true;
            this.but_Rand.Click += new System.EventHandler(this.but_Rand_Click);
            // 
            // but_Tab
            // 
            this.but_Tab.Location = new System.Drawing.Point(208, 144);
            this.but_Tab.Name = "but_Tab";
            this.but_Tab.Size = new System.Drawing.Size(131, 35);
            this.but_Tab.TabIndex = 6;
            this.but_Tab.Text = "Tab";
            this.but_Tab.UseVisualStyleBackColor = true;
            this.but_Tab.Click += new System.EventHandler(this.but_Tab_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(31, 31);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(31, 72);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 8;
            this.labelY.Text = "Y";
            // 
            // but_SortMethod
            // 
            this.but_SortMethod.Location = new System.Drawing.Point(208, 185);
            this.but_SortMethod.Name = "but_SortMethod";
            this.but_SortMethod.Size = new System.Drawing.Size(131, 35);
            this.but_SortMethod.TabIndex = 9;
            this.but_SortMethod.Text = "SortMethod";
            this.but_SortMethod.UseVisualStyleBackColor = true;
            this.but_SortMethod.Click += new System.EventHandler(this.but_SortMethod_Click);
            // 
            // but_Sort_Asc_Desc
            // 
            this.but_Sort_Asc_Desc.Location = new System.Drawing.Point(345, 20);
            this.but_Sort_Asc_Desc.Name = "but_Sort_Asc_Desc";
            this.but_Sort_Asc_Desc.Size = new System.Drawing.Size(131, 35);
            this.but_Sort_Asc_Desc.TabIndex = 10;
            this.but_Sort_Asc_Desc.Text = "Sort Asc/Desc";
            this.but_Sort_Asc_Desc.UseVisualStyleBackColor = true;
            this.but_Sort_Asc_Desc.Click += new System.EventHandler(this.but_Sort_Asc_Desc_Click);
            // 
            // but_Sort_Even_Odd
            // 
            this.but_Sort_Even_Odd.Location = new System.Drawing.Point(345, 61);
            this.but_Sort_Even_Odd.Name = "but_Sort_Even_Odd";
            this.but_Sort_Even_Odd.Size = new System.Drawing.Size(131, 35);
            this.but_Sort_Even_Odd.TabIndex = 11;
            this.but_Sort_Even_Odd.Text = "Sort Even/Odd";
            this.but_Sort_Even_Odd.UseVisualStyleBackColor = true;
            this.but_Sort_Even_Odd.Click += new System.EventHandler(this.but_Sort_Even_Odd_Click);
            // 
            // but_9
            // 
            this.but_9.Location = new System.Drawing.Point(346, 144);
            this.but_9.Name = "but_9";
            this.but_9.Size = new System.Drawing.Size(130, 35);
            this.but_9.TabIndex = 12;
            this.but_9.Text = "9 punkt nie wiadomo po co zrobiony";
            this.but_9.UseVisualStyleBackColor = true;
            this.but_9.Click += new System.EventHandler(this.but_9_Click);
            // 
            // but_Sort_Alfabet
            // 
            this.but_Sort_Alfabet.Location = new System.Drawing.Point(346, 102);
            this.but_Sort_Alfabet.Name = "but_Sort_Alfabet";
            this.but_Sort_Alfabet.Size = new System.Drawing.Size(130, 36);
            this.but_Sort_Alfabet.TabIndex = 13;
            this.but_Sort_Alfabet.Text = "Sort Alfabet";
            this.but_Sort_Alfabet.UseVisualStyleBackColor = true;
            this.but_Sort_Alfabet.Click += new System.EventHandler(this.but_Sort_Alfabet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 249);
            this.Controls.Add(this.but_Sort_Alfabet);
            this.Controls.Add(this.but_9);
            this.Controls.Add(this.but_Sort_Even_Odd);
            this.Controls.Add(this.but_Sort_Asc_Desc);
            this.Controls.Add(this.but_SortMethod);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.but_Tab);
            this.Controls.Add(this.but_Rand);
            this.Controls.Add(this.but_Con);
            this.Controls.Add(this.but_Pow);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button but_Pow;
        private System.Windows.Forms.Button but_Con;
        private System.Windows.Forms.Button but_Rand;
        private System.Windows.Forms.Button but_Tab;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button but_SortMethod;
        private System.Windows.Forms.Button but_Sort_Asc_Desc;
        private System.Windows.Forms.Button but_Sort_Even_Odd;
        private System.Windows.Forms.Button but_9;
        private System.Windows.Forms.Button but_Sort_Alfabet;
    }
}

