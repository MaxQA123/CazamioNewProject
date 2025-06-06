﻿using System.Collections.Generic;

namespace CazamioNewProject.ApiHelpers
{
    public class Headers
    {
        public static ICollection<KeyValuePair<string, string>> HeadersTenantCreator()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("marketplace", "https://landlord-demo.casamio-test.lol"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersTenantOccupant()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("marketplace", "https://landlord-demo.casamio-test.lol"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersTenantGuarantor()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("marketplace", "https://landlord-demo.casamio-test.lol"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersSuperAdmin(string token)

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {token}"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersMarketplaceAdmin(string token)

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {token}"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersBroker(string token)

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {token}"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersAgent(string token)

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {token}"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersAgentBroker(string token)

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {token}"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersForLogIn()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));

            return headersCommon;
        }
    }
}
