namespace OrbitControls
{
    partial class ucAgenda
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrbitControls.OrbitAgenda.DrawTool drawTool1 = new OrbitControls.OrbitAgenda.DrawTool();
            this.orbitAgenda = new OrbitControls.OrbitAgenda.OrbitAgenda();
            this.SuspendLayout();
            // 
            // orbitAgenda
            // 
            drawTool1.OrbitAgenda = this.orbitAgenda;
            this.orbitAgenda.ActiveTool = drawTool1;
            this.orbitAgenda.AllowScroll = false;
            this.orbitAgenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orbitAgenda.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.orbitAgenda.Location = new System.Drawing.Point(0, 0);
            this.orbitAgenda.Name = "orbitAgenda";
            this.orbitAgenda.SelectionEnd = new System.DateTime(((long)(0)));
            this.orbitAgenda.SelectionStart = new System.DateTime(((long)(0)));
            this.orbitAgenda.Size = new System.Drawing.Size(930, 560);
            this.orbitAgenda.StartDate = new System.DateTime(((long)(0)));
            this.orbitAgenda.TabIndex = 0;
            this.orbitAgenda.Text = "orbitAgenda";
            this.orbitAgenda.SelectionChanged += new System.EventHandler(this.orbitAgenda_SelectionChanged);
            this.orbitAgenda.ResolveAppointments += new OrbitControls.OrbitAgenda.ResolveAppointmentsEventHandler(this.orbitAgenda_ResolveAppointments);
            // 
            // ucAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orbitAgenda);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(930, 560);
            this.ResumeLayout(false);

        }

        #endregion

        private OrbitAgenda.OrbitAgenda orbitAgenda;
    }
}
