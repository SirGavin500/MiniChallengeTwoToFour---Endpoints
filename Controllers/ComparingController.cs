using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_template.Services;

namespace API_template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompareNumbers : ControllerBase
{
    private readonly CompareNumbersService _service;

    public CompareNumbers(CompareNumbersService service)
    {
        _service = service;
    }

    public CompareNumbersService Service => _service;

    [HttpGet]
    public string Compare(int num1, int num2)
    {
        return Service.Compare(num1, num2);
    }
}
