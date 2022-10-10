using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;


namespace Automator.Entities
{
    public class SheetConnector
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Automator";
        static readonly string name = "Automator";
        static readonly string sheet = "Tester";
        public static string spreadsheetId;
        static SheetsService service;

        public static bool Connect(string configurationFile)
        {
            GoogleCredential credential;
            try
            {
                using(var stream = new FileStream(configurationFile, FileMode.Open, FileAccess.Read))
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
        public static void CreateEntry(List<object> result)
        {
            var range = $"{sheet}!A27:C";
            var valueRange = new ValueRange();

            var objectList = result.ToList();
            valueRange.Values = new List<IList<object>> { objectList };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
        }
    }
}
