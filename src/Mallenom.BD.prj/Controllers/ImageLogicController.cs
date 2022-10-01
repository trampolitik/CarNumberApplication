using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mallenom.BD.Controller
{
	public class ImageLogicController
	{
		/// <summary>Конвертация из картинки в байты.</summary>
		/// <param name="img">Картинка.</param>
		/// <returns>Возвращает массив байтов.</returns>
		private byte[] ConvertImageToBinary(Image img)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}

		/// <summary>Сохранение Картинки в базу данных.</summary>
		/// <param name="id"> id столбца куда будет сохранена картинка.</param>
		/// <param name="image"> Картинка, преобразующася в массив байтов(picterBox)</param>
		public async Task SaveImageDatabase(int id, Image image)
		{
			using(var db = new ApplicationContext())
			{
				var img = db.Cars.Where(x => x.Id == id).FirstOrDefault();
				img.Image = ConvertImageToBinary(image);
				db.Cars.Update(img);
				await db.SaveChangesAsync();
			}
		}

		/// <summary> Конвертация из байтов в картинку.</summary>
		/// <param name="id"> Id столбца в базе данных.</param>
		/// <returns> Возвращает картинку.</returns>
		private Image ConvertBinaryToImage(int id)
		{
			using(var db = new ApplicationContext())
			{
				var img = db.Cars.Where(x => x.Id == id).FirstOrDefault().Image;
				return Image.FromStream(new MemoryStream(img));
			}
		}
		/// <summary> Метод, показывающий картинку, если она есть в базе данных.</summary>
		/// <param name="id">Id столбца в базе данных.</param>
		/// <returns> Возвращает либо картинку, либо ничего.</returns>
		public Image? ShowExistingImage(int id)
		{
			using(var db = new ApplicationContext())
			{
				var img = db.Cars.Where(x => x.Id == id).FirstOrDefault();
				if(img.Image != null)
				{
					return ConvertBinaryToImage(id);
				}
				else
				{
					return null;
				}

			}
		}
	}
}
