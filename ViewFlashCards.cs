using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanjayComSciIA
{
    public partial class ViewFlashCards : Form
    {
        public ViewFlashCards()
        {
            InitializeComponent();
        }

        private void ViewFlashCards_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
