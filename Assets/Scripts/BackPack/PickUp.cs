using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }
    public void PickUpItems(GameObject Items)
    {
        SpriteRenderer ItemsRenderer = Items.GetComponent<SpriteRenderer>();
        Sprite ItemsSprite = ItemsRenderer.sprite;

        for (int i = 0; i < inventory.Slots.Length; i++)
        {

            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;

                Image[] image = inventory.Slots[i].GetComponentsInChildren<Image>();

                image[1].sprite = ItemsSprite;

                break;
            }
        }
        
    }
}
