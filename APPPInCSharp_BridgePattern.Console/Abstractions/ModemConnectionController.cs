namespace APPPInCSharp_BridgePattern
{
    public abstract class ModemConnectionController : Modem, DedicatedModem
    {
        public ModemConnectionController(ModemImplementation modemImp)
        {
            ModemImp = modemImp;
        }

        private ModemImplementation ModemImp { get; }

        public abstract void Dial();

        public abstract void Hangup();

        public abstract void Receive();

        public abstract void Send();

        protected void DialImp()
        {
            ModemImp.Dial();
        }

        protected void HangupImp()
        {
            ModemImp.Hangup();
        }

        protected void ReceiveImp()
        {
            ModemImp.Receive();
        }

        protected void SendImp()
        {
            ModemImp.Send();
        }
    }
}