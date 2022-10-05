﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	public class Point2D
	{
		private int x, y;

		public Point2D(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public Point2D() : this(0, 0)
		{
		}

		public int getX()
		{
			return x;
		}

		public void setX(int x)
		{
			this.x = x;
		}

		public int getY()
		{
			return y;
		}

		public void setY(int y)
		{
			this.y = y;
		}

		public void moveTo(int newX, int newY)
		{
			x = newX;
			y = newY;
		}

		public void moveRel(int dx, int dy)
		{
			x += dx;
			y += dy;
		}


		public override int GetHashCode()
		{
			int prime = 31;
			int result = 1;
			result = prime * result + x;
			result = prime * result + y;
			return result;
		}


		public override bool Equals(object obj)
		{
			if (this == obj)
				return true;
			if (obj == null)
				return false;
			if (GetType() != obj.GetType())
				return false;
			Point2D other = (Point2D)obj;
			if (x != other.x)
				return false;
			if (y != other.y)
				return false;
			return true;
		}
	}
}
