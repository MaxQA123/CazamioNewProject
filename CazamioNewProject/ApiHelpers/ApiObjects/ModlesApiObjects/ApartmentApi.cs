using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects
{
    public class ApartmentApi
    {
        public OneFiveZeroZeroNormanStreetInfo OneFiveZeroZeroNormanStreet { get; set; }

        public static ApartmentApi Generate()
        {
            return new ApartmentApi
            {
                OneFiveZeroZeroNormanStreet = CreateOneFiveZeroZeroNormanStreetInfo(),
            };
        }

        public class OneFiveZeroZeroNormanStreetInfo
        {
            public string UnitStatic { get; set; }
            public string UnitThreeNumberRandom { get; set; }
        }

        private static OneFiveZeroZeroNormanStreetInfo CreateOneFiveZeroZeroNormanStreetInfo()
        {
            return new OneFiveZeroZeroNormanStreetInfo
            {
                UnitStatic = "1",

            };
        }
    }
}
