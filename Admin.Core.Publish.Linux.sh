git pull;
rm -rf .PublishFiles;
dotnet build;
dotnet publish -o /home/Admin.Core/Admin.Core/bin/Debug/netcoreapp3.1;
cp -r /home/Admin.Core/Admin.Core/bin/Debug/netcoreapp3.1 .PublishFiles;
echo "Successfully!!!! ^ please see the file .PublishFiles";