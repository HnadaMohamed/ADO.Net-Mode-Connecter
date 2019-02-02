namespace ADO.NET_Connecter
{
    partial class OUVRAGE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.BTN_UPDATE = new MetroFramework.Controls.MetroButton();
            this.BTN_DELETE = new MetroFramework.Controls.MetroButton();
            this.BTN_CANCEL = new MetroFramework.Controls.MetroButton();
            this.BTN_VALID = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_MAJ = new System.Windows.Forms.Panel();
            this.panel_text = new System.Windows.Forms.Panel();
            this.comboBox_EDITEUR = new System.Windows.Forms.ComboBox();
            this.panel_VA = new System.Windows.Forms.Panel();
            this.panel_AMS = new System.Windows.Forms.Panel();
            this.BTN_ADD = new MetroFramework.Controls.MetroButton();
            this.panel_OUVRAGE = new System.Windows.Forms.Panel();
            this.listBox_OUVRAGE = new System.Windows.Forms.ListBox();
            this.listBox_help = new System.Windows.Forms.ListBox();
            this.comboBox_classification = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_first = new MetroFramework.Controls.MetroButton();
            this.btn_prev = new MetroFramework.Controls.MetroButton();
            this.btn_last = new MetroFramework.Controls.MetroButton();
            this.btn_next = new MetroFramework.Controls.MetroButton();
            this.txt_NUMOUVR = new System.Windows.Forms.TextBox();
            this.txt_NOMOUVR = new System.Windows.Forms.TextBox();
            this.txt_ANNEPARU = new System.Windows.Forms.TextBox();
            this.dataGridView_ECRIVAIN = new System.Windows.Forms.DataGridView();
            this.ADRED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ECRIVAIN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel_MAJ.SuspendLayout();
            this.panel_text.SuspendLayout();
            this.panel_VA.SuspendLayout();
            this.panel_AMS.SuspendLayout();
            this.panel_OUVRAGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ECRIVAIN)).BeginInit();
            this.panel_ECRIVAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(9, 39);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(183, 23);
            this.BTN_UPDATE.TabIndex = 10;
            this.BTN_UPDATE.Text = "Modifier";
            this.BTN_UPDATE.UseSelectable = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(9, 68);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(183, 23);
            this.BTN_DELETE.TabIndex = 11;
            this.BTN_DELETE.Text = "Supprimer";
            this.BTN_DELETE.UseSelectable = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(9, 35);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(183, 23);
            this.BTN_CANCEL.TabIndex = 13;
            this.BTN_CANCEL.Text = "Annuler";
            this.BTN_CANCEL.UseSelectable = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_VALID
            // 
            this.BTN_VALID.Location = new System.Drawing.Point(9, 6);
            this.BTN_VALID.Name = "BTN_VALID";
            this.BTN_VALID.Size = new System.Drawing.Size(183, 23);
            this.BTN_VALID.TabIndex = 12;
            this.BTN_VALID.Text = "Valider";
            this.BTN_VALID.UseSelectable = true;
            this.BTN_VALID.Click += new System.EventHandler(this.BTN_VALID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "N-Ouvrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom Ouvrage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Editeur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Annee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(445, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ecrivains";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mise a Jour";
            // 
            // panel_MAJ
            // 
            this.panel_MAJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_MAJ.Controls.Add(this.panel_text);
            this.panel_MAJ.Controls.Add(this.panel_VA);
            this.panel_MAJ.Controls.Add(this.panel_AMS);
            this.panel_MAJ.Controls.Add(this.label6);
            this.panel_MAJ.Controls.Add(this.label3);
            this.panel_MAJ.Controls.Add(this.label2);
            this.panel_MAJ.Controls.Add(this.label4);
            this.panel_MAJ.Controls.Add(this.label1);
            this.panel_MAJ.Location = new System.Drawing.Point(23, 111);
            this.panel_MAJ.Name = "panel_MAJ";
            this.panel_MAJ.Size = new System.Drawing.Size(387, 537);
            this.panel_MAJ.TabIndex = 22;
            // 
            // panel_text
            // 
            this.panel_text.Controls.Add(this.txt_ANNEPARU);
            this.panel_text.Controls.Add(this.txt_NOMOUVR);
            this.panel_text.Controls.Add(this.txt_NUMOUVR);
            this.panel_text.Controls.Add(this.comboBox_EDITEUR);
            this.panel_text.Location = new System.Drawing.Point(148, 38);
            this.panel_text.Name = "panel_text";
            this.panel_text.Size = new System.Drawing.Size(210, 172);
            this.panel_text.TabIndex = 22;
            // 
            // comboBox_EDITEUR
            // 
            this.comboBox_EDITEUR.FormattingEnabled = true;
            this.comboBox_EDITEUR.Location = new System.Drawing.Point(13, 140);
            this.comboBox_EDITEUR.Name = "comboBox_EDITEUR";
            this.comboBox_EDITEUR.Size = new System.Drawing.Size(183, 21);
            this.comboBox_EDITEUR.TabIndex = 28;
            // 
            // panel_VA
            // 
            this.panel_VA.Controls.Add(this.BTN_CANCEL);
            this.panel_VA.Controls.Add(this.BTN_VALID);
            this.panel_VA.Location = new System.Drawing.Point(88, 353);
            this.panel_VA.Name = "panel_VA";
            this.panel_VA.Size = new System.Drawing.Size(208, 69);
            this.panel_VA.TabIndex = 21;
            // 
            // panel_AMS
            // 
            this.panel_AMS.Controls.Add(this.BTN_ADD);
            this.panel_AMS.Controls.Add(this.BTN_DELETE);
            this.panel_AMS.Controls.Add(this.BTN_UPDATE);
            this.panel_AMS.Location = new System.Drawing.Point(88, 243);
            this.panel_AMS.Name = "panel_AMS";
            this.panel_AMS.Size = new System.Drawing.Size(208, 98);
            this.panel_AMS.TabIndex = 20;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(9, 10);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(183, 23);
            this.BTN_ADD.TabIndex = 12;
            this.BTN_ADD.Text = "Ajouter";
            this.BTN_ADD.UseSelectable = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // panel_OUVRAGE
            // 
            this.panel_OUVRAGE.Controls.Add(this.btn_last);
            this.panel_OUVRAGE.Controls.Add(this.btn_next);
            this.panel_OUVRAGE.Controls.Add(this.btn_prev);
            this.panel_OUVRAGE.Controls.Add(this.btn_first);
            this.panel_OUVRAGE.Controls.Add(this.listBox_OUVRAGE);
            this.panel_OUVRAGE.Controls.Add(this.listBox_help);
            this.panel_OUVRAGE.Location = new System.Drawing.Point(437, 63);
            this.panel_OUVRAGE.Name = "panel_OUVRAGE";
            this.panel_OUVRAGE.Size = new System.Drawing.Size(372, 357);
            this.panel_OUVRAGE.TabIndex = 24;
            // 
            // listBox_OUVRAGE
            // 
            this.listBox_OUVRAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listBox_OUVRAGE.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_OUVRAGE.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox_OUVRAGE.FormattingEnabled = true;
            this.listBox_OUVRAGE.ItemHeight = 17;
            this.listBox_OUVRAGE.Location = new System.Drawing.Point(13, 17);
            this.listBox_OUVRAGE.Name = "listBox_OUVRAGE";
            this.listBox_OUVRAGE.Size = new System.Drawing.Size(340, 276);
            this.listBox_OUVRAGE.TabIndex = 0;
            this.listBox_OUVRAGE.SelectedIndexChanged += new System.EventHandler(this.listBox_OUVRAGE_SelectedIndexChanged);
            // 
            // listBox_help
            // 
            this.listBox_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.listBox_help.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox_help.FormattingEnabled = true;
            this.listBox_help.Location = new System.Drawing.Point(317, 17);
            this.listBox_help.Name = "listBox_help";
            this.listBox_help.Size = new System.Drawing.Size(36, 264);
            this.listBox_help.TabIndex = 1;
            // 
            // comboBox_classification
            // 
            this.comboBox_classification.FormattingEnabled = true;
            this.comboBox_classification.Location = new System.Drawing.Point(158, 80);
            this.comboBox_classification.Name = "comboBox_classification";
            this.comboBox_classification.Size = new System.Drawing.Size(252, 21);
            this.comboBox_classification.TabIndex = 25;
            this.comboBox_classification.SelectedIndexChanged += new System.EventHandler(this.comboBox_classification_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(23, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Classifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(445, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ouvrages";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(13, 316);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(74, 23);
            this.btn_first.TabIndex = 13;
            this.btn_first.Text = "<<";
            this.btn_first.UseSelectable = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(93, 316);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(74, 23);
            this.btn_prev.TabIndex = 14;
            this.btn_prev.Text = "<";
            this.btn_prev.UseSelectable = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(279, 316);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(74, 23);
            this.btn_last.TabIndex = 16;
            this.btn_last.Text = ">>";
            this.btn_last.UseSelectable = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(198, 316);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(74, 23);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = ">";
            this.btn_next.UseSelectable = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_NUMOUVR
            // 
            this.txt_NUMOUVR.Location = new System.Drawing.Point(13, 11);
            this.txt_NUMOUVR.Name = "txt_NUMOUVR";
            this.txt_NUMOUVR.Size = new System.Drawing.Size(183, 20);
            this.txt_NUMOUVR.TabIndex = 23;
            // 
            // txt_NOMOUVR
            // 
            this.txt_NOMOUVR.Location = new System.Drawing.Point(13, 52);
            this.txt_NOMOUVR.Name = "txt_NOMOUVR";
            this.txt_NOMOUVR.Size = new System.Drawing.Size(183, 20);
            this.txt_NOMOUVR.TabIndex = 29;
            // 
            // txt_ANNEPARU
            // 
            this.txt_ANNEPARU.Location = new System.Drawing.Point(13, 97);
            this.txt_ANNEPARU.Name = "txt_ANNEPARU";
            this.txt_ANNEPARU.Size = new System.Drawing.Size(183, 20);
            this.txt_ANNEPARU.TabIndex = 30;
            // 
            // dataGridView_ECRIVAIN
            // 
            this.dataGridView_ECRIVAIN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_ECRIVAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ECRIVAIN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMED,
            this.ADRED});
            this.dataGridView_ECRIVAIN.Location = new System.Drawing.Point(13, 3);
            this.dataGridView_ECRIVAIN.Name = "dataGridView_ECRIVAIN";
            this.dataGridView_ECRIVAIN.Size = new System.Drawing.Size(340, 177);
            this.dataGridView_ECRIVAIN.TabIndex = 14;
            // 
            // ADRED
            // 
            this.ADRED.HeaderText = "Adress Ecrivain";
            this.ADRED.Name = "ADRED";
            this.ADRED.Width = 110;
            // 
            // NOMED
            // 
            this.NOMED.FillWeight = 110F;
            this.NOMED.HeaderText = "Nom Ecrivain";
            this.NOMED.Name = "NOMED";
            // 
            // panel_ECRIVAIN
            // 
            this.panel_ECRIVAIN.Controls.Add(this.dataGridView_ECRIVAIN);
            this.panel_ECRIVAIN.Location = new System.Drawing.Point(437, 465);
            this.panel_ECRIVAIN.Name = "panel_ECRIVAIN";
            this.panel_ECRIVAIN.Size = new System.Drawing.Size(372, 186);
            this.panel_ECRIVAIN.TabIndex = 23;
            // 
            // OUVRAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 667);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_classification);
            this.Controls.Add(this.panel_OUVRAGE);
            this.Controls.Add(this.panel_ECRIVAIN);
            this.Controls.Add(this.panel_MAJ);
            this.Controls.Add(this.label5);
            this.Name = "OUVRAGE";
            this.Text = "Gestion Des Ouvrages";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OUVRAGE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panel_MAJ.ResumeLayout(false);
            this.panel_MAJ.PerformLayout();
            this.panel_text.ResumeLayout(false);
            this.panel_text.PerformLayout();
            this.panel_VA.ResumeLayout(false);
            this.panel_AMS.ResumeLayout(false);
            this.panel_OUVRAGE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ECRIVAIN)).EndInit();
            this.panel_ECRIVAIN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton BTN_UPDATE;
        private MetroFramework.Controls.MetroButton BTN_DELETE;
        private MetroFramework.Controls.MetroButton BTN_CANCEL;
        private MetroFramework.Controls.MetroButton BTN_VALID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_MAJ;
        private System.Windows.Forms.Panel panel_VA;
        private System.Windows.Forms.Panel panel_AMS;
        private System.Windows.Forms.Panel panel_OUVRAGE;
        private System.Windows.Forms.ComboBox comboBox_classification;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.ListBox listBox_OUVRAGE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_EDITEUR;
        private MetroFramework.Controls.MetroButton BTN_ADD;
        private System.Windows.Forms.ListBox listBox_help;
        private MetroFramework.Controls.MetroButton btn_last;
        private MetroFramework.Controls.MetroButton btn_next;
        private MetroFramework.Controls.MetroButton btn_prev;
        private MetroFramework.Controls.MetroButton btn_first;
        private System.Windows.Forms.TextBox txt_ANNEPARU;
        private System.Windows.Forms.TextBox txt_NOMOUVR;
        private System.Windows.Forms.TextBox txt_NUMOUVR;
        private System.Windows.Forms.DataGridView dataGridView_ECRIVAIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRED;
        private System.Windows.Forms.Panel panel_ECRIVAIN;
    }
}

