using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_template.Services;

public class SayHelloService
{
    public string BuildGreeting(string name)
    {
        return $"Hello, {name}!";
    }
}
