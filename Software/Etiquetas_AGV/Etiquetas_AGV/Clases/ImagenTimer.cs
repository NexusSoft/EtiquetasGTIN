using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using DevExpress.XtraEditors;
using CapaDeDatos;
using System.Linq;

namespace Etiquetas_AGV.Clases
{
    internal class ImagenTimer
    {
        private readonly System.Timers.Timer mostrar;
        private readonly System.Timers.Timer ocultar;
        private List<Image> images;
        private int currentIndex = 0;
        private Form currentImageForm;
        private int Aparecer;
        private int Desaparecer;

        public ImagenTimer()
        {
            CargarTiempos();
            mostrar = new System.Timers.Timer(Aparecer * 60 * 1000); // minutos
            ocultar = new System.Timers.Timer(Desaparecer * 1000); // segundos
            mostrar.Elapsed += ShowTimerElapsed;
            ocultar.Elapsed += HideTimerElapsed;
            LoadImagesFromDatabase();
        }

        private void CargarTiempos()
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            try
            {
                Clase.MtdSeleccionarTiempos();
                if (Clase.Exito)
                {
                    DataTable datos = Clase.Datos;
                    if (datos.Rows.Count > 0)
                    {
                        DataRow row = datos.Rows[0];
                        int retardoAparecer = Convert.ToInt32(row["Retardo_Aparecer_Segundos"]);
                        int retardoDesaparecer = Convert.ToInt32(row["Retardo_Desaparecer_Minutos"]);
                        Aparecer = retardoAparecer;
                        Desaparecer = retardoDesaparecer;
                    }
                    else
                    {
                        XtraMessageBox.Show("No se encontraron datos.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Error: " + Clase.Mensaje);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al cargar imágenes desde la base de datos: " + ex.Message);
            }
        }

        private void LoadImagesFromDatabase()
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            try
            {
                Clase.MtdSeleccionarImagen();
                if (Clase.Exito && Clase.Datos != null && Clase.Datos.Rows.Count > 0)
                {
                    var Arr = Clase.Datos.AsEnumerable()
                                        .Select(row => row.Field<byte[]>("BinImagen"))
                                        .ToArray();
                    images = Arr.Select(bytes => ByteArrayToImage(bytes)).ToList();
                    if (images.Count == 0)
                    {
                        XtraMessageBox.Show("No se encontraron imágenes en la base de datos.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se encontraron datos de imágenes en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al cargar las imágenes desde la base de datos: " + ex.Message);
            }
        }

        public void Start()
        {
            if (images != null && images.Count > 0)
            {
                mostrar.Start();
            }
            else
            {
                XtraMessageBox.Show("No hay imágenes para mostrar.");
            }
        }

        private void ShowTimerElapsed(object source, ElapsedEventArgs e)
        {
            mostrar.Stop();
            if (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].BeginInvoke(new Action(() =>
                {
                    if (currentImageForm == null)
                    {
                        ShowImage(images[currentIndex]);
                        ocultar.Start();
                    }
                }));
            }
        }

        private void HideTimerElapsed(object source, ElapsedEventArgs e)
        {
            ocultar.Stop();
            if (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].BeginInvoke(new Action(() =>
                {
                    if (currentImageForm != null)
                    {
                        currentImageForm.Close();
                        currentImageForm.Dispose();
                        currentImageForm = null;
                        currentIndex++;
                        if (currentIndex >= images.Count)
                        {
                            currentIndex = 0;
                            LoadImagesFromDatabase(); // Volver a consultar la base de datos para nuevas imágenes
                        }
                        mostrar.Start();
                    }
                }));
            }
        }

        private void ShowImage(Image image)
        {
            if (currentImageForm == null)
            {
                currentImageForm = new Form
                {
                    Text = "Imagen",
                    WindowState = FormWindowState.Maximized,
                    StartPosition = FormStartPosition.CenterScreen
                };

                PictureBox pb = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                };

                currentImageForm.Controls.Add(pb);
                currentImageForm.Show();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
