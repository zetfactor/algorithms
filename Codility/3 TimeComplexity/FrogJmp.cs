using System;

class FrogJmp
{
	public int solution(int X, int Y, int D) {
		return (int)Math.Ceiling(((double)Y - X) / D);
	}
}