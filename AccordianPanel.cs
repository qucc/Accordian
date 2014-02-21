using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Accordian
{
    public partial class AccordianPanel : UserControl
    {
        ArrayList sections = new ArrayList();
        int selectItemIndex = -1;

        public AccordianPanel()
        {
            InitializeComponent();
  
        }


        public void addSection(string text, Control control)
        {
            AccordianSection sectionPanel = new AccordianSection(text,control);
            sectionPanel.Header.MouseClick += new MouseEventHandler(headerClicked);
            sections.Add(sectionPanel);
            ReloadSection();
        }

        private void headerClicked(object sender, MouseEventArgs e)
        {
            int index = IndexClick(sender);
            if (index == selectItemIndex)
            {
                selectItemIndex = -1;
            }
            else
            {
                selectItemIndex = index;
            }
            ReloadSection();     
        }

        private int IndexClick(object sender)
        {
            for (int i = 0; i < sections.Count; i++)
            {
                if (sender == ((AccordianSection)sections[i]).Header)
                {
                    return i;
                }
            }
            return -1;
 
        }

        public void OpenSection(int index)
        {
            if (index >= 0 && index < sections.Count)
            {
                for (int i = 0; i < sections.Count; i++)
                {
                    AccordianSection section = (AccordianSection)sections[i];
                    if (i == index)
                    {
                        section.Fill = true;
                    }
                    else
                    {
                        section.Fill = false;
                    }
                }
                ReloadSection();
            }
        }

        private void ReloadSection()
        {
            this.SuspendLayout();
            topPanel.Controls.Clear();
            centerPanel.Controls.Clear();
            bottomPanel.Controls.Clear();
            if (selectItemIndex >= 0)
            {
                for (int i = 0; i < selectItemIndex; i++)
                {
                    AccordianSection section = (AccordianSection)sections[i];
                    AccordianHeader header = section.Header;
                  header.Dock = DockStyle.Bottom;
                    header.Expand = false;
                   
                    topPanel.Controls.Add(header);
                }
                for (int i = selectItemIndex + 1; i < sections.Count; i++)
                {
                    AccordianSection section = (AccordianSection)sections[i];
                    AccordianHeader header = section.Header;
                    header.Expand = false;
                    header.Dock = DockStyle.Bottom;
                    bottomPanel.Controls.Add(header);
                }
                //add selected panel
                AccordianSection centerSection = (AccordianSection)sections[selectItemIndex];
                centerSection.Header.Expand = true;
                centerSection.Header.Dock = DockStyle.Top;
                centerSection.Content.Dock = DockStyle.Fill;
                centerPanel.Controls.Add(centerSection.Header);
                centerPanel.Controls.Add(centerSection.Content);
            }
            else
            {
                foreach (AccordianSection section in sections)
                {
                    AccordianHeader header = section.Header;
                    header.Dock = DockStyle.Bottom;
                    header.Expand = false;
                    topPanel.Controls.Add(header);
                }
            }
            this.ResumeLayout(false);
            PerformLayout();
   
        }
    }

    public class AccordianSection
    {
        bool fill;

        public bool Fill
        {
            get { return fill; }
            set
            {
                fill = value;
                Header.Expand = fill;
            }
        }

        public AccordianHeader Header
        {
            get { return toggleButton1; }
        }

        Control content;
        AccordianHeader toggleButton1;

        public Control Content
        {
            get { return content; }
            set { content = value; }
        }


        public AccordianSection(string text, Control control)
        {
            toggleButton1 = new AccordianHeader();
            toggleButton1.Text = text;
            content = control;
        }

        
      


    }
}
