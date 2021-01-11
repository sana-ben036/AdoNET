
namespace Gestion
{
    partial class Form1
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
            this.listbox = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listInput = new System.Windows.Forms.GroupBox();
            this.inputV = new System.Windows.Forms.TextBox();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputN = new System.Windows.Forms.TextBox();
            this.inputP = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.listClient = new System.Windows.Forms.GroupBox();
            this.listNom = new System.Windows.Forms.ComboBox();
            this.client = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.Label();
            this.listbox.SuspendLayout();
            this.listInput.SuspendLayout();
            this.listClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listbox.Controls.Add(this.save);
            this.listbox.Controls.Add(this.update);
            this.listbox.Controls.Add(this.delete);
            this.listbox.Controls.Add(this.add);
            this.listbox.Location = new System.Drawing.Point(645, 47);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(305, 223);
            this.listbox.TabIndex = 44;
            this.listbox.TabStop = false;
            this.listbox.Text = "Operation";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(164, 37);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(118, 39);
            this.save.TabIndex = 7;
            this.save.Text = "Enregister";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(31, 82);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 39);
            this.update.TabIndex = 5;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(31, 127);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 39);
            this.delete.TabIndex = 4;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(31, 37);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 39);
            this.add.TabIndex = 0;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listInput
            // 
            this.listInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listInput.Controls.Add(this.nom);
            this.listInput.Controls.Add(this.inputV);
            this.listInput.Controls.Add(this.inputA);
            this.listInput.Controls.Add(this.inputN);
            this.listInput.Controls.Add(this.inputP);
            this.listInput.Controls.Add(this.ville);
            this.listInput.Controls.Add(this.adress);
            this.listInput.Controls.Add(this.prenom);
            this.listInput.Location = new System.Drawing.Point(68, 47);
            this.listInput.Name = "listInput";
            this.listInput.Size = new System.Drawing.Size(476, 332);
            this.listInput.TabIndex = 53;
            this.listInput.TabStop = false;
            this.listInput.Text = "Client Info";
            this.listInput.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // inputV
            // 
            this.inputV.Location = new System.Drawing.Point(186, 221);
            this.inputV.Name = "inputV";
            this.inputV.Size = new System.Drawing.Size(215, 22);
            this.inputV.TabIndex = 3;
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(186, 165);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(215, 22);
            this.inputA.TabIndex = 2;
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(186, 104);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(215, 22);
            this.inputN.TabIndex = 1;
            // 
            // inputP
            // 
            this.inputP.Location = new System.Drawing.Point(186, 45);
            this.inputP.Name = "inputP";
            this.inputP.Size = new System.Drawing.Size(215, 22);
            this.inputP.TabIndex = 0;
            // 
            // ville
            // 
            this.ville.AutoSize = true;
            this.ville.Location = new System.Drawing.Point(92, 221);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(42, 17);
            this.ville.TabIndex = 56;
            this.ville.Text = "Ville :";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(92, 165);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(68, 17);
            this.adress.TabIndex = 55;
            this.adress.Text = "Adresse :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(92, 48);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(69, 17);
            this.prenom.TabIndex = 53;
            this.prenom.Text = "Prenom  :";
            // 
            // listClient
            // 
            this.listClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listClient.Controls.Add(this.listNom);
            this.listClient.Controls.Add(this.client);
            this.listClient.Location = new System.Drawing.Point(68, 412);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(476, 152);
            this.listClient.TabIndex = 54;
            this.listClient.TabStop = false;
            this.listClient.Text = "Client List";
            this.listClient.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // listNom
            // 
            this.listNom.FormattingEnabled = true;
            this.listNom.Location = new System.Drawing.Point(140, 68);
            this.listNom.Name = "listNom";
            this.listNom.Size = new System.Drawing.Size(311, 24);
            this.listNom.TabIndex = 62;
            this.listNom.SelectedIndexChanged += new System.EventHandler(this.listNom_SelectedIndexChanged);
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.ForeColor = System.Drawing.Color.Maroon;
            this.client.Location = new System.Drawing.Point(75, 71);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(59, 17);
            this.client.TabIndex = 61;
            this.client.Text = "Choisir :";
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(622, 370);
            this.list.Name = "list";
            this.list.RowHeadersWidth = 51;
            this.list.RowTemplate.Height = 24;
            this.list.Size = new System.Drawing.Size(811, 150);
            this.list.TabIndex = 55;
            this.list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_CellContentClick);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(93, 109);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(37, 17);
            this.nom.TabIndex = 57;
            this.nom.Text = "Nom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1462, 615);
            this.Controls.Add(this.list);
            this.Controls.Add(this.listClient);
            this.Controls.Add(this.listInput);
            this.Controls.Add(this.listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.listbox.ResumeLayout(false);
            this.listInput.ResumeLayout(false);
            this.listInput.PerformLayout();
            this.listClient.ResumeLayout(false);
            this.listClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listbox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox listInput;
        private System.Windows.Forms.TextBox inputV;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.TextBox inputP;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.GroupBox listClient;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.ComboBox listNom;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Label nom;
    }
}

