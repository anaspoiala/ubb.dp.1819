﻿using ChessGame.Pieces;
using System;

namespace ChessGame.Command
{
	public class TwoBackwardOneLeft : IMovementCommand
	{
		public void Execute(ChessPiece piece)
		{
			piece.Position.X += 2;
			piece.Position.Y -= 1;
		}
	}
}
