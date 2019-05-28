using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADInfo.Elements
{
	public partial class CaesarCrypt : UserControl
	{

		private const int UTF_TABLE_LENGTH = 65_536;

		public CaesarCrypt ( )
		{
			InitializeComponent( );

			Dock = DockStyle.Fill;
			Visible = true;
		}

		private void ButtonCryptCC_Click ( object sender, EventArgs e )
		{
			textBoxOutput.Clear( );
			var key = textBoxKey.Text.GetHashCode( );
			
			foreach ( int symbol in textBoxInput.Text )
			{
				textBoxOutput.Text += ( char ) ( ( symbol + key ) % UTF_TABLE_LENGTH );
			}
		}

		private void ButtoncEncryptCC_Click ( object sender, EventArgs e )
		{
			textBoxOutput.Clear( );
			var key = textBoxKey.Text.GetHashCode( );

			foreach ( int symbol in textBoxInput.Text )
			{
				textBoxOutput.Text += ( char ) ( ( symbol - key ) % UTF_TABLE_LENGTH );
			}
		}

		private void ButtonCear_Click ( object sender, EventArgs e )
		{
			textBoxInput.Clear( );
			textBoxOutput.Clear( );
		}
	}
}
