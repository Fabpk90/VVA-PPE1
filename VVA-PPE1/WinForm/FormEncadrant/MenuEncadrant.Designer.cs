namespace VVA_PPE1.WinForm.FormEncandrant
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
            this.btnListeActivite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAct = new System.Windows.Forms.Button();
            this.btnAddAnim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListeAnim
            // 
            this.btnListeAnim.Location = new System.Drawing.Point(77, 144);
            this.btnListeAnim.Name = "btnListeAnim";
            this.btnListeAnim.Size = new System.Drawing.Size(173, 23);
            this.btnListeAnim.TabIndex = 0;
            this.btnListeAnim.Text = "Voir la liste des animations";
            this.btnListeAnim.UseVisualStyleBackColor = true;
            this.btnListeAnim.Click += new System.EventHandler(this.btnListeAnim_Click);
            // 
            // btnListeActivite
            // 
            this.btnListeActivite.Location = new System.Drawing.Point(77, 234);
            this.btnListeActivite.Name = "btnListeActivite";
            this.btnListeActivite.Size = new System.Drawing.Size(173, 23);
            this.btnListeActivite.TabIndex = 2;
            this.btnListeActivite.Text = "Voir la liste des activités";
            this.btnListeActivite.UseVisualStyleBackColor = true;
            this.btnListeActivite.Click += new System.EventHandler(this.btnListeActivite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Encadrant";
            // 
            // btnAddAct
            // 
            this.btnAddAct.Location = new System.Drawing.Point(77, 263);
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.Size = new System.Drawing.Size(173, 23);
            this.btnAddAct.TabIndex = 3;
            this.btnAddAct.Text = "Ajouter une Activité";
            this.btnAddAct.UseVisualStyleBackColor = true;
            this.btnAddAct.Click += new System.EventHandler(this.btnAddAct_Click);
            // 
            // btnAddAnim
            // 
            this.btnAddAnim.Location = new System.Drawing.Point(77, 173);
            this.btnAddAnim.Name = "btnAddAnim";
            this.btnAddAnim.Size = new System.Drawing.Size(173, 23);
            this.btnAddAnim.TabIndex = 1;
            this.btnAddAnim.Text = "Ajouter une Animation";
            this.btnAddAnim.UseVisualStyleBackColor = true;
            this.btnAddAnim.Click += new System.EventHandler(this.btnAddAnim_Click);
            // 
            // MenuEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 325);
            this.Controls.Add(this.btnAddAnim);
            this.Controls.Add(this.btnAddAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListeActivite);
            this.Controls.Add(this.btnListeAnim);
            this.Name = "MenuEncadrant";
            this.ShowIcon = false;
            this.Text = "MenuEncadrant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuEncadrant_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListeAnim;
        private System.Windows.Forms.Button btnListeActivite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAct;
        private System.Windows.Forms.Button btnAddAnim;
    }
}