using CazamioNewProject.GuiHelpers;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace ApiTestsLandlord
{
    public class ApiBaseLandlord
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AllureConfigFilesHelper.CreateJsonConfigFile();
        }

        [SetUp]

        public void SetUp()
        {

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {

        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Console.WriteLine(TestContext.CurrentContext.Result.Outcome.Status);
            }
        }
    }
}
