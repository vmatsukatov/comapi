namespace BaseBotClient
{
    public interface IRequest
    {
        string UserId { get; set; }
        string CommandMessage { get; set; }
    }
}