using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FillClient();
            Ado.DtClient = Ado.Ds.Tables[0];
            Ado.DtClient.TableName = "Client";
            this.listClient.DataSource = Ado.DtClient;
        }

        private void FillClient()
        {
            string query = string.Empty + "select Id, Prenom, Nom, Adresse, Ville, Prenom +' '+Nom from Client as colToDisplay ;";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Client");
        }
    }
}
