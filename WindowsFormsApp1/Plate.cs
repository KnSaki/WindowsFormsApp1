using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Plate : UserControl {
        public Plate() {
            InitializeComponent();
        }

        public void Initialize(int maxNumber) {
            this.label1.Text = "";
            for (int i = 1; maxNumber <= i; ++i) {
                this.menuStrip1.Items.Add(Convert.ToString(i));
            }
        }

        public void Set(int num) {
            this.label1.Text = Convert.ToString(num);
        }

        private void Plate_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            this.menuStrip1.Visible = true;
        }
    }
}
