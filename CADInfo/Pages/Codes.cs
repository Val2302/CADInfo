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
			var grayCode = BinToGray( textBoxInputGray.Text );
			labelDecInputGray.Text = Convert.ToString( uint.Parse( textBoxInputGray.Text ), 10 );
			labelDecOutputValue.Text = Convert.ToString( uint.Parse( grayCode ), 10 );
			labelBinOutputValue.Text = grayCode;

			string BinToGray ( string number ) {
				var isParse = uint.TryParse( number, out uint g );

				if ( !isParse )
				{
					MessageBox.Show( "Ввели не правильное число " );
					return string.Empty;
				}
				
				return Convert.ToString( g ^ ( g >> 1 ), 2 );
			}
		}

		private void ButtonConvertOfGray_Click ( object sender, EventArgs e )
		{
			var grayCode = GrayToBin( textBoxInputGray.Text );
			labelDecInputGray.Text = Convert.ToString( uint.Parse( textBoxInputGray.Text ), 10 );
			labelDecOutputValue.Text = Convert.ToString( uint.Parse( grayCode ), 10 );
			labelBinOutputValue.Text = grayCode;

			string GrayToBin ( string number )
			{
				uint sum = 0;
				var isParse = uint.TryParse( number, out sum );

				if ( !isParse )
				{
					MessageBox.Show( "Ввели не правильное число " );
					return string.Empty;
				}
				else
				{
					for ( int i = 0; i < number.Length; sum ^= sum, i-- )
					{
						sum >>= 1;
					}
				}

				return Convert.ToString( sum, 2 );
			}
		}
	}
}
