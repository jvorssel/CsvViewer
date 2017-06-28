namespace CsvViewer {
    public class CsvQuote
    {
        public char Character { get; }

        public string Name { get; }

        public CsvQuote(char character, string name)
        {
            Character = character;
            Name = name;
        }
    }
}