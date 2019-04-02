using System;

namespace ChessGame.Pieces
{
	public class Position
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Position(int x, int y)
		{
			X = x;
			Y = y;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(X, Y);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || !GetType().Equals(obj.GetType()))
				return false;

			Position position = (Position)obj;

			return X.Equals(position.X) && Y.Equals(position.Y);
		}
	}
}
