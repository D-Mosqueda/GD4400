using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        HealthPotion,
        ConeShot,
        Doubleshot
    }

    public ItemType itemType;
    public int amount;


    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
                case ItemType.HealthPotion: return ItemAssets.Instance.HealthSprite;
                case ItemType.Doubleshot: return ItemAssets.Instance.DoubleShotSprite;
                case ItemType.ConeShot: return ItemAssets.Instance.ConeShotSprite;
        }
    }
}
