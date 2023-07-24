namespace Ch04_P55_MessageBox.Demo
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
            this.tb_money = new System.Windows.Forms.TextBox();
            this.bt_USD_2_NTD = new System.Windows.Forms.Button();
            this.bt_JtoNTD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Usd_rate = new System.Windows.Forms.TextBox();
            this.tb_J_rate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(122, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額:";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(215, 114);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(146, 22);
            this.tb_money.TabIndex = 1;
            // 
            // bt_USD_2_NTD
            // 
            this.bt_USD_2_NTD.Location = new System.Drawing.Point(412, 114);
            this.bt_USD_2_NTD.Name = "bt_USD_2_NTD";
            this.bt_USD_2_NTD.Size = new System.Drawing.Size(75, 23);
            this.bt_USD_2_NTD.TabIndex = 2;
            this.bt_USD_2_NTD.Text = "美金換台幣";
            this.bt_USD_2_NTD.UseVisualStyleBackColor = true;
            this.bt_USD_2_NTD.Click += new System.EventHandler(this.bt_USD_2_NTD_Click);
            // 
            // bt_JtoNTD
            // 
            this.bt_JtoNTD.Location = new System.Drawing.Point(558, 113);
            this.bt_JtoNTD.Name = "bt_JtoNTD";
            this.bt_JtoNTD.Size = new System.Drawing.Size(75, 23);
            this.bt_JtoNTD.TabIndex = 3;
            this.bt_JtoNTD.Text = "日幣換台幣";
            this.bt_JtoNTD.UseVisualStyleBackColor = true;
            this.bt_JtoNTD.Click += new System.EventHandler(this.bt_JtoNTD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(309, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "匯率:";
            // 
            // tb_Usd_rate
            // 
            this.tb_Usd_rate.Location = new System.Drawing.Point(412, 179);
            this.tb_Usd_rate.Name = "tb_Usd_rate";
            this.tb_Usd_rate.Size = new System.Drawing.Size(75, 22);
            this.tb_Usd_rate.TabIndex = 5;
            this.tb_Usd_rate.Text = "31.2";
            // 
            // tb_J_rate
            // 
            this.tb_J_rate.Location = new System.Drawing.Point(558, 179);
            this.tb_J_rate.Name = "tb_J_rate";
            this.tb_J_rate.Size = new System.Drawing.Size(75, 22);
            this.tb_J_rate.TabIndex = 6;
            this.tb_J_rate.Text = "0.24";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(271, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "台幣金額:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(412, 252);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(75, 22);
            this.tb_result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_J_rate);
            this.Controls.Add(this.tb_Usd_rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_JtoNTD);
            this.Controls.Add(this.bt_USD_2_NTD);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Button bt_USD_2_NTD;
        private System.Windows.Forms.Button bt_JtoNTD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Usd_rate;
        private System.Windows.Forms.TextBox tb_J_rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_result;
    }
}

