namespace VVA_PPE1.WinForm
{
    partial class MenuPlanningView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBAct = new System.Windows.Forms.ListBox();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lblDescAct = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.rtRemarque = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelAct = new System.Windows.Forms.Button();
            this.listBInscrit = new System.Windows.Forms.ListBox();
            this.lblInscrit = new System.Windows.Forms.Label();
            this.listBLoisant = new System.Windows.Forms.ListBox();
            this.lblLoisant = new System.Windows.Forms.Label();
            this.numInscription = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelInscip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGestLoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(274, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Planning de ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBAct
            // 
            this.listBAct.FormattingEnabled = true;
            this.listBAct.Location = new System.Drawing.Point(12, 84);
            this.listBAct.Name = "listBAct";
            this.listBAct.Size = new System.Drawing.Size(120, 147);
            this.listBAct.TabIndex = 1;
            this.listBAct.SelectedIndexChanged += new System.EventHandler(this.listBAct_SelectedIndexChanged);
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Location = new System.Drawing.Point(201, 66);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(35, 13);
            this.lblPlaces.TabIndex = 2;
            this.lblPlaces.Text = "label1";
            // 
            // lblDescAct
            // 
            this.lblDescAct.AutoSize = true;
            this.lblDescAct.Location = new System.Drawing.Point(138, 97);
            this.lblDescAct.Name = "lblDescAct";
            this.lblDescAct.Size = new System.Drawing.Size(35, 13);
            this.lblDescAct.TabIndex = 3;
            this.lblDescAct.Text = "label2";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(493, 170);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(75, 34);
            this.btnInscription.TabIndex = 4;
            this.btnInscription.Text = "Insc";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // rtRemarque
            // 
            this.rtRemarque.Location = new System.Drawing.Point(490, 81);
            this.rtRemarque.Name = "rtRemarque";
            this.rtRemarque.Size = new System.Drawing.Size(100, 42);
            this.rtRemarque.TabIndex = 11;
            this.rtRemarque.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Remarques inscription";
            // 
            // btnCancelAct
            // 
            this.btnCancelAct.Location = new System.Drawing.Point(138, 200);
            this.btnCancelAct.Name = "btnCancelAct";
            this.btnCancelAct.Size = new System.Drawing.Size(115, 23);
            this.btnCancelAct.TabIndex = 14;
            this.btnCancelAct.Text = "Annuler l\'activité";
            this.btnCancelAct.UseVisualStyleBackColor = true;
            this.btnCancelAct.Click += new System.EventHandler(this.btnCancelAct_Click);
            // 
            // listBInscrit
            // 
            this.listBInscrit.FormattingEnabled = true;
            this.listBInscrit.Location = new System.Drawing.Point(276, 121);
            this.listBInscrit.Name = "listBInscrit";
            this.listBInscrit.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBInscrit.Size = new System.Drawing.Size(120, 95);
            this.listBInscrit.TabIndex = 15;
            // 
            // lblInscrit
            // 
            this.lblInscrit.AutoSize = true;
            this.lblInscrit.Location = new System.Drawing.Point(276, 97);
            this.lblInscrit.Name = "lblInscrit";
            this.lblInscrit.Size = new System.Drawing.Size(84, 13);
            this.lblInscrit.TabIndex = 16;
            this.lblInscrit.Text = "Liste des inscrits";
            // 
            // listBLoisant
            // 
            this.listBLoisant.FormattingEnabled = true;
            this.listBLoisant.Location = new System.Drawing.Point(637, 84);
            this.listBLoisant.Name = "listBLoisant";
            this.listBLoisant.Size = new System.Drawing.Size(120, 95);
            this.listBLoisant.TabIndex = 17;
            // 
            // lblLoisant
            // 
            this.lblLoisant.AutoSize = true;
            this.lblLoisant.Location = new System.Drawing.Point(637, 66);
            this.lblLoisant.Name = "lblLoisant";
            this.lblLoisant.Size = new System.Drawing.Size(46, 13);
            this.lblLoisant.TabIndex = 18;
            this.lblLoisant.Text = "Loisants";
            // 
            // numInscription
            // 
            this.numInscription.Location = new System.Drawing.Point(723, 218);
            this.numInscription.Name = "numInscription";
            this.numInscription.Size = new System.Drawing.Size(38, 20);
            this.numInscription.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Numero inscription";
            // 
            // btnCancelInscip
            // 
            this.btnCancelInscip.Location = new System.Drawing.Point(615, 218);
            this.btnCancelInscip.Name = "btnCancelInscip";
            this.btnCancelInscip.Size = new System.Drawing.Size(102, 23);
            this.btnCancelInscip.TabIndex = 21;
            this.btnCancelInscip.Text = "Annuler iscription";
            this.btnCancelInscip.UseVisualStyleBackColor = true;
            this.btnCancelInscip.Click += new System.EventHandler(this.btnCancelInscip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Liste des activités";
            // 
            // lblGestLoi
            // 
            this.lblGestLoi.AutoSize = true;
            this.lblGestLoi.Location = new System.Drawing.Point(565, 49);
            this.lblGestLoi.Name = "lblGestLoi";
            this.lblGestLoi.Size = new System.Drawing.Size(101, 13);
            this.lblGestLoi.TabIndex = 23;
            this.lblGestLoi.Text = "Gestion des loisants";
            // 
            // MenuPlanningView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 308);
            this.Controls.Add(this.lblGestLoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelInscip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numInscription);
            this.Controls.Add(this.lblLoisant);
            this.Controls.Add(this.listBLoisant);
            this.Controls.Add(this.lblInscrit);
            this.Controls.Add(this.listBInscrit);
            this.Controls.Add(this.btnCancelAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtRemarque);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblDescAct);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.listBAct);
            this.Controls.Add(this.lblTitle);
            this.Name = "MenuPlanningView";
            this.ShowIcon = false;
            this.Text = "MenuPlanningView";
            this.Load += new System.EventHandler(this.MenuPlanningView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listBAct;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.Label lblDescAct;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.RichTextBox rtRemarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelAct;
        private System.Windows.Forms.ListBox listBInscrit;
        private System.Windows.Forms.Label lblInscrit;
        private System.Windows.Forms.ListBox listBLoisant;
        private System.Windows.Forms.Label lblLoisant;
        private System.Windows.Forms.NumericUpDown numInscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelInscip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGestLoi;
    }
}