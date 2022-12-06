using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        addItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });
        addItem(new Item { itemType = Item.ItemType.ConeShot, amount = 1 });
        addItem(new Item { itemType = Item.ItemType.Doubleshot, amount = 1 });

        Debug.Log(itemList.Count);
        
    }

    public void addItem( Item item)
    {
        itemList.Add(item);
    }


    public List<Item> GetItemList()
    {
        return itemList;
    }
}
