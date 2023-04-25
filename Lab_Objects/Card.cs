namespace Lab_Objects
{
    internal class Card
    {
        public string Type { get; set; }

        //Constructor
        public Card(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return Type + " card";
        }
    }
}