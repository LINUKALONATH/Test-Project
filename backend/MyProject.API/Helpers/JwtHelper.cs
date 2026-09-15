namespace MyProject.API.Helpers;

public static class JwtHelper
{
    public static string CreateDevelopmentToken(string subject) => $"development-token:{subject}";
}
