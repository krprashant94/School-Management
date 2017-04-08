using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class TheamPack
    {
        Regedit reg = new Regedit();
        private string colorCode;
        public Color Black, Main, Gray, DimGray, DarkGray, Silver, White; 
        public TheamPack()
        {
            this.colorCode = reg.get("Theam", "Color").ToString();
            colorMaker();
        }
        void colorMaker()
        {
            Black = Color.Black;
            White = Color.White;
            switch (this.colorCode)
            {

                case "Black":
                    Gray = Color.Gray;
                    DimGray = Color.DimGray;
                    DarkGray = Color.DarkGray;
                    Silver = Color.Silver;
                    Main = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case "Purple":
                    Gray = Color.Purple;
                    DimGray = Color.DarkMagenta;
                    DarkGray = Color.MediumOrchid;
                    Silver = Color.Violet;
                    Main = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                    break;
                case "Green":
                    Gray = Color.Green;
                    DimGray = Color.DarkGreen;
                    DarkGray = Color.LimeGreen;
                    Silver = Color.Lime;
                    Main = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                    break;
                case "Teal":
                    Gray = Color.Teal;
                    DimGray = Color.DarkCyan;
                    DarkGray =Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); 
                    Silver = Color.LightSeaGreen;
                    Main = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    break;
                case "Maroon":
                    Gray = Color.Maroon;
                    DimGray = Color.DarkRed;
                    DarkGray = Color.Brown;
                    Silver = Color.IndianRed;
                    Main = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    break;
            }
        }
    }
}
