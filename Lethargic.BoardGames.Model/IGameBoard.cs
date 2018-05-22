using System;
using System.Collections.Generic;
using System.Text;

namespace Lethargic.BoardGames.Model
{
    public interface IGameBoard
    {
        IEnumerable<IGameMove> GetPossibleMoves();
        void ApplyMove(IGameMove m);
        void UndoLastMove();

        IReadOnlyList<IGameMove> MoveHistory { get; }
        int CurrentPlayer { get; }
        bool IsFinished { get; }
        GameAdvantage CurrentAdvantage { get; }
    }
}
