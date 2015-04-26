Write-Host 'We are created Octo Package after the Publish'
Write-Host "Build Number is " $Env:TF_BUILD_BUILDNUMBER
Write-Host "Source Directory" $Env:TF_BUILD_SOURCESDIRECTORY 
Write-Host '------------------------------------------------------------'
Write-Host "Number of Args:" $args.Length
foreach ($arg in $args) {Write-Host "Arg : $arg"}
Write-Host '------------------------------------------------------------'

Function Get-MSBuildPath {
    $lib = [System.Runtime.InteropServices.RuntimeEnvironment]
    $rtd = $lib::GetRuntimeDirectory()
    Join-Path $rtd msbuild.exe
}
$msbuildPath = Get-MSBuildPath 
Write-Host "Ms Build Path " $msbuildPath

$OctofullCmd = "$msbuildpath $Env:TF_BUILD_SOURCESDIRECTORY\$arg"
cd $OctofullCmd

Write-Host "OctoFull Command" $OctofullCmd
Invoke-Expression -Command "$OctofullCmd"
