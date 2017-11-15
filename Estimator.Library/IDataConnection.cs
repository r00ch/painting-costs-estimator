using Estimator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library
{
	public interface IDataConnection
	{
		BoardModel CreateBoardType(BoardModel model);
	}
}
