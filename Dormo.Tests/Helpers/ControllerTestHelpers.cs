using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dormo.Tests.Helpers;

public static class ControllerTestHelpers
{
    public static T CreateControllerWithIdentity<T>(T controller, string username, bool isAuthenticated) where T : ControllerBase
    {
        var claims = new List<Claim>();
        if (isAuthenticated && !string.IsNullOrEmpty(username))
        {
            claims.Add(new Claim(ClaimTypes.Name, username));
        }

        var identity = new ClaimsIdentity(claims, "Test");
        var principal = new ClaimsPrincipal(identity);

        controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext
            {
                User = principal
            }
        };

        return controller;
    }
}
