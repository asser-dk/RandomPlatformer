namespace SexyFishHorse.RandomPlatformer.Ground
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using SexyFishHorse.DataModel.DataAnnotations;
    using UnityEngine;

    public class TileScript : MonoBehaviour
    {
        public TileType TileType;

        private TileType currentTileType;

        private GroundTileScript groundTile;

        private SpriteRenderer spriteRenderer;

        public void Start()
        {
            groundTile = GetComponentInParent<GroundTileScript>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            UpdateSprite();
        }

        public void Update()
        {
            if (TileType != currentTileType)
            {
                UpdateSprite();
             }
        }

        private void UpdateSprite()
        {
            Debug.Log("Current tile is: " + TileType);
            Debug.Log("ground tile environment is: " + groundTile.PartialSpriteKey);
            if(groundTile.PartialSpriteKey == null)
            {
                return;
            }

            var memberInfo = TileType.GetType().GetMember(TileType.ToString()).Single();
            var attribute = (PartialKeyAttribute)memberInfo
                            .GetCustomAttributes(false)
                            .Single(x => x.GetType().Name == "PartialKeyAttribute");

            var partialSpriteKey = attribute.PartialKey;

            //var resources = Resources.LoadAll("Sprites");

            var spriteName = string.Format("{0}{1}", groundTile.PartialSpriteKey, partialSpriteKey);

            Debug.Log("Loading Sprite " + spriteName);

            var sprite = Resources.Load<Sprite>(spriteName);

            Debug.Log("sprite found? " + (sprite != null));

            spriteRenderer.sprite = sprite;

            currentTileType = TileType;
        }
    }
}
