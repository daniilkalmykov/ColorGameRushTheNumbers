namespace Source.CellsSystem
{
    internal sealed class Cell : ICell
    {
        private const int MaxNumber = 5;
        
        public int CurrentNumber { get; private set; }
        
        public void Tap()
        {
            CurrentNumber++;

            if (CurrentNumber > MaxNumber)
                CurrentNumber = 1;
        }
    }
}