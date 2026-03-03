using PictureBoxExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExercise
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Boy";
            pbPhoto.Image = Resources.Boy;
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Girl";
            pbPhoto.Image = Resources.Girl;
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Book";
            pbPhoto.Image = Resources.Book;
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Pen";
            pbPhoto.Image = Resources.Pen;
        }
    }
}
