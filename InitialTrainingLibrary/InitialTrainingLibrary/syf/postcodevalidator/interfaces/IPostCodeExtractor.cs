﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.postcodevalidator.interfaces
{
    public interface IPostCodeExtractor
    {
        PostCode GetPostCode(string code);
    }
}
