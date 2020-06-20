using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace RandsomNoteWriter
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        
        Random random = new Random();
        
        

        public List<string> GetFontFamilies()
        {
            List<string> fontfamilies = new List<string>();
            foreach (FontFamily family in FontFamily.Families)
            {
                fontfamilies.Add(family.Name);
            }
            return fontfamilies;

        }


        public int RandomNumber(int min, int max)
        {

            return random.Next(min, max);
        }

        private void ConvertClick(object sender, EventArgs e)
        {
            List<string> font_list = GetFontFamilies();
                
            for (int i = 0; i < (TextBox.Text.Length - 1); i++)
            {
                TextBox.SelectionStart = i;
                TextBox.SelectionLength = 1;
                TextBox.SelectionFont = new System.Drawing.Font(font_list[RandomNumber(0, (font_list.Count - 1))], 10);


            }
        }
    }

}
