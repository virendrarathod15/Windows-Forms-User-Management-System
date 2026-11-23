namespace Project1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label9 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.yellow = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(28, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enter UserName";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // t1
            // 
            this.t1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(322, 145);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(295, 34);
            this.t1.TabIndex = 11;
            this.t1.TextChanged += new System.EventHandler(this.vheyr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Allignment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButton2.Location = new System.Drawing.Point(261, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 33);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Center";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton3.Location = new System.Drawing.Point(541, 233);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 33);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Right";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Color";
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow.ForeColor = System.Drawing.Color.Black;
            this.yellow.Location = new System.Drawing.Point(522, 323);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(114, 33);
            this.yellow.TabIndex = 17;
            this.yellow.TabStop = true;
            this.yellow.Text = "Yellow";
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red.ForeColor = System.Drawing.Color.Black;
            this.red.Location = new System.Drawing.Point(388, 324);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(82, 33);
            this.red.TabIndex = 18;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = false;
            this.red.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.ForeColor = System.Drawing.Color.Black;
            this.blue.Location = new System.Drawing.Point(261, 323);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(87, 33);
            this.blue.TabIndex = 19;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton1.Location = new System.Drawing.Point(414, 235);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 33);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Left";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label9);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton yellow;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}