# Build, Test and Run application

$fileName = 'unsorted-names-list.txt';

function Build {
	cd $PSScriptRoot
	dotnet build
}

function Test {
	dotnet test NameSorterTest --no-build
}

function Run {
	dotnet run -p NameSorter $fileName
}

Build

If ($LASTEXITCODE -ne 0) {
	exit -1
}

Test

If ($LASTEXITCODE -ne 0) {
	exit -1
}

Run

exit 0
