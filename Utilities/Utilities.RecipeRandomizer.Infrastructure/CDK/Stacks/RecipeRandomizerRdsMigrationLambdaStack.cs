using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace Utilities.RecipeRandomizer.Infrastructure.CDK.Stacks;

public class RecipeRandomizerRdsMigrationLambdaStack : Stack
{
    public Function DatabaseMigrationLambda { get; set; }

    public RecipeRandomizerRdsMigrationLambdaStack(Construct scope, string id, IStackProps props = null) : base(scope, id)
    {
        DatabaseMigrationLambda = CreateLambdaFunction();
    }  

    internal Function CreateLambdaFunction()
    {
        return new Function(this, "database-migration-lambda", new FunctionProps
        {
            Runtime = Runtime.DOTNET_8,
            Handler = "DatabaseMigrationLambda::DatabaseMigrationLambda.Function::FunctionHandler",
            Code = Code.FromAsset("../Lambdas/DatabaseMigrationLambda") //ToDo: Point towards published folder
        });
    }   
}
