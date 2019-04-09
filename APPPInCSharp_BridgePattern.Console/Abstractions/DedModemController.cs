namespace APPPInCSharp_BridgePattern
{
    public class DedModemController : ModemConnectionController
    {
        public DedModemController(ModemImplementation modemImp)
            : base(modemImp)
        {
        }

        public override void Dial()
        {
            // simulate dial;
        }

        public override void Hangup()
        {
            // simulate hangup();
        }

        public override void Receive()
        {
            ReceiveImp();
        }

        public override void Send()
        {
            SendImp();
        }
    }
}