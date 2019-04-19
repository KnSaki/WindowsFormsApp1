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
    public partial class Base : UserControl {
        public Base() {
            InitializeComponent();

            int i = 1;
            foreach(var plate in this.Controls.OfType<Plate>().OrderBy(s=>s.Name)) {
                plate.Initialize(6);
                plate.Set(i);
                ++i;
            }
        }
    }
}
