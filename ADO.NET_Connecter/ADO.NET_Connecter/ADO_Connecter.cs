using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET_Connecter
{
    public static class ADO_Connecter
    {
        public static SqlConnection connection = new SqlConnection();
        public static String connectionString=@"Data Source=.\HNADASQL;Initial Catalog=librairie;User Id=sa;Password='123123'";
        public static SqlCommand Cmd = new SqlCommand();


        public static void Connection()
        {
            if (connection.State!=System.Data.ConnectionState.Open )
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }
        }
        public static bool Exit(String req)
        {
            Connection();
            Cmd = new SqlCommand(req);
            Cmd.Connection = connection;
            int cp = (int)Cmd.ExecuteScalar();
            if (cp == 0)
            {
                return false;
            }else
            {
                return true;
            }
        }
        public static void RemplirTextBox(TextBox text, String req, String table)
        {
            Connection();
            Cmd = new SqlCommand(req);
            Cmd.Connection = connection;
            String dr =(String) Cmd.ExecuteScalar();
            text.Text = dr;
            
            Cmd = null;
        }
        public static void RemplirListBox(ListBox list ,String req,String champs)
        {
            Connection();
            Cmd = new SqlCommand(req);
            Cmd.Connection = connection;
            SqlDataReader dr = Cmd.ExecuteReader();
            list.Items.Clear();
            while (dr.Read())
            {
                list.Items.Add(dr[champs]);
            }
            dr.Close();
            Cmd = null;
        }
        public static void RemplirComboBox(ComboBox list, String req, String champs)
        {
            Connection();
            Cmd = new SqlCommand(req);
            Cmd.Connection = connection;
            SqlDataReader dr = Cmd.ExecuteReader();
            list.Items.Clear();
            while (dr.Read())
            {
                list.Items.Add(dr[champs]);
            }
            dr.Close();
            Cmd = null;
        }
        public static void RemplirDatagrid(DataGridView datagrid ,String req,String champs1, String champs2)
        {
            Connection();
            Cmd = new SqlCommand(req);
            Cmd.Connection = connection;
            SqlDataReader dr = Cmd.ExecuteReader();

            datagrid.Rows.Clear();
            while (dr.Read())
            {
                datagrid.Rows.Add(dr[champs1], dr[champs2]);
            }
            dr.Close();
            Cmd = null;
        }
        public static void ADD()
        {

        }
        public static void UPDATE()
        {

        }
        public static void DELETE()
        {

        }
        




















    }
}
