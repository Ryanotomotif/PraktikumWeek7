using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek7
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}
		

		private void btn_konversi_Click(object sender, EventArgs e)
		{
			// program hanya bisa salin teks dari text box kalimat langsung ke label output
			// untuk konversi saat di tekan hanya bisa mengconvert salah satu huruf saja bukan seluruh kalimat :v
			// namun jika ingin salin teks dari text box kalimat ke label output text box huruf dan convert harus dikosongkan   

			lbl_output.Text = tbox_kalimat.Text;

			if (tbox_huruf.Text == "a")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "b")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "c")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "d")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "e")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "f")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "g")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "h")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "i")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "j")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "k")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "l")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "m")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "n")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "o")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "p")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "q")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "r")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "s")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "t")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "u")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "v")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "w")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "x")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "y")
			{
				lbl_output.Text = tbox_convert.Text;
			}
			if (tbox_huruf.Text == "z")
			{
				lbl_output.Text = tbox_convert.Text;
			}
		}
	}
}
