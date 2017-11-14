using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library.Models
{
	public class BoardModel
	{
		/// <summary>
		/// Type of painting board, like canvas or wooden panel.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Conatins list of all avaiable sizes.
		/// </summary>
		public List<Dimension> SizeList { get; set; } = new List<Dimension>();
		/// <summary>
		/// Board price per 1 square centimeter, given in PLN.
		/// </summary>
		public decimal Price { get; set; }
	}

}
