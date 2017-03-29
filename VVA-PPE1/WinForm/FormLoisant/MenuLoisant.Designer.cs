namespace VVA_PPE1.WinForm.FormLoisant
{
    partial class MenuLoisant
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoirActivite = new System.Windows.Forms.Button();
            this.btnVoirAnimation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu principal de gestion";
            // 
            // btnVoirActivite
            // 
            this.btnVoirActivite.Location = new System.Drawing.Point(79, 216);
            this.btnVoirActivite.Name = "btnVoirActivite";
            this.btnVoirActivite.Size = new System.Drawing.Size(179, 23);
            this.btnVoirActivite.TabIndex = 1;
            this.btnVoirActivite.Text = "Voir les activités disponibles";
            this.btnVoirActivite.UseVisualStyleBackColor = true;
            this.btnVoirActivite.Click += new System.EventHandler(this.btnVoirActivite_Click);
            // 
            // btnVoirAnimation
            // 
            this.btnVoirAnimation.Location = new System.Drawing.Point(79, 144);
            this.btnVoirAnimation.Name = "btnVoirAnimation";
            this.btnVoirAnimation.Size = new System.Drawing.Size(179, 23);
            this.btnVoirAnimation.TabIndex = 2;
            this.btnVoirAnimation.Text = "Voir les animations disponibles";
            this.btnVoirAnimation.UseVisualStyleBackColor = true;
            this.btnVoirAnimation.Click += new System.EventHandler(this.btnVoirAnimation_Click);
            // 
            // MenuLoisant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 311);
            this.Controls.Add(this.btnVoirAnimation);
            this.Controls.Add(this.btnVoirActivite);
            this.Controls.Add(this.label1);
            this.Name = "MenuLoisant";
            this.ShowIcon = false;
            this.Text = "MenuLoisant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuLoisant_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoirActivite;
        private System.Windows.Forms.Button btnVoirAnimation;
    }
}