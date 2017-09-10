namespace AcmeManufactureCS
{
    partial class AcmeMantufactureCSMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.openForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openForm
            // 
            this.openForm.Location = new System.Drawing.Point(13, 13);
            this.openForm.Name = "openForm";
            this.openForm.Size = new System.Drawing.Size(187, 36);
            this.openForm.TabIndex = 0;
            this.openForm.Text = "Open VB Form";
            this.openForm.UseVisualStyleBackColor = true;
            this.openForm.Click += new System.EventHandler(this.openForm_Click);
            // 
            // AcmeMantufactureCSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 337);
            this.Controls.Add(this.openForm);
            this.Name = "AcmeMantufactureCSMain";
            this.Text = "C Sharp Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openForm;
    }
}

