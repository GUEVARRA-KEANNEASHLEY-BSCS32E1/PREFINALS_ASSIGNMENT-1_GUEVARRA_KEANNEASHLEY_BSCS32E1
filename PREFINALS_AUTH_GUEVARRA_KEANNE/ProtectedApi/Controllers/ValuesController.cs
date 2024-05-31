using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        var userInfo = new
        {
            Name = "Keanne Ashley Guevarra",
            Section = "CS",
            Course = "Computer Science",
            FunFacts = new[]
            {
                "I love Dogs.",
                "I am a bookworm.",
                "I love watching Kdrama's.",
                "I enjoy cooking.",
                "I love stuff toys.",
                "I don't like spicy foods.",
                "I love travelling and expoloring new things.",
                "I do my nails on my own.",
                "I always buy makeups.",
                "I have 5 dogs."
            }
        };

        return Ok(userInfo);
    }
}