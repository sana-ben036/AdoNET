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
        AdoNet Ado = new AdoNet();
        string paramaitre;
        private void Form2_Load(object sender, EventArgs e)
        {
            FillClient();
            Ado.DtClient = Ado.Ds.Tables[0];
            Ado.DtClient.TableName = "Client";
            this.listClient.DataSource = Ado.DtClient;
            this.listVille.DataSource = Ado.DtClient;
            this.listVille.DisplayMember = Ado.DtClient.Columns[4].ColumnName; // "ville" pour eviter la situation de changement du name of column
            this.listVille.ValueMember = Ado.DtClient.Columns[0].ColumnName;  //" id"
            //this.listVille.SelectedIndex = -1;  // pour eviter l'affichage d'un element par defaut sur la list
        }
        private void FillClient()
        {
            string query = string.Empty + $"select * from Client  WHERE Ville = '{paramaitre}';";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Client");
        }
        private void listVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramaitre = this.listVille.Text;
            //query = string.Empty + $"select * from Client  WHERE Ville = '{paramaitre}';";


            
        }

       
        
    }
}
