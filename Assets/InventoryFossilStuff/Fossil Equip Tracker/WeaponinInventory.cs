﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponinInventory : MonoBehaviour
{
    public Image skull;
    public Image neck;
    public Image ribs;
    public Image arms;
    public Image legs;
    public Image tail;

    public void Start()
    {
        if (this.gameObject.tag.Contains("skull"))
        {
            skull = gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.tag.Contains("neck"))
        {
            neck = gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.tag.Contains("ribs"))
        {
            ribs = gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.tag.Contains("arms"))
        {
            arms = gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.tag.Contains("legs"))
        {
            legs = gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.tag.Contains("tail"))
        {
            tail = gameObject.GetComponent<Image>();
        }

    }//In the inventory, checks what fossil type the object the script is attatched to is and assigns specific images accordingly
    public void Update()
    {
        if (gameObject.tag == ("skull" + WeaponStats.skull))
        {
            skull.enabled = true;
        }
        else if (gameObject.tag == ("neck" + WeaponStats.neck))
        {
            neck.enabled = true;
        }
        else if (gameObject.tag == ("ribs" + WeaponStats.ribs))
        {
            ribs.enabled = true;
        }
        else if (gameObject.tag == ("arms" + WeaponStats.arms))
        {
            arms.enabled = true;
        }
        else if (gameObject.tag == ("legs" + WeaponStats.legs))
        {
            legs.enabled = true;
        }
        else if (gameObject.tag == ("tail" + WeaponStats.tail))
        {
            tail.enabled = true;
        }
        //Checks if the gameobject is equiped and if it is, enables the specific according image
        else
        {
            if(skull != null)
            {
                skull.enabled = false;
            }

            if(neck != null)
            {
                neck.enabled = false;
            }

            if (ribs != null)
            {
                ribs.enabled = false;
            }

            if (arms != null)
            {
                arms.enabled = false;
            }

            if(legs != null)
            {
                legs.enabled = false;
            }

            if(tail != null)
            {
                tail.enabled = false;
            }
        }
    }
}
