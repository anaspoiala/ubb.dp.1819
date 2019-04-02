using ChessGame.Pieces;
using System;

namespace ChessGame.Command
{
	public class OneBackwardTwoLeft : IMovementCommand
	{
		public void Execute(ChessPiece piece)
		{
			piece.Position.X += 1;
			piece.Position.Y -= 2;
		}
	}
}
