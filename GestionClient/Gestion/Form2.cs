using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Gestion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void listClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        AdoNet Ado;
        
       
        private void Form2_Load(object sender, EventArgs e)
        {
            Ado = new AdoNet();
            FillVille();
            FillClient();
            Ado.DtVille = Ado.Ds.Tables[0];
            Ado.DtClient = Ado.Ds.Tables[1];
            Ado.DtVille.TableName = "Ville";
            Ado.DtClient.TableName = "Client";
            this.listClient.DataSource = Ado.DtClient;
            this.listVille.DataSource = Ado.DtVille;
            this.listVille.DisplayMember = Ado.DtVille.Columns[0].ColumnName; // "Ville"
            this.listVille.ValueMember = Ado.DtVille.Columns[0].ColumnName;  // "Ville"
            this.listVille.SelectedIndex = -1;  // pour eviter l'affichage d'un element par defaut sur la list
            this.listClient.AllowUserToAddRows = false;



        }
        private void listVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FillClient();
            
        }

        private void FillVille()
        {
            string query = "select distinct Ville from Client ;";
            
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Ville");
        }
        private void FillClient()
        {
            string query = string.Empty + "select Id, Prenom, Nom, Adresse, Ville from Client";
            query += " WHERE Ville = @Ville";
            query += " OR ISNULL(@Ville, '') = ''";
            
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Cmd.Parameters.AddWithValue("@Ville", listVille.SelectedValue);
            Ado.Adapter.Fill(Ado.Ds, "Client");
        }

        



    }
}
