namespace Source.LevelSettings
{
    public interface ILevelSettings
    {
        uint Prize { get; }
        
        uint TryGetSum(uint index);
    }
}