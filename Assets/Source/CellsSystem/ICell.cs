namespace Source.CellsSystem
{
    public interface ICell
    {
        int CurrentNumber { get; }

        void Tap();
    }
}