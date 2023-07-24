namespace Ch04_P43_Multiline_TB_Demo
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
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_input = new System.Windows.Forms.Button();
            this.tb_InputText = new System.Windows.Forms.TextBox();
            this.lb_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(262, 48);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 22);
            this.tb_password.TabIndex = 1;
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(428, 48);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(75, 23);
            this.bt_input.TabIndex = 2;
            this.bt_input.Text = "輸入";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // tb_InputText
            // 
            this.tb_InputText.Location = new System.Drawing.Point(201, 109);
            this.tb_InputText.Multiline = true;
            this.tb_InputText.Name = "tb_InputText";
            this.tb_InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_InputText.Size = new System.Drawing.Size(304, 142);
            this.tb_InputText.TabIndex = 3;
            // 
            // lb_show
            // 
            this.lb_show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_show.Location = new System.Drawing.Point(201, 286);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(304, 118);
            this.lb_show.TabIndex = 4;
            this.lb_show.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.tb_InputText);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.TextBox tb_InputText;
        private System.Windows.Forms.Label lb_show;
    }
}

