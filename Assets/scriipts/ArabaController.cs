using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaController : MonoBehaviour
{
    
    public int Shield = 0;
    public int Durability= 0;
    public int Hardness = 0;
    public int wallValue;

    public int power = 0; 
    public int money = 0;
    public bool sifir;

    buttonTextManager btManager;
    private void Start()
    {
        btManager = GetComponent<buttonTextManager>();
    }
    public void ArtirShield(int deger)
    {
        Shield += deger;
    }

    public void ArtirDurability(int deger)
    {
        Durability += deger;
    }

    public void ArtirShieldHardness(int deger)
    {
        Hardness += deger;
    }
    public void ArtirWallValue(int deger)
    {
        wallValue += deger;
        power = Shield + Durability + Hardness; // Power deðerini hesapla
        money += wallValue;
        power -= wallValue;
        
        // Power sýfýrsa oyunu durdur
        if (power <= 0)
        {
            Time.timeScale = 0f;
            btManager.panels[2].SetActive(true);
            
        }
    }
}
