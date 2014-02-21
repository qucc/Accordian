using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accordian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
 
            InitializeComponent();
      
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accordianPanel1.addSection("1",  GetDummyPanel());
            accordianPanel1.addSection("2",  GetDummyPanel());
            accordianPanel1.addSection("3",  GetDummyPanel());
            accordianPanel1.addSection("4", GetDummyPanel());
        }

        private Panel GetDummyPanel()
        {
            Panel panel = new Panel();
            Button button = new Button();
            button.Text = "Button";
            panel.Controls.Add(button);
            panel.BackColor = Color.Red;
            return panel;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }



      


    
    }
}
