﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        public class Actor
        {
            [Key]

            public int Id { get; set; }


            public string Logo { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            //RelationShips
            public List<Movie> Movies { get; set; }
        }
    }
}
