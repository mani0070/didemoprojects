Write-Host 'This is coming from post build script'
Write-Host "Build Number is " $Env: TF_BUILD_BUILDNUMBER
Write-Host "Number of Args:" $args.Length
foreach ($arg in $args) {Write-Host "Arg : $arg"}
Write-Host '#################################################'