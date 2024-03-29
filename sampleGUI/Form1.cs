﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            ToolTip Aciklama = new ToolTip();
            Aciklama.ToolTipTitle = "Dikkat!";
            Aciklama.ToolTipIcon = ToolTipIcon.Warning;
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(button1, "Form ekranina gitmek icin tiklayiniz");
            Aciklama.SetToolTip(button2, "Marker ekranina gitmek icin tiklayiniz");
            Aciklama.SetToolTip(button3, "Baseline ekranina gitmek icin tiklayiniz");

            // Aciklama.SetToolTip(label1, "İstediğiniz kadar açıklama ekleyebilirsiniz..");

        }


        public void ButtonTransparent(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

      

        public void AllButtonsTransparent()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ButtonTransparent((Button)ctrl);
                }
            }
        }

         
        private void button1_Click(object sender, EventArgs e)
        {

            /// panel içinde baslat

            panelOrta.Controls.Clear();
            AnketForm anketForm = new AnketForm();
            anketForm.TopLevel = false;
            panelOrta.Controls.Add(anketForm);
            anketForm.Show();

            anketForm.Dock = DockStyle.Fill;
            anketForm.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelOrta.Controls.Clear();
            PythonMarkerForm pythonMarker = new PythonMarkerForm();
            pythonMarker.TopLevel = false;
            panelOrta.Controls.Add(pythonMarker);
            pythonMarker.Show();

            pythonMarker.Dock = DockStyle.Fill;
            pythonMarker.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// panel içinde baslat

            panelOrta.Controls.Clear();
            Baseline bsline = new Baseline();
            bsline.TopLevel = false;
            panelOrta.Controls.Add(bsline);
            bsline.Show();

            bsline.Dock = DockStyle.Fill;
            bsline.BringToFront();

            /////////////////////////////////

            altPanel.BackColor = Color.Transparent;
            ustPanel.BackColor = Color.Transparent;

        }
    }
}
