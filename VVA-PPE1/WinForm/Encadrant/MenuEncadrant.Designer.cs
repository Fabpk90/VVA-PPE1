namespace VVA_PPE1.WinForm
{
    partial class MenuEncadrant
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
            this.btnListeAnim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListeAnim
            // 
            this.btnListeAnim.Location = new System.Drawing.Point(77, 220);
            this.btnListeAnim.Name = "btnListeAnim";
            this.btnListeAnim.Size = new System.Drawing.Size(173, 23);
            this.btnListeAnim.TabIndex = 0;
            this.btnListeAnim.Text = "Voir la liste des animations";
            this.btnListeAnim.UseVisualStyleBackColor = true;
            this.btnListeAnim.Click += new System.EventHandler(this.btnListeAnim_Click);
            // 
            // MenuEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 562);
            this.Controls.Add(this.btnListeAnim);
            this.Name = "MenuEncadrant";
            this.Text = "MenuEncadrant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuEncadrant_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListeAnim;
    }
}