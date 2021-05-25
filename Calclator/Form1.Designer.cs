namespace Calclator
{
    partial class Calclator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.inputSynbol = new System.Windows.Forms.ComboBox();
            this.output1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(91, 170);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 19);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(353, 168);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 19);
            this.input2.TabIndex = 1;
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // inputSynbol
            // 
            this.inputSynbol.FormattingEnabled = true;
            this.inputSynbol.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.inputSynbol.Location = new System.Drawing.Point(258, 168);
            this.inputSynbol.Name = "inputSynbol";
            this.inputSynbol.Size = new System.Drawing.Size(27, 20);
            this.inputSynbol.TabIndex = 2;
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(562, 170);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(117, 19);
            this.output1.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submitButton.Location = new System.Drawing.Point(281, 263);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(210, 75);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "計算する";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Calclator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 398);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.inputSynbol);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Calclator";
            this.Text = "Calclaor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.ComboBox inputSynbol;
        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.Button submitButton;
    }
}

