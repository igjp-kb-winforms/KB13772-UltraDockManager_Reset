using Infragistics.Win.UltraWinDock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraDockManager_Reset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

			SuspendLayout();
			DockableControlPane panel1View =
			  new DockableControlPane("panel1", "パネル1", this.panel1);
			DockableControlPane panel2View =
			  new DockableControlPane("panel2", "パネル2", this.panel2);
			DockableControlPane panel3View =
			  new DockableControlPane("panel3", "パネル3", this.panel3);

			DockAreaPane dapLeft = new DockAreaPane(DockedLocation.DockedLeft);
			dapLeft.Panes.Add(panel1View);
			DockAreaPane dapBottom = new DockAreaPane(DockedLocation.DockedBottom);
			dapBottom.Panes.Add(panel2View);
			DockAreaPane dapRight = new DockAreaPane(DockedLocation.DockedRight);
			dapRight.Panes.Add(panel3View);

			this.ultraDockManager1.DockAreas.Add(dapLeft);
			this.ultraDockManager1.DockAreas.Add(dapBottom);
			this.ultraDockManager1.DockAreas.Add(dapRight);
			ResumeLayout();

			this.ultraDockManager1.SaveComponentSettings();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.ultraDockManager1.LoadComponentSettings();
		}
    }
}
