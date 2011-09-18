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
            this.orbitAgenda1 = new OrbitControls.OrbitAgenda.OrbitAgenda();
            this.SuspendLayout();
            // 
            // orbitAgenda1
            // 
            drawTool1.OrbitAgenda = this.orbitAgenda1;
            this.orbitAgenda1.ActiveTool = drawTool1;
            this.orbitAgenda1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.orbitAgenda1.Location = new System.Drawing.Point(0, 4);
            this.orbitAgenda1.Name = "orbitAgenda1";
            this.orbitAgenda1.SelectionEnd = new System.DateTime(((long)(0)));
            this.orbitAgenda1.SelectionStart = new System.DateTime(((long)(0)));
            this.orbitAgenda1.Size = new System.Drawing.Size(904, 547);
            this.orbitAgenda1.StartDate = new System.DateTime(((long)(0)));
            this.orbitAgenda1.TabIndex = 0;
            this.orbitAgenda1.Text = "orbitAgenda1";
            // 
            // ucAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orbitAgenda1);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(907, 554);
            this.ResumeLayout(false);

        }

        #endregion

        private OrbitAgenda.OrbitAgenda orbitAgenda1;
    }
}
