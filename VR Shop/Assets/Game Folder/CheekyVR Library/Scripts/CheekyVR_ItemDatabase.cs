using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using CheekyVR;

namespace CheekyVR
{
    [Serializable]
    public class ItemData
    {
        public string priceValue;
        public string itemName;
        public string itemDescription;
        public string itemNumber;

        public ItemData()
        {
            priceValue = "";
            itemName = "";
            itemDescription = "";
            itemNumber = "";
        }
    }

    [Serializable]
    public class CatalogueData
    {
        public List<ItemData> allItemData;

        public CatalogueData()
        {
            allItemData = new List<ItemData>();
        }
    }
}

public class CheekyVR_ItemDatabase : MonoBehaviour
{
    private string filePath = "C:/JsonTestData/testCatalogue.json";
    private CatalogueData dataStore;

    private void Start()
    {
        LoadJsonInput();
    }

    public void LoadJsonInput()
    {
        string jsonSource = File.ReadAllText(filePath);

        dataStore = JsonUtility.FromJson<CatalogueData>(jsonSource);

        Debug.Log(dataStore.allItemData[0].itemName);
    }
}
