namespace Chat.Interfaces;

public interface IChatClient
{
    public Task ReceiveMessage(string userName, string message);
}