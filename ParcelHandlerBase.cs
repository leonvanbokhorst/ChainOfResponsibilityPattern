namespace ChainOfResponsibilityPattern
{
    public abstract class ParcelHandlerBase
    {
        protected ParcelHandlerBase NextHandler;

        public abstract string Handle(Parcel parcel);

        public void SetNewHandler(ParcelHandlerBase nextHandler)
        {
            NextHandler = nextHandler;
        }
    }
}