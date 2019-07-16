namespace GameFramework.Resource
{
    internal sealed partial class ResourceManager : GameFrameworkModule, IResourceManager
    {
        private sealed partial class ResourceLoader
        {
            private sealed partial class LoadResourceAgent : ITaskAgent<LoadResourceTaskBase>
            {
                private enum WaitingType
                {
                    None = 0,
                    WaitForAsset,
                    WaitForDependencyAsset,
                    WaitForResource,
                }
            }
        }
    }
}
