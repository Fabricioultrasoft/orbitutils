/* OrbitAgenda adapted from the Agenda Project of Ertan Tike */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OrbitControls
{
    public partial class ucAgenda : UserControl
    {
        public ucAgenda()
        {
            InitializeComponent();

            orbitAgenda.DaysToShow = 7;
            orbitAgenda.StartDate = DateTime.Now;
            orbitAgenda.StartHour = 8;
        }
    }
}
