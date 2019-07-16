namespace GameFramework.Resource
{
    /// <summary>
    /// 使用单机模式并初始化资源完成的回调函数。
    /// </summary>
    public delegate void InitResourcesCompleteCallback();

    /// <summary>
    /// 加载资源时加载依赖资源回调函数。
    /// </summary>
    /// <param name="assetName">要加载的资源名称。</param>
    /// <param name="dependencyAssetName">被加载的依赖资源名称。</param>
    /// <param name="loadedCount">当前已加载依赖资源数量。</param>
    /// <param name="totalCount">总共加载依赖资源数量。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadAssetDependencyAssetCallback(string assetName, string dependencyAssetName, int loadedCount, int totalCount, object userData);

    /// <summary>
    /// 加载资源更新回调函数。
    /// </summary>
    /// <param name="assetName">要加载的资源名称。</param>
    /// <param name="progress">加载资源进度。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadAssetUpdateCallback(string assetName, float progress, object userData);

    /// <summary>
    /// 加载资源成功回调函数。
    /// </summary>
    /// <param name="assetName">要加载的资源名称。</param>
    /// <param name="asset">已加载的资源。</param>
    /// <param name="duration">加载持续时间。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadAssetSuccessCallback(string assetName, object asset, float duration, object userData);

    /// <summary>
    /// 加载资源失败回调函数。
    /// </summary>
    /// <param name="assetName">要加载的资源名称。</param>
    /// <param name="status">加载资源状态。</param>
    /// <param name="errorMessage">错误信息。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadAssetFailureCallback(string assetName, LoadResourceStatus status, string errorMessage, object userData);


    /// <summary>
    /// 解密资源回调函数。
    /// </summary>
    /// <param name="name">资源名称。</param>
    /// <param name="variant">变体名称。</param>
    /// <param name="loadType">资源加载方式。</param>
    /// <param name="length">资源大小。</param>
    /// <param name="hashCode">资源哈希值。</param>
    /// <param name="storageInReadOnly">资源是否在只读区。</param>
    /// <param name="bytes">待解密的资源二进制流。</param>
    /// <returns>解密后的资源二进制流。</returns>
    public delegate byte[] DecryptResourceCallback(string name, string variant, int loadType, int length, int hashCode, bool storageInReadOnly, byte[] bytes);

    /// <summary>
    /// 使用可更新模式并检查资源完成的回调函数。
    /// </summary>
    /// <param name="needUpdateResources">是否需要进行资源更新。</param>
    /// <param name="removedCount">已移除的资源数量。</param>
    /// <param name="updateCount">要更新的资源数量。</param>
    /// <param name="updateTotalLength">要更新的资源总大小。</param>
    /// <param name="updateTotalZipLength">要更新的压缩包总大小。</param>
    public delegate void CheckResourcesCompleteCallback(bool needUpdateResources, int removedCount, int updateCount, long updateTotalLength, long updateTotalZipLength);

    /// <summary>
    /// 读取数据流回调函数。
    /// </summary>
    /// <param name="fileUri">文件路径。</param>
    /// <param name="bytes">数据流。</param>
    /// <param name="errorMessage">错误信息。</param>
    public delegate void LoadBytesCallback(string fileUri, byte[] bytes, string errorMessage);

    /// <summary>
    /// 加载场景时加载依赖资源回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要加载的场景资源名称。</param>
    /// <param name="dependencyAssetName">被加载的依赖资源名称。</param>
    /// <param name="loadedCount">当前已加载依赖资源数量。</param>
    /// <param name="totalCount">总共加载依赖资源数量。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadSceneDependencyAssetCallback(string sceneAssetName, string dependencyAssetName, int loadedCount, int totalCount, object userData);

    /// <summary>
    /// 加载场景失败回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要加载的场景资源名称。</param>
    /// <param name="status">加载场景状态。</param>
    /// <param name="errorMessage">错误信息。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadSceneFailureCallback(string sceneAssetName, LoadResourceStatus status, string errorMessage, object userData);

    /// <summary>
    /// 加载场景成功回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要加载的场景资源名称。</param>
    /// <param name="duration">加载持续时间。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadSceneSuccessCallback(string sceneAssetName, float duration, object userData);

    /// <summary>
    /// 加载场景更新回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要加载的场景资源名称。</param>
    /// <param name="progress">加载场景进度。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadSceneUpdateCallback(string sceneAssetName, float progress, object userData);

    /// <summary>
    /// 卸载场景失败回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要卸载的场景资源名称。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void UnloadSceneFailureCallback(string sceneAssetName, object userData);

    /// <summary>
    /// 卸载场景成功回调函数。
    /// </summary>
    /// <param name="sceneAssetName">要卸载的场景资源名称。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void UnloadSceneSuccessCallback(string sceneAssetName, object userData);

    /// <summary>
    /// 使用可更新模式并更新资源全部完成的回调函数。
    /// </summary>
    public delegate void UpdateResourcesCompleteCallback();

    /// <summary>
    /// 版本资源列表更新失败回调函数。
    /// </summary>
    /// <param name="downloadUri">版本资源列表更新地址。</param>
    /// <param name="errorMessage">错误信息。</param>
    public delegate void UpdateVersionListFailureCallback(string downloadUri, string errorMessage);

    /// <summary>
    /// 版本资源列表更新成功回调函数。
    /// </summary>
    /// <param name="downloadPath">版本资源列表更新后存放路径。</param>
    /// <param name="downloadUri">版本资源列表更新地址。</param>
    public delegate void UpdateVersionListSuccessCallback(string downloadPath, string downloadUri);

}
