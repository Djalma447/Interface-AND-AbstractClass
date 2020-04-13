using Course.Models.Enums;

namespace Course.Models.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
