using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Windows.Markup;
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

        public static List<object> GetLatestValuesFromSheet(DateOnly date, string sheetRange)
        {
            List<object> responseList = new List<object>();
            int sheetIndex = GetValuesFromSheet(date);
            string range = $"{sheet}!{sheetRange}{sheetIndex - 1}";
            GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange response = request.Execute();

            while (response.Values == null)
            {
                range = $"{sheet}!{sheetRange}{sheetIndex - 1}";
                request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                response = request.Execute();
                sheetIndex -= 1;
            }
            responseList.Add(response.Values[0][0]);
            return responseList;
        }

        public static void CreateEntry(List<object> result, int sheetIndex, string sheetRange, string urlRange, List<object> latestValues, string latestBankrollSheetRange)
        {
            var imageBankrollRange = $"{sheet}!{sheetRange}{sheetIndex}";
            var latestBankrollRange = $"{sheet}!{latestBankrollSheetRange}{sheetIndex}";
            var imageUrlRange = $"{sheet}!{urlRange}{sheetIndex}";
            

            List<object> bankrollList = new List<object>();
            List<object> imageUrlList = new List<object>();
            List<object> latestBankroll = new List<object>();
            

            bankrollList.Add(result[0]);
            imageUrlList.Add(result[1]);
            latestBankroll.Add(latestValues[0]);
            

            var objectList1 = bankrollList.ToList();
            var objectList2 = imageUrlList.ToList();
            

            var bankrollValueRange = new ValueRange();
            bankrollValueRange.Values = new List<IList<object>> { objectList1 };
            var appendRequestBankroll = service.Spreadsheets.Values.Append(bankrollValueRange, spreadsheetId, imageBankrollRange);

            var imageUrlValueRange = new ValueRange();
            imageUrlValueRange.Values = new List<IList<object>> { objectList2 };
            var appendImageUrlRange = service.Spreadsheets.Values.Append(imageUrlValueRange, spreadsheetId, imageUrlRange);


            var latestBankrollValueRange = new ValueRange();
            latestBankrollValueRange.Values = new List<IList<object>> { latestValues };
            var appendLatestBankrollValueRange = service.Spreadsheets.Values.Append(latestBankrollValueRange, spreadsheetId, latestBankrollRange);

            

            appendRequestBankroll.ValueInputOption = AppendRequest.ValueInputOptionEnum.USERENTERED;
            appendImageUrlRange.ValueInputOption = AppendRequest.ValueInputOptionEnum.USERENTERED;
            appendLatestBankrollValueRange.ValueInputOption = AppendRequest.ValueInputOptionEnum.USERENTERED;
           

            appendRequestBankroll.Execute();
            appendImageUrlRange.Execute();
            appendLatestBankrollValueRange.Execute();
            
        }

        public static void CreateEntry(List<object> graphUrl, string graphSheetRange, int sheetIndex)
        {
            var graphUrlRange = $"{sheet}!{graphSheetRange}{sheetIndex}";

            List<object> graphList = new List<object>();
            graphList.Add(graphUrl[0]);

            var objectList3 = graphList.ToList();

            var graphUrlValueRange = new ValueRange();
            graphUrlValueRange.Values = new List<IList<object>> { objectList3 };
            var appendGraphUrl = service.Spreadsheets.Values.Append(graphUrlValueRange, spreadsheetId, graphUrlRange);

            appendGraphUrl.ValueInputOption = AppendRequest.ValueInputOptionEnum.USERENTERED;
            appendGraphUrl.Execute();

        }
    }
}
