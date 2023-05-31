namespace Ch01_P15_OP_EX
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
            this.bt_compute = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_mul = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "數值1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "數值2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "結果";
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(212, 49);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(100, 22);
            this.tb_Num1.TabIndex = 1;
            // 
            // tb_Num2
            // 
            this.tb_Num2.Location = new System.Drawing.Point(212, 135);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(100, 22);
            this.tb_Num2.TabIndex = 1;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(212, 296);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(100, 22);
            this.tb_result.TabIndex = 1;
            // 
            // bt_compute
            // 
            this.bt_compute.Location = new System.Drawing.Point(212, 190);
            this.bt_compute.Name = "bt_compute";
            this.bt_compute.Size = new System.Drawing.Size(100, 63);
            this.bt_compute.TabIndex = 2;
            this.bt_compute.Text = "計算";
            this.bt_compute.UseVisualStyleBackColor = true;
            this.bt_compute.Click += new System.EventHandler(this.bt_compute_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(212, 345);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(100, 47);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "離開";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_div);
            this.groupBox1.Controls.Add(this.rb_mul);
            this.groupBox1.Controls.Add(this.rb_sub);
            this.groupBox1.Controls.Add(this.rb_add);
            this.groupBox1.Location = new System.Drawing.Point(422, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "四則運算";
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(6, 133);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(47, 16);
            this.rb_div.TabIndex = 0;
            this.rb_div.Text = "除法";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // rb_mul
            // 
            this.rb_mul.AutoSize = true;
            this.rb_mul.Location = new System.Drawing.Point(7, 101);
            this.rb_mul.Name = "rb_mul";
            this.rb_mul.Size = new System.Drawing.Size(47, 16);
            this.rb_mul.TabIndex = 0;
            this.rb_mul.Text = "乘法";
            this.rb_mul.UseVisualStyleBackColor = true;
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(7, 70);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(47, 16);
            this.rb_sub.TabIndex = 0;
            this.rb_sub.Text = "減法";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Checked = true;
            this.rb_add.Location = new System.Drawing.Point(7, 39);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(47, 16);
            this.rb_add.TabIndex = 0;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "加法";
            this.rb_add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_compute);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "四則運算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button bt_compute;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_mul;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_add;
    }
}

