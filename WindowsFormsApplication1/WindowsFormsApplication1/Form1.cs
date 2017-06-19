using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Button buton = new Button();
            buton.Width = 100;
            buton.Height = 30;
            buton.Text="Kaydet";
            this.Controls.Add(buton);
            buton.Location = new System.Drawing.Point(125, 215);
            
            createLabel(new Label(), "Ad:", 55, 46, 19);
            createLabel(new Label(), "Soyad:",55, 46, 59);
            createLabel(new Label(), "Tc Kimlik:",55, 46, 102);
            createLabel(new Label(), "Cinsiyet:",55, 46, 145);
            createLabel(new Label(), "Okul:", 55,46, 185);

            TextBox txt1 = new TextBox();
            TextBox txt2 = new TextBox();
            TextBox txt3 = new TextBox();
            TextBox txt4 = new TextBox();
            TextBox txt5 = new TextBox();
            TextBox(txt1,125, 12);
            TextBox(txt2,125,53);
            TextBox(txt3,125,96);
            TextBox(txt4,125,136);
            TextBox(txt5,125,179);
        }

        private void createLabel(Label lbl ,string lblText, int lblWidth,int lblX, int lblY)
        {
            lbl.Width = lblWidth;
            lbl.Text = lblText;
            lbl.Location = new System.Drawing.Point(lblX, lblY);
            this.Controls.Add(lbl);
        }

        private void TextBox(TextBox txt, int txtX, int txtY)
        {
            txt.Location = new System.Drawing.Point(txtX,txtY);
            this.Controls.Add(txt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      }
}
