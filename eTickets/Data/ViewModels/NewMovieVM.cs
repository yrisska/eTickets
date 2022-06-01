using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTickets.Data;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price in $")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Movie poster URL is required")]
        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Start date is required")]
        [Display(Name = "Movie start date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "Movie end date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Movie category is required")]
        [Display(Name = "Movie category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Required(ErrorMessage = "Movie actors is required")]
        [Display(Name = "Select actors")]
        public List<int> ActorIds { get; set; }
        [Required(ErrorMessage = "Movie cinema is required")]
        [Display(Name = "Select cinema")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Movie producer is required")]
        [Display(Name = "Select producer")]
        public int ProducerId { get; set; }
    }
}
