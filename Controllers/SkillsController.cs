using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers;

[Route("/skills")]
public class SkillsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        /* /skills/form
         * - 3 possible programming language
         * - h1: "Skills Tracker"
         * - h2 + ol: three programming languages
         */
        string html =
          "<h1>Skills Tracker</h1>"
          + "<h2>Let's track some skills</h2>"
          + "<ol>"
          + "  <li>C#</li>"
          + "  <li>JavaScript</li>"
          + "  <li>Java</li>"
          + "</ol>";
        return Content(html, "text/html");
    }
    [HttpGet("form")]
    public IActionResult GetSkills()
    {
        /* GET /skills/form
         * form: date + learning progress
         */
        string html = 
          "<form method='post' action='/skills/form'>"
          + "<div>"
          + "  <label for='as-of'>Date:</label>"
          + "  <input type='date' id='as-of' name='date'/>"
          + "</div>"
          + "<div>"
          + "  <label for='c#-skill-level'>C# skill level:</label>"
          + "  <select name='cSharp' id='c#-skill-level'>"
          + "    <option value=''>--Please choose an option--</option>"
          + "    <option value='learning basics'>Learning Basics</option>"
          + "    <option value='making apps'>Making Apps</option>"
          + "    <option value='master coder'>Master Coder</option>"
          + "  </select>"
          + "</div>"
          + "<div>"
          + "  <label for='javascript-skill-level'>JavaScript skill level:</label>"
          + "  <select name='javaScript' id='javascript-skill-level'>"
          + "    <option value=''>--Please choose an option--</option>"
          + "    <option value='learning basics'>Learning Basics</option>"
          + "    <option value='making apps'>Making Apps</option>"
          + "    <option value='master coder'>Master Coder</option>"
          + "  </select>"
          + "</div>"
          + "<div>"
          + "  <label for='java-skill-level'>Java skill level:</label>"
          + "  <select name='java' id='java-skill-level'>"
          + "    <option value=''>--Please choose an option--</option>"
          + "    <option value='learning basics'>Learning Basics</option>"
          + "    <option value='making apps'>Making Apps</option>"
          + "    <option value='master coder'>Master Coder</option>"
          + "  </select>"
          + "</div>"
          + "<div>"
          + "  <input type='submit' value='Submit!'/>"
          + "</div>"
          + "</form>";
        return Content(html, "text/html");
    }
    [HttpPost("form")]
    public IActionResult DisplaySkills(string date, string cSharp, string javaScript, string java)
    {
        /* POST /skills/form
         */
        string html =
          $"<h1>Progress as of {date}...</h1>"
          + "<ol>"
          + $"<li> C#: {cSharp}</li>"
          + $"<li> JavaScript: {javaScript}</li>"
          + $"<li> Java: {java}</li>"
          + "</ol>";
        return Content(html, "text/html");
    }
}