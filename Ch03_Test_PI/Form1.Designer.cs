namespace Ch03_Test_PI
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
            this.radios = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.tb_radios = new System.Windows.Forms.TextBox();
            this.bt_math = new System.Windows.Forms.Button();
            this.rb_perimeter = new System.Windows.Forms.RadioButton();
            this.rb_area = new System.Windows.Forms.RadioButton();
            this.rb_diameter = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radios
            // 
            this.radios.AutoSize = true;
            this.radios.Location = new System.Drawing.Point(215, 89);
            this.radios.Name = "radios";
            this.radios.Size = new System.Drawing.Size(29, 12);
            this.radios.TabIndex = 0;
            this.radios.Text = "半徑";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(215, 270);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(29, 12);
            this.result.TabIndex = 1;
            this.result.Text = "結果";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(262, 267);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(100, 22);
            this.tb_result.TabIndex = 2;
            this.tb_result.Text = "0";
            // 
            // tb_radios
            // 
            this.tb_radios.Location = new System.Drawing.Point(262, 86);
            this.tb_radios.Multiline = true;
            this.tb_radios.Name = "tb_radios";
            this.tb_radios.Size = new System.Drawing.Size(100, 50);
            this.tb_radios.TabIndex = 3;
            this.tb_radios.Text = "0";
            this.tb_radios.TextChanged += new System.EventHandler(this.tb_r_TextChanged);
            // 
            // bt_math
            // 
            this.bt_math.Location = new System.Drawing.Point(262, 156);
            this.bt_math.Name = "bt_math";
            this.bt_math.Size = new System.Drawing.Size(100, 56);
            this.bt_math.TabIndex = 4;
            this.bt_math.Text = "計算";
            this.bt_math.UseVisualStyleBackColor = true;
            this.bt_math.Click += new System.EventHandler(this.bt_math_Click);
            // 
            // rb_perimeter
            // 
            this.rb_perimeter.AutoSize = true;
            this.rb_perimeter.Checked = true;
            this.rb_perimeter.Location = new System.Drawing.Point(0, 41);
            this.rb_perimeter.Name = "rb_perimeter";
            this.rb_perimeter.Size = new System.Drawing.Size(47, 16);
            this.rb_perimeter.TabIndex = 5;
            this.rb_perimeter.TabStop = true;
            this.rb_perimeter.Text = "周長";
            this.rb_perimeter.UseVisualStyleBackColor = true;
            this.rb_perimeter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_area
            // 
            this.rb_area.AutoSize = true;
            this.rb_area.Location = new System.Drawing.Point(0, 91);
            this.rb_area.Name = "rb_area";
            this.rb_area.Size = new System.Drawing.Size(47, 16);
            this.rb_area.TabIndex = 6;
            this.rb_area.Text = "面積";
            this.rb_area.UseVisualStyleBackColor = true;
            // 
            // rb_diameter
            // 
            this.rb_diameter.AutoSize = true;
            this.rb_diameter.Location = new System.Drawing.Point(0, 136);
            this.rb_diameter.Name = "rb_diameter";
            this.rb_diameter.Size = new System.Drawing.Size(47, 16);
            this.rb_diameter.TabIndex = 7;
            this.rb_diameter.Text = "直徑";
            this.rb_diameter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_perimeter);
            this.groupBox1.Controls.Add(this.rb_diameter);
            this.groupBox1.Controls.Add(this.rb_area);
            this.groupBox1.Location = new System.Drawing.Point(502, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選單";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_math);
            this.Controls.Add(this.tb_radios);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.result);
            this.Controls.Add(this.radios);
            this.Name = "Form1";
            this.Text = "計算圓";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radios;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.TextBox tb_radios;
        private System.Windows.Forms.Button bt_math;
        private System.Windows.Forms.RadioButton rb_perimeter;
        private System.Windows.Forms.RadioButton rb_area;
        private System.Windows.Forms.RadioButton rb_diameter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

