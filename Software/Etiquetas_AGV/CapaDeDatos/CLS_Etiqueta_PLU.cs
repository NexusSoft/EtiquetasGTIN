using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeDatos
{
    public class CLS_Etiqueta_PLU : ConexionBase
    {
        public string c_codigo_pal { get;  set; }
        public string c_codigo_pro { get;  set; }
        public string c_codigo_tem { get;  set; }
        public string c_codigo_dis { get; set; }
        public string c_codigo_sec { get; set; }
        public string c_codsec_pal { get;  set; }
        public string voice1 { get; set; }
        public string voice2 { get; set; }
        public string c_codigo_jul { get;  set; }
        public int? c_codigo_eti { get;  set; }

 
        public void MtdSeleccionarCodigoPLU()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaUPC_Select";
                _dato.CadenaTexto = c_codigo_tem;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_tem");
                _dato.CadenaTexto = c_codigo_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pal");
                _dato.CadenaTexto = c_codsec_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codsec_pal");
                _dato.CadenaTexto = c_codigo_dis;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_dis ");
                _dato.CadenaTexto = c_codigo_sec;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_sec");
                _dato.CadenaTexto = voice1;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "voice1");
                _dato.CadenaTexto = voice2;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "voice2");
                _dato.CadenaTexto = c_codigo_jul;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_jul");
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
