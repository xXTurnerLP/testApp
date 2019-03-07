using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp {
    public partial class mainWindow : Form {
        long fbVal = 0, sbVal = 0;

        public mainWindow() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void firstBox_TextChanged(object sender, EventArgs e) {
            
        }

        private void secondBox_TextChanged(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                fbVal = Convert.ToInt64(firstBox.Text);
                sbVal = Convert.ToInt64(secondBox.Text);
                fbVal += sbVal;
                barProg();
                result.Text = fbVal.ToString();
            } catch { }
        }

        private void barProg() {
            progBar.Value = 0;
            for (int i = 0; i < 100; i++)
                progBar.Value += 1;
        }

        private void result_TextChanged(object sender, EventArgs e) {

        }        
    }
}
