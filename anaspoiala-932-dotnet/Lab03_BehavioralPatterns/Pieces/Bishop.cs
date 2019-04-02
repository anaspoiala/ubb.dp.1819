namespace ChessGame.Pieces
{
	public class Bishop : ChessPiece
	{
		public Bishop(Position position, bool isAlive, ChessPieceColor color)
		{
			Position = position;
			IsAlive = isAlive;
			Color = color;
		}
	}
}
