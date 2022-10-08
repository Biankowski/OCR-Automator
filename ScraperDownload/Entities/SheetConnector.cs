using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automator.Entities
{
    public class SheetConnector
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Automator";
        static readonly string name = "Tester";
        static SheetsService service;

        public static bool Connect(string configurationFile)
        {
            GoogleCredential credential;

            try
            {
                using(var stream = new FileStream(configurationFile + ".json", FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
                }
                service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
