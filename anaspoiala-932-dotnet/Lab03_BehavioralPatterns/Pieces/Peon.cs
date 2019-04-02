namespace ChessGame.Pieces
{
	public class Peon : ChessPiece
	{
		public Peon(Position position, bool isAlive, ChessPieceColor color)
		{
			Position = position;
			IsAlive = isAlive;
			Color = color;
		}
	}
}
