namespace Unicode_To_ST7920C
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.rdbStringStyle = new System.Windows.Forms.RadioButton();
            this.rdbArrayStyle = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxInput.Location = new System.Drawing.Point(12, 12);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(458, 29);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutput.Location = new System.Drawing.Point(12, 104);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(458, 270);
            this.tbxOutput.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(482, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(28, 17);
            this.statusMessage.Text = "030";
            // 
            // rdbStringStyle
            // 
            this.rdbStringStyle.AutoSize = true;
            this.rdbStringStyle.Checked = true;
            this.rdbStringStyle.Location = new System.Drawing.Point(25, 64);
            this.rdbStringStyle.Name = "rdbStringStyle";
            this.rdbStringStyle.Size = new System.Drawing.Size(47, 16);
            this.rdbStringStyle.TabIndex = 3;
            this.rdbStringStyle.TabStop = true;
            this.rdbStringStyle.Text = "字串";
            this.rdbStringStyle.UseVisualStyleBackColor = true;
            this.rdbStringStyle.CheckedChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // rdbArrayStyle
            // 
            this.rdbArrayStyle.AutoSize = true;
            this.rdbArrayStyle.Location = new System.Drawing.Point(87, 64);
            this.rdbArrayStyle.Name = "rdbArrayStyle";
            this.rdbArrayStyle.Size = new System.Drawing.Size(47, 16);
            this.rdbArrayStyle.TabIndex = 4;
            this.rdbArrayStyle.TabStop = true;
            this.rdbArrayStyle.Text = "陣列";
            this.rdbArrayStyle.UseVisualStyleBackColor = true;
            this.rdbArrayStyle.CheckedChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 407);
            this.Controls.Add(this.rdbArrayStyle);
            this.Controls.Add(this.rdbStringStyle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxInput);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Unicode轉ST7920C編碼";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.RadioButton rdbStringStyle;
        private System.Windows.Forms.RadioButton rdbArrayStyle;
    }
}

