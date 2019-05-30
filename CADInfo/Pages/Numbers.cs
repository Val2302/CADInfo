using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Math;

namespace CADInfo.Pages
{
	public partial class Numbers : UserControl
	{
		public Numbers ( )
		{
			InitializeComponent( );

			Dock = DockStyle.Fill;
			Visible = true;
		}

		private void ButtonDecCalc_Click ( object sender, EventArgs e )
		{
			labelExpValue.Text = string.Empty;
			labelBinValue.Text = string.Empty;
			labelOctValue.Text = string.Empty;
			labelHexValue.Text = string.Empty;

			int decNumber;

			if ( !int.TryParse( textBoxDec.Text, out decNumber ) )
			{
				MessageBox.Show( "Ввели не целое число" );
				return;
			}

			labelExpValue.Text = decNumber.ToString( "E", CultureInfo.InvariantCulture );
			labelBinValue.Text = Convert.ToString( decNumber, 2 );
			labelOctValue.Text = Convert.ToString( decNumber, 8 );
			labelHexValue.Text = Convert.ToString( decNumber, 16 );
		}

		private void ButtonBinCalc_Click ( object sender, EventArgs e )
		{
			labelPrimeCodeValue.Text = string.Empty;
			labelReflexCodeValue.Text = string.Empty;
			labelAddCodeValue.Text = string.Empty;
			int decNumber;

			if ( !int.TryParse( textBoxSignDec.Text, out decNumber ) )
			{
				MessageBox.Show( "Ввели не целое число" );
				return;
			}

			if ( decNumber < -253 || 253 < decNumber )
			{
				MessageBox.Show( "Ведённое число занимает более одного байта" );
				return;
			}

			var binNumber = string.Empty;

			labelPrimeCodeValue.Text = CreatePrimeCode( decNumber );
			labelReflexCodeValue.Text = CreateReflectCode( labelPrimeCodeValue.Text );
			labelAddCodeValue.Text = CreateAddCode( labelReflexCodeValue.Text );

			string CreatePrimeCode ( int decIntNumber )
			{
				binNumber = Convert.ToString( Abs( decIntNumber ), 2 );
				var countSpaces = 8 - binNumber.Length - 1;
				var placeholder = countSpaces > 0 ? new string('0', countSpaces ) : "";
				return ( decIntNumber < 0 ? "1" : "0" ) + placeholder + binNumber;
			}

			string CreateReflectCode ( string value )
			{
				var reflectBinString = value;

				if ( decNumber < 0 )
				{
					reflectBinString = value[ 0 ].ToString( );

					for ( int i = 1; i < value.Length; i++ )
					{
						reflectBinString += value[ i ] == '0' ? '1' : '0';
					}
				}

				return reflectBinString;
			}

			string CreateAddCode ( string value )
			{
				var addString = value;
				var isBitInMember = false;

				if ( decNumber < 0 )
				{
					addString = string.Empty;
					AddBit( value.Length - 1 );
					
					for ( int i = 2; i <= binNumber.Length; i-- )
					{
						if ( !isBitInMember )
						{
							break;
						}

						AddBit( value.Length - i );
					}

					addString = value.Substring( 0, value.Length - addString.Length ) + addString;
				}

				return addString;

				void AddBit ( int index )
				{
					if ( value[ index ] == '0' )
					{
						addString = "1" + addString;
						isBitInMember = false;
					}
					else
					{
						addString = "0" + addString;
						isBitInMember = true;
					}
				}
			}
		}
	}
}
