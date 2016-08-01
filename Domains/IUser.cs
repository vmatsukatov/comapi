namespace Domains
{
    public interface IUser
    {
        string name { get; set; }
        string emailAddress { get; set; }
        string displayName { get; set; }
    }
}