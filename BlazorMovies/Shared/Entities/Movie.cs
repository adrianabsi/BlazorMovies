using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento{ get; set; }
        public string Poster { get; set; }
        public string TituloCorto 
        { get { 
                if(string.IsNullOrEmpty(Titulo)) {
                    return null;
                }
                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            } 
        }
        public bool IsReleased()
        {
            if (FechaLanzamiento < DateTime.UtcNow)
            {
                return true;
            }
            else 
            {
                return false; 
            };
        }
    }

}
