using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotKeys : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprites;
    int spriteNumber = 0;
    [SerializeField]
    Image image;
    [SerializeField]
    PlayerController player;
    void Start()
    {
        image.sprite = sprites[spriteNumber];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            spriteNumber--;
            if (spriteNumber < 0)
            {
                spriteNumber = 3;
            }
            image.sprite = sprites[spriteNumber];
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            spriteNumber++;
            if (spriteNumber > 3)
            {
                spriteNumber = 0;
            }
            image.sprite = sprites[spriteNumber];
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (spriteNumber)
            {
                case 0:
                    player.Arbalet();
                    break;
                case 1:
                    player.Bomb();
                    break;
                case 2:
                    player.AddHP();
                    break;
                case 3:
                    player.AddMana();
                    break;
            }
        }
    }
}
