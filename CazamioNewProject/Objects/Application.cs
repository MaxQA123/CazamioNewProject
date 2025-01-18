using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Application
    {
        public RequestedOfferPriceInfo RequestedOfferPrice { get; set; }
        public MonthsFreeInfo MonthsFree { get; set; }
        public MonthlyRentsPrePaymentInfo MonthlyRentsPrePayment { get; set; }
        public RentalTermsInfo RentalTerms { get; set; }
        public RequestedWorkInfo RequestedWork { get; set; }

        public static Application Generate()
        {
            return new Application
            {
                RequestedOfferPrice = CreateRequestedOfferPriceInfo(),
                MonthsFree = CreateMonthsFreeInfo(),
                MonthlyRentsPrePayment = CreateMonthlyRentsPrePaymentInfo(),
                RentalTerms = CreateRentalTermsInfo(),
                RequestedWork = CreateRequestedWorkInfo(),
            };
        }

        public class RequestedOfferPriceInfo
        {
            public string FirstPriceStatic { get; set; }
        }

        public class MonthsFreeInfo
        {
            public string OneMonth { get; set; }
        }

        public class MonthlyRentsPrePaymentInfo
        {
            public string OneMonth { get; set; }
        }

        public class RentalTermsInfo
        {
            public string TwelveMonth { get; set; }
        }

        public class RequestedWorkInfo
        {
            public string LongTextWashingtonSquare { get; set; }
            public string ShortTextWashingtonSquare { get; set; }
        }

        private static RequestedOfferPriceInfo CreateRequestedOfferPriceInfo()
        {
            return new RequestedOfferPriceInfo
            {
                FirstPriceStatic = "1200",
            };
        }

        private static MonthsFreeInfo CreateMonthsFreeInfo()
        {
            return new MonthsFreeInfo
            {
                OneMonth = "1",
            };
        }

        private static MonthlyRentsPrePaymentInfo CreateMonthlyRentsPrePaymentInfo()
        {
            return new MonthlyRentsPrePaymentInfo
            {
                OneMonth = "1",
            };
        }

        private static RentalTermsInfo CreateRentalTermsInfo()
        {
            return new RentalTermsInfo
            {
                TwelveMonth = "12",
            };
        }

        private static RequestedWorkInfo CreateRequestedWorkInfo()
        {
            return new RequestedWorkInfo
            {
                LongTextWashingtonSquare = "Lorem 1 Washington Square Requested Workk. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextWashingtonSquare = "Lorem 1 Washington Square Requested Workk.",
            };
        }
    }
}
