using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
  }
}