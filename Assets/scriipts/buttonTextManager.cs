using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buttonTextManager : MonoBehaviour
{
    public GameObject[] panels;
    public TextMeshProUGUI[] currettext;
    public TextMeshProUGUI[] buttontext;
    int[] buttoncurret=new int[3];
    public GameObject[] buttons;
    public GameObject tank;

    ArabaController controller;
    PrefabDizici PrefabDizici;
    void Start()
    {
        controller = GetComponent<ArabaController>();
        PrefabDizici = GetComponent<PrefabDizici>();
        for (int i = 0; i < buttoncurret.Length; i++)
        {
            buttoncurret[i]=10;
        }
        Time.timeScale = 0f;
    }

    void Update()
    {
        currettext[0].text = "Armor :" + controller.Shield.ToString();
        currettext[1].text = "Durability :" + controller.Durability.ToString();
        currettext[2].text = "Hardness :" + controller.Hardness.ToString();
        currettext[3].text = "Power :" + controller.power.ToString();
        currettext[4].text = "Money :" + controller.money.ToString();

        buttontext[0].text ="ARMOR UPGRADE :" +buttoncurret[0].ToString() + "$";
        buttontext[1].text ="DURABÝLÝTY UPGRADE :"+ buttoncurret[1].ToString() + "$";
        buttontext[2].text ="HARDNESS UPGRADE :"+ buttoncurret[2].ToString() + "$";
    }
    public void armorbutton()
    {
        controller.Shield++;
        buttoncurret[0] += 5;
        controller.money -= buttoncurret[0];
    }
    public void durabilitybutton()
    {
        controller.Durability++;
        buttoncurret[1] += 5;
        controller.money -= buttoncurret[1];
    }
    public void hardnessbutton()
    {
        controller.Hardness++;
        buttoncurret[2] += 5;
        controller.money -= buttoncurret[2];
    }
    public void startbutton()
    {
        Time.timeScale = 1f;
        buttons[0].SetActive(false);
        panels[0].SetActive(true);
        panels[1].SetActive(false);
    }
    public void NextButoon()
    {
        
        foreach (var prefab in PrefabDizici.createdPrefabs)
        {
            Destroy(prefab);
        }
        PrefabDizici.createdPrefabs.Clear(); // Listeyi temizleyin
        PrefabDizici.olustur(); // Yeni prefablarý oluþturun

        tank.transform.position = new Vector3(-45f, 0f, 0f);
        panels[0].SetActive(false);
        panels[1].SetActive(true);
        panels[2].SetActive(false);
        buttons[0].SetActive(true);
        controller.Shield = 0;
        controller.Durability = 0;
        controller.Hardness = 0;
        controller.power = 0;
    }
}

