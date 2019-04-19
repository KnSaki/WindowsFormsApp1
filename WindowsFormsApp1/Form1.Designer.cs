namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.base1 = new WindowsFormsApp1.Base();
            this.base2 = new WindowsFormsApp1.Base();
            this.base3 = new WindowsFormsApp1.Base();
            this.base4 = new WindowsFormsApp1.Base();
            this.base5 = new WindowsFormsApp1.Base();
            this.base6 = new WindowsFormsApp1.Base();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // base1
            // 
            this.base1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base1.Location = new System.Drawing.Point(12, 12);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(154, 98);
            this.base1.TabIndex = 1;
            // 
            // base2
            // 
            this.base2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base2.Location = new System.Drawing.Point(173, 13);
            this.base2.Name = "base2";
            this.base2.Size = new System.Drawing.Size(154, 98);
            this.base2.TabIndex = 2;
            // 
            // base3
            // 
            this.base3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base3.Location = new System.Drawing.Point(12, 117);
            this.base3.Name = "base3";
            this.base3.Size = new System.Drawing.Size(154, 98);
            this.base3.TabIndex = 3;
            // 
            // base4
            // 
            this.base4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base4.Location = new System.Drawing.Point(173, 118);
            this.base4.Name = "base4";
            this.base4.Size = new System.Drawing.Size(154, 98);
            this.base4.TabIndex = 4;
            // 
            // base5
            // 
            this.base5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base5.Location = new System.Drawing.Point(13, 222);
            this.base5.Name = "base5";
            this.base5.Size = new System.Drawing.Size(154, 98);
            this.base5.TabIndex = 5;
            // 
            // base6
            // 
            this.base6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base6.Location = new System.Drawing.Point(174, 222);
            this.base6.Name = "base6";
            this.base6.Size = new System.Drawing.Size(154, 98);
            this.base6.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 404);
            this.Controls.Add(this.base6);
            this.Controls.Add(this.base5);
            this.Controls.Add(this.base4);
            this.Controls.Add(this.base3);
            this.Controls.Add(this.base2);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Base base1;
        private Base base2;
        private Base base3;
        private Base base4;
        private Base base5;
        private Base base6;
    }
}

