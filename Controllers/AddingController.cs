using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddTwoNumbers : ControllerBase
{
    private readonly AddTwoNumbersService _service;

    public AddTwoNumbers(AddTwoNumbersService service)
    {
        _service = service;
    }

    [HttpGet]
    public string Add(int num1, int num2)
    {
        return _service.AddNumbers(num1, num2);
    }
}
