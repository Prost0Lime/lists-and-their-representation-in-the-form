using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba7
{
	/// <summary>
	/// Description of Vector.
	/// </summary>
	public class Vector 	//Описание класса «Элемент»
	{	
		int x,y;
		public Vector(int xx, int yy)
		{
			x=xx;
			y=yy;
		}
		public int getX()
		{
			return x;
		}
		public int getY()
		{
			return y;
		}
	}
}