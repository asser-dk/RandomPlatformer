namespace SexyFishHorse.RandomPlatformer.Ground
{
    using System;
    using SexyFishHorse.DataModel.DataAnnotations;

    public enum TileType
    {
        [PartialKey("")]
        Default = 0,
        
        [PartialKey("-Center")]
        Center = 1,

        [PartialKey("-Center-Rounded")]
        CenterRounded = 2,

        [PartialKey("-Left")]
        Left = 3,

        [PartialKey("-Mid")]
        Mid = 4,

        [PartialKey("-Right")]
        Right = 5,

        [PartialKey("-Corner-Left")]
        CornerLeft = 6,

        [PartialKey("-Hill-Left")]
        HillLeft = 7,

        [PartialKey("-Corner-Right")]
        CornerRight = 8,

        [PartialKey("-Hill-Right")]
        HillRight = 9,

        [PartialKey("-Cliff-Left")]
        CliffLeft = 10,

        [PartialKey("-Cliff-Right")]
        CliffRight = 11,

        [PartialKey("-Cliff-Alt-Left")]
        CliffAltLeft = 12,

        [PartialKey("-Cliff-Alt-Right")]
        CliffAltRight = 13,

        [PartialKey("-Half")]
        Half = 14,

        [PartialKey("-Half-Left")]
        HalfLeft = 15,

        [PartialKey("-Half-Mid")]
        HalfMid = 16,

        [PartialKey("-Half-Right")]
        HalfRight = 17,
    }
}
