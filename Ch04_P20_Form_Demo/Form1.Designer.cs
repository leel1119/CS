namespace Ch04_P20_Form_Demo
{
    partial class bt_ChangeBGcolorr
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
            this.bt_ChangeColor = new System.Windows.Forms.Button();
            this.bt_ChangeColor2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cd_Dialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // bt_ChangeColor
            // 
            this.bt_ChangeColor.Location = new System.Drawing.Point(187, 191);
            this.bt_ChangeColor.Name = "bt_ChangeColor";
            this.bt_ChangeColor.Size = new System.Drawing.Size(105, 23);
            this.bt_ChangeColor.TabIndex = 0;
            this.bt_ChangeColor.Text = "改變背景顏色";
            this.bt_ChangeColor.UseVisualStyleBackColor = true;
            this.bt_ChangeColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ChangeColor2
            // 
            this.bt_ChangeColor2.Location = new System.Drawing.Point(549, 191);
            this.bt_ChangeColor2.Name = "bt_ChangeColor2";
            this.bt_ChangeColor2.Size = new System.Drawing.Size(98, 23);
            this.bt_ChangeColor2.TabIndex = 0;
            this.bt_ChangeColor2.Text = "改變文字顏色";
            this.bt_ChangeColor2.UseVisualStyleBackColor = true;
            this.bt_ChangeColor2.Click += new System.EventHandler(this.bt_ChangeColor2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "改變表單背景顏色";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_ChangeBGcolorr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1275, 639);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_ChangeColor2);
            this.Controls.Add(this.bt_ChangeColor);
            this.Name = "bt_ChangeBGcolorr";
            this.Text = "視窗應用程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ChangeColor;
        private System.Windows.Forms.Button bt_ChangeColor2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog cd_Dialog;
    }
}

