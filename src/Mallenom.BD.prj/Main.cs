using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mallenom.BD
{
	public partial class Main : Form
	{
		private readonly DataBaseLogic _logic = new DataBaseLogic(); // класс логиик 
		private readonly Random _rnd = new Random(); // класс случайных значений 
		
		public Main()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_logic.ViewDataBase(dataGridView1);
			
		}

		/// <summary> Кнопка отвечающая за добавление машины в базу данных. </summary>
		private async void OnAddButtonClick(object sender, EventArgs e)
		{
			if(_txtNumberName.Text == string.Empty || Convert.ToInt32(_txtIdCamer.Text) > 16)
			{
				await Task.Run(() =>
					MessageBox.Show("Поле не должно быть пустым или id не допустимое")
				);

			}
			else
			{
				if(_txtIdCamer.Text == string.Empty)
				{
					_logic.AddCarDataBase(_txtNumberName.Text, _rnd.Next(1, 16));
					TextReset();
				}
				else
				{
					_logic.AddCarDataBase(_txtNumberName.Text, Convert.ToInt32(_txtIdCamer.Text));
					TextReset();
				}

			}

		}
		/// <summary>Очищаем поля id камеры и номера машины.</summary>
		private void TextReset()
		{
			_txtNumberName.Text = string.Empty;
			_txtIdCamer.Text = string.Empty;
			UpdateDataView(dataGridView1);
			_logic.ViewDataBase(dataGridView1);
		}

		/// <summary>Метод обновляет таблицу данных  и показывает его, нужен для того, чтобы видеть обновления в таблице.</summary>
		private void UpdateDataView(DataGridView dataGrid)
		{
			dataGrid.DataSource = null;
			dataGrid.Update();
			dataGrid.Refresh();
			_logic.ViewDataBase(dataGridView1);
		}

		/// <summary> Метод отвечающий за нажатие на таблицу.</summary>
		private async void OnCellClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedRow = e.RowIndex;

			if(e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[selectedRow];
				_txtNumberName.Text = row.Cells[1].Value.ToString();
				_txtIdCamer.Text = row.Cells[3].Value.ToString();
				_txtId.Text = row.Cells[0].Value.ToString();

			}

		}
		/// <summary> Удаление всех машин с данным номером </summary>
		private void OnDeleteManyCarsClick(object sender, EventArgs DataGridViewCellEventArgs)
		{
			using(var db = new ApplicationContext())
			{
				if(_txtNumberName != null)
				{
					var list = db.Cars.Where(x => x.NumberCar == _txtNumberName.Text).ToList();
					foreach(var l in list)
					{
						db.Cars.Remove(l);
						db.SaveChanges();

					}
				}
			}
			
		}

		/// <summary> Кнопка, которая обновляет всю таблицу либо же загружает ее при старте. </summary>
		private void OnUpdateClick(object sender, EventArgs e)
		{
			_logic.ViewDataBase(dataGridView1);
			UpdateDataView(dataGridView1);
		}

		/// <summary> Сортирует данные по id камеры </summary>
		private void OnSortIdClick(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.OrderBy(x => x.IdCamer).ToList();
			}
		}
		/// <summary> Сортирует данные по номеру машины </summary>
		private void OnSortNumberCarsClick(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.OrderBy(x => x.NumberCar).ToList();
			}
		}
		/// <summary> Сортирует данные по дате</summary>
		private void OnSortDataClick(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.OrderBy(x => x.DateTime).ToList();
			}
			
		}
		/// <summary>Поиск по id или номеру машины.</summary>
		private void OnSearchClick(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.AsEnumerable().Where(x => Convert.ToString(x.IdCamer) == _txtSearchIdCamer.Text 
				|| x.NumberCar.Contains(_txtSearchIdCamer.Text)).ToList();

			}
		}
		/// <summary>Кнопка отвечающая за удаление определенного элемента в базе данных.</summary>
		private void OnDeleteClick(object sender, EventArgs e)
		{
			var result = int.TryParse(_txtId.Text, out int id);
			if (result == true)
			{
				_logic.RemoveCatDataBase(id);
				UpdateDataView(dataGridView1);
			}
			else
			{
				MessageBox.Show("Нет такого id");
			}
		
		}
	}
}
