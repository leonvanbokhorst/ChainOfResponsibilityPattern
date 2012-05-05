namespace ChainOfResponsibilityPattern
{
    public class ParcelHandlerDeluxe : ParcelHandlerBase
    {
        public override string Handle(Parcel parcel)
        {
            if (parcel.IsInsured)
            {
                return "DELUXE: " +
                       "Take special care of package at a whooping price.";
            }

            return NextHandler.Handle(parcel);
        }
    }
}