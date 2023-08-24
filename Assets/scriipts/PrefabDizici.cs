using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDizici : MonoBehaviour
{
    public GameObject[] prefablar; // Beþ prefabý dizi olarak tutuyoruz
    public int prefabSayisi = 10; // Kaç adet prefab oluþturulacaðýný belirtiyoruz

    [HideInInspector]
    public List<GameObject> createdPrefabs = new List<GameObject>();

    private void Start()
    {
        olustur();
    }

    public void olustur()
    {
        for (int i = 0; i < prefabSayisi; i++)
        {
            GameObject newPrefab = CreateRandomPrefabWithX(i * 27f);
            createdPrefabs.Add(newPrefab);
        }
    }

    public GameObject CreateRandomPrefabWithX(float xOffset)
    {
        int randomPrefabIndex = Random.Range(0, prefablar.Length); // Rastgele bir prefab seçiyoruz
        GameObject prefab = prefablar[randomPrefabIndex];

        Vector3 position = new Vector3(xOffset, 0f, 0f); // x koordinatýný belirliyoruz, y ve z sýfýr
        Quaternion rotation = Quaternion.identity; // Rastgele döndürme yok

        return Instantiate(prefab, position, rotation);
    }
}
