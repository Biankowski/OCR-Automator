using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using System.Collections;
using static Google.Apis.Sheets.v4.SpreadsheetsResource.ValuesResource;

namespace Automator.Entities
{
    public class SheetConnector
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Automator";
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

        public static int GetValuesFromSheet(DateOnly time)
        {
            string range = $"{sheet}!A1:A1000";
            GetRequest.ValueRenderOptionEnum valueRenderOption = (GetRequest.ValueRenderOptionEnum)1;  
            GetRequest.DateTimeRenderOptionEnum dateTimeRenderOption = (GetRequest.DateTimeRenderOptionEnum)1;
            GetRequest.MajorDimensionEnum majorDimension = (GetRequest.MajorDimensionEnum)2;
            GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            request.ValueRenderOption = valueRenderOption;
            request.DateTimeRenderOption = dateTimeRenderOption;
            request.MajorDimension = majorDimension;
            ValueRange response = request.Execute();

            string serializedData = JsonConvert.SerializeObject(response);
            DeserializedData deserializedData = JsonConvert.DeserializeObject<DeserializedData>(serializedData);

           foreach(var items in deserializedData.values)
            {
               for(int i = 0; i <= 1000; i++)
                {
                    if (items[i] == time.ToString())
                    {
                        return i + 1;
                    }
                }
            }
            return 0;
        }
        public static void CreateEntry(List<object> result, int sheetIndex, string sheetRange)
        {
            var range = $"{sheet}!{sheetRange}{sheetIndex}";
            var valueRange = new ValueRange();

            var objectList1 = result.ToList();
            valueRange.Values = new List<IList<object>> { objectList1 };

            var appendRequest1 = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);

            appendRequest1.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;

            appendRequest1.Execute();
        }
    }
}
