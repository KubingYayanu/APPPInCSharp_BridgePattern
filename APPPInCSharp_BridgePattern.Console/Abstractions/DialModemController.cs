namespace APPPInCSharp_BridgePattern
{
    public class DialModemController : ModemConnectionController
    {
        public DialModemController(ModemImplementation modemImp)
            : base(modemImp)
        {
        }

        public override void Dial()
        {
            DialImp();
        }

        public override void Hangup()
        {
            HangupImp();
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