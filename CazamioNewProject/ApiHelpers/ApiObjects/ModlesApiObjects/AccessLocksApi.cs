using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects
{
    public class AccessLocksApi
    {
        public LocationInfo Location { get; set; }
        //public BuildingAmenitesInfo BuildingAmenites { get; set; }
        //public AmenityTypeInfo AmenityType { get; set; }

        public class LocationInfo
        {
            public string FirstByDefault { get; set; }
            public string SecondByDefault { get; set; }
        }

        //public class BuildingAmenitesInfo
        //{
        //    public string LaundryInBuildingName { get; set; }
        //    public string GymName { get; set; }
        //}

        //public class AmenityTypeInfo
        //{
        //    public string Building { get; set; }
        //    public string Apartment { get; set; }
        //}

        public AccessLocksApi Generate()
        {
            string firstByDefault = "Main Entrance";
            string secondByDefault = "Apartment";

            var accessLocksApi = new AccessLocksApi()
            {
                Location = new LocationInfo
                {
                    FirstByDefault = firstByDefault,
                    SecondByDefault = secondByDefault
                }
            };
            return accessLocksApi;
        }
    }
}
