using BIG.Networking.Network.Requests;

namespace BIG.Networking
{
    public interface IServerSettings
    {
        public int DefaultServerPort => 10515;
        public int ServerMaxConnections => 10;
        public string ServerConnectionString => "test";
        public int MsDelayInTheNetworkThread => 15;
        public bool SyncAllClientsToTheNewlyConnectedOne => true;
        public ConfirmationType ServerRequiredConfirmationType => ConfirmationType.None;
    }
}