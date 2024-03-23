using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Search
{
	internal class Position
	{
		public int Id {get; set;}
		public string PName {get; set;}

		public static List<Position> Positions()
		{
			List<Position> positions = new List<Position>
			{
				new Position {Id = 1, PName = "Officer"},
				new Position {Id = 2, PName = "Team Leader"},
				new Position {Id = 3, PName = "Manager"},
				new Position {Id = 4, PName = "Director"},
			};
			return positions;
		}
	} 
}
