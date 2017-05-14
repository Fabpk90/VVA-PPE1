namespace VVA_PPE1.WinForm
{
    partial class MenuActiviteListe
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
            this.listBAct = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDescEnc = new System.Windows.Forms.Label();
            this.btnPlanAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBAct
            // 
            this.listBAct.FormattingEnabled = true;
            this.listBAct.Location = new System.Drawing.Point(12, 86);
            this.listBAct.Name = "listBAct";
            this.listBAct.Size = new System.Drawing.Size(248, 342);
            this.listBAct.TabIndex = 0;
            this.listBAct.SelectedIndexChanged += new System.EventHandler(this.listBAct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Activités";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(368, 391);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(272, 171);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "label2";
            // 
            // lblDescEnc
            // 
            this.lblDescEnc.AutoSize = true;
            this.lblDescEnc.Location = new System.Drawing.Point(272, 86);
            this.lblDescEnc.Name = "lblDescEnc";
            this.lblDescEnc.Size = new System.Drawing.Size(35, 13);
            this.lblDescEnc.TabIndex = 5;
            this.lblDescEnc.Text = "label2";
            // 
            // btnPlanAct
            // 
            this.btnPlanAct.Location = new System.Drawing.Point(267, 391);
            this.btnPlanAct.Name = "btnPlanAct";
            this.btnPlanAct.Size = new System.Drawing.Size(95, 37);
            this.btnPlanAct.TabIndex = 6;
            this.btnPlanAct.Text = "Gérer les activités";
            this.btnPlanAct.UseVisualStyleBackColor = true;
            this.btnPlanAct.Click += new System.EventHandler(this.btnPlanAct_Click);
            // 
            // MenuActiviteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 435);
            this.Controls.Add(this.btnPlanAct);
            this.Controls.Add(this.lblDescEnc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBAct);
            this.Name = "MenuActiviteListe";
            this.ShowIcon = false;
            this.Text = "MenuActiviteListe";
            this.Load += new System.EventHandler(this.MenuActiviteListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDescEnc;
        private System.Windows.Forms.Button btnPlanAct;
    }
}