using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestion
{
    class AdoNet
    {
        private string connextionString;
        private SqlConnection cnx;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private DataTable dtVille;
        private DataTable dtClient;


        public AdoNet()
        {
            connextionString = ConfigurationManager.ConnectionStrings["CnxSqlServer"].ConnectionString;
            cnx = new SqlConnection(connextionString);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            dtVille = new DataTable();
            dtClient = new DataTable();

        }

        public SqlConnection Cnx { get => cnx; set => cnx = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataTable DtVille { get => dtVille; set => dtVille = value; }
        public DataTable DtClient { get => dtClient; set => dtClient = value; }
        public string ConnextionString { get => connextionString; }
        public DataSet Ds { get => ds; set => ds = value; }
        
    }
}
