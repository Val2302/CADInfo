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
	public partial class Codes : UserControl
	{
		public Codes ( )
		{
			InitializeComponent( );

			Dock = DockStyle.Fill;
			Visible = true;
		}

		private void ButtonConvertToGray_Click ( object sender, EventArgs e )
		{
            var isParse = false;
            labelBinInputGray.Text = string.Empty;
            labelDecOutputValue.Text = string.Empty;
            labelBinOutputValue.Text = string.Empty;
			var grayCode = BinToGray( textBoxInputGray.Text );

            if ( !isParse )
	        {
                return;
	        }

            if (grayCode != string.Empty)
            {
                labelBinInputGray.Text = Convert.ToString(Convert.ToInt32(textBoxInputGray.Text, 2));
                labelDecOutputValue.Text = Convert.ToString(int.Parse(grayCode), 10);
                labelBinOutputValue.Text = Convert.ToString(int.Parse(grayCode), 2);
            }

            string BinToGray ( string number ) {
                isParse = int.TryParse( number, out var binNumber );

                if ( !isParse )
                {
                    MessageBox.Show("Ввели не правильное число ");
                    return string.Empty;
                }

                binNumber = Convert.ToInt32( number, 2 );
                return Convert.ToString(binNumber ^ ( binNumber >> 1 ));
			}
		}

		private void ButtonConvertOfGray_Click ( object sender, EventArgs e )
		{
            var isParse = false;
			labelBinInputGray.Text = string.Empty;
            labelDecOutputValue.Text = string.Empty;
            labelBinOutputValue.Text = string.Empty;
            var grayCode = GrayToBin( textBoxInputGray.Text );

            if ( !isParse )
	        {
                return;
	        }

            if (grayCode != string.Empty)
            {
                labelBinInputGray.Text = Convert.ToString(Convert.ToInt32(textBoxInputGray.Text, 2));
                labelDecOutputValue.Text = Convert.ToString(int.Parse(grayCode), 10);
                labelBinOutputValue.Text = Convert.ToString(int.Parse(grayCode), 2);
            }

			string GrayToBin ( string number )
			{
				isParse = int.TryParse( number, out var binNumber );

				if ( !isParse )
				{
					MessageBox.Show( "Ввели не правильное число " );
					return string.Empty;
				}
				else
				{
                    binNumber = Convert.ToInt32( number, 2 );
                    int sum;

					for ( sum = 0; binNumber > 0; binNumber >>= 1 )
					{
						sum ^= binNumber;
					}

                    return Convert.ToString( sum );
				}
			}
		}
	}
}
