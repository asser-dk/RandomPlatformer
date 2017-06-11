namespace SexyFishHorse.RandomPlatformer.Ground
{
    using SexyFishHorse.DataModel.DataAnnotations;

    public enum GameEnvironment
    {
        [PartialKey("Grass")]
        Grass = 1,

        [PartialKey("Dirt")]
        Dirt = 2,
        
        [PartialKey("Stone")]
        Stone = 3,

        [PartialKey("Snow")]
        Snow = 4,

        [PartialKey("Sand")]
        Sand = 5,

        [PartialKey("Planet")]
        Planet = 6,
    }
}
