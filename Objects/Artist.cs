using System.Collections.Generic;
using System;

namespace CdOrganizer.Objects
{
  public class Artist
  {
    private string _name;
    private string _genre;
    private int _id;
    private List<Cd> _cds = new List<Cd>{};
    private static List<Artist> _instances = new List<Artist>{};

    public Artist(string name, string genre)
    {
      if(Artist.GetByName(name) == null)
      {
        _name = name;
        _genre = genre;
        _instances.Add(this);
        _id = _instances.Count;
      }

    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetGenre(string newGenre)
    {
      _genre = newGenre;
    }

    public string GetGenre()
    {
      return _genre;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public static Artist GetByName(string name)
    {
      foreach(Artist artist in _instances)
      {
        if(name == artist.GetName())
        {
          return artist;
        }
      }
      return null;
    }

    public static Artist Find(int id)
    {
      return _instances[id -1];
    }

    public void AddCd(Cd newCd)
    {
      _cds.Add(newCd);
    }

    public List<Cd> GetCds()
    {
      return _cds;
    }

  }
}
