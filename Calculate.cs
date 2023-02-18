namespace CalculateImc
{
    internal class Calculate
    {
        public Calculate(PersonData personData)
        {
            this.personData = personData;
        }

        public PersonData personData { get; private set; }

        public float ClacResult()
        {
            return this.personData.Weight / (this.personData.Heigth * this.personData.Heigth);
        }
    }
}
