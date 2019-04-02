using ChessGame.Pieces;

namespace ChessGame.Command
{
	public class OneForward : IMovementCommand
	{
		public void Execute(ChessPiece piece)
		{
			piece.Position.X--;
		}
	}
}
