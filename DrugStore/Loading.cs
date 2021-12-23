using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
           
        }

        int count = 0;
       

        private void timer_image_Tick(object sender, EventArgs e)
        {

            if (count < 6)
            {
                pb_loading.Image = il_loading.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void loading_tm_Tick(object sender, EventArgs e)
        {
            pnl_loading.Width += 3;
            if (pnl_loading.Width >= 699)
            {
                loading_tm.Stop();
                Main m = new Main();
                m.FormClosed += (_sender, _e) => { Application.Exit(); };
                m.Show();
                this.Hide();
            }
        }
    }
}
