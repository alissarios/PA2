using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Services;

namespace MyWebApp.Pages
{
    public class SongModel : PageModel
    {
        public List<Song> allSongs = new();
        [BindProperty]
        public int songIdToDelete {get; set;} = new();

        [BindProperty]
        public int songIdToFav {get; set;} = new();
        public void OnGet()
        {
            allSongs = SongService.GetAll();
        }

        public IActionResult OnPost()
        {
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDeleteButton(int songIdToDelete)
        {
            SongService.DeleteSong(songIdToDelete);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostFavButton(int songIdToFav)
        {
            SongService.FavoriteSong(songIdToFav);
            return Redirect("/Song");
        }


    }
}
