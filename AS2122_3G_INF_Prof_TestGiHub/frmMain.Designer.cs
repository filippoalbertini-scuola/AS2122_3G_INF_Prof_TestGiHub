namespace AS2122_3G_INF_Prof_TestGiHub
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperando1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperando2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperatore = new System.Windows.Forms.ComboBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1";
            // 
            // txtOperando1
            // 
            this.txtOperando1.Location = new System.Drawing.Point(188, 55);
            this.txtOperando1.Name = "txtOperando1";
            this.txtOperando1.Size = new System.Drawing.Size(73, 27);
            this.txtOperando1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Operando 2";
            // 
            // txtOperando2
            // 
            this.txtOperando2.Location = new System.Drawing.Point(188, 108);
            this.txtOperando2.Name = "txtOperando2";
            this.txtOperando2.Size = new System.Drawing.Size(73, 27);
            this.txtOperando2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Operatore";
            // 
            // cmbOperatore
            // 
            this.cmbOperatore.FormattingEnabled = true;
            this.cmbOperatore.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbOperatore.Location = new System.Drawing.Point(192, 166);
            this.cmbOperatore.Name = "cmbOperatore";
            this.cmbOperatore.Size = new System.Drawing.Size(77, 28);
            this.cmbOperatore.TabIndex = 2;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(165, 225);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(137, 46);
            this.btnCalcola.TabIndex = 3;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(123, 318);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(74, 20);
            this.lblRisultato.TabIndex = 4;
            this.lblRisultato.Text = "Risultato :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.cmbOperatore);
            this.Controls.Add(this.txtOperando2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOperando1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Prof; Lab 2.3 3G; 09/03/22; Programma di test per l\'uso di GitHub da dentro Visua" +
    "l Studio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtOperando1;
        private Label label2;
        private TextBox txtOperando2;
        private Label label3;
        private ComboBox cmbOperatore;
        private Button btnCalcola;
        private Label lblRisultato;
    }
}