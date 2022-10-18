using UnityEngine;

public class movimiento : MonoBehaviour
{
    float movx;
    float movy;
    Vector3 moverJug;
    float speed;
    public float vida = 100;
    Vector3 jugadorSaltando;
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        movx = Input.GetAxis("Horizontal");
        movy = Input.GetAxis("Vertical");
        moverJug = new Vector3(movy, 0, -movx);
        transform.Translate(moverJug * Time.deltaTime * speed);
        
}
   
}
