using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacten
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Connection dbconn = new Connection();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlDataReader sdr;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(dbconn.MyConnectionDB());
            LaadContacten();
        }

        private void KnopAfsluiten(object sender, EventArgs e)
        {
            if (MessageBox.Show("Applicatie Afsluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //
            }
        }

        private void knopToevoeg_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            knopWijzig.Enabled = false;
            knopWis.Enabled = false;
        }

        private void knopOpslaan_Click(object sender, EventArgs e)
        {
            if (txtAchternaam.Text == string.Empty)
            {
                MessageBox.Show("Voer een Achternaam in", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO ContactenDB (Voornaam, Achternaam, Straat, Postcode, Woonplaats, Telefoonnummer, Mobielnummer, Emailadres, Notities) VALUES (@Voornaam, @Achternaam, @Straat, @Postcode, @Woonplaats, @Telefoonnummer, @Mobielnummer, @Emailadres, @Notities) ", con);
                cmd.Parameters.AddWithValue("@Voornaam", txtVoornaam.Text);
                cmd.Parameters.AddWithValue("@Achternaam", txtAchternaam.Text);
                cmd.Parameters.AddWithValue("@Straat", txtStraat.Text);
                cmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text);
                cmd.Parameters.AddWithValue("@Woonplaats", txtWoonplaats.Text);
                cmd.Parameters.AddWithValue("@Telefoonnummer", txtTelefoon.Text);
                cmd.Parameters.AddWithValue("@Mobielnummer", txtMobiel.Text);
                cmd.Parameters.AddWithValue("@Emailadres", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Notities", txtNotities.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Nieuw Contact Gegevens toegevoegd!", "Opgeslagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                LaadContacten();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void ClearText()
        {
            txtVoornaam.Clear();
            txtAchternaam.Clear();
            txtStraat.Clear();
            txtWoonplaats.Clear(); ;
            txtTelefoon.Clear();
            txtMobiel.Clear();
            txtEmail.Clear();
            txtNotities.Clear();

            panel2.Enabled = false;

        }
        public void LaadContacten()
        {
            try
            {
                con.Open();
                dataGridView1.Rows.Clear();
                int i = 0;
                cmd = new SqlCommand("SELECT * FROM ContactenDB", con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                        i++;
                        dataGridView1.Rows.Add(i,
                        sdr["Id"].ToString(),
                        sdr["Voornaam"].ToString(),
                        sdr["Achternaam"].ToString(),
                        sdr["Straat"].ToString(),
                        sdr["Postcode"].ToString(),
                        sdr["Woonplaats"].ToString(),
                        sdr["Telefoonnummer"].ToString(),
                        sdr["Mobielnummer"].ToString(),
                        sdr["Emailadres"].ToString(),
                        sdr["Notities"].ToString());

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "wijzig")
            {
                panel2.Enabled = true;
                knopOpslaan.Enabled = false;
                knopWijzig.Enabled = true;

                con.Open();
                new SqlCommand("SELECT * FROM ContactenDB WHERE ID LIKE '" + int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) + "'", con);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    txtID.Text = sdr["Id"].ToString();
                    txtVoornaam.Text = sdr["Voornaam"].ToString();
                    txtAchternaam.Text = sdr["Achternaam"].ToString();
                    txtStraat.Text = sdr["Straat"].ToString();
                    txtPostcode.Text = sdr["Postcode"].ToString();
                    txtWoonplaats.Text = sdr["Woonplaats"].ToString();
                    txtTelefoon.Text = sdr["Telefoonnummer"].ToString();
                    txtMobiel.Text = sdr["Mobielnummer"].ToString();
                    txtEmail.Text = sdr["Emailadres"].ToString();
                    txtNotities.Text = sdr["Notities"].ToString();
                }
                con.Close();
            }
            else if (colName == "wissen")
            {
                if (MessageBox.Show("Wilt U de Contact Gegevens verwijderen?", "Verwijderen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM ContactenDB WHERE ID LIKE '" + int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Contact Gegevens Verwijderd!", "Verwijderd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LaadContacten();
                }
                else
                {
                    //
                }
            }
        }

        private void knopWijzig_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE ContactenDB SET Voornaam=@Voornaam, Achternaam=@Achternaam, Straat=@Straat, Postcode=@Postcode, Woonplaats=@Woonplaats, Telefoonnummer=@Telefoonnummer, Mobielnummer=@Mobielnummer, Emailadres=@Emailadres, Notities=@Notities WHERE ID LIKE'" + int.Parse(txtID.Text) + "'", con);
                cmd.Parameters.AddWithValue("@Voornaam", txtVoornaam.Text);
                cmd.Parameters.AddWithValue("@Achternaam", txtAchternaam.Text);
                cmd.Parameters.AddWithValue("@Straat", txtStraat.Text);
                cmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text);
                cmd.Parameters.AddWithValue("@Woonplaats", txtWoonplaats.Text);
                cmd.Parameters.AddWithValue("@Telefoonnummer", txtTelefoon.Text);
                cmd.Parameters.AddWithValue("@Mobielnummer", txtMobiel.Text);
                cmd.Parameters.AddWithValue("@Emailadres", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Notities", txtNotities.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Contact Gegevens Bijgewerkt!", "Gewijzigd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void txtZoek_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int i = 0;
                dataGridView1.Rows.Clear();
                cmd = new SqlCommand("SELECT * FROM ContactenDB WHERE Achternaam LIKE '%" + txtZoek.Text + "%' ", con);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                        i++;
                        dataGridView1.Rows.Add(i,
                        sdr["Id"].ToString(),
                        sdr["Voornaam"].ToString(),
                        sdr["Achternaam"].ToString(),
                        sdr["Straat"].ToString(),
                        sdr["Postcode"].ToString(),
                        sdr["Woonplaats"].ToString(),
                        sdr["Telefoonnummer"].ToString(),
                        sdr["Mobielnummer"].ToString(),
                        sdr["Emailadres"].ToString(),
                        sdr["Notities"].ToString());

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}

