using Core.Utilities.Resluts;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.Business.Abstract
{
   public interface IMovieService
    {
        IResult Add(Movie movie);
        IResult Delete(Movie movie);
        IResult Update(Movie movie);
        IDataResult<List<Movie>> GetAll();
    }
}
