namespace ChainOfResponsibilityPattern
{
    public class ParcelHandlerBudget : ParcelHandlerBase
    {
        public override string Handle(Parcel parcel)
        {
            if (parcel.Value < 50m && !parcel.IsInsured)
            {
                return "BUDGET: " +
                       "Assault package at a discount price";
            }

            return NextHandler.Handle(parcel);
        }
    }
}