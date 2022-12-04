namespace cosmosbd.models;

public class Recipes
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    [JsonProperty(PropertyName = "healthScore")]
    public int HealthScore { get; set; }

    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    [JsonProperty(PropertyName = "nutrients")]
    public Nutrients[] Nutrients { get; set; }
}


public class Nutrients
{

    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "amount")]
    public int Amount { get; set; }

    [JsonProperty(PropertyName = "unit")]
    public string unit { get; set; }

    [JsonProperty(PropertyName = "percentOfDailyNeeds")]
    public float percentOfDailyNeeds { get; set; }
}