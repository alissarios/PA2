using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Models;
using MyWebApp.Services;

namespace MyWebApp.Pages
{
    public class AddSongModel : PageModel
    {
        [BindProperty]
        public string? newTitle {get;set;} = "no title given";


        [BindProperty]
        public string? newArtist {get;set;} = "no artist given";

        public void OnGet()
        {
        }

        public RedirectResult OnPostAddNewSong(string newTitle,string newArtist)
        {
            SongService.AddNewSong(newTitle, newArtist);
            return Redirect("/Song");
        }












    }
}
