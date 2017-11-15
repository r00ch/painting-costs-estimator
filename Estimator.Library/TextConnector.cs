using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estimator.Library.Models;

namespace Estimator.Library
{
	public class TextConnector : IDataConnection
	{
		// TODO - Wire up the CreateBoardType for text file.
		public BoardModel CreateBoardType(BoardModel model)
		{
			model.Id = 1;
			return model;
		}
	}
}
