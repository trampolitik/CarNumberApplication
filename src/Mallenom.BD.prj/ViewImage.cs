using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mallenom.BD
{
	public partial class ViewImage : Form
	{
		public ViewImage()
		{
			InitializeComponent();
		}

		private  async void _btnLoadImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();

			openFile.Filter = "ALL files (*.*)|*.*";

			if(openFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pictureBox1.Image = new Bitmap(openFile.FileName);
				}
				catch
				{
					MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK);
				}
			}

		}
	}
}
