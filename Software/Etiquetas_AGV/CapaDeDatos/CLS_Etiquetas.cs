using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDeDatos
{
    public class CLS_Etiquetas: ConexionBase
    {
        public string c_codigo_pal { get;  set; }
        public string c_codigo_pro { get;  set; }
        public string c_codigo_tem { get;  set; }
        public string c_codsec_pal { get;  set; }
        public string c_codigo_jul { get;  set; }

        public void MtdSeleccionarEtiquetas()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_Etiquetas_Select";
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
        public void MtdSeleccionarPaletCodigo()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaCodigoBarra_Select";
                _dato.CadenaTexto = c_codigo_tem;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_tem");
                _dato.CadenaTexto = c_codigo_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pal");
                _dato.CadenaTexto = c_codsec_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codsec_pal");
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
        public void MtdSeleccionarPaletCodigoUPC()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaUPCCodigoBarra_Select";
                _dato.CadenaTexto = c_codigo_pro;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pro");
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
        public void MtdSeleccionarPaletCodigoJuliana()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaJulianaCodigoBarra_Select";
                _dato.CadenaTexto = c_codigo_tem;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_tem");
                _dato.CadenaTexto = c_codigo_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pal");
                _dato.CadenaTexto = c_codsec_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codsec_pal");
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
