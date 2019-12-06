namespace Sorter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.algorithm_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.generated_array = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sorting_time = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sorted_array = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NumberArray = new System.Windows.Forms.RichTextBox();
            this.generate_array = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.max_value = new System.Windows.Forms.TextBox();
            this.min_value = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.algorithm_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.generated_array);
            this.panel1.Location = new System.Drawing.Point(394, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 438);
            this.panel1.TabIndex = 0;
            // 
            // algorithm_name
            // 
            this.algorithm_name.AutoSize = true;
            this.algorithm_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithm_name.Location = new System.Drawing.Point(73, 258);
            this.algorithm_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algorithm_name.Name = "algorithm_name";
            this.algorithm_name.Size = new System.Drawing.Size(0, 13);
            this.algorithm_name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 BlkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Generated Array";
            // 
            // generated_array
            // 
            this.generated_array.BackColor = System.Drawing.Color.GhostWhite;
            this.generated_array.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generated_array.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11F);
            this.generated_array.Location = new System.Drawing.Point(2, 37);
            this.generated_array.Margin = new System.Windows.Forms.Padding(2);
            this.generated_array.Multiline = true;
            this.generated_array.Name = "generated_array";
            this.generated_array.ReadOnly = true;
            this.generated_array.Size = new System.Drawing.Size(363, 429);
            this.generated_array.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(348, 392);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 15);
            this.label4.Size = new System.Drawing.Size(25, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "      ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sorting_time
            // 
            this.sorting_time.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorting_time.ForeColor = System.Drawing.Color.BurlyWood;
            this.sorting_time.Location = new System.Drawing.Point(58, 392);
            this.sorting_time.Margin = new System.Windows.Forms.Padding(2);
            this.sorting_time.Multiline = true;
            this.sorting_time.Name = "sorting_time";
            this.sorting_time.ReadOnly = true;
            this.sorting_time.Size = new System.Drawing.Size(135, 36);
            this.sorting_time.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Milli-Seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 BlkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sorted Array";
            // 
            // sorted_array
            // 
            this.sorted_array.BackColor = System.Drawing.Color.GhostWhite;
            this.sorted_array.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sorted_array.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11F);
            this.sorted_array.Location = new System.Drawing.Point(763, 48);
            this.sorted_array.Margin = new System.Windows.Forms.Padding(2);
            this.sorted_array.Multiline = true;
            this.sorted_array.Name = "sorted_array";
            this.sorted_array.ReadOnly = true;
            this.sorted_array.Size = new System.Drawing.Size(312, 429);
            this.sorted_array.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.sorting_time);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.NumberArray);
            this.panel2.Controls.Add(this.generate_array);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.max_value);
            this.panel2.Controls.Add(this.min_value);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 475);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Clear Array";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DarkCyan;
            this.button4.Location = new System.Drawing.Point(284, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 36);
            this.button4.TabIndex = 16;
            this.button4.Text = "Counting Sort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(202, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Heap Sort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(118, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Quick Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(15, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insertion Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberArray
            // 
            this.NumberArray.BackColor = System.Drawing.Color.AliceBlue;
            this.NumberArray.Location = new System.Drawing.Point(201, 76);
            this.NumberArray.Name = "NumberArray";
            this.NumberArray.Size = new System.Drawing.Size(140, 40);
            this.NumberArray.TabIndex = 12;
            this.NumberArray.Text = "";
            // 
            // generate_array
            // 
            this.generate_array.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_array.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_array.ForeColor = System.Drawing.Color.Crimson;
            this.generate_array.Location = new System.Drawing.Point(15, 249);
            this.generate_array.Margin = new System.Windows.Forms.Padding(2);
            this.generate_array.Name = "generate_array";
            this.generate_array.Size = new System.Drawing.Size(358, 38);
            this.generate_array.TabIndex = 9;
            this.generate_array.Text = "Generate Array";
            this.generate_array.UseVisualStyleBackColor = true;
            this.generate_array.Click += new System.EventHandler(this.generate_array_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Of Elements in Array";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum Value";
            // 
            // max_value
            // 
            this.max_value.BackColor = System.Drawing.Color.AliceBlue;
            this.max_value.Location = new System.Drawing.Point(201, 181);
            this.max_value.Margin = new System.Windows.Forms.Padding(2);
            this.max_value.Multiline = true;
            this.max_value.Name = "max_value";
            this.max_value.Size = new System.Drawing.Size(139, 42);
            this.max_value.TabIndex = 1;
            // 
            // min_value
            // 
            this.min_value.BackColor = System.Drawing.Color.AliceBlue;
            this.min_value.Location = new System.Drawing.Point(201, 131);
            this.min_value.Margin = new System.Windows.Forms.Padding(2);
            this.min_value.Multiline = true;
            this.min_value.Name = "min_value";
            this.min_value.Size = new System.Drawing.Size(139, 39);
            this.min_value.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sorted_array);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sorted_array;
        private System.Windows.Forms.TextBox generated_array;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox max_value;
        private System.Windows.Forms.TextBox min_value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sorting_time;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generate_array;
        private System.Windows.Forms.Label algorithm_name;
        private System.Windows.Forms.RichTextBox NumberArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

