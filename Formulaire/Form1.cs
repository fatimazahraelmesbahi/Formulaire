using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Formulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String connexionString = @"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=Formulaire;Integrated Security=True";
        int nbr;
        private void Reset()
        {
            input_id.Text = "";
            input_nom.Text = "";
            input_prenom.Text = "";
            input_age.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)//search
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connexionString;
            String Query = "SELECT * FROM Personne";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
           
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd["Id_personne"], rd[1], rd[2], rd[3]);

                }
                btn_search.Enabled = true;
                btn_insert.Enabled = true;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
                btn_saved.Enabled = false;
                btn_anuller.Enabled = false;
                input_id.Enabled = true;
                input_nom.Enabled = true;
                input_prenom.Enabled = true;
                input_age.Enabled = true;
                Reset();
            }
            else
                MessageBox.Show("La tabe vide");
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            nbr = 2;
            btn_search.Enabled = false;
            btn_insert.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_saved.Enabled = true;
            btn_anuller.Enabled = true;
            input_id.Enabled = true;
            input_nom.Enabled = true;
            input_prenom.Enabled = true;
            input_age.Enabled = true;
            Reset();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nbr = 3;


            //cmd.CommandText = "update Dossier set NOM_DOSSIER='" + txtNom_dossier.Text + "' where ID_DOSSIER='" + txtId_dossier.Text + "' ";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
                nbr = 1;
                btn_search.Enabled = false;
                btn_insert.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saved.Enabled = true;
                btn_anuller.Enabled = true;
                input_id.Enabled = true;
                input_nom.Enabled = true;
                input_prenom.Enabled = true;
                input_age.Enabled = true;
                Reset(); 
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_saved_Click(object sender, EventArgs e)
        {
            if (nbr == 1)
            {
                if (input_id.Text == "" || input_nom.Text == "" || input_age.Text == "" || input_prenom.Text == "")
                { MessageBox.Show("Ajouter des informations"); }


                else
                {
                    try
                    {
                        using (SqlConnection cnx = new SqlConnection(connexionString))
                        {
                            String Query = "insert into Personne(Id_personne,Nom,Prenom,Age) values('" + input_id.Text + "','" + input_nom.Text + "','" + input_prenom.Text + "','" + input_age.Text + "') ";
                            SqlCommand cmd = new SqlCommand(Query, cnx);
                            if (cnx.State == ConnectionState.Open)
                                cnx.Close();
                            cnx.Open();
                            cmd.ExecuteNonQuery();
                            button1_Click(sender, e);
                            MessageBox.Show("(ligne affectée)");
                            cnx.Close();

                        }

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else if (nbr == 2)
            {
                if (input_id.Text == "" || input_nom.Text == "" || input_age.Text == "" || input_prenom.Text == "")
                { MessageBox.Show("Ajouter des informations"); }


                else
                {
                    try
                    {
                        using (SqlConnection cnx = new SqlConnection(connexionString))
                        {
                            string q = "delete from Personne where Id_personne = " + input_id.Text + ";";
                            SqlCommand cmd = new SqlCommand(q, cnx);
                            cnx.Open();
                            cmd.Connection = cnx;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("le personne est bien supprimé");
                            cnx.Close();
                        }
                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
               
            }
            else if (nbr  == 3)
            {
                if (input_id.Text == "" || input_nom.Text == "" || input_age.Text == "" || input_prenom.Text == "")
                { MessageBox.Show("Ajouter des informations"); }


                else
                {
                    try
                    {
                        using (SqlConnection cnx = new SqlConnection(connexionString))
                        {
                            String Query = " Update Personne set Age= '" + input_age.Text + "','" + "'Prenom ='" + input_prenom.Text + "','" + "'Nom ='" + input_nom.Text + "'," + " 'where Id_personne='" + input_id.Text + "'";
                            SqlCommand cmd = new SqlCommand(Query, cnx);
                            cnx.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("C'est bien modifié");
                            cnx.Close();
                        }
                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void btn_anuller_Click(object sender, EventArgs e)
        {
            nbr = 1;
            btn_search.Enabled = true;
            btn_insert.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_saved.Enabled = false;
            btn_anuller.Enabled = true;
            input_id.Enabled = true;
            input_nom.Enabled = true;
            input_prenom.Enabled = true;
            input_age.Enabled = true;
            Reset();
        }
    }
}
