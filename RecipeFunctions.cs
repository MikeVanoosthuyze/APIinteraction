namespace MCT.Functions
{
    public static class RecipeFunctions
    {
        [FunctionName("GetRecipe")]
        public static async Task<IActionResult> GetRecipe(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "eindproject/recipes")] HttpRequest req,
            ILogger log)
        {

            try {
                var connectionString = Environment.GetEnvironmentVariable("CosmosDb");

                CosmosClientOptions options = new CosmosClientOptions()
                {
                    ConnectionMode = ConnectionMode.Gateway
                };

                CosmosClient client = new CosmosClient(connectionString, options);
                var container = client.GetContainer(General.COSMOS_DB, General.COSMOS_CONTAINER_RECIPE);

                string sql = "SELECT * FROM c";

                var iterator = container.GetItemQueryIterator<Recipes>(sql);
                var results = new List<Recipes>();

                while (iterator.HasMoreResults)
                {
                    var response = await iterator.ReadNextAsync();
                    results.AddRange(response.ToList());
                }

                return new OkObjectResult(results);

            } catch (System.Exception ex)
            {
                log.LogError(ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
            
        }
    
        // [FunctionName("GetRecipeById")]
        // public static async Task<IActionResult> GetRecipeById(
        //     [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "eindproject/recipes/{id}")] HttpRequest req,
        //     string id,
        //     ILogger log) {

        //     try {
        //         var connectionString = Environment.GetEnvironmentVariable("CosmosDb");

        //         CosmosClientOptions options = new CosmosClientOptions()
        //         {
        //             ConnectionMode = ConnectionMode.Gateway
        //         };

        //         CosmosClient client = new CosmosClient(connectionString, options);
        //         var container = client.GetContainer(General.COSMOS_DB, General.COSMOS_CONTAINER_RECIPE);

        //         string sql = "SELECT * FROM c WHERE c.id = @id";
                

        //         var iterator = container.GetItemQueryIterator<Recipes>(sql);
        //         var results = new List<Recipes>();

        //         while (iterator.HasMoreResults)
        //         {
        //             var response = await iterator.ReadNextAsync();
        //             results.AddRange(response.ToList());
        //         }

        //         return new OkObjectResult(results);

        //     } catch (System.Exception ex)
        //     {
        //         log.LogError(ex.Message);
        //         return new BadRequestObjectResult(ex.Message);
        //     }

        //     }
    
    }
}
