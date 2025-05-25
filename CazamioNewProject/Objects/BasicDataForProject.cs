using System;

namespace CazamioNewProject.Objects
{
    public class BasicDataForProject
    {
        public PasswordsInfo Passwords { get; set; }

        public static BasicDataForProject Generate()
        {
            return new BasicDataForProject
            {
                Passwords = CreatePasswordsInfo(),
            };
        }

        public class PasswordsInfo
        {
            public string BasicStaticFirst { get; set; }
        }

        private static PasswordsInfo CreatePasswordsInfo()
        {
            return new PasswordsInfo
            {
                BasicStaticFirst = "Qwerty123!",
            };
        }
    }
}
