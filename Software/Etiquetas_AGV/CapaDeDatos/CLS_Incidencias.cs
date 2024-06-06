using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDeDatos
{
    public class CLS_Incidencias : ConexionBase
    {
        public string c_codigo_einc { get; set; }
        public string c_codigo_emp { get; set; }
        public int IdIncidencia { get; set; }
        public string Fecha { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }



        public void MtdSeleccionarInsidencias()
        {

            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "usp_Incidencias_Select";
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
        public void MtdInsertEmpleadoIncidencias()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_EmpleadosBono_Insert";
                _dato.CadenaTexto = c_codigo_einc;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_einc");
                _dato.CadenaTexto = c_codigo_emp;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_emp");
                _dato.Entero = IdIncidencia;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "IdIncidencia");
                _dato.CadenaTexto = Fecha;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "Fecha");
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
        public void MtdEliminarEmpleadoIncidencias()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_EmpleadosBono_Delete";
                _dato.CadenaTexto = c_codigo_einc;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_einc");
                
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
        public void MtdSeleccionarEmpleadoInsidencias()
        {

            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                
                _conexion.NombreProcedimiento = "SP_EmpleadosBono_Select";
                _dato.CadenaTexto = FechaInicio;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaInicio");
                _dato.CadenaTexto = FechaFin;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "FechaFin");
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
