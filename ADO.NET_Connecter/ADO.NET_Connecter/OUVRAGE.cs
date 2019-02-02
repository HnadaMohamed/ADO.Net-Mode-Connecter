using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET_Connecter
{
    public partial class OUVRAGE : MetroForm
    {
        public OUVRAGE()
        {
            InitializeComponent();
        }
        int NUMRUB=0;
        private void OUVRAGE_Load(object sender, EventArgs e)
        {
            // Design
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
            this.FormBorderStyle = FormBorderStyle.None;

            //Connection Test 
            ADO_Connecter.RemplirListBox(listBox_OUVRAGE,"select * from OUVRAGE" ,"NOMOUVR");
            ADO_Connecter.RemplirListBox(listBox_help, "select * from OUVRAGE", "NUMOUVR");
            ADO_Connecter.RemplirComboBox(comboBox_classification,"select * from CLASSIFICATION","LIBRUB");
            ADO_Connecter.RemplirComboBox(comboBox_EDITEUR, "select * from EDITEUR", "NOMED");

        }

        private void listBox_OUVRAGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_help.SelectedIndex = listBox_OUVRAGE.SelectedIndex;
            ADO_Connecter.RemplirDatagrid(dataGridView_ECRIVAIN, "select NOMECR,PAYSECR from ECRIVAIN as e inner join ECRIRE as ec on e.NUMECR=ec.NUMECR inner join OUVRAGE as o on o.NUMOUVR=ec.NUMOUVR   where o.NUMOUVR=' " + listBox_help.SelectedItem.ToString() + "'", "NOMECR", "PAYSECR");
            
            //selection in combobox Editeur 
            ADO_Connecter.Connection();
            ADO_Connecter.Cmd = new SqlCommand("select * from OUVRAGE where NUMOUVR='" + listBox_help.SelectedItem.ToString() + "'");
            
            ADO_Connecter.Cmd.Connection = ADO_Connecter.connection;
            SqlDataReader dr = ADO_Connecter.Cmd.ExecuteReader();
            dr.Read();
            comboBox_EDITEUR.SelectedItem = dr["NOMED"].ToString();
            txt_ANNEPARU.Text = dr["ANNEEPARU"].ToString();
            txt_NUMOUVR.Text = dr["NUMOUVR"].ToString();
            txt_NOMOUVR.Text = dr["NOMOUVR"].ToString();
            NUMRUB = (int)dr["NUMRUB"];
            ADO_Connecter.Cmd = null;
            dr.Close();

        }

        private void comboBox_classification_SelectedIndexChanged(object sender, EventArgs e)
        {
            ADO_Connecter.RemplirListBox(listBox_OUVRAGE, "select * from OUVRAGE where NUMRUB in (select NUMRUB from CLASSIFICATION where LIBRUB = '"+comboBox_classification.SelectedItem.ToString()+"')", "NOMOUVR");
        }
    }
}
