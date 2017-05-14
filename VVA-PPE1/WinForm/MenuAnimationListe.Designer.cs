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
            this.btnPlanning = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.rtDesc = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblListAnim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBAnim
            // 
            this.listBAnim.FormattingEnabled = true;
            this.listBAnim.Location = new System.Drawing.Point(12, 123);
            this.listBAnim.Name = "listBAnim";
            this.listBAnim.Size = new System.Drawing.Size(245, 121);
            this.listBAnim.Sorted = true;
            this.listBAnim.TabIndex = 0;
            this.listBAnim.SelectedIndexChanged += new System.EventHandler(this.listBAnim_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(113, 26);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(312, 24);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Liste des animations disponibles";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(460, 272);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenu.TabIndex = 10;
            this.btnAddMenu.Text = "Ajouter ";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(379, 272);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnPlanning
            // 
            this.btnPlanning.Location = new System.Drawing.Point(261, 272);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(112, 23);
            this.btnPlanning.TabIndex = 26;
            this.btnPlanning.Text = "Planning de l\'activité";
            this.btnPlanning.UseVisualStyleBackColor = true;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(379, 243);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(156, 23);
            this.btnAddType.TabIndex = 27;
            this.btnAddType.Text = "Ajouter un Type d\'animation";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // rtDesc
            // 
            this.rtDesc.Location = new System.Drawing.Point(263, 123);
            this.rtDesc.Name = "rtDesc";
            this.rtDesc.Size = new System.Drawing.Size(272, 114);
            this.rtDesc.TabIndex = 28;
            this.rtDesc.Text = "";
            this.rtDesc.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(263, 104);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(162, 16);
            this.lblDesc.TabIndex = 29;
            this.lblDesc.Text = "Description de l\'animation";
            // 
            // lblListAnim
            // 
            this.lblListAnim.AutoSize = true;
            this.lblListAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListAnim.Location = new System.Drawing.Point(12, 104);
            this.lblListAnim.Name = "lblListAnim";
            this.lblListAnim.Size = new System.Drawing.Size(130, 16);
            this.lblListAnim.TabIndex = 30;
            this.lblListAnim.Text = "Liste des animations";
            // 
            // MenuAnimationListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 316);
            this.Controls.Add(this.lblListAnim);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.rtDesc);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnPlanning);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.listBAnim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuAnimationListe";
            this.ShowIcon = false;
            this.Text = "Menu liste des animations";
            this.Load += new System.EventHandler(this.MenuAnimationListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBAnim;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.RichTextBox rtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblListAnim;
    }
}