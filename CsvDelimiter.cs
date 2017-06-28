namespace CsvViewer
{
    public class CsvDelimiter
    {
        public char Character { get; }
        public string Name { get; }

        public CsvDelimiter(char character, string name)
        {
            Character = character;
            Name = name;
        }

        public override string ToString()
        {
            var str = Name;
            if (!char.IsControl(Character))
                str += $" \"{Character}\"";

            return str;
        }
    }
}