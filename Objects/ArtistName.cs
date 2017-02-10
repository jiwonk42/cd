using System.Collections.Generic;

namespace CdOrganizer.Objects
{
  public class ArtistName
  {
    private static List<ArtistName> _instances = new List<ArtistName> {};
    private string _name;
    private int _id;
    private List<ArtistName> _artistNames;

    public ArtistName(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _artistNames = new List<ArtistName>{};
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public List<ArtistName> GetArtistList()
    {
      return _artistNames;
    }
  }
}
