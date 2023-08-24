using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public int startValue = 10; // Baþlangýç deðeri
    public int increaseValue = 20; // Artýþ deðeri

    public GameObject relatedPrefab; // Duvara ait prefabý buraya sürükleyin

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Araba"))
        {
            ArabaController arabController = other.GetComponent<ArabaController>();
            if (arabController != null && relatedPrefab != null)
            {
                arabController.ArtirWallValue(startValue); // Araba nesnesine duvar deðeri ekleyin
                startValue += increaseValue; // Duvarýn baþlangýç deðerini artýrýn

            } 
        }
    }
}
