using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public int startValue = 10; // Ba�lang�� de�eri
    public int increaseValue = 20; // Art�� de�eri

    public GameObject relatedPrefab; // Duvara ait prefab� buraya s�r�kleyin

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
                arabController.ArtirWallValue(startValue); // Araba nesnesine duvar de�eri ekleyin
                startValue += increaseValue; // Duvar�n ba�lang�� de�erini art�r�n

            } 
        }
    }
}
