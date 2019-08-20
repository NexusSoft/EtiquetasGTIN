﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using iTextSharp.text.pdf;

namespace EtiquetasGTIN
{
    class Codigos
    {
        public static Bitmap Codigos128(string _Code, Boolean vertexto = false, Single Height = 0)
        {
            Barcode128 barcode = new Barcode128();
            
            if (Height != 0)
            {
                barcode.BarHeight = Height;
            }

            barcode.Code = _Code;
            try
            {

                Bitmap bm = new Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White));
                if (vertexto == false)
                {
                    return bm;
                }
                else
                {
                    Bitmap bmT = new Bitmap(bm.Width, bm.Height + 14);
                    Graphics g = Graphics.FromImage(bmT);
                    g.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 14);

                    Font pintarTexto = new Font("Arial", 8);
                    SolidBrush brocha = new SolidBrush(Color.Black);

                    SizeF stringSize = new SizeF();
                    stringSize = g.MeasureString(_Code, pintarTexto);
                    Single centrox = (bm.Width - stringSize.Width) / 2;
                    Single x = centrox;
                    Single y = bm.Height;

                    StringFormat drawformat = new StringFormat();
                    drawformat.FormatFlags = StringFormatFlags.NoWrap;
                    g.DrawImage(bm, 0, 0);

                    String ncode = _Code.Substring(0, _Code.Length);
                    g.DrawString(ncode, pintarTexto, brocha, x, y, drawformat);
                    return bmT;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el codigo" + ex.ToString());
            }
        }
    }
}
