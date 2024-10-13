using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
	internal class Struct
	{
		// 열거형 C++과 같음
		enum Direction
		{
			Up, Down, Left, Right
		}
		struct StudentInfo
		{
			public string name;
			public int math;
			public int eng;
			public int science;

			public float Average()
			{
				return (math + eng + science) / 3.0f;
			}
		}
		struct Point
		{
			public int x;
			public int y;

			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}

		static void Main(string[] args)
		{
			Direction dir = Direction.Up;

			switch (dir)
			{
				case Direction.Up:
					break;
			}
		}
	}
}