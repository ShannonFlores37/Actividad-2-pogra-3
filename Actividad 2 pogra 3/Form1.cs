using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;


namespace Actividad_2_pogra_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //conectamos los botones a sus eventos
            //btnguardar.Click += btnguardar_Click;
            //btnmostrar.Click += btnmostrar_Click;
            //btnlimpiar.Click += btnlimpiar_Click;

            //consultamos los alumnos al entrar al programa
            Load += Form1_Load;

        }

        private void nudsemestre_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //validamos que los cammpos de texto no esten vacions (daeerror y tumba todo)
            if (string.IsNullOrWhiteSpace(txtmatricula.Text) || string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtgrupo.Text) || string.IsNullOrWhiteSpace(txtespecialidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Obtemoa los datos del formulario
            try
            {
                using (OleDbConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                         "INSERT INTO alumnos" +
                         "(matricula, nombre, semestre,  grupo, especialidad )" +
                         "VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        //con oledb importa el orden de lo parametros
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtmatricula.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtnombre.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.Integer
                            ).Value = nudsemestre.Value;
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtgrupo.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 50
                            ).Value = txtespecialidad.Text.Trim();
                        comando.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                $"Error al guardar el alumno: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }


        }



        private void CargarAlumnos()
        {
            try
            {
                using (OleDbConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "SELECT id_alumno, matricula, nombre," +
                        "semestre, grupo, especialidad" +
                        " FROM alumnos Order by id_alumno";
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgv.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                 $"Error al cargar los alumnos: {ex.Message}",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error
                 );
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                string consulta =
                    "DELETE FROM alumnos" +
                    " WHERE id_alumno = ?";
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {

                }
            }
        }
    }
}
