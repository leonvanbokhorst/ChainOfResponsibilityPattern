namespace ChainOfResponsibilityPattern
{
    public class ParcelHandlerNormal : ParcelHandlerBase
    {
        public override string Handle(Parcel parcel)
        {
            if (parcel.Value >= 50m && !parcel.IsInsured)
            {
                return "NORMAL: " +
                       "Deliver package at a reasonable price";
            }

            return NextHandler.Handle(parcel);
        }
    }
}