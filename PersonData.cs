namespace CalculateImc
{
    public class PersonData
    {
        public PersonData(float heigth, float weight)
        {
            Heigth = heigth;
            Weight = weight;
        }

        public float Heigth { get; private set; }
        public float Weight { get; private set; }
    }
}
