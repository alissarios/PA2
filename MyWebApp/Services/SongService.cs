using MyWebApp.Models;

namespace MyWebApp.Services;
public static class SongService
{
    public static List<Song> allSongs {get;}
    static SongService()
    {
        allSongs = new List<Song>();
        CreateSetupSongs();
        SortSongsByDateAdded();
        allSongs[1].isFave = true;





    }

    public static List<Song> GetAll() => allSongs;

    public static Song? Get(int id) => allSongs.FirstOrDefault(p => p.songId == id);

    static void CreateSetupSongs()
    {
        DateTime song1AddedDate = new DateTime (2020,2,27);
        DateTime song2AddedDate = new DateTime(2021,3,5);
        DateTime song3AddedDate = new DateTime(2022,7,19);

        Song song1 = new Song(1,"Body","Summer Walker", song1AddedDate);
        Song song2 = new Song(2,"Snooze", "SZA", song2AddedDate);
        Song song3 = new Song(3,"Free Mind", "Tems", song3AddedDate);

        allSongs.Add(song1);
        allSongs.Add(song2);
        allSongs.Add(song3);
    }

    static void SortSongsByDateAdded()
    {
        allSongs.Sort((x,y)=> DateTime.Compare(x.dateAdded, y.dateAdded));
        allSongs.Reverse();
    }

     public static void FavoriteSong(int idToFav)
    {
        Song songToFav = Get(idToFav);
        if(songToFav is null) return;

        if (songToFav.isFave == true)
        {
            songToFav.isFave = false;
        }
        else
        {
            songToFav.isFave = true;
        }

    }

    public static void DeleteSong(int songIdToDelete)
    {
        var songToDelete = Get(songIdToDelete);
        if(songToDelete is null)
        {
            return;
        }
        allSongs.Remove(songToDelete);
        SortSongsByDateAdded();
        //int indexOfSongsToDelete = allSongs.IndexOf(GetSongByID(songIdToDelete));
        //allSongs.RemoveAt(indexOfSongsToDelete);

    }

    public static void AddNewSong(string newTitle, string newArtist)
    {
        DateTime newDateAdded = new DateTime();
        newDateAdded = DateTime.Now;
        int newSongId = allSongs.Count()+1;
        if (newTitle!=null && newArtist !=null)
        {
            Song newestSong = new Song(newSongId, newTitle, newArtist, newDateAdded);
            allSongs.Add(newestSong);
        }else {
            Song newestSong = new Song(newSongId, "No Title Given", "No Artist Given", newDateAdded);
            allSongs.Add(newestSong);
        }
        SortSongsByDateAdded();

    }

}