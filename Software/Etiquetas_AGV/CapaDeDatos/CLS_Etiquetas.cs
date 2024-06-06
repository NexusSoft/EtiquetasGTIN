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
        public int? c_codigo_eti { get;  set; }
        public string d_empaque_eti { get; set; }

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
        public void MtdSeleccionarEtiquetasDist()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_Etiqueta_distribuidor_Select";
                _dato.Entero = c_codigo_eti;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "c_codigo_eti");
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
        public void MtdSeleccionarPaletMarmaCodigo()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaCodigoBarra_MARMA_Select";
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
        public void MtdSeleccionarPaletCodigoSAMS()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaCodigoBarra_SAMS_Select";
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
        public void MtdSeleccionarPaletCodigoEAN13()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaEAN13CodigoBarra_Select";
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
        public void MtdSeleccionarExisteImportador()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_ExisteImportador_Select";
                _dato.Entero = c_codigo_eti;
                _conexion.agregarParametro(EnumTipoDato.Entero, _dato, "c_codigo_eti");
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
        public void MtdUpdateFechaPalet()
        {
            TipoDato _dato = new TipoDato();
            Exito = true;
            try
            {
                _conexion.NombreProcedimiento = "SP_Eti_EtiquetaFecha_Update";
                _dato.CadenaTexto = c_codigo_tem;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_tem");
                _dato.CadenaTexto = c_codigo_pal;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "c_codigo_pal");
                _dato.CadenaTexto = d_empaque_eti;
                _conexion.agregarParametro(EnumTipoDato.CadenaTexto, _dato, "d_empaque_eti");
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
