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
        List<OrbitAgenda.Appointment> listAppointments;

        public ucAgenda()
        {
            InitializeComponent();

            orbitAgenda.DaysToShow = 7;
            orbitAgenda.StartDate = DateTime.Now;
            orbitAgenda.StartHour = 8;
            orbitAgenda.AllowInplaceEditing = false;
        }

        public ucAgenda(DataTable dtAppointments)
        {
            InitializeComponent();

            orbitAgenda.DaysToShow = 7;
            orbitAgenda.StartDate = DateTime.Now;
            orbitAgenda.StartHour = 8;
            orbitAgenda.AllowInplaceEditing = false;
            listarAppointments(dtAppointments);

            orbitAgenda.ResolveAppointments += new OrbitAgenda.ResolveAppointmentsEventHandler(this.orbitAgenda_ResolveAppointments);
            orbitAgenda.SelectionChanged += new EventHandler(orbitAgenda_SelectionChanged);
        }

        public void listarAppointments(DataTable dt)
        { 
            listAppointments = new List<OrbitAgenda.Appointment>();

            foreach (DataRow dr in dt.Rows)
            {
                TimeSpan ts = new TimeSpan(0, 30, 0);
                OrbitAgenda.Appointment app = new OrbitAgenda.Appointment();
                app.StartDate = DateTime.Parse(dr["data"].ToString());
                app.EndDate = DateTime.Parse(dr["data"].ToString()) + ts;
                app.BorderColor = Color.Black;
                app.Title = dr["nome"].ToString();

                listAppointments.Add(app);

                orbitAgenda.Invalidate();
            }
        }

        private void orbitAgenda_ResolveAppointments(object sender, OrbitAgenda.ResolveAppointmentsEventArgs args)
        {
            List<OrbitAgenda.Appointment> lAppointments = new List<OrbitAgenda.Appointment>();

            foreach (OrbitAgenda.Appointment app in listAppointments)
            {
                if ((app.StartDate >= args.StartDate) &&
                    (app.StartDate <= args.EndDate))
                    lAppointments.Add(app);
                args.Appointments = lAppointments;
            }
        }

        private void orbitAgenda_SelectionChanged(object sender, EventArgs e)
        {

        }

    }
}
