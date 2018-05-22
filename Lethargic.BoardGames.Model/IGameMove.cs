using System;
using System.Collections.Generic;
using System.Text;

namespace Lethargic.BoardGames.Model
{
    public interface IGameMove : IEquatable<IGameMove> { 
        int Player { get; }
    }

}