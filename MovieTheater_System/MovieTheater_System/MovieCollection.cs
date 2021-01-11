using MovieTheater_System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class MovieCollection: IMovieCollection
    {
        public List<Movie> collection = new List<Movie>();

        public void AddMovie(string name)
        {
            if(MovieExists(name))
                foreach (Movie movie in collection) Console.WriteLine(movie.Name + " is already registered!");
            else
            {
                var newMovie = new Movie(name);
                collection.Add(newMovie);
                Console.WriteLine(newMovie.Name + " was succesfully registered!");
            }
        }

        public void RemoveMovie(string name)
        {
            if (!MovieExists(name)) 
                Console.WriteLine(name + " was not found!");
            else
            {
                Console.WriteLine(name + " was successfully removed!");
                collection.Remove(GetMovie(name));
            }
        }

        //Tem uma outra solução pra esse método?
        protected Movie GetMovie(string name)
        {
            int i = 0;
            foreach (Movie movie in collection)
            {
                if (name != movie.Name) 
                    i++;
            }
            return collection.ElementAt(i);
        }

        private bool MovieExists(string name)
        {
            foreach (Movie movie in collection)
            {
                if (name == movie.Name) return true;
            }
            return false;
        }




        






    }
}
