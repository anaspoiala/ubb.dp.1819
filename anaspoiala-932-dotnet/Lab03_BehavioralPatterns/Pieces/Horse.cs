namespace ChessGame.Pieces
{
	public class Horse : ChessPiece
	{
		public Horse(Position position, bool isAlive, ChessPieceColor color)
		{
			Position = position;
			IsAlive = isAlive;
			Color = color;
		}
	}
}
