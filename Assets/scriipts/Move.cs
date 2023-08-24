using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rg;
    bool sol;
    bool sag;
    float hiz = -20.0f;
   
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(0, 0, hiz * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            // A tuþuna basýldýðýnda sola hareket et
            transform.Translate(Vector3.left * hiz * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // D tuþuna basýldýðýnda saða hareket et
            transform.Translate(Vector3.right * hiz * Time.deltaTime);
        }

    }
}
