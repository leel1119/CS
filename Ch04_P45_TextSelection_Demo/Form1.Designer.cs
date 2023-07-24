namespace Ch04_P45_TextSelection_Demo
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
            this.tb_Text = new System.Windows.Forms.TextBox();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            this.lb_Output = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(38, 30);
            this.tb_Text.Multiline = true;
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Text.Size = new System.Drawing.Size(416, 153);
            this.tb_Text.TabIndex = 0;
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(236, 232);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 1;
            this.bt_select.Text = "選取6個字";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_show
            // 
            this.bt_show.Location = new System.Drawing.Point(454, 232);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(75, 23);
            this.bt_show.TabIndex = 2;
            this.bt_show.Text = "顯示";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // lb_Output
            // 
            this.lb_Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Output.Location = new System.Drawing.Point(174, 298);
            this.lb_Output.Name = "lb_Output";
            this.lb_Output.Size = new System.Drawing.Size(418, 118);
            this.lb_Output.TabIndex = 3;
            this.lb_Output.Text = "label1";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(524, 78);
            this.tb_number.Multiline = true;
            this.tb_number.Name = "tb_number";
            this.tb_number.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_number.Size = new System.Drawing.Size(222, 64);
            this.tb_number.TabIndex = 4;
            this.tb_number.Text = "3";
            this.tb_number.TextChanged += new System.EventHandler(this.tb_number_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.lb_Output);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.tb_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Text;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_show;
        private System.Windows.Forms.Label lb_Output;
        private System.Windows.Forms.TextBox tb_number;
    }
}

