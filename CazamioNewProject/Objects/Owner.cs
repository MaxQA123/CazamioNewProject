﻿using CazamioNewProject.GuiHelpers;
using RimuTec.Faker;

namespace CazamioNewProject.Objects
{
    public class Owner
    {
        public string CompanyName { get; set; }
        public string CompanyNameWithBroker { get; set; }
        public string CompanyNameWithAgent { get; set; }
        public string AlreadyCreatedCompanyNameWithBroker { get; set; }
        public string AlreadyCreatedCompanyNameWithAgent { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string OfficeLocation { get; set; }
        public string InternalNotes { get; set; }
        public string PhoneNumber { get; set; }
        public string ExtensionNumber { get; set; }
        public string OwnerNumberOfMonths { get; set; }
        public string TenantNumberOfMonths { get; set; }
        public string OwnerPercentage { get; set; }
        public string TenantPercentage { get; set; }
        public string TakeOff { get; set; }
        public string EmailAddressOwnerForAgent { get; set; }
        public string EmailAddressOwnerForBroker { get; set; }

        public Owner Generate()
        {
            string companyName = "OOO assigned role";
            string roleBroker = "Broker";
            string roleAgent = "Agent";
            string alreadyCreatedCompanyNameWithBroker = "For Autotest For Broker";
            string alreadyCreatedCompanyNameWithAgent = "For Autotest For Agent Broker";
            string FullName = Name.FirstName() + " " + Name.LastName();
            string firstName = Name.FirstName();
            string lastName = Name.LastName();
            string shortEmail = GenerateRandomData.RandomEmail(5) + GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomEmail(2);
            string officeLocation = Address.City();
            string internalNotes = "Owner lorem ipsum (12345) (&%$#@!)";
            string phoneNumber = "585" + GenerateRandomData.RandomPhoneNumber(7);
            string extensionNumber = "325" + GenerateRandomData.RandomPhoneNumber(7);
            string ownerNumberOfMonths = GenerateRandomData.RandomNumberWithoutZero(1);
            string tenantNumberOfMonths = GenerateRandomData.RandomNumberWithoutZero(1);
            string ownerPercentage = GenerateRandomData.RandomNumberWithoutZero(2);
            string tenantPercentage = GenerateRandomData.RandomNumberWithoutZero(2);
            string takeOff = GenerateRandomData.RandomNumberWithoutZero(2);
            string emailAddressOwnerForAgent = "owner2forag5bro@putsbox.com";
            string emailAddressOwnerForBroker = "owner2for5broker@putsbox.com";

            var owner = new Owner()
            {
                CompanyName = companyName,
                CompanyNameWithAgent = companyName + " " + roleAgent,
                CompanyNameWithBroker = companyName + " " + roleBroker,
                AlreadyCreatedCompanyNameWithBroker = alreadyCreatedCompanyNameWithBroker,
                AlreadyCreatedCompanyNameWithAgent = alreadyCreatedCompanyNameWithAgent,
                FullName = FullName,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = shortEmail + EmailNameDomen.PUTS_BOX,
                ShortEmail = shortEmail,
                OfficeLocation = officeLocation,
                InternalNotes = internalNotes,
                PhoneNumber = phoneNumber,
                ExtensionNumber = extensionNumber,
                OwnerNumberOfMonths = ownerNumberOfMonths,
                TenantNumberOfMonths = tenantNumberOfMonths,
                OwnerPercentage = ownerPercentage,
                TenantPercentage = tenantPercentage,
                TakeOff = takeOff,
                EmailAddressOwnerForAgent = emailAddressOwnerForAgent,
                EmailAddressOwnerForBroker = emailAddressOwnerForBroker,
            };
            return owner;
        }
    }
}