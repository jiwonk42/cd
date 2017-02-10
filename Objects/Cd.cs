using System.Collections.Generic;
using System;

namespace CdOrganizer.Objects
{
  public class Cd
  {
    private string _artist;
    private string _album;
    private int _id;
    private static List<Cd> _instances = new List<Cd>{};
    private static List<Cd> _albumCheck = new List<Cd>{};
    private static List<Cd> _artistCheck = new List<Cd>{};


    public Cd(string artist, string album)
    {
      _artist = artist;
      _album = album;
      _instances.Add(this);
      _id = _instances.Count;
    }

    // public static void SetArtistList()
    // {
    //   foreach(Cd cd in _instances)
    //   {
    //     for(int index = 0; index<_artistCheck.Count; index++)
    //     {
    //       if(cd.GetName() != _instances[index].GetName())
    //       {
    //
    //       }
    //       else
    //       {
    //         _
    //       }
    //     }
    //   }
    // }



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

    public static void SetAlbumList(string artistName)
    {
      _albumCheck.Clear();
      foreach(Cd cd in GetAll())
      {
        if(cd.GetArtist() == artistName)
        {
          _albumCheck.Add(cd);
        }
      }
    }

    public static List<Cd> GetAlbumList()
    {
      return _albumCheck;
    }
  }
}
