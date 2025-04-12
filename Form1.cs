using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaCrud.Clases;

namespace TareaCrud
{
    public partial class Form1 : Form
    {
        private Crud crud; // Instancia de la clase Crud

        public Form1()
        {
            InitializeComponent();
            // Inicializar la instancia de Crud
            crud = new Crud();
        }

        private void BotonSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola te saludo desde el formulario.  (_8(|)   ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opcional: Código que se ejecuta al cargar el formulario
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            // Llama al método Mostrarinformacion de la clase Crud
            string carnet = TBCarnet.Text;
            string nombre = crud.Mostrarinformacion(carnet);
            string seccion = crud.MostrarSeccion(carnet);
            string correo = crud.MostrarCorreo(carnet);
            string nota1 = crud.MostrarNota1(carnet);
            string nota2 = crud.MostrarNota2(carnet);
            string nota3 = crud.MostrarNota3(carnet);
            string nota4 = crud.MostrarNota4(carnet);

            if (nombre != "No Existe" && nombre != "Error")
            {
                TBNombre.Text = nombre;
                TBSeccion.Text = seccion;
                TBCorreo.Text = correo;
                TBTarea1.Text = nota1;
                TBTarea2.Text = nota2;
                TBTarea3.Text = nota3;
                TBTarea4.Text = nota4;

                MessageBox.Show($"Información encontrada para el carnet {carnet}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró información para el carnet {carnet}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBNombre.Text = string.Empty;
            }
        }

        private void BotonCrearRegistro_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los TextBox
            string carnet = TBCarnet.Text;
            string nombre = TBNombre.Text;
            string email = TBCorreo.Text;
            string seccion = TBSeccion.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(carnet) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(seccion))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llama al método AgregarAlumno de la clase Crud
            string respuesta = crud.AgregarAlumno(carnet, nombre, email, seccion);

            // Muestra el resultado en un MessageBox
            MessageBox.Show(respuesta, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpia los TextBox después de agregar el registro
            TBCarnet.Text = string.Empty;
            TBNombre.Text = string.Empty;
            TBCorreo.Text = string.Empty;
            TBSeccion.Text = string.Empty;
        }

        private void VerDB_Click(object sender, EventArgs e)
        {
            // Llama al método ObtenerTodosLosRegistros de la clase Crud
            string registros = ObtenerTodosLosRegistros();
            MessageBox.Show(registros, "Registros de la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ObtenerTodosLosRegistros()
        {
            // Llama al método ObtenerTodosLosRegistros de Crud y devuelve los registros
            StringBuilder resultado = new StringBuilder();
            string connectionString = "Server=USUARIO_PC\\SQLEXPRESS;Database=UMG;Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tb_alumnos";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string carnet = reader["carnet"].ToString();
                        string nombre = reader["estudiante"].ToString();
                        string email = reader["email"].ToString();
                        string seccion = reader["seccion"].ToString();

                        resultado.AppendLine($"Carnet: {carnet}, Nombre: {nombre}, Email: {email}, Sección: {seccion}");
                    }
                }
                catch (Exception ex)
                {
                    return "Error al obtener los registros: " + ex.Message;
                }
                connection.Close();
            }

            return resultado.Length > 0 ? resultado.ToString() : "No hay registros en la base de datos.";
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            string carnet = TBCarnet.Text;
            crud.BorrarAlumno(carnet);
            MessageBox.Show($"Información eliminada para el carnet {carnet}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
    
}
