using System.Collections.Generic;

namespace CdOrganizer.Objects
{
  public class Cd
  {
    private string _artist;
    private string _album;
    private int _id;
    private static List<Cd> _instances = new List<Cd>{};

    public Cd(string artist, string album)
    {
      _artist = artist;
      _album = album;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public void SetArtist(string artist)
    {
      _artist = artist;
    }

    public string GetArtist()
    {
      return _artist;
    }

    public void SetAlbum(string album)
    {
      _album = album;
    }

    public string GetAlbum()
    {
      return _album;
    }

    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }

    public static Cd GetCd(int cdId)
    {
      return _instances[cdId - 1];
    }
  }
}
