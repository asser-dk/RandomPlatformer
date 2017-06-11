namespace SexyFishHorse.RandomPlatformer.Ground
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using SexyFishHorse.DataModel.DataAnnotations;
    using UnityEngine;

    public class GroundTileScript : MonoBehaviour
    {
        public GameEnvironment Environment;

        private GameEnvironment currentEnvironment;

        public string PartialSpriteKey { get; private set; }

        public void Start()
        {
            UpdatePartialSpriteKey();
        }

        public void Update()
        {
            if (Environment != currentEnvironment)
            {
                UpdatePartialSpriteKey();
            }
        }

        private void UpdatePartialSpriteKey()
        {
            Debug.Log("Current environment is " + Environment);

            var memberInfo = Environment.GetType().GetMember(Environment.ToString()).Single();
            var attribute = (PartialKeyAttribute)memberInfo
                .GetCustomAttributes(false)
                .Single(x => x.GetType().Name == "PartialKeyAttribute");

            PartialSpriteKey = attribute.PartialKey;

            Debug.Log("Environment partial key: " + PartialSpriteKey);

            currentEnvironment = Environment;
        }
    }
}
