using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSuper
{
    public partial class Crud : Form
    {
        SqlConnection con = new SqlConnection("data source=MAHO\\SQLEXPRESS;initial catalog=Biblioteca;integrated security=true");

        public Crud()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spinsertarsuper",con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idsuper", int.Parse(txtid.Text));
                comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@sexo", cmbsexo.Text);
                comando.Parameters.AddWithValue("@poder",txtpoder.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro insertado");
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spactualizarsuper", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("@idsuper",SqlDbType.Int).Value= int.Parse(txtid.Text);
                comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@sexo", cmbsexo.Text);
                comando.Parameters.AddWithValue("@poder", txtpoder.Text);
                //comando.Parameters.AddWithValue("@idsuper", int.Parse(txtid.Text));
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
                throw;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("speliminarsuper", con);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.Add("@idsuper",SqlDbType.Int).Value=int.Parse(txtid.Text);
            comm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            con.Close();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("spobteneridsuper", con);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@idsuper",int.Parse(txtid.Text));
            SqlDataReader registro = comm.ExecuteReader();
            if (registro.Read())
            {
                txtid.Text = registro["idsuper"].ToString();
                txtnombre.Text = registro["nombre"].ToString();
                cmbsexo.Text = registro["sexo"].ToString();
                txtpoder.Text = registro["poder"].ToString();

            }

            con.Close();
        }
    }
}
