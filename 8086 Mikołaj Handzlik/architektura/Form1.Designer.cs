﻿
namespace architektura
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
            this.AXBox = new System.Windows.Forms.TextBox();
            this.BXBox = new System.Windows.Forms.TextBox();
            this.CXBox = new System.Windows.Forms.TextBox();
            this.DXBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MOV_btn = new System.Windows.Forms.Button();
            this.XCHG_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.random_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AXBox
            // 
            this.AXBox.Location = new System.Drawing.Point(45, 160);
            this.AXBox.MaxLength = 4;
            this.AXBox.Name = "AXBox";
            this.AXBox.Size = new System.Drawing.Size(100, 23);
            this.AXBox.TabIndex = 0;
            this.AXBox.Text = "0000";
            this.AXBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AXBox_KeyPress);
            // 
            // BXBox
            // 
            this.BXBox.Location = new System.Drawing.Point(46, 193);
            this.BXBox.MaxLength = 4;
            this.BXBox.Name = "BXBox";
            this.BXBox.Size = new System.Drawing.Size(100, 23);
            this.BXBox.TabIndex = 1;
            this.BXBox.Text = "0000";
            // 
            // CXBox
            // 
            this.CXBox.Location = new System.Drawing.Point(46, 226);
            this.CXBox.MaxLength = 4;
            this.CXBox.Name = "CXBox";
            this.CXBox.Size = new System.Drawing.Size(100, 23);
            this.CXBox.TabIndex = 2;
            this.CXBox.Text = "0000";
            // 
            // DXBox
            // 
            this.DXBox.Location = new System.Drawing.Point(46, 260);
            this.DXBox.MaxLength = 4;
            this.DXBox.Name = "DXBox";
            this.DXBox.Size = new System.Drawing.Size(100, 23);
            this.DXBox.TabIndex = 3;
            this.DXBox.Text = "0000";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 19);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AX\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 19);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "BX";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(40, 19);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CX";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 19);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "DX";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(45, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 141);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(165, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 141);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 65);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(40, 19);
            this.radioButton7.TabIndex = 15;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "CX";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 15);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(40, 19);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "AX\r\n";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(40, 19);
            this.radioButton8.TabIndex = 14;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "DX";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(39, 19);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "BX";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "DX";
            // 
            // MOV_btn
            // 
            this.MOV_btn.BackColor = System.Drawing.Color.Salmon;
            this.MOV_btn.ForeColor = System.Drawing.Color.Black;
            this.MOV_btn.Location = new System.Drawing.Point(403, 119);
            this.MOV_btn.Name = "MOV_btn";
            this.MOV_btn.Size = new System.Drawing.Size(110, 52);
            this.MOV_btn.TabIndex = 30;
            this.MOV_btn.Text = "MOV";
            this.MOV_btn.UseVisualStyleBackColor = false;
            this.MOV_btn.Click += new System.EventHandler(this.MOV_btn_Click);
            // 
            // XCHG_btn
            // 
            this.XCHG_btn.BackColor = System.Drawing.Color.Salmon;
            this.XCHG_btn.ForeColor = System.Drawing.Color.Black;
            this.XCHG_btn.Location = new System.Drawing.Point(403, 177);
            this.XCHG_btn.Name = "XCHG_btn";
            this.XCHG_btn.Size = new System.Drawing.Size(110, 53);
            this.XCHG_btn.TabIndex = 31;
            this.XCHG_btn.Text = "XCHG";
            this.XCHG_btn.UseVisualStyleBackColor = false;
            this.XCHG_btn.Click += new System.EventHandler(this.XCHG_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(165, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // random_button
            // 
            this.random_button.BackColor = System.Drawing.Color.Red;
            this.random_button.ForeColor = System.Drawing.Color.Black;
            this.random_button.Location = new System.Drawing.Point(165, 215);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(75, 23);
            this.random_button.TabIndex = 33;
            this.random_button.Text = "Random";
            this.random_button.UseVisualStyleBackColor = false;
            this.random_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::architektura.Properties.Resources.ssss;
            this.ClientSize = new System.Drawing.Size(511, 510);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.XCHG_btn);
            this.Controls.Add(this.MOV_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DXBox);
            this.Controls.Add(this.CXBox);
            this.Controls.Add(this.BXBox);
            this.Controls.Add(this.AXBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AXBox;

        private System.Windows.Forms.TextBox BXBox;
        
        private System.Windows.Forms.TextBox CXBox;
        
        private System.Windows.Forms.TextBox DXBox;
        
        private System.Windows.Forms.RadioButton radioButton1;
        
        private System.Windows.Forms.RadioButton radioButton2;
        
        private System.Windows.Forms.RadioButton radioButton3;
        
        private System.Windows.Forms.RadioButton radioButton4;
        
        private System.Windows.Forms.GroupBox groupBox1;
        
        private System.Windows.Forms.GroupBox groupBox2;
        
        private System.Windows.Forms.RadioButton radioButton7;
        
        private System.Windows.Forms.RadioButton radioButton5;
        
        private System.Windows.Forms.RadioButton radioButton8;
        
        private System.Windows.Forms.RadioButton radioButton6;
        
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Label label3;
        
        private System.Windows.Forms.Label label4;
        
        private System.Windows.Forms.Button MOV_btn;
        
        private System.Windows.Forms.Button XCHG_btn;
        
        private System.Windows.Forms.Button button3;
        
        private System.Windows.Forms.Button random_button;
    }
}

