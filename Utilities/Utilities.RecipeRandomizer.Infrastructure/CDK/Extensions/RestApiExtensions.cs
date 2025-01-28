using Amazon.CDK;
using Amazon.CDK.AWS.APIGateway;
using Constructs;

namespace Utilities.RecipeRandomizer.Infrastructure.CDK;

public static class RestApiExtensions
{
    private static IRestApi GetExistingRestApi(this RestApi restApi, Construct scope, string id, string restApiIdImportKey, string rootResourceIdKey)
    {
        string restApiId = Fn.ImportValue(restApiIdImportKey);
        string rootResourceId = Fn.ImportValue(rootResourceIdKey);

        return RestApi.FromRestApiAttributes(scope, id, new RestApiAttributes 
        {
            RootResourceId = rootResourceId,
            RestApiId = restApiId
        });
    }
}
