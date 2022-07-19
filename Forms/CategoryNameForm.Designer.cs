namespace BannerEdge.Forms
{
    partial class CategoryNameForm
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
            this._categoryNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _categoryNameTxt
            // 
            this._categoryNameTxt.Location = new System.Drawing.Point(15, 38);
            this._categoryNameTxt.Name = "_categoryNameTxt";
            this._categoryNameTxt.Size = new System.Drawing.Size(298, 20);
            this._categoryNameTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Custom Sprite Category Name:";
            // 
            // _okBtn
            // 
            this._okBtn.Location = new System.Drawing.Point(238, 75);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(75, 23);
            this._okBtn.TabIndex = 2;
            this._okBtn.Text = "OK";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this._okBtn_Click);
            // 
            // CategoryNameForm
            // 
            this.AcceptButton = this._okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 110);
            this.Controls.Add(this._okBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._categoryNameTxt);
            this.Name = "CategoryNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BannerEdge";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CategoryNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _categoryNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _okBtn;
    }
}