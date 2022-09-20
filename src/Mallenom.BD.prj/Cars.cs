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

		/// <summary>Номер машины.</summary>
		public string NumberCar { get; set; } 

		/// <summary>Время когда был сделан снимок.</summary>
		public DateTime DateTime { get; set; }
		/// <summary>Id камеры.</summary>
		[Range(1,16)]
		public int? IdCamer { get; set; } // id камеры
		
	}
}
