using Nancy;
using Triangles.Objects;

namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };

      Get["/result"] = _ => {
      int length1 = int.Parse(Request.Query["length1"]);
      int length2 = int.Parse(Request.Query["length2"]);
      int length3 = int.Parse(Request.Query["length3"]);

      Triangle userTriangle = new Triangle(length1, length2, length3);
      string result = userTriangle.TriangleType();
      return View["result.cshtml", result];
      };
    }
  }
}
