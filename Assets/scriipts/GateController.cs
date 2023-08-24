using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GateController : MonoBehaviour
{
    private int minValue = 1;
    public int maxValue = 10;
    public int randomValue;

    public TextMeshPro textMesh; // TextMesh bileþeni
    int secim;
    private void Start()
    {
        textMesh.text = ""; // Baþlangýçta boþ bir metin
        secim = Random.Range(0, 3); // 0: Tork, 1: Hýz, 2: Defans
        randomValue = Random.Range(minValue, maxValue + 1);
        if (secim == 0)
        {
            textMesh.text = "Shield: " + randomValue;
        }
        else if (secim == 1)
        {
            textMesh.text = "Durability: " + randomValue;
        }
        else if (secim == 2)
        {
            textMesh.text = "Hardness: " + randomValue;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Araba"))
        {
            ArabaController arabController = other.GetComponent<ArabaController>();
            if (arabController != null)
            {

                if (secim == 0)
                {
                    arabController.ArtirShield(randomValue);
                }
                else if (secim == 1)
                {
                    arabController.ArtirDurability(randomValue);
                }
                else if (secim == 2)
                {
                    arabController.ArtirShieldHardness(randomValue);
                }
            }
        }
    }
}
