using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    public int itemNum;
    public Image itemImg;
}
public class Marge : MonoBehaviour
{
    
    public List<Item> itemdata = new List<Item>();
    public GameObject itemPrefabs;

    public void ItemCreate()
    {
        Instantiate(itemPrefabs);
    }


}
