try
{
    # Locate Chutzpah
    $ChutzpaPath = get-childitem .\*\chutzpah.console.exe -recurse | select-object -first 1

    # Locate Test files
    $TestFiles = Get-ChildItem .\*\*Tests.js -recurse

    # Prevent spaces in the path from breaking the script
    $ChutzpaPath = $ChutzpaPath -replace ' ', '` '
    $TestFiles = $TestFiles  -replace ' ', '` '

    # Build command
    $ChutzpahCmd = "$($ChutzpaPath) $($TestFiles) /junit .\chutzpah-results.xml"

    # Run tests using Chutzpah and export results as JUnit format to chutzpah-results.xml
    Invoke-Expression $ChutzpahCmd

    # Upload results to AppVeyor one by one

    $testsuites = [xml](get-content .\chutzpah-results.xml)

    $anyFailures = $FALSE
    foreach ($testsuite in $testsuites.testsuites.testsuite) {
        write-host " $($testsuite.name)"
        foreach ($testcase in $testsuite.testcase){
            $failed = $testcase.failure
            $time = $testsuite.time
            if ($testcase.time) { $time = $testcase.time }
            if ($failed) {
                write-host "Failed   $($testcase.name) $($testcase.failure.message)"
                Add-AppveyorTest $testcase.name -Outcome Failed -FileName $testsuite.name -ErrorMessage $testcase.failure.message -Duration $time
                $anyFailures = $TRUE
            }
            else {
                write-host "Passed   $($testcase.name)"
                Add-AppveyorTest $testcase.name -Outcome Passed -FileName $testsuite.name -Duration $time
            }

        }
    }

    if ($anyFailures -eq $TRUE){
        write-host "Failing build as there are broken tests"
        $host.SetShouldExit(1)
    }
}
catch
{
    write-host "Failing build as the javascript tests didn't run properly"
    $host.SetShouldExit(1)
}