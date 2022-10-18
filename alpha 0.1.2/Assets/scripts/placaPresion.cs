using UnityEngine;

public class placaPresion : MonoBehaviour
{



    public Animator boton;

    private void OnTriggerStay(Collider other)
    {
        boton.Play("botonBajar");
    }
    private void OnTriggerExit(Collider other)
    {
        boton.Play("botonSubir");
    
    }
}

