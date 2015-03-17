# JF.Build.Targets

Custom MsBuild tasks and targets

## Available Tasks

### GetVersionNumber

Example usage (Creating a nuspec file from a template for the current dll version)

    <Target Name="AfterBuild">
    	<GetVersionNumber FileName="$(TargetPath)">
    		<Output TaskParameter="VersionString" ItemName="VersionString"></Output>
    	</GetVersionNumber>
    	<Exec Command="copy $(SolutionDir)nuspec.tpl $(SolutionDir)$(ProjectName).@(VersionString).nuspec" />
    </Target>

