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
	public partial class Strings : UserControl
	{
		public Strings ( )
		{
			InitializeComponent( );

			Dock = DockStyle.Fill;
			Visible = true;
		}

		private void ButtonRun_Click ( object sender, EventArgs e )
		{
			if ( textBoxString.Text is null || textBoxString.Text == string.Empty )
			{
				return;
			}

			labelSymbolsCodes.Text = string.Empty;
			labelInputCode.Text = string.Empty;
			labelStandartCode.Text = string.Empty;
			
			foreach ( int symbol in textBoxString.Text )
			{
				labelSymbolsCodes.Text += symbol.ToString( ) + " ";
			}

			labelInputCode.Text = HashCode( labelSymbolsCodes.Text ).ToString( );
			labelStandartCode.Text = labelSymbolsCodes.Text.GetHashCode( ).ToString( );

			long HashCode ( string text )
			{
				const int UTF_TABLE_LENGTH = 65_536;
				long hash = 1;

				for ( int i = 0; i < text.Length; i++ )
				{
					hash = UTF_TABLE_LENGTH << ( ( text[ i ] + 1 ) * ( i + 1 ) );
				}

				return hash;
			}
		}
	}
}
