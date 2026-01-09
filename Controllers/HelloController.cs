using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SayHello : ControllerBase
{
    private readonly SayHelloService _service;

    public SayHello(SayHelloService service)
    {
        _service = service;
    }

    [HttpGet]
    public string GetHello(string name)
    {
        return _service.BuildGreeting(name);
    }
}
