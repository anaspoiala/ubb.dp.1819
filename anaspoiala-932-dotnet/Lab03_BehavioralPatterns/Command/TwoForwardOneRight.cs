using ChessGame.Pieces;

namespace ChessGame.Command
{
	public class TwoForwardOneRight : IMovementCommand
	{
		public void Execute(ChessPiece piece)
		{
			piece.Position.X -= 2;
			piece.Position.Y += 1;
		}
	}
}
