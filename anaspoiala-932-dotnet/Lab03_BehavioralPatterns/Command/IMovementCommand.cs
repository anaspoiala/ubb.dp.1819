using ChessGame.Pieces;

namespace ChessGame.Command
{
	public interface IMovementCommand
	{
		void Execute(ChessPiece piece);
	}
}
