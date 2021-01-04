using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class MovieCollection : Movie
    {
        public int MovieQty { get; private set; }
        public List<Movie> Collection { get; private set; }

        public void AddMovie(string name)
        {
            var movie = new Movie();
            Collection = new List<Movie>();
            setName(name);
            setRegistrationDate(DateTime.Now);
            setAvaiable(false);
            Collection.Add(movie);
            MovieQty++;
        }

        public void RemoveMovie(string name)
        {
            if (!MovieExists(name)) Console.WriteLine(name + " não foi encontrado no catálogo!");
            else
            {
                Console.WriteLine(name + " removido do catálogo!");
                Collection.Remove(GetMovie(name));
            }   
        }

        protected Movie GetMovie(string name)
        {
            var movie = new Movie();
            foreach (Movie item in Collection)
            {
                if (name == movie.Name) movie = item;
            }
            return movie;
        }

        private bool MovieExists(string name)
        {
            foreach (Movie movie in Collection)
            {
                if (name == movie.Name) return true;
            }
            return false;
        }




        






    }
}
