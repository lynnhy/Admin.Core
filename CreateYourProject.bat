color 3

dotnet new -i .template.config\Admin.Core.Webapi.Template.2.1.0.nupkg

set /p OP=Please set your project name(for example:Baidu.Api):

md .1YourProject

cd .1YourProject

dotnet new blogcoretpl -n %OP%

cd ../


echo "Create Successfully!!!! ^ please see the folder .1YourProject"

dotnet new -u Admin.Core.Webapi.Template


echo "Delete Template Successfully"

pause