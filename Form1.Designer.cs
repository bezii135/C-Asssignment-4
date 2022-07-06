namespace cassignment4
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
            this.txtnumber = new System.Windows.Forms.Label();
            this.dtn_date = new System.Windows.Forms.Label();
            this.txtmodifier = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumber
            // 
            this.txtnumber.AutoSize = true;
            this.txtnumber.Location = new System.Drawing.Point(72, 38);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(63, 20);
            this.txtnumber.TabIndex = 0;
            this.txtnumber.Text = "Number";
            this.txtnumber.Click += new System.EventHandler(this.txtnumber_Click);
            // 
            // dtn_date
            // 
            this.dtn_date.AutoSize = true;
            this.dtn_date.Location = new System.Drawing.Point(305, 38);
            this.dtn_date.Name = "dtn_date";
            this.dtn_date.Size = new System.Drawing.Size(41, 20);
            this.dtn_date.TabIndex = 1;
            this.dtn_date.Text = "Date";
            this.dtn_date.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtmodifier
            // 
            this.txtmodifier.AutoSize = true;
            this.txtmodifier.Location = new System.Drawing.Point(570, 38);
            this.txtmodifier.Name = "txtmodifier";
            this.txtmodifier.Size = new System.Drawing.Size(66, 20);
            this.txtmodifier.TabIndex = 2;
            this.txtmodifier.Text = "Modifier";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(533, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Itemname";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 27);
            this.textBox2.TabIndex = 8;
            // 
            // txtcount
            // 
            this.txtcount.AutoSize = true;
            this.txtcount.Location = new System.Drawing.Point(72, 259);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(46, 20);
            this.txtcount.TabIndex = 9;
            this.txtcount.Text = "count";
            // 
            // txtprice
            // 
            this.txtprice.AutoSize = true;
            this.txtprice.Location = new System.Drawing.Point(366, 259);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(41, 20);
            this.txtprice.TabIndex = 10;
            this.txtprice.Text = "Price";
            this.txtprice.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 294);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 27);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(322, 294);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 27);
            this.textBox5.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(41, 381);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 29);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(349, 381);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 29);
            this.btnclose.TabIndex = 16;
            this.btnclose.Text = "Cancel";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtmodifier);
            this.Controls.Add(this.dtn_date);
            this.Controls.Add(this.txtnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtnumber;
        private Label dtn_date;
        private Label txtmodifier;
        private TextBox textBox1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox2;
        private Label txtcount;
        private Label txtprice;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnadd;
        private Button btnclose;
    }
}