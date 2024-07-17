# CommunityCameraIssueRepro

This repo contains three CS Projects:
- CommunityCameraReproToolkit (class library)
- CommunityCameraReproWithBug (MAUI App)
- CommunityCameraReproWithoutBug (MAUI App)

The "WithBug" sample app contains a project reference to the toolkit class library. The other sample does not.

## Toolkit Class Library

The class library contains a single class `MauiAppBuilderExtensions`. This class defines an extension method for applying bootstrap methods from the `CommunityToolkit.Maui.*` packages. 

## MAUI Sample App (without bug)

This sample app demonstrates bringing in the `CommunityToolkit.Maui.Camera` package and making use of the `CameraView` component to display a view of the current device camera on the main page. The bootstrapping methods for the Community Toolkit packges are applied directly to the MauiAppBuilder object in the `MauiProgram.cs` file. This app should build and run with no issues.

## MAUI Sample App (with bug - depends on toolkit class library)

This sample app is almost identical to the sample app that works above. The only difference is that the bootstrapper methods are applied using the MauiAppBuilderExtensions class from the toolkit class library. This app will not build. 
