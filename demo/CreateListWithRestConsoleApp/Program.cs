using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace ConsoleApplication1 {
  class Program {
    static void Main(string[] args) {
      // NOTE this assumes you are running locally on-prem with Windows auth
      // as this does not pass along an access token in the header for authentication

      // get security digest
      HttpWebRequest request = WebRequest.CreateHttp("http://site/_api/contextinfo") as HttpWebRequest;
      request.UseDefaultCredentials = true;
      request.Method = "POST";
      request.Accept = "application/json;odata=verbose";
      request.ContentLength = 0;

      var response = request.GetResponse();
      var rawJson = new StreamReader(response.GetResponseStream()).ReadToEnd();
      var serializer = new JavaScriptSerializer();
      var spContextInfo = serializer.Deserialize<SpContextInfo>(rawJson);
      var formDigest = spContextInfo.d.GetContextWebInformation.FormDigestValue;
      Console.WriteLine("Form Digest: ");
      Console.WriteLine("    " + formDigest);
      Console.WriteLine();

      // create list
      request = WebRequest.Create("http://site/_api/web/lists") as HttpWebRequest;
      request.UseDefaultCredentials = true;
      request.Method = "POST";
      request.Accept = "application/json;odata=verbose";
      request.ContentType = "application/json;odata=verbose";
      request.Headers.Add("X-RequestDigest", formDigest);

      /*
       * {
       *  "__metadata":{
       *    "type":"SP.List"
       *  },
       *  "Title":"test4",
       *  "BaseTemplate":101
       *  }
       */
      string jsonPayload = "{\"__metadata\":{\"type\":\"SP.List\"},\"Title\":\"test4\",\"BaseTemplate\":101}";
      request.ContentLength = jsonPayload.Length;
      var writer = new StreamWriter(request.GetRequestStream());
      writer.Write(jsonPayload);
      writer.Close();

      response = request.GetResponse();
      rawJson = new StreamReader(response.GetResponseStream()).ReadToEnd();
      var spList = serializer.Deserialize<SpList>(rawJson);
      
      Console.WriteLine("New list location: ");
      Console.WriteLine("    " + spList.d.DefaultView.__deferred.uri);
      Console.ReadLine();
    }
  }
}
