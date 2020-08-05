namespace GameLauncher.Game
{
    public interface IGame
    {
        /// <summary>
        /// The name of the game
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The AppId for the game
        /// </summary>
        uint AppId { get; }

        /// <summary>
        /// The local directory where game content is saved
        /// </summary>
        string Directory { get; }

        /// <summary>
        /// The banner image for the game
        /// </summary>
        string Banner { get; }

        /// <summary>
        /// The icon for the game
        /// </summary>
        string Icon { get; }

        /// <summary>
        /// Sets the directory where game files are stored
        /// </summary>
        /// <param name="directory">The directory</param>
        /// <param name="moveExisting">If old directory exists and contains files move files to new directory</param>
        /// <returns>A observable move operation</returns>
        IObservableOperation SetLocalDirectory(string directory, bool moveExisting = false);

        /// <summary>
        /// Delete game files
        /// </summary>
        /// <param name="includeSaveData">Include user specific information</param>
        /// <returns>Watchable operation</returns>
        IObservableOperation DeleteGame(bool includeSaveData = false);

        /// <summary>
        /// Launch the game
        /// </summary>
        /// <param name="parameters">Parameters used to launch game</param>
        void LaunchGame(string[] parameters);
    }
}
