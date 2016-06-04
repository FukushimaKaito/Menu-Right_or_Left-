namespace メニュー
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選択肢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右に行くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左に行くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選択肢ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選択肢ToolStripMenuItem
            // 
            this.選択肢ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.右に行くToolStripMenuItem,
            this.左に行くToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.選択肢ToolStripMenuItem.Name = "選択肢ToolStripMenuItem";
            this.選択肢ToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.選択肢ToolStripMenuItem.Text = "選択肢";
            // 
            // 右に行くToolStripMenuItem
            // 
            this.右に行くToolStripMenuItem.Name = "右に行くToolStripMenuItem";
            this.右に行くToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.右に行くToolStripMenuItem.Text = "右に行く";
            this.右に行くToolStripMenuItem.Click += new System.EventHandler(this.右に行くToolStripMenuItem_Click);
            // 
            // 左に行くToolStripMenuItem
            // 
            this.左に行くToolStripMenuItem.Name = "左に行くToolStripMenuItem";
            this.左に行くToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.左に行くToolStripMenuItem.Text = "左に行く";
            this.左に行くToolStripMenuItem.Click += new System.EventHandler(this.左に行くToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選択肢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右に行くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左に行くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;

    }
}

