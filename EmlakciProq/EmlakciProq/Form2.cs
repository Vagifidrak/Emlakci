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

namespace EmlakciProq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=USER\\VQFSQL;Initial Catalog=EmlakciSQL;Integrated Security=True");
        private void infoShow() {
            connect.Open();
            SqlCommand cm = new SqlCommand("Select * from EmlakMelumat", connect);
            SqlDataReader rd = cm.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem Ekle = new ListViewItem();
                Ekle.Text = rd["Id"].ToString();
                Ekle.SubItems.Add(rd["Emlak"].ToString());
                Ekle.SubItems.Add(rd["Otaq"].ToString());
                Ekle.SubItems.Add(rd["kv.m"].ToString());
                Ekle.SubItems.Add(rd["Qiymet"].ToString());
                Ekle.SubItems.Add(rd["Blok"].ToString());
                Ekle.SubItems.Add(rd["No"].ToString());
                Ekle.SubItems.Add(rd["Ad Soyad"].ToString());
                Ekle.SubItems.Add(rd["Telefon"].ToString());
                Ekle.SubItems.Add(rd["Qeydler"].ToString());
                Ekle.SubItems.Add(rd["SatKira"].ToString());

                listView1.Items.Add(Ekle);
            }
            connect.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "KristalHoll")
            {
                btnKristal.BackColor = Color.CadetBlue;
                btnQurtulus.BackColor = Color.LightSlateGray;
                btnBaki.BackColor = Color.LightSlateGray;
                btnDaisy.BackColor = Color.LightSlateGray;
            }
            if (comboBox1.Text == "Qurtulus")
            {
                btnKristal.BackColor = Color.LightSlateGray;
                btnQurtulus.BackColor = Color.CadetBlue;
                btnBaki.BackColor = Color.LightSlateGray;
                btnDaisy.BackColor = Color.LightSlateGray;
            }
            if (comboBox1.Text == "DaisyHoll")
            {
                btnKristal.BackColor = Color.LightSlateGray;
                btnQurtulus.BackColor = Color.LightSlateGray;
                btnBaki.BackColor = Color.LightSlateGray;
                btnDaisy.BackColor = Color.CadetBlue;
            }
            if (comboBox1.Text == "Yeni Baki")
            {
                btnKristal.BackColor = Color.LightSlateGray;
                btnQurtulus.BackColor = Color.LightSlateGray;
                btnBaki.BackColor = Color.CadetBlue;
                btnDaisy.BackColor = Color.LightSlateGray;
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            infoShow();
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cm2 = new SqlCommand("insert into EmlakMelumat" +
                " values( '" + textBox7.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", connect);
            cm2.ExecuteNonQuery();
            connect.Close();
            infoShow();
        }
    }
}
