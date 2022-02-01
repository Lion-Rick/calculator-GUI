
using System;

namespace 電卓のGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.button_tasu = new System.Windows.Forms.Button();
            this.button_hiku = new System.Windows.Forms.Button();
            this.button_kakuru = new System.Windows.Forms.Button();
            this.button_waru = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_pasento = new System.Windows.Forms.Button();
            this.button_kawaru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.計算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(11, 441);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 64);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(11, 371);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 64);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(69, 371);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 64);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(128, 371);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 64);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(11, 301);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 64);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(69, 301);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 64);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(128, 301);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 64);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 231);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 64);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(69, 231);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 64);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(128, 231);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 64);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(69, 441);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(53, 64);
            this.button_dot.TabIndex = 10;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(128, 441);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(53, 64);
            this.calc.TabIndex = 11;
            this.calc.Text = "=";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // button_tasu
            // 
            this.button_tasu.Location = new System.Drawing.Point(186, 441);
            this.button_tasu.Name = "button_tasu";
            this.button_tasu.Size = new System.Drawing.Size(53, 64);
            this.button_tasu.TabIndex = 12;
            this.button_tasu.Text = "+";
            this.button_tasu.UseVisualStyleBackColor = true;
            this.button_tasu.Click += new System.EventHandler(this.button_tasu_Click);
            // 
            // button_hiku
            // 
            this.button_hiku.Location = new System.Drawing.Point(186, 371);
            this.button_hiku.Name = "button_hiku";
            this.button_hiku.Size = new System.Drawing.Size(53, 64);
            this.button_hiku.TabIndex = 13;
            this.button_hiku.Text = "-";
            this.button_hiku.UseVisualStyleBackColor = true;
            this.button_hiku.Click += new System.EventHandler(this.button_hiku_Click);
            // 
            // button_kakuru
            // 
            this.button_kakuru.Location = new System.Drawing.Point(186, 301);
            this.button_kakuru.Name = "button_kakuru";
            this.button_kakuru.Size = new System.Drawing.Size(53, 64);
            this.button_kakuru.TabIndex = 14;
            this.button_kakuru.Text = "×";
            this.button_kakuru.UseVisualStyleBackColor = true;
            this.button_kakuru.Click += new System.EventHandler(this.button_kakuru_Click);
            // 
            // button_waru
            // 
            this.button_waru.Location = new System.Drawing.Point(186, 231);
            this.button_waru.Name = "button_waru";
            this.button_waru.Size = new System.Drawing.Size(53, 64);
            this.button_waru.TabIndex = 15;
            this.button_waru.Text = "÷";
            this.button_waru.UseVisualStyleBackColor = true;
            this.button_waru.Click += new System.EventHandler(this.button_waru_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_delete.Location = new System.Drawing.Point(187, 161);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(53, 64);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "DEL";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_clean.Location = new System.Drawing.Point(128, 161);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(53, 64);
            this.button_clean.TabIndex = 17;
            this.button_clean.Text = "C";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_pasento
            // 
            this.button_pasento.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_pasento.Location = new System.Drawing.Point(69, 161);
            this.button_pasento.Name = "button_pasento";
            this.button_pasento.Size = new System.Drawing.Size(53, 64);
            this.button_pasento.TabIndex = 18;
            this.button_pasento.Text = "%";
            this.button_pasento.UseVisualStyleBackColor = true;
            this.button_pasento.Click += new System.EventHandler(this.button_pasento_Click);
            // 
            // button_kawaru
            // 
            this.button_kawaru.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_kawaru.Location = new System.Drawing.Point(11, 161);
            this.button_kawaru.Name = "button_kawaru";
            this.button_kawaru.Size = new System.Drawing.Size(53, 64);
            this.button_kawaru.TabIndex = 19;
            this.button_kawaru.Text = "+/-";
            this.button_kawaru.UseVisualStyleBackColor = true;
            this.button_kawaru.Click += new System.EventHandler(this.button_kawaru_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 88);
            this.label1.TabIndex = 20;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(252, 34);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.計算ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 29);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // 計算ToolStripMenuItem
            // 
            this.計算ToolStripMenuItem.Name = "計算ToolStripMenuItem";
            this.計算ToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.計算ToolStripMenuItem.Text = "計算";
            this.計算ToolStripMenuItem.Click += new System.EventHandler(this.計算ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 517);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kawaru);
            this.Controls.Add(this.button_pasento);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_waru);
            this.Controls.Add(this.button_kakuru);
            this.Controls.Add(this.button_hiku);
            this.Controls.Add(this.button_tasu);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button button_tasu;
        private System.Windows.Forms.Button button_hiku;
        private System.Windows.Forms.Button button_kakuru;
        private System.Windows.Forms.Button button_waru;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_pasento;
        private System.Windows.Forms.Button button_kawaru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 計算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}

