using UnityEngine;

namespace Source.LevelSettings
{
    public interface ILevelSettings
    {
        uint Prize { get; }
        
        uint TryGetSum(uint index);
        Sprite TryGetSprite(uint index);
    }
}