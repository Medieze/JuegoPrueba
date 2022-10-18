using UnityEngine;

public class abriendo : MonoBehaviour
{
    public Animator puerta;

    private void OnTriggerStay(Collider other)
    {
        puerta.Play("abrir2");       
    }
    private void OnTriggerExit(Collider other)
    {
        puerta.Play("cerrar2");
    }
}

