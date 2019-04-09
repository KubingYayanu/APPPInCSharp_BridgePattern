namespace APPPInCSharp_BridgePattern
{
    public interface Modem
    {
        void Dial();

        void Hangup();

        void Send();

        void Receive();
    }
}