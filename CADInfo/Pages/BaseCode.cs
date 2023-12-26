using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADInfo.Pages
{
    public partial class BaseCode : UserControl
    {
        public BaseCode()
        {
            InitializeComponent();
        }

        private void ButtonCear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxOutput.Clear();
        }

        private void ButtonCrypt_Click(object sender, EventArgs e)
        {
            var byteText = Encoding.UTF8.GetBytes(textBoxInput.Text);
            textBoxOutput.Text = Convert.ToBase64String(byteText);
        }

        private void ButtoncEncrypt_Click(object sender, EventArgs e)
        {
            var byteText = Convert.FromBase64String(textBoxInput.Text);
            textBoxOutput.Text = Encoding.UTF8.GetString(byteText);
        }
    }
}
