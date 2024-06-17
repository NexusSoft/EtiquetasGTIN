using CapaDeDatos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
            CargarImagnes();
            CargarTiempos();
        }

        private void CargarImagnes()
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
                        byte[] binImagen = (byte[])row["BinImagen"];

                        try
                        {
                            using (MemoryStream ms = new MemoryStream(binImagen))
                            {
                                Image image = Image.FromStream(ms);
                                imageList1.Images.Add(image);
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
                XtraMessageBox.Show("Error al cargar imágenes desde la base de datos: " + ex.Message);
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
                    CargarImagnes();
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

        private void btn_Guadar_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; 
            openFileDialog.Title = "Seleccione una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombreArchivo = Path.GetFileName(openFileDialog.FileName); 
                    byte[] imagenBytes = File.ReadAllBytes(openFileDialog.FileName);
                    string base64String = Convert.ToBase64String(imagenBytes);
                    CLS_Imagenes Clase = new CLS_Imagenes();
                    Clase.nombre = nombreArchivo;
                    Clase.bin_imagen = base64String;
                    Clase.MtdInsertarImagen();
                    if (Clase.Exito)
                    {
                        
                        XtraMessageBox.Show("Se ha Insertado el registro con exito");
                        CargarImagnes();
                    }
                    else
                    {
                        XtraMessageBox.Show(Clase.Mensaje);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar la imagen: " + ex.Message);
                }
            }
        }


        private void btn_Eliminar_Imagen_Click(object sender, EventArgs e)
        {
            if (Lista_imagenes.SelectedIndex != -1)
            {
                var selectedItem = Lista_imagenes.SelectedItem;
                if (selectedItem is DevExpress.XtraEditors.Controls.ImageListBoxItem selectedImage)
                {
                    int idImagen = (int)selectedImage.Value;
                    BorrarImagenDeBaseDeDatos(idImagen);
                    CargarImagnes();
                }
                else
                {
                    XtraMessageBox.Show("El elemento seleccionado no es válido.");
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor, seleccione una imagen para borrar.");
            }

        }

        private void BorrarImagenDeBaseDeDatos(int idImagen)
        {
            CLS_Imagenes Clase = new CLS_Imagenes();
            Clase.id = idImagen;
            Clase.MtdEliminarImagen();
            if (Clase.Exito)
            {
                XtraMessageBox.Show("Imagen eliminada exitosamente.");
            }
            else
            {
                XtraMessageBox.Show("Error al eliminar la imagen: " + Clase.Mensaje);
            }
        }

 
    }

    public class ImageListBoxItem : ImageComboBoxItem
    {

        public int Id { get; set; }

        public ImageListBoxItem(int imageIndex, int id, string description)
            : base(description, imageIndex, imageIndex)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"{base.Description} (ID: {Id})";
        }
        public int GetId()
        {
            return Id;
        }

    }
}