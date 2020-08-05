using System;

namespace GameLauncher
{
    public interface IObservableOperation
    {
        /// <summary>
        /// The name of this operation
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Current Progress
        /// </summary>
        double Current { get; }

        /// <summary>
        /// Completed Value
        /// </summary>
        double Max { get; }

        /// <summary>
        /// True if this operation has completed
        /// </summary>
        bool Completed { get; }

        /// <summary>
        /// Subscribe to progress updates for this operation
        /// </summary>
        /// <param name="callback">The callback to invoke when progress has been changed</param>
        void Subscribe(Action<IObservableOperation> callback);
    }
}
