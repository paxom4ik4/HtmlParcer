namespace HParser.Core.Habra
{
    class HabraSettings : IParserSettings
    {

        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoing = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com/ru/";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoing { get; set; }
    }
}
