using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CADInfo.Pages
{
	public partial class Colors : UserControl
	{  
		public Colors ( )
		{
			InitializeComponent( );

			Dock = DockStyle.Fill;
			Visible = true;

            try
            {
                var centerWidth = pictureBoxImage.Width / 2;
                var centerHeight = pictureBoxImage.Height / 2;
                var selectColor = (pictureBoxImage.Image as Bitmap).GetPixel(centerWidth, centerHeight);
                ShowColors(selectColor);
            }
            catch
            {
            }
		}

		private void PictureBoxImage_MouseClick ( object sender, MouseEventArgs e )
		{
            try
            {
                var selectColor = (pictureBoxImage.Image as Bitmap).GetPixel(e.X, e.Y);
                ShowColors(selectColor);
                ShowColors(selectColor);
            }
            catch
            {
            }
        }

		void ShowColors ( Color selectColor )
		{
			panelSelectColor.BackColor = selectColor;
			labelColorPartR.Text = $"R = {selectColor.R.ToString( )}";
			labelColorPartG.Text = $"G = {selectColor.G.ToString( )}";
			labelColorPartB.Text = $"B = {selectColor.B.ToString( )}";
			panelColorR.BackColor = Color.FromArgb( selectColor.R, 255, 255 );
			panelColorG.BackColor = Color.FromArgb( 255, selectColor.G, 255 );
			panelColorB.BackColor = Color.FromArgb( 255, 255, selectColor.B );
			groupBoxRGBA.Text = $"RGBA: #{Convert.ToString( createRGBA( selectColor ), 16)}";
			RGBToCMYK( selectColor );
			RGBToXYZ( selectColor );
			RGBToHSV( selectColor );
			RGBToLAB( selectColor );

			long createRGBA ( Color color )
			{
				int r = color.R;
				int g = color.G;
				int b = color.B;
				int a = color.A;
				return ( ( r & 0xff ) << 24 ) + ( ( g & 0xff ) << 16 ) + ( ( b & 0xff ) << 8 ) + ( a & 0xff );
			}

			void RGBToCMYK ( Color color )
			{
				double computedC = 0;
				double computedM = 0;
				double computedY = 0;
				double computedK = 0;

				double r = color.R;
				double g = color.G;
				double b = color.B;

				if ( r == 0 && g == 0 && b == 0 )
				{
					computedC = computedM = computedY = 0;
					computedK = 1;
				}

				computedC = 1 - ( r / 255.0 );
				computedM = 1 - ( g / 255.0 );
				computedY = 1 - ( b / 255.0 );

				var minCMY = Math.Min( computedC, Math.Min( computedM,computedY ) );
				computedC = ( computedC - minCMY ) / ( 1 - minCMY );
				computedM = ( computedM - minCMY ) / ( 1 - minCMY );
				computedY = ( computedY - minCMY ) / ( 1 - minCMY );
				computedK = minCMY;

				labelC.Text = $"C = {computedC}";
				labelM.Text = $"M = {computedM}";
				labelY.Text = $"Y = {computedY}";
				labelK.Text = $"K = {computedK}";
			}

			void RGBToXYZ ( Color c )
			{
				double x, y, z;

				double rFloat = c.R / 255.0;
				double gFloat = c.G / 255.0;
				double bFloat = c.B / 255.0;

				rFloat = rFloat > 0.04045 ? Math.Pow( ( rFloat + 0.055 ) / 1.055, 2.2 ) : rFloat / 12.92;
				gFloat = gFloat > 0.04045 ? Math.Pow( ( gFloat + 0.055 ) / 1.055, 2.2 ) : gFloat / 12.92;
				bFloat = bFloat > 0.04045 ? Math.Pow( ( bFloat + 0.055 ) / 1.055, 2.2 ) : bFloat / 12.92;

				x = rFloat * 0.4124 + gFloat * 0.3576 + bFloat * 0.1805;
				y = rFloat * 0.2126 + gFloat * 0.7152 + bFloat * 0.0722;
				z = rFloat * 0.0193 + gFloat * 0.1192 + bFloat * 0.9505;

				labelX.Text = $"X = {x}";
				labelYY.Text = $"Y = {y}";
				labelZ.Text = $"Z = {z}";
			}

			void RGBToHSV ( Color color )
			{
				double h, s, v;
				double r = color.R / 255.0;
				double g = color.G / 255.0;
				double b = color.B / 255.0;

				double max = Math.Max( Math.Max( r, g ), b );
				double min = Math.Min( Math.Min( r, g ), b );

				double delta = max - min;

				switch ( 0 )
				{
					case int n when max == r:
						h = 60 * ( ( g - b ) / delta % 6 );
						break;
					case int n when max == g:
						h = 60 * ( ( b - r ) / delta + 2 );
						break;
					case int n when max == b:
						h = 60 * ( ( r - g ) / delta + 4 );
						break;
					default:
						h = 0;
						break;
				}

				s = max == 0 ? 0 : delta / max;
				v = max;

				labelH.Text = $"H = {h}";
				labelS.Text = $"S = {s}";
				labelV.Text = $"V = {v}";
			}

			void RGBToLAB ( Color color )
			{
				double rr = color.R / 255.0;
				double gg = color.G / 255.0;
				double bb = color.B / 255.0;

				rr = CalcColor( rr );
				gg = CalcColor( gg );
				bb = CalcColor( bb );

				double l = rr * 0.4124 + gg * 0.3576 + bb * 0.1805;
				double a = rr * 0.2126 + gg * 0.7152 + bb * 0.0722;
				double b = rr * 0.0193 + gg * 0.1192 + bb * 0.9505;

				labelL.Text = $"L = {l}";
				labelA.Text = $"A = {a}";
				labelB.Text = $"B = {b}";

				double CalcColor( double clr )
				{
					return ( clr > 0.04045 ? Math.Pow( ( clr + 0.055 ) / 1.055, 2.4 ) : clr / 12.92 ) * 100;
				}
			}
		}
    }
}
