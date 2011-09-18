using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrbitControls.OrbitAgenda
{
    public interface ITool
    {
        OrbitAgenda OrbitAgenda
        {
            get;
            set;
        }

        void Reset();

        void MouseMove(MouseEventArgs e);
        void MouseUp(MouseEventArgs e);
        void MouseDown(MouseEventArgs e);
    }
}
