﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Interfaces
{
    public interface IDateValidator
    {
        bool DateValidate(int year, int month, int day);

        string GetName(); //Zwróćcie swoje imię lub nick
    }
}
