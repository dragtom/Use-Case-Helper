using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_helper
{
    public partial class frmMain : Form
    {
        //fields
        private List<Element> ElementList = new List<Element>();
        private Element selectedElement;

        //constructor
        public frmMain()
        {
            InitializeComponent();
        }
        //methods

        private void addElement(Point mouseLocation)
        {
            //check which element
            //create element and add it to listbox
            //selectElement
            //draw element
        }

        //windows-methods
        private void gbElements_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlDrawSpace_MouseClick(object sender, MouseEventArgs e)
        {
            //the panel is clicked!
            //get mouse locations;
            
            Point mouseLocation = PointToClient(Cursor.Position);
            //MessageBox.Show(mouseLocation.X + "," + mouseLocation.Y);
            //get which mode we are in;
            if (rbModeAdd.Checked)
            {
                addElement(mouseLocation);
            }
            else
            {
                //SelectElement
            }
        }
    }
}
