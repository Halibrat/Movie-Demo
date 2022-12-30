using Core.Aspect.Autofac.Logging;
using Core.CCS;
using Core.Utilities.Resluts;
using Core.Utilities.Results;
using MovieProject.Business.Abstract;
using MovieProject.Business.Contans;
using MovieProject.DataAccess.Abstract;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;
        public MovieManager(IMovieDal movie)
        {
            _movieDal = movie;
        }
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(Messages.MovieAdd);
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.MovieDelete);
        }

        public IDataResult<List<Movie>> GetAll()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetAll());
        }

        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(Messages.MovieUpdate);
        }
    }
}
