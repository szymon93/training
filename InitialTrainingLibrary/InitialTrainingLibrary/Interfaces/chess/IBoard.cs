﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Interfaces.chess
{
    public interface IBoard
    {
        IBoardField[,] GetFields();
    }
}
