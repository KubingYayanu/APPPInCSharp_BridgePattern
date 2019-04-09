namespace APPPInCSharp_BridgePattern.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DedicatedModem dedUser = new DedModemController(new HayesModem());
            dedUser.Receive();
            dedUser.Send();

            Modem modemClient = new DialModemController(new ErnieModem());
            modemClient.Dial();
            modemClient.Hangup();
            modemClient.Receive();
            modemClient.Send();
        }
    }
}