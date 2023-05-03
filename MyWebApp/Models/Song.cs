using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models;

    public class Song
    {
        [Required]
        public int songId { get; set; }
        public string? title { get; set; }
        public string? artist { get; set; }
        public DateTime dateAdded { get; set; }
        //public DateTime dateFavorited { get; set; }
        //public DateTime dateDeleted
        //public static int totalNumSongs =0;

        public bool isFave= false;


       /* public Song()
        {
            songId = -1;
            title = "";
            artist = "";
            dateAdded = new DateTime(1970,1,1);
            //totalNumSongs++;
        }*/

         public Song(int sngId, string ttl, string rtst, DateTime dtAdded)
        {
            songId = sngId;
            title = ttl;
            artist = rtst;
            dateAdded = dtAdded; 
            //totalNumSongs++;
        }

    }
