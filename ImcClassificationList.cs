namespace CalculateImc
{
    public class ImcClassificationList
    {
        public List<ImcClassification> Classifications = new List<ImcClassification>();

        public List<ImcClassification> GetClassificationList()
        {
            Classifications
                .Add(new ImcClassification("Magreza Grau III", 0, 16, String.Empty));

            Classifications
                .Add(new ImcClassification("Magreza Grau II", 16, 16.9f, String.Empty));

            Classifications
                .Add(new ImcClassification("Magreza Grau I", 17, 18.4f, String.Empty));

            Classifications
                .Add(new ImcClassification("Eutrofia", 18.5f, 24.9f, String.Empty));

            Classifications
                .Add(new ImcClassification("Sobrepeso", 25, 29.9f, "Aumentado"));

            Classifications
                .Add(new ImcClassification("Obesidade Grau I", 30, 34.9f, "Moderado"));

            Classifications
                .Add(new ImcClassification("Obesidade Grau I", 30, 34.9f, "Grave"));

            Classifications
                .Add(new ImcClassification("Obesidade Grau I", 30, 34.9f, "Muito Grave"));

            return Classifications;
        }
    }
}
