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
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;

namespace ProyectoFinalDCU_Felix_Ortega_2021_0825_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string imgLocation = "";

        SqlCommand cmd;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dcufinalDataSet.datos' table. You can move, or remove it, as needed.
            this.datosTableAdapter.Fill(this.dcufinalDataSet.datos);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
                    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            /*
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               openFileDialog1.ShowDialog();
                string filePath = openFileDialog1.FileName;
                pictobox.Image = Image.FromFile(filePath);
            } */

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    pictobox.ImageLocation = imgLocation;

                }
            }
        }

        public void Insert(string fileNmae, byte[] image)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProyectoFinalDCU_Felix_Ortega_2021_0825_.Properties.Settings.dcufinalConnectionString"].ConnectionString))
            {

            }
        }

        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public DataTable LlenarTable()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string Consulta = "SELECT * FROM datos";
            SqlCommand cmd = new SqlCommand(Consulta, Conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                img = brs.ReadBytes((int)streem.Length);
                int i = int.Parse(txtid.Text);
                Conexion.conectar();
                
                string comando = "INSERT INTO datos (id,nombre,correo,telefono,foto,texto)  VALUES " +
                    "(" + i + "," +
                    "'" + txtnombre.Text + "'," +
                    "'" + txtcorreo.Text + "'," +
                    "'" + txttelefono.Text + "',@images" + "," +
                    "'" + txttexto.Text + "'" +


                    ")";



                cmd = new SqlCommand(comando, Conexion.conectar());
                cmd.Parameters.Add(new SqlParameter("@images", img));
                int n = cmd.ExecuteNonQuery();
                Conexion.close();
                MessageBox.Show(n.ToString() + " " + "dato/s fueron guardados correctamente");
                dataGridView1.DataSource = LlenarTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.conectar();

            SqlCommand cmd = new SqlCommand(("INSERT INTO datos VALUES(@id, @nombre, @correo, @telefono, @foto, @texto)"), Conexion.conectar());
                
                    int i = int.Parse(txtid.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", i);
                    cmd.Parameters.AddWithValue("@nombre", txtnombre);
                    cmd.Parameters.AddWithValue("@telefono", txttelefono);
                    cmd.Parameters.AddWithValue("@foto", ConvertImageToBytes(pictobox.Image));
                

                    dataGridView1.DataSource = LlenarTable();


                
          
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            int i = int.Parse(txtid.Text);
            string consulta = "select * from datos  where id = " + i + ";";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conexion.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand cmd = new SqlCommand(consulta, Conexion.conectar());
            SqlDataReader leer;

            leer = cmd.ExecuteReader();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            int i = int.Parse(txtid.Text);
            string Consulta = "SELECT * FROM datos WHERE id ='" + i + "'";
            SqlCommand cmd = new SqlCommand(Consulta, Conexion.conectar());


            SqlDataReader rd = cmd.ExecuteReader();

            if (rd != null)
            {
                
                string consulta = "DELETE  FROM datos where id = ' " + i + " ' ";
                SqlCommand cmd1 = new SqlCommand(consulta, Conexion.conectar());
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron eliminados correctamente");
                dataGridView1.DataSource = LlenarTable();
            }
            else
            {
                MessageBox.Show("Los datos fueron eliminados correctamente");
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            int i = int.Parse(txtid.Text);
            string Consulta = "SELECT * FROM datos WHERE id ='" + i + "'";
            SqlCommand cmd = new SqlCommand(Consulta, Conexion.conectar());


            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                byte[] img = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                img = brs.ReadBytes((int)streem.Length);
                Conexion.conectar();
                string consulta = "UPDATE datos SET " +
                    "id = '" + i + "'," +
                    "nombre ='" + txtnombre.Text + "'," +
                    "correo ='" + txtcorreo.Text + "'," +
                    "telefono ='" + txttelefono.Text + "'," +
                    "foto = " + " @images," + "," +
                    "texto ='" + txttexto.Text + "'" +
                    "where id =" + i + ";";


                SqlCommand cmd1 = new SqlCommand(consulta, Conexion.conectar());
                cmd1.Parameters.Add(new SqlParameter("@images", img));

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Grupo Entidad Editado");

                dataGridView1.DataSource = LlenarTable();
            }
            else
            {
                MessageBox.Show("Entidad No Encontrada");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            pictobox.Image = null;
            txttexto.Text = "";
        }
    }
}
