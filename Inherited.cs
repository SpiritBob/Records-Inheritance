using System;

namespace WebApp
{
    public record Inherited(string NewProperty = null) : Base();

    public record Base(int TemperatureC = 0, string Summary = null, DateTime Date = default);
}
