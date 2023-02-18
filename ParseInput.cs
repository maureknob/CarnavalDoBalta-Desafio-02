namespace CalculateImc
{
    public class ParseInput
    {
        public float ToFloat(string input)
        {
            if(float.TryParse(input, out float result))
                return result;

            return 0;
        }
    }
}
