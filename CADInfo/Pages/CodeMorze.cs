using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Threading;

namespace CADInfo.Pages
{
	public partial class CodeMorze : UserControl
	{
		class Coder
		{
			public  string[,] _alphabet;

			public Coder ( )
			{
				_alphabet = new[ , ]
				{
					{"0", ""},
					{"1", "•‒‒‒‒"},
					{"2", "••‒‒‒"},
					{"3", "•••‒‒"},
					{"4", "••••‒"},
					{"5", "•••••"},
					{"6", "‒••••"},
					{"7", "‒‒•••"},
					{"8", "‒‒‒••"},
					{"9", "‒‒‒‒•"},
					{"а", "•‒"},
					{"б", "‒•••"},
					{"в", "•‒‒"},
					{"г", "‒‒•"},
					{"д", "‒••"},
					{"е", "•"},
					{"ё", "•"},
					{"ж", "•••‒"},
					{"з", "‒‒••"},
					{"и", "••"},
					{"й", "•‒‒‒"},
					{"к", "‒•‒"},
					{"л", "•‒••"},
					{"м", "‒‒"},
					{"н", "‒•"},
					{"о", "‒‒‒"},
					{"п", "•‒‒•"},
					{"р", "•‒•"},
					{"с", "•••"},
					{"т", "‒"},
					{"у", "••‒"},
					{"ф", "••‒•"},
					{"х", "••••"},
					{"ц", "‒•‒•"},
					{"ч", "‒‒‒•"},
					{"ш", "‒‒‒‒"},
					{"щ", "‒‒•‒"},
					{"Ъ", "‒••‒"},
					{"ы", "‒•‒‒"},
					{"ь", "‒••‒"},
					{"э", "••‒••"},
					{"ю", "••‒‒"},
					{"я", "•‒•‒"},
					{"a", "•‒"},
					{"b", "‒•••"},
					{"c", "‒•‒•"},
					{"d", "‒••"},
					{"e", "•"},
					{"f", "••‒•"},
					{"g", "‒‒•"},
					{"h", "••••"},
					{"i", "••"},
					{"j", "•‒‒‒"},
					{"k", "‒•‒"},
					{"l", "•‒••"},
					{"m", "‒‒"},
					{"n", "‒•"},
					{"o", "‒‒‒"},
					{"p", "•‒‒•"},
					{"q", "‒‒•‒"},
					{"r", "•‒•"},
					{"s", "•••"},
					{"t", "‒"},
					{"u", "••‒"},
					{"v", "•••‒"},
					{"w", "•‒‒"},
					{"x", "‒••‒"},
					{"y", "‒•‒‒"},
					{"z", "‒‒••"},
					{".", "••••••"},
					{",", "•‒•‒•‒"},
					{";", "‒•‒•‒•"},
					{":", "‒‒‒•••"},
					{"!", "‒‒••‒‒"},
					{"?", "••‒‒••"},
					{"-", "‒••••‒"},
					{"+", "•‒•‒•"},
					{"«", "•‒••‒•"},
					{"»", "‒•‒‒•‒"},
					{"(", "‒•‒‒•‒"},
					{")", "‒•‒‒•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"},
					{"а", "•‒"}
				};
			}

			public string GetSymbol ( string morze )
			{
				var count = _alphabet.GetLength( 0 );

				for ( var i = 0; i < count; i++ )
				{
					if ( morze == _alphabet[ i, 1 ] )
					{
						return _alphabet[ i, 0 ];
					}
				}

				return morze;
			}

			public string GetMorze ( string symbol )
			{
				symbol = symbol.ToLower( );
				var count = _alphabet.GetLength( 0 );

				for ( var i = 0; i < count; i++ )
				{
					if ( symbol == _alphabet[ i, 0 ] )
					{
						return $" {_alphabet[ i, 1 ]} ";
					}
				}

				return symbol;
			}
		}

		private Coder _coder;

		public CodeMorze ( )
		{
			InitializeComponent( );

			Dock = DockStyle.Fill;
			Visible = true;
			_coder = new Coder( );
		}

		private void ButtonCrypt_Click ( object sender, EventArgs e )
		{
			textBoxOutput.Clear( );

			foreach ( var symbol in textBoxInput.Text )
			{
				textBoxOutput.Text += _coder.GetMorze( symbol.ToString( ) );
			}
		}

		private void ButtoncEncrypt_Click ( object sender, EventArgs e )
		{
			textBoxOutput.Clear( );
			var dot = '•';
			var dash = '‒';
			var word = string.Empty;

			foreach ( var symbol in textBoxInput.Text )
			{
				if ( symbol == dot || symbol == dash )
				{
					word += symbol;
				}
				else
				{
					textBoxOutput.Text += word == string.Empty ? symbol.ToString( ) : _coder.GetSymbol( word );
					word = string.Empty;
				}
			}
		}

		private void ButtonCear_Click ( object sender, EventArgs e )
		{
			textBoxInput.Clear( );
			textBoxOutput.Clear( );
		}

		private void ButtonPlay_Click ( object sender, EventArgs e )
		{
			var timeLength = 100;
			var dot = '•';
			var dash = '‒';
			var dotFrequency = 2000;
			var dashFrequency = 1000;

			foreach ( var symbol in textBoxOutput.Text )
			{
				if ( symbol == dot )
				{
					Beep(dotFrequency, timeLength );
					Thread.Sleep( timeLength );
				}
				else if ( symbol == dash )
				{
					Beep(dashFrequency, timeLength);
					Thread.Sleep(timeLength);
				}
				else
				{
					Thread.Sleep(timeLength);
				}
			}
		}
	}
}
