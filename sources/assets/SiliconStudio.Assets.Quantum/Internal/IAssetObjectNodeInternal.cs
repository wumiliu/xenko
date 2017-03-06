namespace SiliconStudio.Assets.Quantum
{
    /// <summary>
    /// An interface exposing internal methods of <see cref="IAssetObjectNode"/>
    /// </summary>
    internal interface IAssetObjectNodeInternal : IAssetObjectNode, IAssetNodeInternal
    {
        void NotifyOverrideChanging();

        void NotifyOverrideChanged();
    }
}
