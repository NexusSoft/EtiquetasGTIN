using CapaDeDatos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Etiquetas_AGV.Formularios.Rendimiento
{
    public partial class Frm_Avisos : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Avisos m_FormDefInstance;
        public string c_codigo_usu { get; set; }

        public static Frm_Avisos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Avisos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_Avisos()
        {
            InitializeComponent();
            CargarArchivos(); 
            CargarTiempos();
           

        }

        private void CargarArchivos() 
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            try
            {
                Clase.MtdSeleccionarImagen();
                if (Clase.Exito)
                {
                    DataTable datos = Clase.Datos;
                    imageList1.Images.Clear();
                    Lista_imagenes.Items.Clear();
 
                    foreach (DataRow row in datos.Rows)
                    {
                        int id = Convert.ToInt32(row["Id"]);
                        string nombre = row["nombre"].ToString();
                        string tipoArchivo = row["tipo_archivo"].ToString();

                        if (tipoArchivo == "imagen")
                        {
                            if (row["Bin_Imagen"] != DBNull.Value)  
                            {
                                byte[] binImagen = (byte[])row["Bin_Imagen"];
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream(binImagen))
                                    {
                                        Image image = Image.FromStream(ms);
                                        Image thumbnail = image.GetThumbnailImage(64, 64, null, IntPtr.Zero);
                                        imageList1.Images.Add(thumbnail);
                                        DevExpress.XtraEditors.Controls.ImageListBoxItem item = new DevExpress.XtraEditors.Controls.ImageListBoxItem();
                                        item.ImageIndex = imageList1.Images.Count - 1;
                                        item.Value = id;
                                        item.Description = nombre;
                                        Lista_imagenes.Items.Add(item);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    XtraMessageBox.Show("Error al cargar la imagen: " + ex.Message);
                                }
                            }
                        }
                        else if (tipoArchivo == "video")
                        {
                            if (row["Bin_Video"] != DBNull.Value)  
                            {
                                
                                byte[] binVideo = Properties.Resources.images;
                                using (MemoryStream ms = new MemoryStream(binVideo))
                                {
                                    Image image = Image.FromStream(ms);
                                    imageList1.Images.Add(image);
                                    DevExpress.XtraEditors.Controls.ImageListBoxItem item = new DevExpress.XtraEditors.Controls.ImageListBoxItem();
                                    item.ImageIndex = imageList1.Images.Count - 1;
                                    item.Value = id;
                                    item.Description = nombre + " (Video)";
                                    Lista_imagenes.Items.Add(item);
                                }
                            }
                        }
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

                        text_Aparecer.Text = retardoAparecer.ToString();
                        text_Desaparecer.Text = retardoDesaparecer.ToString();
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
                XtraMessageBox.Show("Error al cargar tiempos desde la base de datos: " + ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int TAparecer = Convert.ToInt32(text_Aparecer.Text);
                int TDesaparecer = Convert.ToInt32(text_Desaparecer.Text);

                CLS_Imagenes Clase = new CLS_Imagenes();
                Clase.desaparecer = TDesaparecer;
                Clase.aparecer = TAparecer;

                Clase.MtdUpdateTiempo();

                if (Clase.Exito)
                {
                    XtraMessageBox.Show("Tiempos actualizados");
                    CargarArchivos();
                    CargarTiempos();
                }
                else
                {
                    XtraMessageBox.Show("Error: " + Clase.Mensaje);
                }
            }
            catch (FormatException)
            {
                XtraMessageBox.Show("Por favor ingrese valores numéricos válidos para Aparecer y Desaparecer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BorrarArchivoDeBaseDeDatos(int idArchivo)
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            Clase.id = idArchivo;
            Clase.MtdEliminarImagen();
            if (Clase.Exito)
            {
                XtraMessageBox.Show("Archivo eliminado exitosamente.");
            }
            else
            {
                XtraMessageBox.Show("Error al eliminar el archivo: " + Clase.Mensaje);
            }
        }
        private void Lista_imagenes_DoubleClick(object sender, EventArgs e)
        {
            if (Lista_imagenes.SelectedIndex != -1)
            {
                var selectedItem = Lista_imagenes.SelectedItem;
                if (selectedItem is DevExpress.XtraEditors.Controls.ImageListBoxItem selectedArchivo)
                {
                    int idArchivo = (int)selectedArchivo.Value;
                    MostrarArchivo(idArchivo);
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor, seleccione un archivo.");
            }
        }

        private void MostrarArchivo(int idArchivo)
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            Clase.id = idArchivo;
            Clase.MtdSeleccionarImagenPorId(idArchivo);

            if (Clase.Exito && Clase.Datos.Rows.Count > 0)
            {
                DataRow row = Clase.Datos.Rows[0];
                string tipoArchivo = row["tipo_archivo"].ToString();

                if (tipoArchivo == "imagen")
                {
                    if (row["Bin_Imagen"] != DBNull.Value)
                    {
                        byte[] binImagen = (byte[])row["Bin_Imagen"];
                        MostrarImagen(binImagen);
                    }
                }
                else if (tipoArchivo == "video")
                {
                    if (row["Bin_Video"] != DBNull.Value)
                    {
                        byte[] binVideo = (byte[])row["Bin_Video"];
                        MostrarVideo(binVideo);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Error al cargar el archivo.");
            }
        }

        private void MostrarImagen(byte[] imagenBytes)
        {
            using (MemoryStream ms = new MemoryStream(imagenBytes))
            {
                Image image = Image.FromStream(ms);
                Form imageForm = new Form
                {
                    Text = "Imagen",
                    WindowState = FormWindowState.Maximized,
                    StartPosition = FormStartPosition.CenterScreen
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                };

                imageForm.Controls.Add(pictureBox);
                imageForm.ShowDialog();
            }
        }
        private void MostrarVideo(byte[] videoBytes)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "tempVideo.mp4");
            File.WriteAllBytes(tempFilePath, videoBytes);

            Form videoForm = new Form
            {
                Text = "Video",
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterScreen
            };

            var libVLC = new LibVLC();
            MediaPlayer mediaPlayer = new MediaPlayer(libVLC);
            VideoView videoView = new VideoView
            {
                Dock = DockStyle.Fill,
                MediaPlayer = mediaPlayer
            };
            videoForm.Controls.Add(videoView);

            Panel controlPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60 
            };
            videoForm.Controls.Add(controlPanel);

            Button playButton = new Button { Text = "Play", Width = 75, Left = 10, Top = 30 };
            Button pauseButton = new Button { Text = "Pause", Width = 75, Left = 90, Top = 30 };
            Button stopButton = new Button { Text = "Stop", Width = 75, Left = 170, Top = 30 };

            controlPanel.Controls.Add(playButton);
            controlPanel.Controls.Add(pauseButton);
            controlPanel.Controls.Add(stopButton);

            TrackBar trackBar = new TrackBar
            {
                Dock = DockStyle.Top, 
                Minimum = 0,
                Maximum = 1000, 
                Height = 30,
                TickStyle = TickStyle.None
            };
            controlPanel.Controls.Add(trackBar); 

            playButton.Click += (sender, e) => mediaPlayer.Play(new Media(libVLC, tempFilePath, FromType.FromPath));

            pauseButton.Click += (sender, e) => mediaPlayer.Pause();

            stopButton.Click += (sender, e) => mediaPlayer.Stop();

            mediaPlayer.TimeChanged += (sender, e) =>
            {
                videoForm.BeginInvoke(new Action(() =>
                {
                    if (mediaPlayer.Length > 0)
                    {
                        trackBar.Value = (int)(1000 * mediaPlayer.Time / mediaPlayer.Length);
                    }
                }));
            };

            trackBar.Scroll += (sender, e) =>
            {
                if (mediaPlayer.Length > 0)
                {
                    mediaPlayer.Time = (long)(mediaPlayer.Length * trackBar.Value / 1000); 
                }
            };

            videoForm.Show();

            mediaPlayer.EndReached += (sender, e) =>
            {
                videoForm.BeginInvoke(new Action(() =>
                {
                    mediaPlayer.Stop();
                    mediaPlayer.Dispose();
                    videoForm.Close();
                }));
            };

            videoForm.FormClosing += (sender, e) =>
            {
                mediaPlayer.Stop();
                mediaPlayer.Dispose();
                videoView.Dispose();
            };
        }
        private void btn_Guadar_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos multimedia|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.mp4;*.avi;*.mov;*.wmv";
            openFileDialog.Title = "Seleccione una imagen o video";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombreArchivo = Path.GetFileName(openFileDialog.FileName);
                    string extension = Path.GetExtension(openFileDialog.FileName).ToLower();
                    CLS_Imagenes Clase = new CLS_Imagenes();

                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp")
                    {
                        byte[] imagenBytes = File.ReadAllBytes(openFileDialog.FileName);
                        string base64String = Convert.ToBase64String(imagenBytes);
                        Clase.bin_imagen = base64String;
                        Clase.tipo_archivo = "imagen";
                    }
                    else if (extension == ".mp4" || extension == ".avi" || extension == ".mov" || extension == ".wmv")
                    {
                        byte[] videoBytes = File.ReadAllBytes(openFileDialog.FileName);
                        string base64String = Convert.ToBase64String(videoBytes);
                        Clase.bin_video = base64String;
                        Clase.tipo_archivo = "video";
                    }
                    else
                    {
                        XtraMessageBox.Show("Formato no soportado.");
                        return;
                    }

                    Clase.nombre = nombreArchivo;
                    Clase.MtdInsertarImagen();
                    if (Clase.Exito)
                    {
                        XtraMessageBox.Show("Archivo insertado con éxito");
                        CargarArchivos();
                    }
                    else
                    {
                        XtraMessageBox.Show(Clase.Mensaje);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el archivo: " + ex.Message);
                }
            }
        }

        private void btn_Eliminar_Imagen_Click(object sender, EventArgs e)
        {
            if (Lista_imagenes.SelectedIndex != -1)
            {
                var selectedItem = Lista_imagenes.SelectedItem;
                if (selectedItem is DevExpress.XtraEditors.Controls.ImageListBoxItem selectedArchivo)
                {
                    int idArchivo = (int)selectedArchivo.Value;
                    BorrarArchivoDeBaseDeDatos(idArchivo);
                    CargarArchivos();
                }
                else
                {
                    XtraMessageBox.Show("El elemento seleccionado no es válido.");
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor, seleccione un archivo para borrar.");
            }
        }

        
    }



    public class ImageListBoxItem : ImageComboBoxItem
    {
        public int Id { get; set; }
        public ImageListBoxItem(int imageIndex, int id, string description)
            : base(description, imageIndex) 
        {
            Id = id;
            ImageIndex = imageIndex;
        }

        
        public override string ToString()
        {
            return $"{Description} (ID: {Id})";
        }

        public int GetId()
        {
            return Id;
        }
    }

}