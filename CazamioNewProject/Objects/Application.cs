using CazamioNewProject.GuiHelpers;
using System;

namespace CazamioNewProject.Objects
{
    public class Application
    {
        public BasicDataInfo BasicData { get; set; }
        public RequestedOfferPriceInfo RequestedOfferPrice { get; set; }
        public MonthsFreeInfo MonthsFree { get; set; }
        public MonthlyRentsPrePaymentInfo MonthlyRentsPrePayment { get; set; }
        public RentalTermsInfo RentalTerms { get; set; }
        public RequestedWorkInfo RequestedWork { get; set; }
        public ReferralDetailsInfo ReferralDetails { get; set; }
        public StatusesInfo Statuses { get; set; }
        public ButtonsInfo Buttons { get; set; }

        public static Application Generate()
        {
            return new Application
            {
                BasicData = CreateBasicDataInfo(),
                RequestedOfferPrice = CreateRequestedOfferPriceInfo(),
                MonthsFree = CreateMonthsFreeInfo(),
                MonthlyRentsPrePayment = CreateMonthlyRentsPrePaymentInfo(),
                RentalTerms = CreateRentalTermsInfo(),
                RequestedWork = CreateRequestedWorkInfo(),
                ReferralDetails = CreateReferralDetailsInfo(),
                Statuses = CreateStatusesInfo(),
                Buttons = CreateButtonsInfo(),
            };
        }

        public class BasicDataInfo
        {
            public string NotAssignetLabel { get; set; }
            public string DateCurrent { get; set; }
        }

        public class RequestedOfferPriceInfo
        {
            public string FirstPriceStatic { get; set; }
            public string SecondPriceStatic { get; set; }
        }

        public class MonthsFreeInfo
        {
            public string OneMonth { get; set; }
            public string TwoMonths { get; set; }
        }

        public class MonthlyRentsPrePaymentInfo
        {
            public string OneMonth { get; set; }
            public string TwoMonth { get; set; }
        }

        public class RentalTermsInfo
        {
            public string TwelveMonth { get; set; }
            public string TwoYears { get; set; }
        }

        public class RequestedWorkInfo
        {
            public string LongTextWashingtonSquare { get; set; }
            public string ShortTextWashingtonSquare { get; set; }
            public string ShortTextEastStreet { get; set; }
        }

        public class ReferralDetailsInfo
        {
            public string LongTextWashingtonSquare { get; set; }
            public string ShortTextWashingtonSquare { get; set; }
            public string ShortTextEastStreet { get; set; }
        }

        public class StatusesInfo
        {
            public string Draft { get; set; }
            public string ShortTextWashingtonSquare { get; set; }
            public string ShortTextEastStreet { get; set; }
        }

        public class ButtonsInfo
        {
            public string Close { get; set; }
            public string Approve { get; set; }
            public string Decline { get; set; }
        }

        private static BasicDataInfo CreateBasicDataInfo()
        {
            return new BasicDataInfo
            {
                NotAssignetLabel = "Not assigned",
                DateCurrent = DateTime.Now.ToString("MM/dd/yyyy"), // Format the date "12/14/2024"
            };
        }

        private static RequestedOfferPriceInfo CreateRequestedOfferPriceInfo()
        {
            return new RequestedOfferPriceInfo
            {
                FirstPriceStatic = "1200",
                SecondPriceStatic = "2500",
            };
        }

        private static MonthsFreeInfo CreateMonthsFreeInfo()
        {
            return new MonthsFreeInfo
            {
                OneMonth = "1",
                TwoMonths = "2",
            };
        }

        private static MonthlyRentsPrePaymentInfo CreateMonthlyRentsPrePaymentInfo()
        {
            return new MonthlyRentsPrePaymentInfo
            {
                OneMonth = "1",
                TwoMonth = "2",
            };
        }

        private static RentalTermsInfo CreateRentalTermsInfo()
        {
            return new RentalTermsInfo
            {
                TwelveMonth = "12",
                TwoYears = "2",
            };
        }

        private static RequestedWorkInfo CreateRequestedWorkInfo()
        {
            return new RequestedWorkInfo
            {
                LongTextWashingtonSquare = "Lorem 1 Washington Square Requested Work. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextWashingtonSquare = "Lorem 1 Washington Square Requested Work.",
                ShortTextEastStreet = "Lorem 111A East 51st Street Referral Details.",
            };
        }

        private static ReferralDetailsInfo CreateReferralDetailsInfo()
        {
            return new ReferralDetailsInfo
            {
                LongTextWashingtonSquare = "Lorem 1 Washington Square Referral Details. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextWashingtonSquare = "Lorem 1 Washington Square Referral Details.",
                ShortTextEastStreet = "Lorem 111A East 51st Street Referral Details.",
            };
        }

        private static StatusesInfo CreateStatusesInfo()
        {
            return new StatusesInfo
            {
                Draft = "Draft",
                ShortTextWashingtonSquare = "Lorem 1 Washington Square Referral Details.",
                ShortTextEastStreet = "Lorem 111A East 51st Street Referral Details.",
            };
        }

        private static ButtonsInfo CreateButtonsInfo()
        {
            return new ButtonsInfo
            {
                Close = "Close",
                Decline = "Decline",
                Approve = "Approve",
            };
        }
    }
}
