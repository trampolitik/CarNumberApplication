using Mallenom.BD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mallenom.BD
{
	public partial class ViewImage : Form
	{
		private int _id; // id столбца с которым работаем.
		private readonly ImageLogicController _imageLogic = new ImageLogicController(); // класс контроллера, который работает с картинкой.
		public ViewImage(int id)
		{
			_id = id;
			InitializeComponent();

			pictureBox1.Image = _imageLogic.ShowExistingImage(id);
		}
		/// <summary> Кнопка отвечающая за загрузку изображения из проводника.</summary>
		private void _btnLoadImage_Click(object sender, EventArgs e)
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
		/// <summary> Кнопка отвечающая за сохранение картинки в базу данных.</summary>
		private async void _btnSaveImage_Click(object sender, EventArgs e)
		{
			if(pictureBox1.Image != null)
			{
				await _imageLogic.SaveImageDatabase(_id, pictureBox1.Image);
				MessageBox.Show("Успешно сохранено!");
			}
			else
			{
				MessageBox.Show("Картинка не загружена для сохранения.");
			}

		}
	}
}
