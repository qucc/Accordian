using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accordian
{
    public partial class AccordianHeader : UserControl
    {
        bool expand;
        public bool Expand
        {
            get { return expand; }
            set
            {
                expand = value;
                if (expand)
                {
                    imageView1.Image = imageView1.DownImage;
                }
                else
                {
                    imageView1.Image = imageView1.UpImage;
                }
      
            }
        }

        string text;

        public override string Text
        {
            set
            {
                label1.Text = value;
            }
        }

        public AccordianHeader(string text ):this()
        {
            this.text = text;
        }

        public AccordianHeader()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }

    class ImageView : PictureBox
    {
        Image upImage;
        [CategoryAttribute("Appearance"), DescriptionAttribute("Gets/Sets a value indicating whether instance should persist settings.")]
        [Bindable(true)]
        public Image UpImage
        {
            get { return upImage; }
            set { upImage = value; }
        }

        Image downImage;
          [CategoryAttribute("Appearance"), DescriptionAttribute("Gets/Sets a value indicating whether instance should persist settings.")]
        [Bindable(true)]
        public Image DownImage
        {
            get { return downImage; }
            set { downImage = value; }
        }
 
    }

}
