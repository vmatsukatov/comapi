namespace BaseBotClient
{
    public interface IResponse
    {
        IRequest Request { get; }
        string CommandResponse { get; }
    }
}