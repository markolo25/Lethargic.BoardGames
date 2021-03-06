﻿using System;
using System.Collections.Generic;
using System.Text;
using Lethargic.BoardGames.Model;

namespace Lethargic.BoardGames.View
{
    public interface IConsoleView
    {
        string BoardToString(IGameBoard board);
        string MoveToString(IGameMove move);
        IGameMove ParseMove(string moveText);
        string PlayerToString(int player);

    }
}
