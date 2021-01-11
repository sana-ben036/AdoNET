
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.listClient = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.client = new System.Windows.Forms.Label();
            this.listbox.SuspendLayout();
            this.listInput.SuspendLayout();
            this.listClient.SuspendLayout();
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
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(31, 82);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 39);
            this.update.TabIndex = 5;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(31, 127);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 39);
            this.delete.TabIndex = 4;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(31, 37);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 39);
            this.add.TabIndex = 0;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            // 
            // listInput
            // 
            this.listInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listInput.Controls.Add(this.textBox4);
            this.listInput.Controls.Add(this.textBox3);
            this.listInput.Controls.Add(this.textBox2);
            this.listInput.Controls.Add(this.textBox1);
            this.listInput.Controls.Add(this.ville);
            this.listInput.Controls.Add(this.adress);
            this.listInput.Controls.Add(this.nom);
            this.listInput.Controls.Add(this.prenom);
            this.listInput.Location = new System.Drawing.Point(68, 47);
            this.listInput.Name = "listInput";
            this.listInput.Size = new System.Drawing.Size(476, 332);
            this.listInput.TabIndex = 53;
            this.listInput.TabStop = false;
            this.listInput.Text = "Client Info";
            this.listInput.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 221);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 22);
            this.textBox4.TabIndex = 60;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 22);
            this.textBox3.TabIndex = 59;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 57;
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
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(92, 107);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(49, 17);
            this.nom.TabIndex = 54;
            this.nom.Text = "Nom  :";
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
            this.listClient.Controls.Add(this.client);
            this.listClient.Controls.Add(this.comboBox1);
            this.listClient.Location = new System.Drawing.Point(68, 412);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(476, 152);
            this.listClient.TabIndex = 54;
            this.listClient.TabStop = false;
            this.listClient.Text = "Client List";
            this.listClient.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 24);
            this.comboBox1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 615);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox listbox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox listInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.GroupBox listClient;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

