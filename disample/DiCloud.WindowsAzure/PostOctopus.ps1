Write-Host 'This is coming from post build script'
Write-Host "Build Number is " $Env:TF_BUILD_BUILDNUMBER
Write-Host "Source Directory" $Env:TF_BUILD_SOURCESDIRECTORY 
Write-Host "Number of Args:" $args.Length
foreach ($arg in $args) {Write-Host "Arg : $arg"}
Write-Host '#################################################'
Function Get-MSBuild {
    $lib = [System.Runtime.InteropServices.RuntimeEnvironment]
    $rtd = $lib::GetRuntimeDirectory()
    Join-Path $rtd msbuild.exe
}

$msbuildPath = Get-MSBuild 
Write-Host "Ms Build Path " $msbuildPath

$OctofullCmd = "$Env:TF_BUILD_SOURCESDIRECTORY\$arg"

& "$msbuildpath $OctofullCmd"