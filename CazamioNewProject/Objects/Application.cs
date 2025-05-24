using System;

namespace CazamioNewProject.Objects
{
    public class Application
    {
        public BasicDataInfo BasicData { get; set; }
        public AddressApartmentInfo AddressApartment { get; set; }
        public RequestedOfferPriceInfo RequestedOfferPrice { get; set; }
        public LeasePriceInfo LeasePrice { get; set; }
        public SecurityDepositInfo SecurityDeposit { get; set; }
        public MonthsFreeInfo MonthsFree { get; set; }
        public MonthlyRentsPrePaymentInfo MonthlyRentsPrePayment { get; set; }
        public RentalTermsInfo RentalTerms { get; set; }
        public RequestedWorkInfo RequestedWork { get; set; }
        public ReferralDetailsInfo ReferralDetails { get; set; }
        public AdditionalInfoInfo AdditionalInfo { get; set; }
        public StatusesInfo Statuses { get; set; }
        public ButtonsInfo Buttons { get; set; }

        public static Application Generate()
        {
            return new Application
            {
                BasicData = CreateBasicDataInfo(),
                AddressApartment = CreateAddressApartmentInfo(),
                RequestedOfferPrice = CreateRequestedOfferPriceInfo(),
                LeasePrice = CreateLeasePriceInfo(),
                SecurityDeposit = CreateSecurityDepositInfo(),
                MonthsFree = CreateMonthsFreeInfo(),
                MonthlyRentsPrePayment = CreateMonthlyRentsPrePaymentInfo(),
                RentalTerms = CreateRentalTermsInfo(),
                RequestedWork = CreateRequestedWorkInfo(),
                ReferralDetails = CreateReferralDetailsInfo(),
                AdditionalInfo = CreateAdditionalInfoInfo(),
                Statuses = CreateStatusesInfo(),
                Buttons = CreateButtonsInfo(),
            };
        }

        public class BasicDataInfo
        {
            public string NotAssignetLabel { get; set; }
            public string DateCurrent { get; set; }
        }

        public class AddressApartmentInfo
        {
            public string NineNineNineEightSaintJohnsonPlace { get; set; }
        }

        public class RequestedOfferPriceInfo
        {
            public string FirstPriceStatic { get; set; }
            public string SecondPriceStatic { get; set; }
            public string ThirdPriceStatic { get; set; }
            public string FourthPriceStatic { get; set; }
            public string FifthPriceStatic { get; set; }
            public string SixthPriceStatic { get; set; }
        }

        public class LeasePriceInfo
        {
            public string FirstPriceStatic { get; set; }
            public string SecondPriceStatic { get; set; }
            public string ThirdPriceStatic { get; set; }
            public string FourthPriceStatic { get; set; }
            public string FifthPriceStatic { get; set; }
            public string SixthPriceStatic { get; set; }
        }

        public class SecurityDepositInfo
        {
            public string FirstPriceStatic { get; set; }
            public string SecondPriceStatic { get; set; }
            public string ThirdPriceStatic { get; set; }
            public string FourthPriceStatic { get; set; }
            public string FifthPriceStatic { get; set; }
            public string SixthPriceStatic { get; set; }
        }

        public class MonthsFreeInfo
        {
            public string OneMonth { get; set; }
            public string TwoMonths { get; set; }
            public string ThreeMonths { get; set; }
        }

        public class MonthlyRentsPrePaymentInfo
        {
            public string OneMonth { get; set; }
            public string TwoMonths { get; set; }
            public string ThreeMonths { get; set; }
        }

        public class RentalTermsInfo
        {
            public string TwentyFourMonths { get; set; }
            public string TwelveMonths { get; set; }
            public string NineMonths { get; set; }
            public string OneYear { get; set; }
            public string TwoYears { get; set; }
        }

        public class RequestedWorkInfo
        {
            public string LongTextNineNineNineEightSaintJohnsonPlace { get; set; }
            public string ShortTextNineNineNineEightSaintJohnsonPlace { get; set; }
            public string LongTextWashingtonSquare { get; set; }
            public string ShortTextWashingtonSquare { get; set; }
            public string ShortTextEastStreet { get; set; }
            public string ShortTextGatesAvenue { get; set; }
            public string LongTextGatesAvenue { get; set; }
            public string ShortTextDeanStreet { get; set; }
            public string LongTextDeanStreet { get; set; }
        }

        public class ReferralDetailsInfo
        {
            public string LongTextNineNineNineEightSaintJohnsonPlace { get; set; }
            public string ShortTextNineNineNineEightSaintJohnsonPlace { get; set; }
            public string LongTextWashingtonSquare { get; set; }
            public string ShortTextWashingtonSquare { get; set; }
            public string ShortTextEastStreet { get; set; }
            public string ShortTextGatesAvenue { get; set; }
            public string LongTextGatesAvenue { get; set; }
            public string ShortTextDeanStreet { get; set; }
            public string LongTextDeanStreet { get; set; }
        }

        public class AdditionalInfoInfo
        {
            public string ShortTextGatesAvenue { get; set; }
            public string LongTextGatesAvenue { get; set; }
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

        private static AddressApartmentInfo CreateAddressApartmentInfo()
        {
            return new AddressApartmentInfo
            {
                NineNineNineEightSaintJohnsonPlace = "",
            };
        }

        private static RequestedOfferPriceInfo CreateRequestedOfferPriceInfo()
        {
            return new RequestedOfferPriceInfo
            {
                FirstPriceStatic = "1200",
                SecondPriceStatic = "2500",
                ThirdPriceStatic = "16000",
                FourthPriceStatic = "900",
                FifthPriceStatic = "",
                SixthPriceStatic = "3999",
            };
        }

        private static LeasePriceInfo CreateLeasePriceInfo()
        {
            return new LeasePriceInfo
            {
                FirstPriceStatic = "$2500",
                SecondPriceStatic = "$1555",
                ThirdPriceStatic = "$16333",
                FourthPriceStatic = "$900",
                FifthPriceStatic = "$10333",
                SixthPriceStatic = "3999",
            };
        }

        private static SecurityDepositInfo CreateSecurityDepositInfo()
        {
            return new SecurityDepositInfo
            {
                FirstPriceStatic = "5000",
                SecondPriceStatic = "",
                ThirdPriceStatic = "32000",
                FourthPriceStatic = "1800",
                FifthPriceStatic = "",
                SixthPriceStatic = "7998",
            };
        }

        private static MonthsFreeInfo CreateMonthsFreeInfo()
        {
            return new MonthsFreeInfo
            {
                OneMonth = "1",
                TwoMonths = "2",
                ThreeMonths = "3",
            };
        }

        private static MonthlyRentsPrePaymentInfo CreateMonthlyRentsPrePaymentInfo()
        {
            return new MonthlyRentsPrePaymentInfo
            {
                OneMonth = "1",
                TwoMonths = "2",
                ThreeMonths = "3",
            };
        }

        private static RentalTermsInfo CreateRentalTermsInfo()
        {
            return new RentalTermsInfo
            {
                TwentyFourMonths = "24",
                TwelveMonths = "12",
                NineMonths = "9",
                OneYear = "1",
                TwoYears = "2",
            };
        }

        private static RequestedWorkInfo CreateRequestedWorkInfo()
        {
            return new RequestedWorkInfo
            {
                LongTextNineNineNineEightSaintJohnsonPlace = "Lorem 9998 Saint Johnson Pl Requested Work. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextNineNineNineEightSaintJohnsonPlace = "Lorem 9998 Saint Johnson Pl Requested Work. ipsum",
                LongTextWashingtonSquare = "Lorem 1 Washington Square Requested Work. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextWashingtonSquare = "Lorem 1 Washington Square Requested Work.",
                ShortTextEastStreet = "Lorem 111A East 51st Street Reqeusted work.",
                ShortTextGatesAvenue = "Lorem 12867 Gates Avenue Reqeusted work.",
                LongTextGatesAvenue = "Lorem 12867 Gates Avenue Reqeusted work. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextDeanStreet = "Lorem 12867 Dean Street Reqeusted work.",
                LongTextDeanStreet = "Lorem 12867 Dean Street Reqeusted work. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
            };
        }

        private static ReferralDetailsInfo CreateReferralDetailsInfo()
        {
            return new ReferralDetailsInfo
            {
                LongTextNineNineNineEightSaintJohnsonPlace = "Lorem 9998 Saint Johnson Pl Referral Details. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextNineNineNineEightSaintJohnsonPlace = "Lorem 9998 Saint Johnson Pl Referral Details. ipsum",
                LongTextWashingtonSquare = "Lorem 1 Washington Square Referral Details. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextWashingtonSquare = "Lorem 1 Washington Square Referral Details.",
                ShortTextEastStreet = "Lorem 111A East 51st Street Referral Details.",
                ShortTextGatesAvenue = "Lorem 12867 Gates Avenue Referral Details.",
                LongTextGatesAvenue = "Lorem 12867 Gates Avenue Referral Details. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
                ShortTextDeanStreet = "Lorem 12867 Dean Street Referral Details.",
                LongTextDeanStreet = "Lorem 12867 Dean Street Referral Details. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
            };
        }

        private static AdditionalInfoInfo CreateAdditionalInfoInfo()
        {
            return new AdditionalInfoInfo
            {
                ShortTextGatesAvenue = "Lorem 12867 Gates Avenue ADDITIONAL INFO APPLICATION",
                LongTextGatesAvenue = "Lorem 12867 Gates Avenue ADDITIONAL INFO APPLICATION. Lorem ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit.",
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
