color B

del  .PublishFiles\*.*   /s /q

dotnet restore

dotnet build

cd Admin.Core

dotnet publish -o ..\Admin.Core\bin\Debug\netcoreapp3.1\

md ..\.PublishFiles

xcopy ..\Admin.Core\bin\Debug\netcoreapp3.1\*.* ..\.PublishFiles\ /s /e 

echo "Successfully!!!! ^ please see the file .PublishFiles"

cmd