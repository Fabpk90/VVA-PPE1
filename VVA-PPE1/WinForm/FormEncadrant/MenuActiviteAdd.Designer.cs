namespace VVA_PPE1.WinForm.FormEncadrant
{
    partial class MenuActiviteAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtObj = new System.Windows.Forms.RichTextBox();
            this.dtHrFin = new System.Windows.Forms.DateTimePicker();
            this.dtHrDebut = new System.Windows.Forms.DateTimePicker();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.dtRDV = new System.Windows.Forms.DateTimePicker();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.dtAct = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCodeAnim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de l\'activité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heure rdv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Heure debut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Heure fin ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Objectif";
            // 
            // rtObj
            // 
            this.rtObj.Location = new System.Drawing.Point(28, 246);
            this.rtObj.Name = "rtObj";
            this.rtObj.Size = new System.Drawing.Size(368, 117);
            this.rtObj.TabIndex = 9;
            this.rtObj.Text = "";
            // 
            // dtHrFin
            // 
            this.dtHrFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrFin.Location = new System.Drawing.Point(296, 177);
            this.dtHrFin.Name = "dtHrFin";
            this.dtHrFin.ShowUpDown = true;
            this.dtHrFin.Size = new System.Drawing.Size(100, 20);
            this.dtHrFin.TabIndex = 10;
            // 
            // dtHrDebut
            // 
            this.dtHrDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrDebut.Location = new System.Drawing.Point(296, 123);
            this.dtHrDebut.Name = "dtHrDebut";
            this.dtHrDebut.ShowUpDown = true;
            this.dtHrDebut.Size = new System.Drawing.Size(100, 20);
            this.dtHrDebut.TabIndex = 11;
            // 
            // numPrix
            // 
            this.numPrix.DecimalPlaces = 1;
            this.numPrix.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrix.Location = new System.Drawing.Point(296, 54);
            this.numPrix.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(61, 20);
            this.numPrix.TabIndex = 12;
            this.numPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtRDV
            // 
            this.dtRDV.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRDV.Location = new System.Drawing.Point(28, 187);
            this.dtRDV.Name = "dtRDV";
            this.dtRDV.ShowUpDown = true;
            this.dtRDV.Size = new System.Drawing.Size(100, 20);
            this.dtRDV.TabIndex = 13;
            // 
            // cbEtat
            // 
            this.cbEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtat.Location = new System.Drawing.Point(28, 140);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(61, 21);
            this.cbEtat.Sorted = true;
            this.cbEtat.TabIndex = 14;
            // 
            // dtAct
            // 
            this.dtAct.Location = new System.Drawing.Point(28, 84);
            this.dtAct.Name = "dtAct";
            this.dtAct.Size = new System.Drawing.Size(174, 20);
            this.dtAct.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 55);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCodeAnim
            // 
            this.cbCodeAnim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodeAnim.FormattingEnabled = true;
            this.cbCodeAnim.Location = new System.Drawing.Point(28, 30);
            this.cbCodeAnim.Name = "cbCodeAnim";
            this.cbCodeAnim.Size = new System.Drawing.Size(61, 21);
            this.cbCodeAnim.TabIndex = 17;
            // 
            // MenuActiviteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 432);
            this.Controls.Add(this.cbCodeAnim);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtAct);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(this.dtRDV);
            this.Controls.Add(this.numPrix);
            this.Controls.Add(this.dtHrDebut);
            this.Controls.Add(this.dtHrFin);
            this.Controls.Add(this.rtObj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuActiviteAdd";
            this.Text = "MenuActiviteAdd";
            this.Load += new System.EventHandler(this.MenuActiviteAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtObj;
        private System.Windows.Forms.DateTimePicker dtHrFin;
        private System.Windows.Forms.DateTimePicker dtHrDebut;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.DateTimePicker dtRDV;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.DateTimePicker dtAct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCodeAnim;
    }
}