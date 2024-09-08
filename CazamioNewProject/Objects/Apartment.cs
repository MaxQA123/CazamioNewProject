using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Apartment
    {
        public string TextLong { get; set; }
        public string AgentAssignedToApartmentAsAgent { get; set; }

        public LinksToVideosInfo LinksToVideos { get; set; }

        public class RentalTermsInfo
        {
            public string OneYear { get; set; }
            public string TwelveMonths { get; set; }
            public string EighteenMonths { get; set; }
            public string DefaultRentalTerms { get; set; }
        }

        public class BuildingShortAddressInfo
        {
            public string MarkAdmAssignedBroker { get; set; }
            public string MarkAdmAssignedAgent { get; set; }
            public string BrokerAssignedBroker { get; set; }
            public string BrokerAssignedAgent { get; set; }
        }

        public class LinksToVideosInfo
        {
            public string LinkYouTube { get; set; }
            public string LinkVimeo { get; set; }
            public string LinkDailymotion { get; set; }
        }

        public Apartment Generate()
        {
            string linkYouTube = "https://www.youtube.com/watch?v=0mh5d2a8wp0";
            string linkVimeo = "https://vimeo.com/988164102";
            string linkDailymotion = "";

            var apartment = new Apartment()
            {

                LinksToVideos = new LinksToVideosInfo
                {
                    LinkYouTube = linkYouTube,
                    LinkVimeo = linkVimeo,
                    LinkDailymotion = linkDailymotion
                },
            };
            return apartment;
        }
    }
}
