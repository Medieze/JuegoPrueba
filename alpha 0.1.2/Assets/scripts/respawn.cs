using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{

    public GameObject jugador;
    public GameObject rp;
    Vector3 posInicial;
    void Start()
    {
        posInicial = rp.transform.position;
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (jugador.transform.position.y < 3)
        {
            Debug.Log("Moriste");
            jugador.transform.position = posInicial;
        }
    }


}
