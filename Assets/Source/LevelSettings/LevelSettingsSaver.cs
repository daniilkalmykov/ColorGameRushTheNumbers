namespace Source.LevelSettings
{
    internal static class LevelSettingsSaver
    {
        private static LevelSettings _levelSettings;

        public static void Save(LevelSettings levelSettings)
        {
            _levelSettings = levelSettings;
        }

        public static LevelSettings GetLevelSettings()
        {
            return _levelSettings;
        }
    }
}