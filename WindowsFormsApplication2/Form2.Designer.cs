namespace WindowsFormsApplication2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(809, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 46);
            this.button7.TabIndex = 0;
            this.button7.Text = "回首頁";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(73, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "11800 - 電腦軟體應用";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("新細明體", 12F);
            this.button2.Location = new System.Drawing.Point(73, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "12000 - 電腦硬體裝修";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("新細明體", 12F);
            this.button4.Location = new System.Drawing.Point(463, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 55);
            this.button4.TabIndex = 1;
            this.button4.Text = "11900 - 電腦軟體設計";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("新細明體", 12F);
            this.button3.Location = new System.Drawing.Point(73, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 55);
            this.button3.TabIndex = 1;
            this.button3.Text = "17200 - 網路架設";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("新細明體", 12F);
            this.button6.Location = new System.Drawing.Point(463, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(296, 55);
            this.button6.TabIndex = 1;
            this.button6.Text = "17300 - 網頁設計";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("新細明體", 12F);
            this.button5.Location = new System.Drawing.Point(463, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(296, 55);
            this.button5.TabIndex = 1;
            this.button5.Text = "02800 - 工業電子";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 471);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "選擇證照考試";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}