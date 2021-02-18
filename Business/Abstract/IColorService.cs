﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetColors();
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<Color> GetById(int id);
    }
}