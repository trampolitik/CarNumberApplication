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
	public partial class Form1 : Form
	{
		ApplicationContext dataBase = new ApplicationContext();// класс базы данных
		DataBaseLogic logic = new DataBaseLogic(); // класс логиик 
		Random rnd = new Random(); // класс случайных значений 
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			logic.ViewDataBase(dataGridView1);
			
		}

		/// <summary> Кнопка отвечающая за добавление машины в базу данных. </summary>
		private async void add_button_Click(object sender, EventArgs e)
		{
			if(textBox_NumberName.Text == string.Empty || Convert.ToInt32(textBox_idCamer.Text) > 16)
			{
				await Task.Run(() =>
					MessageBox.Show("Поле не должно быть пустым или id не допустимое")
				);

			}
			else
			{
				if(textBox_idCamer.Text == string.Empty)
				{
					logic.AddCarDataBase(textBox_NumberName.Text, rnd.Next(1, 16));
					TextReset();
				}
				else
				{
					logic.AddCarDataBase(textBox_NumberName.Text, Convert.ToInt32(textBox_idCamer.Text));
					TextReset();
				}

			}

		}
		/// <summary>Очищаем поля id камеры и номера машины.</summary>
		private void TextReset()
		{
			textBox_NumberName.Text = string.Empty;
			textBox_idCamer.Text = string.Empty;
			UpdateDataView(dataGridView1);
			logic.ViewDataBase(dataGridView1);
		}

		/// <summary>Метод обновляет таблицу данных  и показывает его, нужен для того, чтобы видеть обновления в таблице.</summary>
		private void UpdateDataView(DataGridView dataGrid)
		{
			dataGrid.DataSource = null;
			dataGrid.Update();
			dataGrid.Refresh();
			logic.ViewDataBase(dataGridView1);
		}

		/// <summary> Метод отвечающий за нажатие на таблицу.</summary>
		private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedRow = e.RowIndex;

			if(e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[selectedRow];
				textBox_NumberName.Text = row.Cells[1].Value.ToString();
				textBox_idCamer.Text = row.Cells[3].Value.ToString();
				label_delete.Text = row.Cells[0].Value.ToString();

			}

		}
		/// <summary> Удаление всех машин с данным номером </summary>
		private void deleteOneThing_button1_Click(object sender, EventArgs DataGridViewCellEventArgs)
		{
			using(var db = new ApplicationContext())
			{
				if(textBox_NumberName != null)
				{
					var list = db.Cars.Where(x => x.NumberCar == textBox_NumberName.Text).ToList();
					foreach(var l in list)
					{
						db.Cars.Remove(l);
						db.SaveChanges();

					}
				}
			}
			
		}

		/// <summary> Кнопка, которая обновляет всю таблицу либо же загружает ее при старте. </summary>
		private void dounload_update_Button_Click(object sender, EventArgs e)
		{
			logic.ViewDataBase(dataGridView1);
			UpdateDataView(dataGridView1);
		}

		/// <summary> Сортирует данные по id камеры </summary>
		private void sortOfId_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.OrderBy(x => x.IdCamer).ToList();
			}
		}
		/// <summary> Сортирует данные по номеру машины </summary>
		private void sortOfByNumberCars_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.OrderBy(x => x.NumberCar).ToList();
			}
		}
		/// <summary> Сортирует данные по дате</summary>
		private void sortByData_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.OrderBy(x => x.DateTime).ToList();
			}
		}
		/// <summary></summ>Поиск по id или номеру машины.</summary>
		private void button_searchIdCamer_Click(object sender, EventArgs e)
		{
			using(var db = new ApplicationContext())
			{
				dataGridView1.DataSource = db.Cars.AsEnumerable().Where(x => Convert.ToString(x.IdCamer) == textBox_searchIdCamer.Text 
				|| x.NumberCar.Contains(textBox_searchIdCamer.Text)).ToList();

			}
		}
		/// <summary>Кнопка отвечающая за удаление определенного элемента в базе данных.</summary>
		private void button_DeleteCar_Click(object sender, EventArgs e)
		{
			logic.RemoveCatDataBase(Convert.ToInt32(label_delete.Text));
			UpdateDataView(dataGridView1);
		}
	}
}
