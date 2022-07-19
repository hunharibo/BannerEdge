namespace BannerEdge.Forms
{
    partial class PopupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._progessBar = new System.Windows.Forms.ProgressBar();
            this._progressLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _progessBar
            // 
            this._progessBar.Location = new System.Drawing.Point(38, 45);
            this._progessBar.Name = "_progessBar";
            this._progessBar.Size = new System.Drawing.Size(455, 38);
            this._progessBar.TabIndex = 0;
            // 
            // _progressLbl
            // 
            this._progressLbl.AutoSize = true;
            this._progressLbl.Location = new System.Drawing.Point(38, 101);
            this._progressLbl.Name = "_progressLbl";
            this._progressLbl.Size = new System.Drawing.Size(61, 13);
            this._progressLbl.TabIndex = 1;
            this._progressLbl.Text = "Please wait";
            // 
            // PopupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(543, 149);
            this.Controls.Add(this._progressLbl);
            this.Controls.Add(this._progessBar);
            this.Name = "PopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please wait...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _progessBar;
        private System.Windows.Forms.Label _progressLbl;
    }
}