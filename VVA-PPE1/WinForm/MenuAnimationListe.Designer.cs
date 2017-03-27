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
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
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
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(462, 489);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 10;
            this.btnAddMenu.Text = "Ajouter ";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(381, 489);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(358, 189);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "label3";
            // 
            // btnPlanning
            // 
            this.btnPlanning.Location = new System.Drawing.Point(263, 489);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(112, 23);
            this.btnPlanning.TabIndex = 26;
            this.btnPlanning.Text = "Planning de l\'activité";
            this.btnPlanning.UseVisualStyleBackColor = true;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(381, 460);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(156, 23);
            this.btnAddType.TabIndex = 27;
            this.btnAddType.Text = "Ajouter un Type d\'animation";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // MenuAnimationListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 524);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnPlanning);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddMenu);
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
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnAddType;
    }
}