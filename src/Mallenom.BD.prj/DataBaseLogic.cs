using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mallenom.BD
{
	public  class DataBaseLogic
	{
		Random rnd = new Random();
		ApplicationContext db =  new ApplicationContext();

		/// <summary>Добавление номера машины в базу данных.</summary>
		/// <param name="numberName">Номер машины.</param>
		/// <param name="idCamer">Id камеры.</param>
		public void AddCarDataBase(string numberName, int idCamer)
		{
			using(var db = new ApplicationContext())
			{
				Cars car = new Cars { NumberCar = numberName, DateTime = DateTime.Now, IdCamer = idCamer };
				db.Cars.Add(car);
				db.SaveChanges();
			}
		}
		/// <summary>Удаление элемента из базы данных по id.</summary>
		/// <param name="id"> Id в базе данных.</param>
		public void RemoveCatDataBase(int id)
		{
			using( var db = new ApplicationContext())
			{
				var deleteitem = db.Cars.Find(id);

				if(deleteitem != null)
				{
					db.Cars.Remove(deleteitem);
					db.SaveChanges();
				}

			}

		}
		/// <summary>Метод, который будет показывать таблицу и проверять данные.</summary>
		public void ViewDataBase(DataGridView dataGrid)
		{
			var cars = db.Cars;

			if(cars.Count() > 0)
			{
				dataGrid.DataSource = cars.ToList();
			}
			else
			{
				MessageBox.Show("нет данных");
				dataGrid.DataSource = null;
			}

		}
		/// <summary>Создание случайных автомобилей для тестирования.</summary>
		public void GenerationCars()
		{
			List<string> NumberCars = new List<string>
			{
				"g546k","g786k","g896k","g675k","a786k",
				"p789k","g675k","h686l"
			};

			for(int i = 0; i < 10; i++)
			{
				int index = rnd.Next(NumberCars.Count);
				using(var db = new ApplicationContext())
				{
					Cars car = new Cars { NumberCar = NumberCars[index], DateTime = DateTime.Now, IdCamer = rnd.Next(1, 16) };
					db.Cars.Add(car);
					db.SaveChanges();
				}

			}

		}

	}
}
