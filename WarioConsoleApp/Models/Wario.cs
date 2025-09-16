using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WarioConsoleApp.Models
{
    [XmlRoot("wario")]
    public class Wario
    {
        [XmlElement("input")]
        [JsonPropertyName("input")]
        public Input? Input { get; set; }
        [XmlElement("output")]
        [JsonPropertyName("output")]
        public Output? Output { get; set; }
        [XmlElement("variable")]
        [JsonPropertyName("variable")]
        public Variable? Variable { get; set; }
        [XmlElement("minmax")]
        [JsonPropertyName("minmax")]
        public MinMax? MinMax { get; set; }
        [XmlAttribute("degree")]
        [JsonPropertyName("degree")]
        public string? Degree { get; set; }
        [XmlAttribute("pressure")]
        [JsonPropertyName("pressure")]
        public string? Pressure { get; set; }
        [XmlAttribute("serial_number")]
        [JsonPropertyName("serial_number")]
        public string? SerialNumber { get; set; }
        [XmlAttribute("model")]
        [JsonPropertyName("model")]
        public string? Model { get; set; }
        [XmlAttribute("firmware")]
        [JsonPropertyName("firmware")]
        public string? Firmware { get; set; }
        [XmlAttribute("runtime")]
        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }
        [XmlAttribute("freemem")]
        [JsonPropertyName("freemem")]
        public int Freemem { get; set; }
        [XmlAttribute("date")]
        [JsonPropertyName("date")]
        public string? Date { get; set; }
        [XmlAttribute("time")]
        [JsonPropertyName("time")]
        public string? Time { get; set; }
        [XmlAttribute("language")]
        [JsonPropertyName("language")]
        public int Language { get; set; }
        [XmlAttribute("pressure_type")]
        [JsonPropertyName("pressure_type")]
        public int PressureType { get; set; }
        [XmlAttribute("r")]
        [JsonPropertyName("r")]
        public int R { get; set; }
        [XmlAttribute("bip")]
        [JsonPropertyName("bip")]
        public int Bip { get; set; }
    }
    public class Input
    {
        [XmlElement("sensor")]
        [JsonPropertyName("sensor")]
        public List<Sensor>? Sensors { get; set; }
    }
    public class Output
    {
        [XmlElement("sensor")]
        [JsonPropertyName("sensor")]
        public List<Sensor>? Sensors { get; set; }
    }
    public class Sensor
    {
        [XmlElement("type")]
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [XmlElement("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [XmlElement("name")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [XmlElement("place")]
        [JsonPropertyName("place")]
        public string? Place { get; set; }
        [XmlElement("value")]
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
    public class Variable
    {
        [XmlElement("sunrise")]
        [JsonPropertyName("sunrise")]
        public string? Sunrise { get; set; }
        [XmlElement("sunset")]
        [JsonPropertyName("sunset")]
        public string? Sunset { get; set; }
        [XmlElement("civstart")]
        [JsonPropertyName("civstart")]
        public string? Civstart { get; set; }
        [XmlElement("civend")]
        [JsonPropertyName("civend")]
        public string? Civend { get; set; }
        [XmlElement("nautstart")]
        [JsonPropertyName("nautstart")]
        public string? Nautstart { get; set; }
        [XmlElement("nautend")]
        [JsonPropertyName("nautend")]
        public string? Nautend { get; set; }
        [XmlElement("astrostart")]
        [JsonPropertyName("astrostart")]
        public string? Astrostart { get; set; }
        [XmlElement("astroend")]
        [JsonPropertyName("astroend")]
        public string? Astroend { get; set; }
        [XmlElement("daylen")]
        [JsonPropertyName("daylen")]
        public string? Daylen { get; set; }
        [XmlElement("civlen")]
        [JsonPropertyName("civlen")]
        public string? Civlen { get; set; }
        [XmlElement("nautlen")]
        [JsonPropertyName("nautlen")]
        public string? Nautlen { get; set; }
        [XmlElement("astrolen")]
        [JsonPropertyName("astrolen")]
        public string? Astrolen { get; set; }
        [XmlElement("moonphase")]
        [JsonPropertyName("moonphase")]
        public int Moonphase { get; set; }
        [XmlElement("isday")]
        [JsonPropertyName("isday")]
        public int Isday { get; set; }
        [XmlElement("bio")]
        [JsonPropertyName("bio")]
        public int Bio { get; set; }
        [XmlElement("pressure_old")]
        [JsonPropertyName("pressure_old")]
        public double PressureOld { get; set; }
        [XmlElement("temperature_avg")]
        [JsonPropertyName("temperature_avg")]
        public double TemperatureAvg { get; set; }
        [XmlElement("agl")]
        [JsonPropertyName("agl")]
        public int Agl { get; set; }
        [XmlElement("fog")]
        [JsonPropertyName("fog")]
        public int Fog { get; set; }
        [XmlElement("lsp")]
        [JsonPropertyName("lsp")]
        public int Lsp { get; set; }
    }
    public class MinMax
    {
        [XmlElement("s")]
        [JsonPropertyName("s")]
        public List<MinMaxSensor>? MinMaxSensors { get; set; }
    }
    public class MinMaxSensor
    {
        [XmlAttribute("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [XmlAttribute("min")]
        [JsonPropertyName("min")]
        public double Min { get; set; }
        [XmlAttribute("max")]
        [JsonPropertyName("max")]
        public double Max { get; set; }
    }
}

