using Core.DataAccess;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.DataAccess.Abstract
{
   public interface IMovieDal:IEntityRepository<Movie>
    {
    }
}
