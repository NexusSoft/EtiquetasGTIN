using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using DevExpress.XtraEditors;
using CapaDeDatos;

using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace Etiquetas_AGV.Clases
{
    internal class ImagenTimer
    {
        private readonly System.Timers.Timer mostrar;
        private readonly System.Timers.Timer ocultar;
        private List<byte[]> archivosBinarios;
        private List<string> tiposArchivos;
        private int currentIndex = 0;
        private Form currentMediaForm;
        private int Aparecer;
        private int Desaparecer;
        private LibVLC libVLC;
        private LibVLCSharp.Shared.MediaPlayer mediaPlayer;

        public ImagenTimer()
        {
            var libvlcPath = @"C:\Program Files\VideoLAN\VLC";
            Core.Initialize(libvlcPath);
            libVLC = new LibVLC();
            CargarTiempos(); 
            mostrar = new System.Timers.Timer(Aparecer * 60 * 1000); 
            ocultar = new System.Timers.Timer(Desaparecer * 1000); 
            mostrar.Elapsed += ShowTimerElapsed;
            ocultar.Elapsed += HideTimerElapsed;
            LoadMediaFromDatabase();
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
                        Aparecer = Convert.ToInt32(row["Retardo_Aparecer_Segundos"]);
                        Desaparecer = Convert.ToInt32(row["Retardo_Desaparecer_Minutos"]);

                    }
                }
                else
                {
                    XtraMessageBox.Show("Error: " + Clase.Mensaje);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al cargar los tiempos: " + ex.Message);
            }
        }

        private void LoadMediaFromDatabase()
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            try
            {
                Clase.MtdSeleccionarImagen();
                if (Clase.Exito && Clase.Datos != null && Clase.Datos.Rows.Count > 0)
                {
                    archivosBinarios = new List<byte[]>();
                    tiposArchivos = new List<string>();

                    foreach (DataRow row in Clase.Datos.Rows)
                    {
                        if (row["Bin_Imagen"] != DBNull.Value)
                        {
                            archivosBinarios.Add((byte[])row["Bin_Imagen"]);
                            tiposArchivos.Add("imagen");
                        }
                        else if (row["Bin_Video"] != DBNull.Value)
                        {
                            archivosBinarios.Add((byte[])row["Bin_Video"]);
                            tiposArchivos.Add("video");
                        }
                    }

                    if (archivosBinarios.Count == 0)
                    {
                        XtraMessageBox.Show("No se encontraron archivos multimedia en la base de datos.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se encontraron datos multimedia en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al cargar los archivos multimedia desde la base de datos: " + ex.Message);
            }
        }

        public void Start()
        {
            if (archivosBinarios != null && archivosBinarios.Count > 0)
            {
                mostrar.Start();
            }
            else
            {
                XtraMessageBox.Show("No hay archivos multimedia para mostrar.");
            }
        }

        private void ShowTimerElapsed(object source, ElapsedEventArgs e)
        {
            mostrar.Stop();
            if (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].BeginInvoke(new Action(() =>
                {
                    if (currentMediaForm == null)
                    {
                        string tipoArchivo = tiposArchivos[currentIndex];
                        byte[] archivoBinario = archivosBinarios[currentIndex];

                        if (tipoArchivo == "imagen")
                        {
                            ShowImage(ByteArrayToImage(archivoBinario));
                            ocultar.Interval = Desaparecer * 1000; 
                            ocultar.Start();
                        }
                        else if (tipoArchivo == "video")
                        {
                            ShowVideo(archivoBinario);
                            
                            ocultar.Stop();
                        }
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
                    if (currentMediaForm != null)
                    {
                        currentMediaForm.Close();
                        currentMediaForm.Dispose();
                        currentMediaForm = null;
                        currentIndex++;
                        if (currentIndex >= archivosBinarios.Count)
                        {
                            currentIndex = 0;
                            LoadMediaFromDatabase();
                        }
                        mostrar.Start();
                    }
                }));
            }
        }

        private void ShowImage(Image image)
        {
            if (currentMediaForm == null)
            {
                currentMediaForm = new Form
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

                currentMediaForm.Controls.Add(pb);
                currentMediaForm.Show();
            }
        }

        private void ShowVideo(byte[] videoBytes)
        {
            if (currentMediaForm == null)
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), "tempVideo.mp4");
                File.WriteAllBytes(tempFilePath, videoBytes);

                currentMediaForm = new Form
                {
                    Text = "Video",
                    WindowState = FormWindowState.Maximized,
                    StartPosition = FormStartPosition.CenterScreen
                };

                mediaPlayer = new MediaPlayer(libVLC);
                var videoView = new VideoView
                {
                    Dock = DockStyle.Fill,
                    MediaPlayer = mediaPlayer
                };
                currentMediaForm.Controls.Add(videoView);
                currentMediaForm.Show();

                var media = new Media(libVLC, tempFilePath, FromType.FromPath);
                mediaPlayer.Play(media);
                mostrar.Stop();

                mediaPlayer.EndReached += (sender, e) =>
                {
                    
                    if (currentMediaForm != null)
                    {
                        currentMediaForm.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                if (currentMediaForm != null)
                                {
                                    currentMediaForm.Close();
                                    currentMediaForm.Dispose();
                                    currentMediaForm = null;
                                    mostrar.Start();
                                }
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show("Error al cerrar el formulario del video: " + ex.Message);
                            }
                        }));
                    }
                };
                System.Windows.Forms.Timer videoDurationTimer = new System.Windows.Forms.Timer();
                videoDurationTimer.Interval = 100; 
                videoDurationTimer.Tick += (sender, e) =>
                {
                    if (mediaPlayer.Length > 0)
                    {
                        videoDurationTimer.Stop();
                        long videoDuration = mediaPlayer.Length; 
                        if (videoDuration > 0)
                        {
                            ocultar.Interval = videoDuration;
                            ocultar.Start();
                        }
                        else
                        {
                            XtraMessageBox.Show("No se pudo obtener la duración del video.");
                        }
                    }
                };
                videoDurationTimer.Start();
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
