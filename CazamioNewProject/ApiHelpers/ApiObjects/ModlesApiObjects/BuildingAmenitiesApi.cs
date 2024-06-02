using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects
{
    public class BuildingAmenitiesApiModel
    {
        public IdInfo Id { get; set; }
        public BuildingAmenitesInfo BuildingAmenites { get; set; }
        public AmenityTypeInfo AmenityType { get; set; }

        public class IdInfo
        {
            public long IdLaundryInBuilding { get; set; }
            public long IdGym { get; set; }
        }

        public class BuildingAmenitesInfo
        {
            public string LaundryInBuildingName { get; set; }
            public string GymName { get; set; }
        }

        public class AmenityTypeInfo
        {
            public string Building { get; set; }
            public string Apartment { get; set; }
        }

        public BuildingAmenitiesApiModel Generate()
        {
            #region Id amenities

            long idLaundryInBuilding = 4;
            long idGym = 6;

            #endregion

            #region Name amenities

            string laundryInBuildingName = "Laundry In Building";
            string gymName = "Gym";

            #endregion

            string buildingType = "Building";

            var buildingAmenitiesApiModel = new BuildingAmenitiesApiModel()
            {
                Id = new IdInfo
                {
                    IdLaundryInBuilding = idLaundryInBuilding,
                    IdGym = idGym
                },
                BuildingAmenites = new BuildingAmenitesInfo
                {
                    LaundryInBuildingName = laundryInBuildingName,
                    GymName = gymName
                },
                AmenityType = new AmenityTypeInfo
                {
                    Building = buildingType
                }
            };
            return buildingAmenitiesApiModel;
        }
    }
}
