namespace Interface
{
    partial class Nouvelle_Voiture
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
            this.textMarq = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Annee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAnnee = new System.Windows.Forms.TextBox();
            this.textImm = new System.Windows.Forms.TextBox();
            this.textCoul = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AjouterV = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMarq
            // 
            this.textMarq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMarq.Location = new System.Drawing.Point(282, 217);
            this.textMarq.Margin = new System.Windows.Forms.Padding(4);
            this.textMarq.Name = "textMarq";
            this.textMarq.Size = new System.Drawing.Size(514, 22);
            this.textMarq.TabIndex = 8;
            this.textMarq.TextChanged += new System.EventHandler(this.textMarq_TextChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textAnnee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textImm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textCoul, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textMarq, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Annee
            // 
            this.Annee.AutoSize = true;
            this.Annee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annee.Location = new System.Drawing.Point(4, 0);
            this.Annee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Annee.Name = "Annee";
            this.Annee.Size = new System.Drawing.Size(270, 71);
            this.Annee.TabIndex = 0;
            this.Annee.Text = "Annee: ";
            this.Annee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 71);
            this.label2.TabIndex = 1;
            this.label2.Text = "Immatriculation: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 71);
            this.label3.TabIndex = 2;
            this.label3.Text = "Couleur: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 71);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marque: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 71);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.textImm.Location = new System.Drawing.Point(282, 75);
            this.textImm.Margin = new System.Windows.Forms.Padding(4);
            this.textImm.Name = "textImm";
            this.textImm.Size = new System.Drawing.Size(514, 22);
            this.textImm.TabIndex = 6;
            // 
            // textCoul
            // 
            this.textCoul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCoul.Location = new System.Drawing.Point(282, 146);
            this.textCoul.Margin = new System.Windows.Forms.Padding(4);
            this.textCoul.Name = "textCoul";
            this.textCoul.Size = new System.Drawing.Size(514, 22);
            this.textCoul.TabIndex = 7;
            // 
            // textType
            // 
            this.textType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textType.Location = new System.Drawing.Point(282, 288);
            this.textType.Margin = new System.Windows.Forms.Padding(4);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(514, 22);
            this.textType.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.AjouterV);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 359);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 87);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // AjouterV
            // 
            this.AjouterV.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AjouterV.Location = new System.Drawing.Point(688, 4);
            this.AjouterV.Margin = new System.Windows.Forms.Padding(4);
            this.AjouterV.Name = "AjouterV";
            this.AjouterV.Size = new System.Drawing.Size(100, 28);
            this.AjouterV.TabIndex = 0;
            this.AjouterV.Text = "Ajouter";
            this.AjouterV.UseVisualStyleBackColor = true;
            this.AjouterV.Click += new System.EventHandler(this.AjouterV_Click);
            // 
            // Nouvelle_Voiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Nouvelle_Voiture";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textMarq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Annee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAnnee;
        private System.Windows.Forms.TextBox textImm;
        private System.Windows.Forms.TextBox textCoul;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AjouterV;
    }
}