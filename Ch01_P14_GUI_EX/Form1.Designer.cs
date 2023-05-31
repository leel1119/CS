namespace Ch01_P14_GUI_EX
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.tb_Num2 = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.bt_compute_sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "數值1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "數值2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "結果";
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(241, 52);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(100, 22);
            this.tb_Num1.TabIndex = 3;
            this.tb_Num1.Text = "0";
            // 
            // tb_Num2
            // 
            this.tb_Num2.Location = new System.Drawing.Point(241, 133);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(100, 22);
            this.tb_Num2.TabIndex = 4;
            this.tb_Num2.Text = "0";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(241, 239);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(100, 22);
            this.tb_result.TabIndex = 5;
            this.tb_result.Text = "0";
            // 
            // bt_compute_sum
            // 
            this.bt_compute_sum.Location = new System.Drawing.Point(255, 186);
            this.bt_compute_sum.Name = "bt_compute_sum";
            this.bt_compute_sum.Size = new System.Drawing.Size(86, 23);
            this.bt_compute_sum.TabIndex = 6;
            this.bt_compute_sum.Text = "Compute Sum";
            this.bt_compute_sum.UseVisualStyleBackColor = true;
            this.bt_compute_sum.Click += new System.EventHandler(this.bt_compute_sum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_compute_sum);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.TextBox tb_Num2;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button bt_compute_sum;
    }
}

