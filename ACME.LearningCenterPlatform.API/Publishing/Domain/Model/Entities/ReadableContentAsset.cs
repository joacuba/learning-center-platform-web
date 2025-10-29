using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

public class ReadableContentAsset : Asset
{
    /// <summary>
    /// The readable content of the asset.
    /// </summary>
    public string ReadableContent { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReadableContentAsset"/> class.
    /// </summary>
    public ReadableContentAsset() : base(EAssetType.ReadableContentItem)
    {
        ReadableContent = string.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ReadableContentAsset"/> class with specified content.
    /// </summary>
    public ReadableContentAsset(string content) : base(EAssetType.ReadableContentItem)
    {
       ReadableContent = content;
    }

    /// <summary>
    /// Indicates whether the asset is readable.
    /// </summary>
    public override bool Readable => true;

    /// <summary>
    /// Indicates whether the asset is viewable.
    /// </summary>
    public override bool Viewable => false;
}