namespace Comparsion.Models
{
    [Serializable]
    public struct Element: IEquatable<Element>, IComparable<Element>
    {
        public Element(long value, long originalPosition)
        {
            Value = value;
            OriginalPosition = originalPosition;
        }

        public long Value { get; set; }
        public long OriginalPosition { get; set; }

        public int CompareTo(Element other)
        {
            return Value.CompareTo(other.Value);
        }

        public bool Equals(Element other)
        {
            if (this.Value == other.Value) return true;
            return false;
        }

        public override string ToString()
        {
            return String.Format("{0,6},{1,6}", Value, OriginalPosition);
        }
    }
}
