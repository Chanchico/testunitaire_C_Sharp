


function createProject(){
    projectName=$1
    mkdir "$projectName"
    cd "$projectName/"
    dotnet new console -n "$projectName"
    dotnet new sln 
    dotnet sln add "$projectName/$projetName.csproj"
    namePojectTest="$projectName.Test"
    dotnet new mstest -n "$nameProjectTest"
    dotnet sln add "$nameProjectTest/$nameProjectTest.csproj"
    cd "$nameProjectTest/"
    dotnet add reference "../$projectName/$projetName.csproj"

}
createProject $1
