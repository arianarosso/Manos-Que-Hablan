﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manos_que_Hablan
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIraKinect_Click(object sender, EventArgs e)
        {
            KinectStream kinect = new KinectStream();
            kinect.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
