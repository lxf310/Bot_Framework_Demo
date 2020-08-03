using System.Collections.Generic;

namespace IdiotBot.Business
{
    public class MockSecretVault
    {
        // Mock data storage of bot passwords.
        // Key: bot id
        // Value: bot password
        public static Dictionary<string, string> Vault = new Dictionary<string, string>
        {
            {"f2b5b99d-5ee4-47df-ae0e-8493020e1d08", "BdP:w/WdbaF$Ud4dCjA#(E$NU+IKn}s+" }
        };
    }
}
