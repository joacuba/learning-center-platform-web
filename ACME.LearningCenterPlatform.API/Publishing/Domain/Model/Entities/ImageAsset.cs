using System.Net.Mime;
using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.ValueObjects;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

public class ImageAsset : Asset
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public ImageAsset() : base(EAssetType.Image)
    {
    }

    /// <summary>
    /// Gets the URI of the image.
    /// </summary>
    public Uri? ImageUri { get; }

    /// <summary>
    /// Constructor with image URL
    /// </summary>
    public ImageAsset(string imageUrl) : base(EAssetType.Image)
    {
        ImageUri = new Uri(imageUrl);
    }

    public override bool Readable => false;

    public override bool Viewable => true;

    public override string GetContent()
    {
        return ImageUri?.ToString() ?? string.Empty;
    }
}