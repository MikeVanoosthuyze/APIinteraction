namespace cosmosbd.models;

public class Recipes
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    [JsonProperty(PropertyName = "calories")]
    public int Calories { get; set; }

    [JsonProperty(PropertyName = "healthScore")]
    public int HealthScore { get; set; }

    [JsonProperty(PropertyName = "taste")]
    public Taste[] Taste { get; set; }

    [JsonProperty(PropertyName = "nutrients")]
    public Nutrients[] Nutrients { get; set; }
}
public class Taste
{

    [JsonProperty(PropertyName = "sweetness")]
    public float Sweetness { get; set; }

    [JsonProperty(PropertyName = "saltiness")]
    public float Saltiness { get; set; }

    [JsonProperty(PropertyName = "sourness")]
    public float Sourness { get; set; }

    [JsonProperty(PropertyName = "bitterness")]
    public float Bitterness { get; set; }

    [JsonProperty(PropertyName = "savoriness")]
    public float Savoriness { get; set; }

    [JsonProperty(PropertyName = "fattiness")]
    public int Fattiness { get; set; }

    [JsonProperty(PropertyName = "spiciness")]
    public int Spiciness { get; set; }
}

public class Nutrients
{


    [JsonProperty(PropertyName = "carbs")]
    public string Carbs { get; set; }

    [JsonProperty(PropertyName = "fat")]
    public string Fat { get; set; }

    [JsonProperty(PropertyName = "protein")]
    public string Protein { get; set; }

    [JsonProperty(PropertyName = "sugar")]
    public string Sugar { get; set; }



}