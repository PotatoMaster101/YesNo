using Microsoft.AspNetCore.Mvc;
using YesNo.Api.Services;

namespace YesNo.Api.Controllers;

[ApiController]
[Route("/api")]
public class YesNoController(IYesNoService yesNoService) : ControllerBase
{
    [HttpGet]
    public Models.YesNo Get()
    {
        return yesNoService.GetRandom();
    }

    [HttpGet("{answer:bool}")]
    public Models.YesNo Get(bool answer)
    {
        return yesNoService.GetForced(answer);
    }
}
