using UnityEngine;

public class GameManager : MonoBehaviour
{
    //private const string httpserver = "https://clickycrateswebapi.azurewebsites.net";
    private const string httpServer = "https://localhost:44363";
    public string GetHttpServer()
    {
        return httpServer;
    }

    private string _token;
    public string Token
    {
        get { return _token; }
        set { _token = value; }
    }

    private string _playerId;
    public string PlayerId
    {
        get { return _playerId; }
        set { _playerId = value; }
    }
}
