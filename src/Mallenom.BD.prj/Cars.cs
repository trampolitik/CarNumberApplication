using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mallenom.BD
{
	public class Cars
	{
		/// <summary>Id в базе данных.</summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		/// <summary>Возвращает и устанавлиет номер машины.</summary>
		/// <value>Номер машины.</value>
		public string NumberCar { get; set; }

		/// <summary>Возвращает и устанавлиет время, когда был сделан снимок.</summary>
		/// <value>Время, когда был сделан снимок.</value>
		public DateTime DateTime { get; set; }

		/// <summary>Возвращает и устанавлиет Id камеры.</summary>
		/// <value>Id камеры.</value>
		[Range(1,16)]
		public int? IdCamer { get; set; } 
		
	}
}
