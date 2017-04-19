namespace VVA_PPE1.WinForm.FormEncadrant
{
    partial class MenuPlanningAdd
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
            this.lblAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBEnc = new System.Windows.Forms.ListBox();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.lblReferent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Location = new System.Drawing.Point(140, 80);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(35, 13);
            this.lblAct.TabIndex = 0;
            this.lblAct.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planning";
            // 
            // listBEnc
            // 
            this.listBEnc.FormattingEnabled = true;
            this.listBEnc.Location = new System.Drawing.Point(12, 80);
            this.listBEnc.Name = "listBEnc";
            this.listBEnc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBEnc.Size = new System.Drawing.Size(120, 238);
            this.listBEnc.Sorted = true;
            this.listBEnc.TabIndex = 2;
            // 
            // btnAffecter
            // 
            this.btnAffecter.Location = new System.Drawing.Point(228, 281);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(75, 37);
            this.btnAffecter.TabIndex = 4;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = true;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // lblReferent
            // 
            this.lblReferent.AutoSize = true;
            this.lblReferent.Location = new System.Drawing.Point(137, 213);
            this.lblReferent.Name = "lblReferent";
            this.lblReferent.Size = new System.Drawing.Size(35, 13);
            this.lblReferent.TabIndex = 5;
            this.lblReferent.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encadrant référent";
            // 
            // MenuPlanningAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReferent);
            this.Controls.Add(this.btnAffecter);
            this.Controls.Add(this.listBEnc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAct);
            this.Name = "MenuPlanningAdd";
            this.ShowIcon = false;
            this.Text = "MenuPlanning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPlanning_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBEnc;
        private System.Windows.Forms.Button btnAffecter;
        private System.Windows.Forms.Label lblReferent;
        private System.Windows.Forms.Label label2;
    }
}