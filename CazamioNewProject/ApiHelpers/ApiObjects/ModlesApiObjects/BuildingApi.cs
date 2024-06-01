﻿using CazamioNewProject.GuiHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects
{
    public class BuildingApi
    {
        public long AddressIdApi { get; set; }//0
        public string CountryApi { get; set; }
        public StreetApiInfo StreetApi { get; set; }//78954 Avenue A
        public string StateApi { get; set; }
        public CityApiInfo CityApi { get; set; }
        public ZipCodeInfo ZipCode { get; set; }
        public NeighborhoodApiInfo NeighborhoodApi { get; set; }
        public PetPoliciesApiInfo PetPoliciesApi { get; set; }
        public LlcNameApiInfo LlcNameApi { get; set; }
        public BuildingNameApiInfo BuildingNameApi { get; set; }
        public AmountApiInfo AmountApi { get; set; }

        public class StreetApiInfo
        {
            public string MarkAdmAssignedRoleAgntBrkr { get; set; }
            public string MarkAdmAssignedRoleBrkr { get; set; }
            public string BrokerAssignedRoleAgntBrkr { get; set; }
            public string BrokerAssignedRoleBrkr { get; set; }
            public string AgentBrokerAssignedRoleAgntBrkr { get; set; }
        }

        public class CityApiInfo
        {
            public string NewYork { get; set; }
            public string Brooklyn { get; set; }
        }

        public class ZipCodeInfo
        {
            public long ZipBuildingMarkAdmAssignedRoleAgntBrkr { get; set; }
            public long ZipBuildingMarkAdmAssignedRoleBrkr { get; set; }
            public long ZipBuildingBrokerAssignedRoleAgntBrkr { get; set; }
            public long ZipBuildingBrokerAssignedRoleBrkr { get; set; }
            public long ZipBuildingAgntBrkrAssignedRolegAgntBrkr { get; set; }
        }

        public class NeighborhoodApiInfo
        {
            public string BuildingMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string BuildingMarkAdmAssignedRoleBrkr { get; set; }
            public string BuildingBrokerAssignedRoleAgntBrkr { get; set; }
            public string BuildingBrokerAssignedRoleBrkr { get; set; }
            public string BuildingAgntBrkrAssignedRoleAgntBrkr { get; set; }
        }

        public class PetPoliciesApiInfo
        {
            public string CaseByCase { get; set; }
            public string PetFee { get; set; }
            public string AllPetsAllowed { get; set; }
            public string SmallPetsAllowed { get; set; }
            public string CatsOnly { get; set; }
            public string NoPets { get; set; }
        }

        public class LlcNameApiInfo
        {
            public string LlcNameStreetApiMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string LlcNameStreetApiMarkAdmAssignedRoleBrkr { get; set; }
            public string LlcNameStreetApiBrokerAssignedRoleAgntBrkr { get; set; }
            public string LlcNameStreetApiBrokerAssignedRoleBrkr { get; set; }
            public string LlcNameStreetApiAgentBrokerAssignedRoleAgntBrkr { get; set; }
            public string ForAgentBroker { get; set; }
            public string ForBroker { get; set; }
        }

        public class BuildingNameApiInfo
        {
            public string BuildingNameStreetApiMarkAdmAssignedRoleAgntBrkr { get; set; }
            public string BuldingNameStreetApiMarkAdmAssignedRoleBrkr { get; set; }
            public string BuldingNameStreetApiBrokerAssignedRoleAgntBrkr { get; set; }
            public string BuldingNameStreetApiBrokerAssignedRoleBrkr { get; set; }
            public string BuldingNameStreetApiAgentBrokerAssignedRoleAgntBrkr { get; set; }
            public string BuldingNameShort { get; set; }
        }

        public class AmountApiInfo
        {
            public long CreditScreeningFeeByDefaultMySpace { get; set; }
            public long CreditScreeningFeeByDefaultEvergreen { get; set; }
            public long CreditScreeningFeeByDefaultDoorway { get; set; }
            public long HoldDepositByDefaultMySpace { get; set; }
            public long HoldDepositByDefaultEvergreen { get; set; }
            public long HoldDepositByDefaultDoorway { get; set; }
            public long CreditScreeningFeeOneNumber { get; set; }
            public long CreditScreeningFeeTwoNumber { get; set; }
            public long CreditScreeningFeeThreeNumber { get; set; }
            public long HoldDepositOneNumber { get; set; }
            public long HoldDepositTwoNumber { get; set; }
            public long HoldDepositThreeNumber { get; set; }

        }

        public BuildingApi Generate()
        {
            long addressIdApi = 0;
            string countryApi = "United States";
            string llcNameForAgentBroker = "LLC QA Agent As Broker (12345) (!@#$%)";
            string llcNameForBroker = "LLC QA Broker (12345) (!@#$%)";
            string nameBuilfing = "QA-Building NAME (12345 !@#$%)";

            #region Settings Building for role Marketplace Admin

            string streetApiMarkAdmAssignedRoleAgntBrkr = "1 Saint Johnson Place";
            long zipBuildingMarkAdmAssignedRoleAgntBrkr = 11213;
            string neighborhoodMarkAdmBuildingAssignedRoleAgntBrkr = "Crown Heights";

            string streetApiMarkAdmAssignedRoleBrkr = "1 Washington Square";
            long zipBuildingMarkAdmAssignedRoleBrkr = 10012;
            string neighborhoodBuildingMarkAdmAssignedRoleBrkr = "Manhattan";

            #endregion

            #region Settings Building for role Broker

            string streetApiBrokerAssignedRoleAgntBrkr = "1 Albermale Rd";
            long zipBuildingBrokerAssignedRoleAgntBrkr = 11226;
            string neighborhoodBrokerBuildingAssignedRoleAgntBrkr = "East Flatbush";

            string streetApiBrokerAssignedRoleBrkr = "1 Crown St";
            long zipBuildingBrokerAssignedRoleBrkr = 11225;
            string neighborhoodBuildingBrokerAssignedRoleBrkr = "Crown Heights";

            #endregion

            #region Settings Building for role Agent-Broker

            string streetApiAgentBrokerAssignedRoleAgntBrkr = "1 East 51st Street Pedestrian Crossing";
            long zipBuildingAgntBrkrAssignedRoleAgntBrkr = 10022;
            string neighborhoodAgntBrkrBuildingAssignedRoleAgntBrkr = "Manhattan";

            #endregion

            string stateApi = "NY";
            string cityApiNewYork = "New York";
            string cityApiBrooklyn = "Brooklyn";
            string caseByCase = "CaseByCase";
            string petFee = "PetFee";
            string allPetsAllowed = "AllPetsAllowed";
            string smallPetsAllowed = "SmallPetsAllowed";
            string catsOnly = "CatsOnly";
            string noPets = "NoPets";
            long creditScreeningFeeByDefaultMySpace = 20;
            long holdDepositByDefaultMySpace = 500;

            var buildingApi = new BuildingApi()
            {
                AddressIdApi = addressIdApi,
                CountryApi = countryApi,
                StreetApi = new StreetApiInfo
                {
                    MarkAdmAssignedRoleAgntBrkr = streetApiMarkAdmAssignedRoleAgntBrkr,
                    MarkAdmAssignedRoleBrkr = streetApiMarkAdmAssignedRoleBrkr,
                    BrokerAssignedRoleAgntBrkr = streetApiBrokerAssignedRoleAgntBrkr,
                    BrokerAssignedRoleBrkr = streetApiBrokerAssignedRoleBrkr,
                    AgentBrokerAssignedRoleAgntBrkr = streetApiAgentBrokerAssignedRoleAgntBrkr
                },
                StateApi = stateApi,
                CityApi = new CityApiInfo
                {
                    NewYork = cityApiNewYork,
                    Brooklyn = cityApiBrooklyn
                },
                ZipCode = new ZipCodeInfo
                {
                    ZipBuildingMarkAdmAssignedRoleAgntBrkr = zipBuildingMarkAdmAssignedRoleAgntBrkr,
                    ZipBuildingMarkAdmAssignedRoleBrkr = zipBuildingMarkAdmAssignedRoleBrkr,
                    ZipBuildingBrokerAssignedRoleAgntBrkr = zipBuildingBrokerAssignedRoleAgntBrkr,
                    ZipBuildingBrokerAssignedRoleBrkr = zipBuildingBrokerAssignedRoleBrkr,
                    ZipBuildingAgntBrkrAssignedRolegAgntBrkr = zipBuildingAgntBrkrAssignedRoleAgntBrkr
                },
                NeighborhoodApi = new NeighborhoodApiInfo
                {
                    BuildingMarkAdmAssignedRoleAgntBrkr = neighborhoodMarkAdmBuildingAssignedRoleAgntBrkr,
                    BuildingMarkAdmAssignedRoleBrkr = neighborhoodBuildingMarkAdmAssignedRoleBrkr,
                    BuildingBrokerAssignedRoleAgntBrkr = neighborhoodBrokerBuildingAssignedRoleAgntBrkr,
                    BuildingBrokerAssignedRoleBrkr = neighborhoodBuildingBrokerAssignedRoleBrkr,
                    BuildingAgntBrkrAssignedRoleAgntBrkr = neighborhoodAgntBrkrBuildingAssignedRoleAgntBrkr
                },
                PetPoliciesApi = new PetPoliciesApiInfo
                {
                    CaseByCase = caseByCase,
                    PetFee = petFee,
                    AllPetsAllowed = allPetsAllowed,
                    SmallPetsAllowed = smallPetsAllowed,
                    CatsOnly = catsOnly,
                    NoPets = noPets
                },
                LlcNameApi = new LlcNameApiInfo
                {
                    LlcNameStreetApiMarkAdmAssignedRoleAgntBrkr = llcNameForAgentBroker + " " + streetApiMarkAdmAssignedRoleAgntBrkr,
                    LlcNameStreetApiMarkAdmAssignedRoleBrkr = llcNameForBroker + " " + streetApiMarkAdmAssignedRoleBrkr,
                    LlcNameStreetApiBrokerAssignedRoleAgntBrkr = llcNameForAgentBroker + " " + streetApiBrokerAssignedRoleAgntBrkr,
                    LlcNameStreetApiBrokerAssignedRoleBrkr = llcNameForBroker + " " + streetApiBrokerAssignedRoleBrkr,
                    LlcNameStreetApiAgentBrokerAssignedRoleAgntBrkr = llcNameForAgentBroker + " " + streetApiAgentBrokerAssignedRoleAgntBrkr
                },
                BuildingNameApi = new BuildingNameApiInfo
                {
                    BuildingNameStreetApiMarkAdmAssignedRoleAgntBrkr = nameBuilfing + " " + streetApiMarkAdmAssignedRoleAgntBrkr,
                    BuldingNameStreetApiMarkAdmAssignedRoleBrkr = nameBuilfing + " " + streetApiMarkAdmAssignedRoleBrkr,
                    BuldingNameStreetApiBrokerAssignedRoleAgntBrkr = nameBuilfing + " " + streetApiBrokerAssignedRoleAgntBrkr,
                    BuldingNameStreetApiBrokerAssignedRoleBrkr = nameBuilfing + " " + streetApiBrokerAssignedRoleBrkr,
                    BuldingNameStreetApiAgentBrokerAssignedRoleAgntBrkr = nameBuilfing + " " + streetApiAgentBrokerAssignedRoleAgntBrkr
                },
                AmountApi = new AmountApiInfo
                {
                    CreditScreeningFeeByDefaultMySpace = creditScreeningFeeByDefaultMySpace,
                    HoldDepositByDefaultMySpace = holdDepositByDefaultMySpace
                }
            };
            return buildingApi;
        }
    }
}
