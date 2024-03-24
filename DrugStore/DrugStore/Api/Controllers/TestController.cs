using Microsoft.AspNetCore.Mvc;

namespace DrugStore.Api.Controllers;

/// <summary>
/// Пример того, как выглядит контроллер
/// </summary>
[ApiController, Route("test-controller")]
public class TestController
{
    /// <summary>
    /// Пример Post метода
    /// </summary>
    [HttpPost, Route("test-post")]
    public Task<int> TestPostMethod()
    {
        return Task.FromResult(1);
    }
    
    /// <summary>
    /// Пример Get метода
    /// </summary>
    [HttpGet, Route("test-get")]
    public Task<int> TestGetMethod()
    {
        //return Task.FromResult(_testService.GetHui());

        return Task.FromResult(1);
    }
    
    /// <summary>
    /// Пример Put метода
    /// </summary>
    [HttpPut, Route("test-put")]
    public Task TestPutMethod()
    {
        return Task.CompletedTask;
    }
}