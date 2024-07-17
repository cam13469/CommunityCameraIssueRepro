using CommunityToolkit.Maui;

namespace CommunityCameraReproToolkit;

public static partial class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseCommunityCameraReproToolkit(this MauiAppBuilder builder)
    {
        builder.UseMauiCommunityToolkit();
        builder.UseMauiCommunityToolkitCamera();

        return builder;
    }
}
