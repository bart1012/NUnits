namespace UNitTestingChallenge
{
    public class Compass
    {
        public Point CompassPoint { get; private set; }

        public Compass(Point compassPoint)
        {
            CompassPoint = compassPoint;
        }

        public Point Rotate(Point point, Direction direction)
        {
            return Point.South;
        }
    }
}
