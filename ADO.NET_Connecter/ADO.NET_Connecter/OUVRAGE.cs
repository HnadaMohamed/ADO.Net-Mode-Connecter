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

        //*******************************Variable Utils***********************************//
        int NUMRUB=0;
        String req;
        String MAJ;
        private void OUVRAGE_Load(object sender, EventArgs e)
        {
            //Metro Dark Theme 
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
            this.FormBorderStyle = FormBorderStyle.None;

            //Remplir Les LIstBox Et DataGridView
            ADO_Connecter.RemplirListBox(listBox_OUVRAGE,"select * from OUVRAGE" ,"NOMOUVR");
            ADO_Connecter.RemplirListBox(listBox_help, "select * from OUVRAGE", "NUMOUVR");
            ADO_Connecter.RemplirComboBox(comboBox_classification,"select * from CLASSIFICATION","LIBRUB");
            ADO_Connecter.RemplirComboBox(comboBox_EDITEUR, "select * from EDITEUR", "NOMED");

            //initialisation de selection du classification 
            comboBox_classification.SelectedIndex = 0;

            apres_validation();
            
        }

        private void listBox_OUVRAGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_help.SelectedIndex = listBox_OUVRAGE.SelectedIndex;
            ADO_Connecter.RemplirDatagrid(dataGridView_ECRIVAIN, "select NOMECR,PAYSECR from ECRIVAIN as e inner join ECRIRE as ec on e.NUMECR=ec.NUMECR inner join OUVRAGE as o on o.NUMOUVR=ec.NUMOUVR   where o.NUMOUVR=' " + listBox_help.SelectedItem.ToString() + "'", "NOMECR", "PAYSECR");
            
            //Remplir Les Text Box  et ComboBox Selection
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
            ADO_Connecter.RemplirListBox(listBox_help, "select * from OUVRAGE where NUMRUB in (select NUMRUB from CLASSIFICATION where LIBRUB = '" + comboBox_classification.SelectedItem.ToString() + "')", "NUMOUVR");
            listBox_OUVRAGE.SelectedIndex = 0;

        }
        //*******************************go to first element  ***********************************//
        private void btn_first_Click(object sender, EventArgs e)
        {
            listBox_OUVRAGE.SelectedIndex = 0;
        }
        //*******************************go to last element  ***********************************//
        private void btn_last_Click(object sender, EventArgs e)
        {
            listBox_OUVRAGE.SelectedIndex = listBox_OUVRAGE.Items.Count - 1;
        }
        //*******************************go to nest element  ***********************************//
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (listBox_OUVRAGE.SelectedIndex== listBox_OUVRAGE.Items.Count - 1)
            {
                listBox_OUVRAGE.SelectedIndex = 0;
            }else
            {
                listBox_OUVRAGE.SelectedIndex++;
            }
        }
        //*******************************go to previous element  ***********************************//
        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (listBox_OUVRAGE.SelectedIndex ==0 )
            {
                listBox_OUVRAGE.SelectedIndex = listBox_OUVRAGE.Items.Count - 1;
            }
            else
            {
                listBox_OUVRAGE.SelectedIndex--;
            }
        }
        //*******************************ADD OUVRAGE  ***********************************//
        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            avant_validation();
            MAJ = "ADD";
           
            foreach (Control c in panel_text.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
 
            }
        }
        //******************************* VALIDER OPERATION  ***********************************//
        private void BTN_VALID_Click(object sender, EventArgs e)
        {
            
            if (MAJ == "UPDATE")
            {
                req = " update OUVRAGE set  NOMOUVR='" + txt_NOMOUVR.Text + "', ANNEEPARU='" + txt_ANNEPARU.Text + "', NUMRUB='" + NUMRUB + "', NOMED='" + comboBox_EDITEUR.SelectedItem + "'  where NUMOUVR = '" + txt_NUMOUVR.Text + "'";
            }
            else
            {
                req = " insert into OUVRAGE values('" + Convert.ToInt32(txt_NUMOUVR.Text) + "','" + txt_NOMOUVR.Text + "','" + Convert.ToInt64(txt_ANNEPARU.Text) + "','" + NUMRUB + "','" + comboBox_EDITEUR.SelectedItem.ToString() + "')";

            }
            ADO_Connecter.Cmd = new SqlCommand(req);
            ADO_Connecter.Cmd.Connection = ADO_Connecter.connection;
            ADO_Connecter.Cmd.ExecuteNonQuery();

            
        }
        //******************************* UPDATE ELEMENT ***********************************//
        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            avant_validation();
            MAJ = "UPDATE";   
        }
        //******************************* CANCEL OPERATION ***********************************//
        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            apres_validation();
            //ces 2 ligne pour le romplisar des textbox de panel_text;
            listBox_OUVRAGE.SelectedIndex++;
            listBox_OUVRAGE.SelectedIndex--;
        }
        //******************************* DELETE ELEMENT ***********************************//
        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            String selected= txt_NUMOUVR.Text;
            int todelete= listBox_OUVRAGE.SelectedIndex;
            listBox_OUVRAGE.SelectedIndex = 0;

            listBox_OUVRAGE.Items.RemoveAt(todelete);
            listBox_help.Items.RemoveAt(todelete);
            req = "delete from OUVRAGE where NUMOUVR = '" +selected + "'";
            
            
            BTN_VALID_Click(sender, e);
        }

        public  void avant_validation()
        {
            panel_AMS.Enabled = false;
            panel_OUVRAGE.Enabled = false;
            panel_ECRIVAIN.Enabled = true;
            panel_VA.Enabled = true;
            panel_text.Enabled = true;
        }
        public  void apres_validation()
        {
            panel_AMS.Enabled = true;
            panel_OUVRAGE.Enabled = true;
            panel_ECRIVAIN.Enabled = false;
            panel_VA.Enabled = false;
            panel_text.Enabled = false;
            
        }
        



    }
}
