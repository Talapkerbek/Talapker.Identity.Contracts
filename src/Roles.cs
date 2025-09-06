namespace Talapker.Identity.Contracts;

public static class Roles
{
    public const string Admin = "Admin";
    public const string Zavuch = "Zavuch";
    public const string Teacher = "Teacher";
    
    public static List<string> ListOfRoles = [Roles.Admin, Roles.Zavuch, Roles.Teacher];
}