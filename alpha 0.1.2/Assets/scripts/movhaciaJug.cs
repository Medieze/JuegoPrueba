using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movhaciaJug : MonoBehaviour
{

    public GameObject Jugador;
    float speedtoLook = 1;
    float speed = 1;
    [SerializeField]
    private movimiento movimiento;
    [SerializeField]
    private float vida;



    void Start()
    {
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        
    }
    void LookAtPlayer()
    {
        Quaternion Rot = Quaternion.LookRotation(Jugador.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, Rot, speedtoLook * Time.deltaTime);

    }
    void followPlayer()
    {
        float dist = Vector3.Distance(transform.position, Jugador.transform.position);
        
        if (dist < 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, Jugador.transform.position, 1 *speed*Time.deltaTime);
        }
        if (dist < 1.5)
        {
            attackPlayer();
            
        }
    }
    void attackPlayer()
    {
        vida -= 1 * speed * Time.deltaTime;
        Debug.Log("Has recibido 1 de Daño! Tu vida total es: " + vida);
    }
}
