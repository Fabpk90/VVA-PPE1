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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAddAct = new System.Windows.Forms.Button();
            this.btnAddAnim = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitreMenuAct = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitreMenuAnim = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListeAnim
            // 
            this.btnListeAnim.Location = new System.Drawing.Point(3, 23);
            this.btnListeAnim.Name = "btnListeAnim";
            this.btnListeAnim.Size = new System.Drawing.Size(173, 23);
            this.btnListeAnim.TabIndex = 0;
            this.btnListeAnim.Text = "Voir la liste des animations";
            this.btnListeAnim.UseVisualStyleBackColor = true;
            this.btnListeAnim.Click += new System.EventHandler(this.btnListeAnim_Click);
            // 
            // btnListeActivite
            // 
            this.btnListeActivite.Location = new System.Drawing.Point(3, 23);
            this.btnListeActivite.Name = "btnListeActivite";
            this.btnListeActivite.Size = new System.Drawing.Size(173, 23);
            this.btnListeActivite.TabIndex = 2;
            this.btnListeActivite.Text = "Voir la liste des activités";
            this.btnListeActivite.UseVisualStyleBackColor = true;
            this.btnListeActivite.Click += new System.EventHandler(this.btnListeActivite_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(207, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(164, 24);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Menu Encadrant";
            // 
            // btnAddAct
            // 
            this.btnAddAct.Location = new System.Drawing.Point(3, 52);
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.Size = new System.Drawing.Size(173, 23);
            this.btnAddAct.TabIndex = 3;
            this.btnAddAct.Text = "Ajouter une Activité";
            this.btnAddAct.UseVisualStyleBackColor = true;
            this.btnAddAct.Click += new System.EventHandler(this.btnAddAct_Click);
            // 
            // btnAddAnim
            // 
            this.btnAddAnim.Location = new System.Drawing.Point(3, 52);
            this.btnAddAnim.Name = "btnAddAnim";
            this.btnAddAnim.Size = new System.Drawing.Size(173, 23);
            this.btnAddAnim.TabIndex = 1;
            this.btnAddAnim.Text = "Ajouter une Animation";
            this.btnAddAnim.UseVisualStyleBackColor = true;
            this.btnAddAnim.Click += new System.EventHandler(this.btnAddAnim_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTitreMenuAct);
            this.flowLayoutPanel1.Controls.Add(this.btnListeActivite);
            this.flowLayoutPanel1.Controls.Add(this.btnAddAct);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblTitreMenuAct
            // 
            this.lblTitreMenuAct.AutoSize = true;
            this.lblTitreMenuAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreMenuAct.Location = new System.Drawing.Point(3, 0);
            this.lblTitreMenuAct.Name = "lblTitreMenuAct";
            this.lblTitreMenuAct.Size = new System.Drawing.Size(156, 20);
            this.lblTitreMenuAct.TabIndex = 4;
            this.lblTitreMenuAct.Text = "Gestion des activités";
            this.lblTitreMenuAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblTitreMenuAnim);
            this.flowLayoutPanel2.Controls.Add(this.btnListeAnim);
            this.flowLayoutPanel2.Controls.Add(this.btnAddAnim);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(337, 57);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // lblTitreMenuAnim
            // 
            this.lblTitreMenuAnim.AutoSize = true;
            this.lblTitreMenuAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreMenuAnim.Location = new System.Drawing.Point(3, 0);
            this.lblTitreMenuAnim.Name = "lblTitreMenuAnim";
            this.lblTitreMenuAnim.Size = new System.Drawing.Size(176, 20);
            this.lblTitreMenuAnim.TabIndex = 6;
            this.lblTitreMenuAnim.Text = "Gestion des animations";
            this.lblTitreMenuAnim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(12, 184);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(76, 23);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // MenuEncadrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 219);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuEncadrant";
            this.ShowIcon = false;
            this.Text = "Menu Encadrant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuEncadrant_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListeAnim;
        private System.Windows.Forms.Button btnListeActivite;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAddAct;
        private System.Windows.Forms.Button btnAddAnim;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitreMenuAct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblTitreMenuAnim;
        private System.Windows.Forms.Button btnRetour;
    }
}