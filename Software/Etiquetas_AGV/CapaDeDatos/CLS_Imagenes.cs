using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDeDatos
{
    public class CLS_Imagenes : ConexionBase 
    {
        public string nombre {  get; set; }
        public string bin_imagen { get; set; }
        public int id { get; set; }
        public int aparecer { get; set; }
        public int desaparecer { get; set; }
        public string bin_video { get; set; }
        public string tipo_archivo { get; set; }
        public void MtdSeleccionarImagen()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Avisos_Imagenes_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
        public void MtdInsertarImagen()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {

                if (tipo_archivo == "imagen")
                {
                    _conexion.NombreProcedimiento = "SP_Avisos_Imagenes_Insert";
                    _dato.CadenaTexto = nombre;
                    _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "nombre");
                    _dato.CadenaTexto = bin_imagen;
                    _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "base64_imagen");
                    _dato.CadenaTexto = tipo_archivo;
                    _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "tipo_archivo");


                    _conexion.EjecutarDataset();

                    if (_conexion.Exito)
                    {
                        Datos = _conexion.Datos;
                    }
                    else
                    {
                        Mensaje = _conexion.Mensaje;
                        Exito = false;
                    }

                }else
                {
                    _conexion.NombreProcedimiento = "SP_Avisos_Video_Insert";
                    _dato.CadenaTexto = nombre;
                    _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "nombre");
                    _dato.CadenaTexto = bin_video;
                    _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "base64_video");
                    _dato.CadenaTexto = tipo_archivo;
                    _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "tipo_archivo");


                    _conexion.EjecutarDataset();

                    if (_conexion.Exito)
                    {
                        Datos = _conexion.Datos;
                    }
                    else
                    {
                        Mensaje = _conexion.Mensaje;
                        Exito = false;
                    }

                }
               
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdEliminarImagen()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Avisos_Imagenes_Delete";
                _dato.Entero = id;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "id");
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }

        public void MtdSeleccionarTiempos()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tiempo_Imagenes_Select";
                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }

        }
        public void MtdSeleccionarImagenPorId(int id)
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion); // Aquí debes asegurarte de usar la cadena de conexión adecuada
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Seleccionar_Imagen_Por_Id"; // Asegúrate de tener el nombre correcto del procedimiento almacenado o la consulta
                _dato.Entero = id;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Id");
                _conexion.EjecutarDataset();
                Datos = _conexion.Datos;
            }
            catch (Exception ex)
            {
                Exito = false;
                Mensaje = ex.Message;
            }
        }
        public void MtdUpdateTiempo()
        {
            TipoDato _dato = new TipoDato();
            Conexion _conexion = new Conexion(cadenaConexion);

            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Tiempo_Imagenes_Update";
                _dato.Entero = desaparecer;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Retardo_Desaparecer_Minutos");
                _dato.Entero = aparecer;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "Retardo_Aparecer_Segundos");


                _conexion.EjecutarDataset();

                if (_conexion.Exito)
                {
                    Datos = _conexion.Datos;
                }
                else
                {
                    Mensaje = _conexion.Mensaje;
                    Exito = false;
                }
            }
            catch (Exception e)
            {
                Mensaje = e.Message;
                Exito = false;
            }
        }
    }
}
