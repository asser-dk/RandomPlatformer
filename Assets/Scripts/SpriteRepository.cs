using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRepository : MonoBehaviour
{

    public string SpriteSheet;

    private IDictionary<string, Sprite> sprites;

    public void Start()
    {
        var resourceSprites = Resources.LoadAll<Sprite>(SpriteSheet);

        Debug.Log("number of sprites loaded: " + resourceSprites.Length);

        sprites = new Dictionary<string, Sprite>();

        foreach (var sprite in resourceSprites)
        {
            Debug.Log("Add sprite " + sprite.name);
            sprites.Add(sprite.name, sprite);
        }
    }

    public void Update()
    {

    }
}
