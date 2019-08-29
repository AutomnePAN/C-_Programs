using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceSample
{
    /// <summary>
    /// SampleService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.wrox.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class SampleService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReverseString(string message)
        {
            return new string(message.Reverse().ToArray());
        }

        public enum TemperatureType
        {
            Fahrenheit,
            Celsius
        }
        public class GetWeatherRequest
        {
            public string City { get; set; }
            public TemperatureType TemperatureType { get; set; }
        }

        public enum TemperatureCondition
        {
            Rainy,
            Sunny,
            Cloudy,
            Thunderstorm
        }
        public class GetWeatherResponse
        {
            public TemperatureCondition Condition { get; set; }
            public int Temperature { get; set; }
        }
        [WebMethod]
        public GetWeatherResponse GetWeather(GetWeatherRequest req)
        {
            var resp = new GetWeatherResponse();
            var r = new Random();
            int celsius = r.Next(-20, 50);
            if (req.TemperatureType == TemperatureType.Celsius)
                resp.Temperature = celsius;
            else
                resp.Temperature = (212 - 32) / 100 * celsius + 32;
            if (req.City == "Redmond")
                resp.Condition = TemperatureCondition.Rainy;
            else
                resp.Condition = (TemperatureCondition)r.Next(0, 3);
            return resp;
        }
    }

    
}
