#load nuget:?package=Chocolatey.Cake.Recipe&version=0.14.0

///////////////////////////////////////////////////////////////////////////////
// TOOLS
///////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////
// SCRIPT
///////////////////////////////////////////////////////////////////////////////



///////////////////////////////////////////////////////////////////////////////
// CUSTOM TASKS
///////////////////////////////////////////////////////////////////////////////



///////////////////////////////////////////////////////////////////////////////
// RECIPE SCRIPT
///////////////////////////////////////////////////////////////////////////////

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./",
                            solutionFilePath: "./checksum.sln",
                            solutionDirectoryPath: "./src/checksum",
                            title: "checksum",
                            repositoryOwner: "ferventcoder",
                            repositoryName: "checksum",
                            productName: "checksum",
                            productDescription: "TODO",
                            productCopyright: string.Format("{0}", DateTime.Now.Year),
                            shouldStrongNameSignDependentAssemblies: false,
                            treatWarningsAsErrors: false);

ToolSettings.SetToolSettings(context: Context,
                            buildMSBuildToolVersion: MSBuildToolVersion.NET40);

BuildParameters.PrintParameters(Context);

Build.Run();