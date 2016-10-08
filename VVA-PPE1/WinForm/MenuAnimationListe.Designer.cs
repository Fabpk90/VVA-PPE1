namespace VVA_PPE1.WinForm
{
    partial class MenuAnimationListe
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
            this.listBAnim = new System.Windows.Forms.ListBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblNbPlace = new System.Windows.Forms.Label();
            this.lblLimitAge = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblDtCrea = new System.Windows.Forms.Label();
            this.lblDtVal = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblNomType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBAnim
            // 
            this.listBAnim.FormattingEnabled = true;
            this.listBAnim.Location = new System.Drawing.Point(12, 189);
            this.listBAnim.Name = "listBAnim";
            this.listBAnim.Size = new System.Drawing.Size(245, 329);
            this.listBAnim.Sorted = true;
            this.listBAnim.TabIndex = 0;
            this.listBAnim.SelectedIndexChanged += new System.EventHandler(this.listBAnim_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(122, 39);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(312, 24);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Liste des animations disponibles";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNbPlace
            // 
            this.lblNbPlace.AutoSize = true;
            this.lblNbPlace.Location = new System.Drawing.Point(388, 345);
            this.lblNbPlace.Name = "lblNbPlace";
            this.lblNbPlace.Size = new System.Drawing.Size(96, 13);
            this.lblNbPlace.TabIndex = 2;
            this.lblNbPlace.Text = "Nom de l\'animation";
            // 
            // lblLimitAge
            // 
            this.lblLimitAge.AutoSize = true;
            this.lblLimitAge.Location = new System.Drawing.Point(385, 319);
            this.lblLimitAge.Name = "lblLimitAge";
            this.lblLimitAge.Size = new System.Drawing.Size(103, 13);
            this.lblLimitAge.TabIndex = 3;
            this.lblLimitAge.Text = "Durée de l\'animation";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(388, 293);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "label4";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(388, 374);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(35, 13);
            this.lblTarif.TabIndex = 5;
            this.lblTarif.Text = "label5";
            // 
            // lblDtCrea
            // 
            this.lblDtCrea.AutoSize = true;
            this.lblDtCrea.Location = new System.Drawing.Point(388, 254);
            this.lblDtCrea.Name = "lblDtCrea";
            this.lblDtCrea.Size = new System.Drawing.Size(35, 13);
            this.lblDtCrea.TabIndex = 6;
            this.lblDtCrea.Text = "label6";
            // 
            // lblDtVal
            // 
            this.lblDtVal.AutoSize = true;
            this.lblDtVal.Location = new System.Drawing.Point(388, 219);
            this.lblDtVal.Name = "lblDtVal";
            this.lblDtVal.Size = new System.Drawing.Size(35, 13);
            this.lblDtVal.TabIndex = 7;
            this.lblDtVal.Text = "label7";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(388, 149);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(19, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "no";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(388, 193);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(0, 13);
            this.lblDuree.TabIndex = 9;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(498, 489);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 10;
            this.btnAddMenu.Text = "Ajouter ";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(418, 489);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblNomType
            // 
            this.lblNomType.AutoSize = true;
            this.lblNomType.Location = new System.Drawing.Point(493, 149);
            this.lblNomType.Name = "lblNomType";
            this.lblNomType.Size = new System.Drawing.Size(35, 13);
            this.lblNomType.TabIndex = 12;
            this.lblNomType.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Commentaire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre de places";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Limite d\'âge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tarif";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Date de création";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Date de Validité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nom ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Durée";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(388, 420);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(35, 13);
            this.lblCom.TabIndex = 24;
            this.lblCom.Text = "label4";
            // 
            // MenuAnimationListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 524);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNomType);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblDtVal);
            this.Controls.Add(this.lblDtCrea);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblLimitAge);
            this.Controls.Add(this.lblNbPlace);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.listBAnim);
            this.Name = "MenuAnimationListe";
            this.Text = "MenuAnimationListe";
            this.Load += new System.EventHandler(this.MenuAnimationListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBAnim;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblNbPlace;
        private System.Windows.Forms.Label lblLimitAge;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblDtCrea;
        private System.Windows.Forms.Label lblDtVal;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblNomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCom;
    }
}