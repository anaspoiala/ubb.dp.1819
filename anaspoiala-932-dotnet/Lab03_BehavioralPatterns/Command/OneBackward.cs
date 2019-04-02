using ChessGame.Pieces;
using System;

namespace ChessGame.Command
{
	public class OneBackward : IMovementCommand
	{
		public void Execute(ChessPiece piece)
		{
			piece.Position.X++;
		}
	}
}
