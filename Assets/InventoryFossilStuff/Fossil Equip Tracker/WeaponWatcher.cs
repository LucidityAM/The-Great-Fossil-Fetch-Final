﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponWatcher : MonoBehaviour
{
    public bool[] isFilled = new bool[18];

    public InventoryWeapons inventoryWeapons;

    public GameObject[] fossils = new GameObject[18];

    public AudioSource pickup;

    private void Start()
    {

        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "Level2" || scene.name == "Level3")
        {

            Debug.Log(scene.name);

            for(int i = 0; i < 18; i++)
            {
                if (WeaponStats.fossilsInSpaces[i] != 0)
                {
                    if (WeaponStats.fossilsInSpaces[i] == 1)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[0], inventoryWeapons.inventorySpace[i]); //makes a gameobject called FossilInstantiate based of a specific fossil in the fossil array
                        GameObject FossilInstantiateLibrary = Instantiate(fossils[0], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 2)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[1], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[1], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 3)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[2], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[2], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 4)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[3], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[3], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 5)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[4], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[4], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 6)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[5], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[5], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 7)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[6], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[6], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 8)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[7], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[7], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 9)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[8], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[8], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 10)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[9], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[9], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 11)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[10], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[10], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 12)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[11], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[11], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 13)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[12], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[12], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 14)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[13], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[13], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 15)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[14], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[14], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 16)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[15], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[15], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 17)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[16], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[16], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;

                        WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                        isFilled[i] = true;
                    }
                    else if (WeaponStats.fossilsInSpaces[i] == 18)
                    {
                        GameObject FossilInstantiate = Instantiate(fossils[17], inventoryWeapons.inventorySpace[i]);
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                        GameObject FossilInstantiateLibrary = Instantiate(fossils[17], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                            FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                        FossilInstantiateLibrary.name = "Library" + i;


                        isFilled[i] = true;
                    }
                }
            }

        }//Simply repopulates the inventory for the second and third levels
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "skull1")
        {
            collision.gameObject.SetActive(false); //When you collide with an object in the world, disable it

            for (int i = 0; i < isFilled.Length; i++) 
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[0], inventoryWeapons.inventorySpace[i]); //makes a gameobject called FossilInstantiate based of a specific fossil in the fossil array
                    GameObject FossilInstantiateLibrary = Instantiate(fossils[0], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    WeaponStats.fossilsInSpaces[i] = 1;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[0] = "skull1";
                    //Take the instantiated object and populate some arrays with it for future use

                    isFilled[i] = true; //Sets the space to full so the next time the script instantiates an object, it is in the next space
                    break;

                }//If the loop finds a space that isnt filled, run the code

            }//Run a for loop for each the length of the isFilled array(18)
        }
        if (collision.gameObject.tag == "skull2")
        {
            collision.gameObject.SetActive(false);

            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[1], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[1], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 2;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[1] = "skull2";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "skull3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[2], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[2], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 3;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[2] = "skull3";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "neck1")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[3], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[3], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 4;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[3] = "neck1";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "neck2")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[4], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[4], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 5;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[4] = "neck2";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "neck3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[5], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[5], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 6;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[5] = "neck3";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "ribs1")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[6], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[6], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 7;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[6] = "ribs1";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "ribs2")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[7], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[7], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 8;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[7] = "ribs2";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "ribs3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[8], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[8], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 9;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[8] = "ribs3";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "arms1")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[9], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[9], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 10;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[9] = "arms1";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "arms2")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[10], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[10], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 11;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[10] = "arms2";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "arms3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[11], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[11], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 12;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[11] = "arms3";
                    isFilled[i] = true;
                    break;
                }
            }
            
        }
        if (collision.gameObject.tag == "legs1")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[12], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[12], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 13;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[12] = "legs1";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "legs2")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[13], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[13], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 14;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[13] = "legs2";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "legs3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[14], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[14], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 15;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[14] = "legs3";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "tail1")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[15], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[15], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 16;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[15] = "tail1";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "tail2")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[16], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[16], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 17;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[16] = "tail2";
                    isFilled[i] = true;
                    break;
                }
            }
        }
        if (collision.gameObject.tag == "tail3")
        {
            collision.gameObject.SetActive(false);
            for (int i = 0; i < isFilled.Length; i++)
            {
                if (isFilled[i] == false)
                {
                    //pickup.Play();
                    GameObject FossilInstantiate = Instantiate(fossils[17], inventoryWeapons.inventorySpace[i]);
                    FossilInstantiate.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.x + 444f, FossilInstantiate.GetComponent<RectTransform>().anchoredPosition.y);

                    GameObject FossilInstantiateLibrary = Instantiate(fossils[17], inventoryWeapons.librarySpaces[i]); //Instantiates the fossils into the library too

                    FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition = new Vector2(FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.x + 444f,
                        FossilInstantiateLibrary.GetComponent<RectTransform>().anchoredPosition.y); //Moves the instantiated fossil in the inventory over 444 units to account for some wacky positioning

                    FossilInstantiateLibrary.name = "Library" + i;

                    WeaponStats.fossilsInSpaces[i] = 18;
                    WeaponStats.objectsInSpaces[i] = FossilInstantiate;
                    WeaponStats.fossilsOutOfSpaces[17] = "tail3";
                    isFilled[i] = true;
                    break;
                }
            }
        }
    }

}
