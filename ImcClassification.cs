namespace CalculateImc
{
    public class ImcClassification
    {
        public ImcClassification(string classification, float rangeStart, float rangeEnd, string risk)
        {
            Classification = classification;
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
            Risk = risk;
        }

        public string Classification { get; private set; }
        public float RangeStart { get; private set; }
        public float RangeEnd { get; private set; }
        public string Risk { get; private set; }
    }
}
