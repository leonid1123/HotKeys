using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] TMP_Text HPtext;
    [SerializeField] TMP_Text manaText;
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject bombPrefab;
    [SerializeField] GameObject arrowPrefab;
    int HP = 100;
    int mana = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPtext.text = "HP:" + HP.ToString();
        manaText.text = "Mana:" + mana.ToString();
    }
    public void AddHP()
    {
        HP+=10;
    }
    public void AddMana() 
    { 
        mana+=10;
    }
    public void Bomb()
    {
        Instantiate(bombPrefab,transform.position,transform.rotation);
    }
    public void Arbalet()
    {
        Instantiate(arrowPrefab,transform.position,transform.rotation);
    }
}
