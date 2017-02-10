using Nancy;
using CdOrganizer.Objects;
using System.Collections.Generic;

namespace CdOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml", Artist.GetAll()];

      Post["/add-cd"] = _ =>
      {
        if(Artist.GetByName(Request.Form["name"]) != null)
        {
          return View["alreadyAdded.cshtml"];
        }
        else
        {
          Artist newArtist = new Artist(Request.Form["name"], Request.Form["genre"]);
          return View["artist-confirm.cshtml", newArtist];
        }
      };

      Get["/cd/{id}"] = parameters => {
        Cd newCd = Cd.GetCd(parameters.id);
        return View["cd.cshtml", newCd];
      };

      Get["/artist-list"] = _ => {
        List<Artist> allArtists = Artist.GetAll();
        return View["artist-list.cshtml", allArtists];
      };
    }
  }
}
