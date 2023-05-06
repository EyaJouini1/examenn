namespace Interface
{
    partial class Nouveau_Moto
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AjouterM = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Annee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAnnee = new System.Windows.Forms.TextBox();
            this.textImm = new System.Windows.Forms.TextBox();
            this.textCylindre = new System.Windows.Forms.TextBox();
            this.textVitesse = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.AjouterM);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 340);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 106);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // AjouterM
            // 
            this.AjouterM.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AjouterM.Location = new System.Drawing.Point(688, 4);
            this.AjouterM.Margin = new System.Windows.Forms.Padding(4);
            this.AjouterM.Name = "AjouterM";
            this.AjouterM.Size = new System.Drawing.Size(100, 28);
            this.AjouterM.TabIndex = 0;
            this.AjouterM.Text = "Ajouter";
            this.AjouterM.UseVisualStyleBackColor = true;
            this.AjouterM.Click += new System.EventHandler(this.AjouterM_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.85915F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.14085F));
            this.tableLayoutPanel1.Controls.Add(this.Annee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textAnnee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textImm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textCylindre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textVitesse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Annee
            // 
            this.Annee.AutoSize = true;
            this.Annee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annee.Location = new System.Drawing.Point(4, 0);
            this.Annee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Annee.Name = "Annee";
            this.Annee.Size = new System.Drawing.Size(270, 84);
            this.Annee.TabIndex = 0;
            this.Annee.Text = "Annee: ";
            this.Annee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "Immatriculation: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 84);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cylindre: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 84);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vitesse Max: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textAnnee
            // 
            this.textAnnee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAnnee.Location = new System.Drawing.Point(282, 4);
            this.textAnnee.Margin = new System.Windows.Forms.Padding(4);
            this.textAnnee.Name = "textAnnee";
            this.textAnnee.Size = new System.Drawing.Size(514, 22);
            this.textAnnee.TabIndex = 5;
            // 
            // textImm
            // 
            this.textImm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textImm.Location = new System.Drawing.Point(282, 88);
            this.textImm.Margin = new System.Windows.Forms.Padding(4);
            this.textImm.Name = "textImm";
            this.textImm.Size = new System.Drawing.Size(514, 22);
            this.textImm.TabIndex = 6;
            // 
            // textCylindre
            // 
            this.textCylindre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCylindre.Location = new System.Drawing.Point(282, 172);
            this.textCylindre.Margin = new System.Windows.Forms.Padding(4);
            this.textCylindre.Name = "textCylindre";
            this.textCylindre.Size = new System.Drawing.Size(514, 22);
            this.textCylindre.TabIndex = 7;
            // 
            // textVitesse
            // 
            this.textVitesse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textVitesse.Location = new System.Drawing.Point(282, 256);
            this.textVitesse.Margin = new System.Windows.Forms.Padding(4);
            this.textVitesse.Name = "textVitesse";
            this.textVitesse.Size = new System.Drawing.Size(514, 22);
            this.textVitesse.TabIndex = 8;
            // 
            // Nouveau_Moto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Nouveau_Moto";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Annee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAnnee;
        private System.Windows.Forms.TextBox textImm;
        private System.Windows.Forms.TextBox textCylindre;
        private System.Windows.Forms.TextBox textVitesse;
        private System.Windows.Forms.Button AjouterM;
    }
}