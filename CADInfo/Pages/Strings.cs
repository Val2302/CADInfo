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

		private void ButtonConvertToCodes_Click ( object sender, EventArgs e )
		{
			if ( textBoxString.Text is null || textBoxString.Text == string.Empty )
			{
				return;
			}

			labelOutput.Text = string.Empty;
			labeMylCode.Text = string.Empty;
			labelStandartCode.Text = string.Empty;
			
			foreach ( int symbol in textBoxString.Text )
			{
				labelOutput.Text += symbol.ToString( ) + " ";
			}

			labeMylCode.Text = HashCode( labelOutput.Text ).ToString( );
			labelStandartCode.Text = labelOutput.Text.GetHashCode( ).ToString( );
		}

		private void ButtonConvertToSymbols_Click ( object sender, EventArgs e )
		{
			if ( textBoxString.Text is null || textBoxString.Text == string.Empty )
			{
				return;
			}

			labelOutput.Text = string.Empty;
			labeMylCode.Text = string.Empty;
			labelStandartCode.Text = string.Empty;

			string[] words = textBoxString.Text.Split( ' ' );
            
			foreach ( var word in words )
			{
				var isParse = char.TryParse( word, out char symbol );

                if ( isParse )
                {
                    labelOutput.Text += symbol.ToString( );
                }
                else
                {
                    MessageBox.Show( "Введены не коды символов" );
                    textBoxString.Text = string.Empty;
                    return;
                }
			}

			labeMylCode.Text = HashCode( labelOutput.Text ).ToString( );
			labelStandartCode.Text = labelOutput.Text.GetHashCode( ).ToString( );
		}

		private long HashCode ( string text )
		{
			const int UTF_TABLE_LENGTH = 65_536;
			long hash = 1;

			for ( int i = 0; i < text.Length; i++ )
			{
				hash = UTF_TABLE_LENGTH << ( ( ( ( int ) text[ i ] ) ) * ( i + 1 ) );
			}

			return hash;
		}
    }
}
