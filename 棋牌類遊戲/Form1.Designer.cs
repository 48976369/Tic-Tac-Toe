namespace 棋牌類遊戲
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Location = new System.Drawing.Point(45, 66);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Location = new System.Drawing.Point(151, 66);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Location = new System.Drawing.Point(257, 66);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Location = new System.Drawing.Point(45, 172);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.Location = new System.Drawing.Point(151, 172);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.Location = new System.Drawing.Point(257, 172);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.Location = new System.Drawing.Point(45, 278);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.Location = new System.Drawing.Point(151, 278);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.Location = new System.Drawing.Point(257, 278);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblStatus.Location = new System.Drawing.Point(124, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(165, 27);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "目前輪到：O";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnRestart.Location = new System.Drawing.Point(390, 341);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(97, 37);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "重新開始";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRestart;
    }
}

