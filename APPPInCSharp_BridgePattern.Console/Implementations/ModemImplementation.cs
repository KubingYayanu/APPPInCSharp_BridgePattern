namespace APPPInCSharp_BridgePattern
{
    public interface ModemImplementation
    {
        void Dial();

        void Hangup();

        void Send();

        void Receive();
    }
}