namespace SortingAlgorithmSimulation
{
    public enum MoveType { UP_DOWN, RIGHT_LEFT, DOWN_UP, STOP}

    public class Status
    {
        public MoveType Type { get; set; }
        public int Local1 { get; set; }
        public int Local2 { get; set; }
    }
}