﻿using System;
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
        }
    }
}
