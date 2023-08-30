using UnityEditor;
using UnityEngine;

namespace Source.LevelSettings
{
    public interface ILevelSettings
    {
        SceneAsset SceneAsset { get; }
        ILevelSettings NextLevelSettings { get; }
        
        uint Prize { get; }
        
        uint TryGetSum(uint index);
        Sprite TryGetSprite(uint index);
    }
}