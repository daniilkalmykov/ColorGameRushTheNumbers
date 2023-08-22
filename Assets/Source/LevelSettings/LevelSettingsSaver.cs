using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.LevelSettings
{
    internal static class LevelSettingsSaver
    {
        private static ILevelSettings _levelSettings;

        public static void Save(ILevelSettings levelSettings)
        {
            _levelSettings = levelSettings;
        }

        public static ILevelSettings GetLevelSettings()
        {
            return _levelSettings;
        }
    }
}