namespace GRE_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextHH = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextMM = new System.Windows.Forms.Label();
            this.TextSS = new System.Windows.Forms.Label();
            this.TextDD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextHH
            // 
            this.TextHH.AutoSize = true;
            this.TextHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHH.Location = new System.Drawing.Point(65, 22);
            this.TextHH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextHH.Name = "TextHH";
            this.TextHH.Size = new System.Drawing.Size(35, 20);
            this.TextHH.TabIndex = 3;
            this.TextHH.Text = "HH";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextMM
            // 
            this.TextMM.AutoSize = true;
            this.TextMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMM.Location = new System.Drawing.Point(125, 22);
            this.TextMM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextMM.Name = "TextMM";
            this.TextMM.Size = new System.Drawing.Size(37, 20);
            this.TextMM.TabIndex = 5;
            this.TextMM.Text = "MM";
            this.TextMM.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextSS
            // 
            this.TextSS.AutoSize = true;
            this.TextSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSS.Location = new System.Drawing.Point(199, 22);
            this.TextSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextSS.Name = "TextSS";
            this.TextSS.Size = new System.Drawing.Size(33, 20);
            this.TextSS.TabIndex = 6;
            this.TextSS.Text = "SS";
            // 
            // TextDD
            // 
            this.TextDD.AutoSize = true;
            this.TextDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDD.Location = new System.Drawing.Point(3, 22);
            this.TextDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextDD.Name = "TextDD";
            this.TextDD.Size = new System.Drawing.Size(35, 20);
            this.TextDD.TabIndex = 7;
            this.TextDD.Text = "DD";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Days";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hours";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time Remaining";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::GRE_Counter.Settings1.Default, "DT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = global::GRE_Counter.Settings1.Default.DT;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Target Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 72);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextDD);
            this.Controls.Add(this.TextSS);
            this.Controls.Add(this.TextMM);
            this.Controls.Add(this.TextHH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(311, 111);
            this.MinimumSize = new System.Drawing.Size(311, 91);
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZeroSofts - Time Counter";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextHH;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TextMM;
        private System.Windows.Forms.Label TextSS;
        private System.Windows.Forms.Label TextDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}

