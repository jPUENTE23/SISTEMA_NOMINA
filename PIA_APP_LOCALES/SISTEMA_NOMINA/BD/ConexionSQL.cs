using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SISTEMA_NOMINA.BD
{
    internal class ConexionSQL
    {

        public class Conexion
        {
            // CONEXION A SQL SERVER CON AUTENTICACION DE WINDOWS
            SqlConnection ConexionBD = new SqlConnection("server=DESKTOP-6JRCA2I ; database=DB_00_SISTEMA_NOMINA ; integrated security = true");
            public SqlConnection AbrirConexioBD()
            {
                //SqlConnection Conexion = new SqlConnection("server=DESKTOP-6JRCA2I ; database=DB_00_SISTEMA_NOMINA ; integrated security = true");
                SqlConnection AbrirConn = ConexionBD;
                try
                {
                    AbrirConn.Open();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("La conexion a fallado " + e.ToString());
                }
                return AbrirConn;
            }

            public SqlConnection CerrarConexionnBD()
            {
                SqlConnection CerrarConn = ConexionBD;
                try
                {
                    CerrarConn.Close();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("La conexion a fallado " + e.ToString());
                }
                return CerrarConn;
            }

           
        }

        public class Empresa
        {
            // Creacion de varuable Empr_Conexion de tipo Conexion();
            // La variable Empr_Conexion sera privadad para evitar alguna modificacion
            private Conexion Empr_Conexion = new Conexion();

            // Creacion de la variable cmd para la maipulacion de comandos SQL
            SqlCommand cmd = new SqlCommand();

            // METODO/FUNCION para el registro de nuesvas empresas
            // Parametros a recibis: NomEmoresa, RFC_Empresa
            public void InsertarEmopresa(dynamic NomEmoresa, dynamic RFC_Empresa)
            {
                // Enlazamos el comando con la conexion al servidor de SQL
                cmd.Connection = Empr_Conexion.AbrirConexioBD();

                // Indicamos el nombre del procedimeinto almacenado que vamos a utilzar
                cmd.CommandText = "SP_INSERTAR_EMPRESA";

                // Definimos el tipo de comando que vamos a ejecutar. esta caso StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Pasamos los parametos del procediemnto almacenado de acuerdo a los valores ingresados a los parametros que solicita el metodo
                cmd.Parameters.AddWithValue("@Nom_Empresa", NomEmoresa);
                cmd.Parameters.AddWithValue("@RFC_Empresa", RFC_Empresa);

                // Procedemos a comnnicarnos con el servidor para que ejecute el comado SQL
                cmd.ExecuteNonQuery();

                // Limpiamos los parametros de nuestro procedimiento almacenado
                cmd.Parameters.Clear();

                // Cerramos la conexion con nuestro servidor
                Empr_Conexion.CerrarConexionnBD();

            }

            public SqlDataReader ListarEmpresas()
            {
                cmd.Connection = Empr_Conexion.AbrirConexioBD();
                cmd.CommandText = "SP_LISTAR_EMPRESAS";
                cmd.CommandType = CommandType.StoredProcedure;

                /* Creamos una variable de tipo SqlDataReader para la lectura de los
                 datos que nos devuelva la consulta */
                SqlDataReader ListadoEmpr = cmd.ExecuteReader();


                /* Retornamos los daos que se hayan encontrado */
                return ListadoEmpr;

            }

            public SqlDataReader ID_Empresa(dynamic Nom_Empresa)
            {
                cmd.Connection = Empr_Conexion.AbrirConexioBD();

                cmd.CommandText = "SP_OBTENER_ID_EMPRESA";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreEmpresa", Nom_Empresa);

                SqlDataReader id_empresa = cmd.ExecuteReader();

                cmd.Parameters.Clear();

                return id_empresa;

            }
        }

        public class Usuarios
        {
            private Conexion Usuario_Conexion = new Conexion();
            SqlCommand cmd = new SqlCommand();

            public void Crear_Usuario(dynamic NomUsuario, dynamic passUsuario)
            {
                /*  - Abrimos la conexion a la base de datos.
                    - Indicamos el nombre del procedimiento almcenado a ajecutar.
                    - Indicamos el tipo de comando a ejecutar. */

                cmd.Connection = Usuario_Conexion.AbrirConexioBD();
                cmd.CommandText = "SP_CREAR_USUARIO";
                cmd.CommandType = CommandType.StoredProcedure;

                /* Pasamo los parametros y valores al procedimient almacenado */
                cmd.Parameters.AddWithValue("@NombreUsuario", NomUsuario);
                cmd.Parameters.AddWithValue("@ConstraseñaUsuario", passUsuario);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                /* Cerramos la conexion con la base de datos */
                Usuario_Conexion.CerrarConexionnBD();
            }

            public SqlDataReader ListarUsuarios()
            {
                /* Abrimos la conexion hacia la basse de datos */
                cmd.Connection = Usuario_Conexion.AbrirConexioBD();

                /* Idicamos el nombre del procedimiento almcaendao y el tipo 
                 de comando a ajecutar */
                cmd.CommandText = "SP_LISTAR_USUARIOS";
                cmd.CommandType = CommandType.StoredProcedure;

                /* Almacenamos los resultados obtenidos */
                SqlDataReader Usuarios = cmd.ExecuteReader();

                return Usuarios;
            }

            public SqlDataReader ID_USUARIO(dynamic Nombre_Usuario)
            {
                cmd.Connection = Usuario_Conexion.AbrirConexioBD();

                cmd.CommandText = "SP_OBTENER_ID_USUARIO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario",Nombre_Usuario);
                SqlDataReader id_usuario = cmd.ExecuteReader();

                cmd.Parameters.Clear();

                return id_usuario;

            }
        }

        public class Login
        {
            private Conexion LoginConexion = new Conexion();
            SqlCommand cmd = new SqlCommand();
            

            // METODO PARA VALIDAR EL INGREDO DE USUARIOS
            public SqlDataReader LoginValidar(dynamic LogUsarios, dynamic LogConstraseña)
            {
                /* Abrimos la conexion a la base de datos */
                cmd.Connection = LoginConexion.AbrirConexioBD();

                /* Indicasmos el nombre del procediiento almcacenado y el tipo de coandoa a ejecutar */
                cmd.CommandText = "SP_LOGIN";
                cmd.CommandType = CommandType.StoredProcedure;

                /* Pasamos los parametros al procedmiento almacenado */
                cmd.Parameters.AddWithValue("@Usuario", LogUsarios);
                cmd.Parameters.AddWithValue("@Constraseña", LogConstraseña);
                SqlDataReader valLogin = cmd.ExecuteReader();

                cmd.Parameters.Clear();

                return valLogin;
            }
        }

        public class Detalle_Usuario
        {
            private Conexion DU_Conn = new Conexion();
            SqlCommand cmd = new SqlCommand();

            public void Insertar_DU(int DU_IdUsuario, int DU_IdEmpresa)
            {
                cmd.Connection = DU_Conn.AbrirConexioBD();

                cmd.CommandText = "SP_CREAR_DETALLE_USUARIO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario", DU_IdUsuario);
                cmd.Parameters.AddWithValue("@IdEmpresa", DU_IdEmpresa);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                DU_Conn.CerrarConexionnBD();
            }

            public SqlDataReader Empresas_Usuarios(int DU_IdUsuario)
            {
                cmd.Connection = DU_Conn.AbrirConexioBD();
                cmd.CommandText = "SP_LISTAR_DETALLE_USUARIO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Usuario", DU_IdUsuario);
                SqlDataReader List_DU_IdUsuario = cmd.ExecuteReader();

                return List_DU_IdUsuario;
            }

        }

        public class Timbra
        {
            private Conexion GenRec_Conn = new Conexion();
            SqlCommand cmd = new SqlCommand();

            public SqlDataReader Gen_Recibo(
                dynamic Nom_Empleado,
                dynamic RFC_Empleado,
                DateTime Fecha_Emision,
                DateTime Fecha_Pago,
                DateTime Fecha_Inicial,
                DateTime Fecha_Final,
                int Dias_Pagados,
                double Percepciones,
                double Deducciones,
                double Otros_Pagos,
                double ISR,
                double Neto,
                int ID_Empresa)
            {
                cmd.Connection = GenRec_Conn.AbrirConexioBD();
                cmd.CommandText = "SP_GEN_RECIBO_NOM";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nom_Empleado", Nom_Empleado);
                cmd.Parameters.AddWithValue("@RFC_Empleado", RFC_Empleado);
                cmd.Parameters.AddWithValue("@Fecha_Emision", Fecha_Emision);
                cmd.Parameters.AddWithValue("@Fecha_Pago", Fecha_Pago);
                cmd.Parameters.AddWithValue("@Fecha_Inicial", Fecha_Final);
                cmd.Parameters.AddWithValue("@Fecha_Final", Fecha_Final);
                cmd.Parameters.AddWithValue("@Dias_Pagados", Dias_Pagados);
                cmd.Parameters.AddWithValue("@Percepciones", Percepciones);
                cmd.Parameters.AddWithValue("@Deducciones", Deducciones);
                cmd.Parameters.AddWithValue("@Otros_Pagos", Otros_Pagos);
                cmd.Parameters.AddWithValue("@ISR", ISR);
                cmd.Parameters.AddWithValue("@Neto", Neto);
                cmd.Parameters.AddWithValue("@ID_Empresa", ID_Empresa);

                SqlDataReader Id_Recibo = cmd.ExecuteReader();

                return Id_Recibo;
            }
        }
    }
}
