using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Gestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        bool textBoxFree = false;
        AdoNet Ado;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxFree = true;
            Ado = new AdoNet();
            FillClient();
            Ado.DtClient = Ado.Ds.Tables[0];
            Ado.DtClient.TableName = "Client";
            this.listNom.DataSource = Ado.DtClient;
            this.list.DataSource = Ado.DtClient;
            this.listNom.DisplayMember = Ado.DtClient.Columns[5].ColumnName; // "prenom" pour eviter la situation de changement du name of column
            this.listNom.ValueMember = Ado.DtClient.Columns[0].ColumnName;  //" id"
            this.listNom.SelectedIndex = -1;  // pour eviter l'affichage d'un element par defaut sur la list
            this.list.AllowUserToAddRows = false; // pour eviter l'ajout d'une ligne vide 

           

                




        }
        private bool CheckInput()
        {
            if (this.inputP.Text.Trim().Equals(string.Empty) ||
               this.inputN.Text.Trim().Equals(string.Empty) ||
               this.inputA.Text.Trim().Equals(string.Empty) ||
               this.inputV.Text.Trim().Equals(string.Empty) )
                return false;
            return true;

        }

        private void FillClient()
        {
            string query = string.Empty + "select Id, Prenom, Nom, Adresse, Ville, Prenom +' '+Nom from Client as colToDisplay ;";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Client");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        int id;
        private void listNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = this.listNom.SelectedIndex;
            if(id < 0)
            {
                this.inputP.Text = string.Empty;
                this.inputN.Text = string.Empty;
                this.inputA.Text = string.Empty;
                this.inputV.Text = string.Empty;
            }
            else
            {
                this.inputP.Text = Ado.DtClient.Rows[id][1].ToString();
                this.inputN.Text = Ado.DtClient.Rows[id][2].ToString();
                this.inputA.Text = Ado.DtClient.Rows[id][3].ToString();
                this.inputV.Text = Ado.DtClient.Rows[id][4].ToString();
            }
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("SVP choisir un client à modifier !!");
                this.listNom.Focus();
                
                
            }
            else
            {
                Ado.DtClient.Rows[id][1] = this.inputP.Text.Trim();
                Ado.DtClient.Rows[id][2] = this.inputN.Text.Trim();
                Ado.DtClient.Rows[id][3] = this.inputA.Text.Trim();
                Ado.DtClient.Rows[id][4] = this.inputV.Text.Trim();
                Ado.DtClient.Rows[id][5] = this.inputP.Text.Trim() + " " + this.inputN.Text.Trim();

                MessageBox.Show($"l'id {id + 1} est bien modifié");
            }

            
           

        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                MessageBox.Show("SVP choisir un client à supprimer !!");
                this.listNom.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Voullez vous supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Ado.DtClient.Rows[id].Delete();
                MessageBox.Show($"le client id({id+2}) est bien supprimé");
                return;
            }return;
               
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            if (textBoxFree == false)
            {
                foreach (Control item in Controls) // vider les input
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                this.listNom.SelectedIndex = -1;  // vider list
                

               
            }
            DataRow Client = Ado.DtClient.NewRow();
            Client[1] = this.inputP.Text.Trim();
            Client[2] = this.inputN.Text.Trim();
            Client[3] = this.inputA.Text.Trim();
            Client[4] = this.inputV.Text.Trim();
            Client[5] = this.inputP.Text.Trim()+ " " + this.inputN.Text.Trim();
            
            
            if (CheckInput())
            {
                Ado.DtClient.Rows.Add(Client);
                
                foreach (Control item in Controls) // vider les input
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                this.listNom.SelectedIndex = -1;  // vider list
                MessageBox.Show("Un nouveau client est bien ajouté");
            }
            else
            {
                MessageBox.Show("Svp remplir tout les champs!!");
                this.inputP.Focus();
            }
            







        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                Ado.Adapter.Update(Ado.Ds, Ado.DtClient.ToString());
                MessageBox.Show("les modification est bien enregistées !!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
