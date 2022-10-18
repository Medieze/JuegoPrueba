using UnityEngine;

public class logicaDeAtaque : MonoBehaviour
{
    public Animator jugAnim;

    void Start()
    {
        
    }


   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Estoy atacando");
            jugAnim.SetTrigger("ataque");
        }
    }
    public void ataca()
    {
        
    }
   public void dejadeAtacar()
    {

    }
}
