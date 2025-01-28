using Amazon.CDK;
using Utilities.RecipeRandomizer.Infrastructure.CDK.Stacks;

sealed class Program
{
    public static void Main(string[] args)
    {
        var app = new App();

        _ = new RecipeRandomizerRdsStack(app, "recipe-randomizer-database-stack", new DatabaseStackProps
        {
            //MigrationLambda = dbMigrationLambdaStack.DatabaseMigrationLambda,
            Env = new Amazon.CDK.Environment
            {
                Account = System.Environment.GetEnvironmentVariable("PROJECTS_AWS_DEFAULT_ACCOUNT", EnvironmentVariableTarget.User),
                Region = "us-east-1",
                //Region = System.Environment.GetEnvironmentVariable("PROJECTS_AWS_DEFAULT_REGION", EnvironmentVariableTarget.User)
            }
        });

        app.Synth();
    }
}
