
namespace Gestion
{
    partial class Form2
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
            this.listClient = new System.Windows.Forms.DataGridView();
            this.listVille = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "La list des Clients";
            // 
            // listClient
            // 
            this.listClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listClient.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listClient.Location = new System.Drawing.Point(26, 82);
            this.listClient.Name = "listClient";
            this.listClient.RowHeadersWidth = 51;
            this.listClient.RowTemplate.Height = 24;
            this.listClient.Size = new System.Drawing.Size(915, 383);
            this.listClient.TabIndex = 2;
            this.listClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listClient_CellContentClick);
            // 
            // listVille
            // 
            this.listVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listVille.FormattingEnabled = true;
            this.listVille.Location = new System.Drawing.Point(474, 39);
            this.listVille.Name = "listVille";
            this.listVille.Size = new System.Drawing.Size(226, 24);
            this.listVille.TabIndex = 3;
            this.listVille.SelectedIndexChanged += new System.EventHandler(this.listVille_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selectioner la Ville";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listVille);
            this.Controls.Add(this.listClient);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listClient;
        private System.Windows.Forms.ComboBox listVille;
        private System.Windows.Forms.Label label2;
    }
}