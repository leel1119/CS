namespace Ch04_P35_Label_Output_Demo
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
            this.bt_increase = new System.Windows.Forms.Button();
            this.bt_decrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(293, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 222);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_increase
            // 
            this.bt_increase.Location = new System.Drawing.Point(193, 313);
            this.bt_increase.Name = "bt_increase";
            this.bt_increase.Size = new System.Drawing.Size(162, 61);
            this.bt_increase.TabIndex = 1;
            this.bt_increase.Text = "增加";
            this.bt_increase.UseVisualStyleBackColor = true;
            this.bt_increase.Click += new System.EventHandler(this.bt_increase_Click);
            // 
            // bt_decrease
            // 
            this.bt_decrease.Location = new System.Drawing.Point(462, 313);
            this.bt_decrease.Name = "bt_decrease";
            this.bt_decrease.Size = new System.Drawing.Size(143, 61);
            this.bt_decrease.TabIndex = 2;
            this.bt_decrease.Text = "減少";
            this.bt_decrease.UseVisualStyleBackColor = true;
            this.bt_decrease.Click += new System.EventHandler(this.bt_decrease_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_decrease);
            this.Controls.Add(this.bt_increase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "計數器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_increase;
        private System.Windows.Forms.Button bt_decrease;
    }
}

