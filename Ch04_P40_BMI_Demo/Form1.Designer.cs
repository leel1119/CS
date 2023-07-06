namespace Ch04_P40_BMI_Demo
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
            this.lb_M = new System.Windows.Forms.Label();
            this.lb_KG = new System.Windows.Forms.Label();
            this.lb_BMI = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_tall = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_M
            // 
            this.lb_M.BackColor = System.Drawing.SystemColors.Control;
            this.lb_M.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_M.Location = new System.Drawing.Point(127, 107);
            this.lb_M.Name = "lb_M";
            this.lb_M.Size = new System.Drawing.Size(136, 32);
            this.lb_M.TabIndex = 0;
            this.lb_M.Text = "身高:(M)";
            this.lb_M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_M.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_KG
            // 
            this.lb_KG.AutoSize = true;
            this.lb_KG.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_KG.Location = new System.Drawing.Point(145, 190);
            this.lb_KG.Name = "lb_KG";
            this.lb_KG.Size = new System.Drawing.Size(97, 19);
            this.lb_KG.TabIndex = 1;
            this.lb_KG.Text = "體重:(KG)";
            this.lb_KG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_BMI
            // 
            this.lb_BMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_BMI.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_BMI.Location = new System.Drawing.Point(149, 264);
            this.lb_BMI.Name = "lb_BMI";
            this.lb_BMI.Size = new System.Drawing.Size(479, 40);
            this.lb_BMI.TabIndex = 2;
            this.lb_BMI.Text = "BMI值";
            this.lb_BMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(446, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 162);
            this.button1.TabIndex = 3;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_tall
            // 
            this.tb_tall.Location = new System.Drawing.Point(295, 107);
            this.tb_tall.Name = "tb_tall";
            this.tb_tall.Size = new System.Drawing.Size(100, 22);
            this.tb_tall.TabIndex = 4;
            this.tb_tall.Text = "0";
            this.tb_tall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(295, 187);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(100, 22);
            this.tb_weight.TabIndex = 5;
            this.tb_weight.Text = "0";
            this.tb_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.tb_tall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_BMI);
            this.Controls.Add(this.lb_KG);
            this.Controls.Add(this.lb_M);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_M;
        private System.Windows.Forms.Label lb_KG;
        private System.Windows.Forms.Label lb_BMI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_tall;
        private System.Windows.Forms.TextBox tb_weight;
    }
}

