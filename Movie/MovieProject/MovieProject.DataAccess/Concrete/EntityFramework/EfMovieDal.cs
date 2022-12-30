using Core.DataAccess.EntityFramework;
using MovieProject.DataAccess.Abstract;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.DataAccess.Concrete.EntityFramework
{
    public class EfMovieDal: EfEntityRepositoryBase<Movie, MovieDbContext>,IMovieDal
    {
    }
}
