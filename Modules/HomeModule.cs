using Nancy;
using CdOrganizer.Objects;
using System.Collections.Generic;

namespace CdOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml", Cd.GetAll()];

      Post["/add-cd"] = _ =>
      {
        Cd newCd = new Cd(Request.Form["artist"], Request.Form["album"]);
        return View["cd-confirm.cshtml", newCd];
      };

      Get["/cd/{id}"] = parameters => {
        Cd newCd = Cd.GetCd(parameters.id);
        return View["cd.cshtml", newCd];
      };
    }
  }
}
