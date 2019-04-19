namespace WindowsFormsApp1 {
    partial class Base {
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.plate1 = new WindowsFormsApp1.Plate();
            this.plate2 = new WindowsFormsApp1.Plate();
            this.plate3 = new WindowsFormsApp1.Plate();
            this.plate4 = new WindowsFormsApp1.Plate();
            this.plate5 = new WindowsFormsApp1.Plate();
            this.plate6 = new WindowsFormsApp1.Plate();
            this.SuspendLayout();
            // 
            // plate1
            // 
            this.plate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plate1.Location = new System.Drawing.Point(3, 3);
            this.plate1.Name = "plate1";
            this.plate1.Size = new System.Drawing.Size(43, 40);
            this.plate1.TabIndex = 2;
            // 
            // plate2
            // 
            this.plate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plate2.Location = new System.Drawing.Point(52, 3);
            this.plate2.Name = "plate2";
            this.plate2.Size = new System.Drawing.Size(43, 40);
            this.plate2.TabIndex = 3;
            // 
            // plate3
            // 
            this.plate3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plate3.Location = new System.Drawing.Point(102, 4);
            this.plate3.Name = "plate3";
            this.plate3.Size = new System.Drawing.Size(43, 40);
            this.plate3.TabIndex = 4;
            // 
            // plate4
            // 
            this.plate4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plate4.Location = new System.Drawing.Point(3, 50);
            this.plate4.Name = "plate4";
            this.plate4.Size = new System.Drawing.Size(43, 40);
            this.plate4.TabIndex = 5;
            // 
            // plate5
            // 
            this.plate5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plate5.Location = new System.Drawing.Point(53, 50);
            this.plate5.Name = "plate5";
            this.plate5.Size = new System.Drawing.Size(43, 40);
            this.plate5.TabIndex = 6;
            // 
            // plate6
            // 
            this.plate6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plate6.Location = new System.Drawing.Point(102, 50);
            this.plate6.Name = "plate6";
            this.plate6.Size = new System.Drawing.Size(43, 40);
            this.plate6.TabIndex = 7;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.plate6);
            this.Controls.Add(this.plate5);
            this.Controls.Add(this.plate4);
            this.Controls.Add(this.plate3);
            this.Controls.Add(this.plate2);
            this.Controls.Add(this.plate1);
            this.Name = "Base";
            this.Size = new System.Drawing.Size(154, 98);
            this.ResumeLayout(false);

        }

        #endregion
        private Plate plate1;
        private Plate plate2;
        private Plate plate3;
        private Plate plate4;
        private Plate plate5;
        private Plate plate6;
    }
}
