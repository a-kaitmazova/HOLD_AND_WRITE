using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOLD_AND_WRITE
{
    public partial class HoldAndWrite : Form
    {
        public int fontSize;
        public string fontCurrent;

        public HoldAndWrite()
        {
            InitializeComponent();

            ProjectDirectoryView();

            fontSize = 12;
            fontCurrent = "";
        }

        public void ProjectDirectoryView()
        {

        }

        public void IncreaseFrontSize(object sender, EventArgs e) /* > */
        {
            Notepad.SelectionFont = new Font(fontCurrent, fontSize++);
            FrontSizeNumb.Text = fontSize.ToString();
        }
        
        public void ReduceFrontSize (object sender, EventArgs e) /* < */
        {
            Notepad.SelectionFont = new Font(fontCurrent, fontSize--);
            FrontSizeNumb.Text = fontSize.ToString();
        }

        public void Front_TimesNewRoman (object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font("Times New Roman", fontSize);
            fontCurrent = "Times New Roman";
        } 

        public void Front_Impact (object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font("Impact", fontSize);
            fontCurrent = "Impact";
        }

        public void Front_SimSim (object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font("SimSim", fontSize);
            fontCurrent = "SimSim";
        }

        public void Front_Standart (object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font("Segoe UI", fontSize);
            fontCurrent = "Segoe UI";
        }
        public void RegularFront(object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font(fontCurrent, fontSize, FontStyle.Regular);
        }

        public void BoldFront (object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font(fontCurrent, fontSize, FontStyle.Bold);
        }

        public void ItalicFront(object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font(fontCurrent, fontSize, FontStyle.Italic);
        }

        public void StripFront(object sender, EventArgs e)
        {
            Notepad.SelectionFont = new Font(fontCurrent, fontSize, FontStyle.Underline);
        }

    }
}
