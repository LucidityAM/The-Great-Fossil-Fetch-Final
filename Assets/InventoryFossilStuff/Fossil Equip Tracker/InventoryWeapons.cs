﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWeapons : MonoBehaviour
{
    public RectTransform[] inventorySpace = new RectTransform[18];
    public GameObject[] InventoryBlocks = new GameObject[18];

    void Awake()
    {
        for (int i = 0; i < inventorySpace.Length; i++)
        {
            inventorySpace[i] = InventoryBlocks[i].GetComponent<RectTransform>();
        }
    }
}
