using UnityEngine;

public class pj1 : MonoBehaviour
{
    public float velocidadM = 0.5f;
    public float velocidadR = 20.0f;
    public Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0,x*Time.deltaTime*velocidadR,0);
        transform.Translate(0,0,y*Time.deltaTime*velocidadM);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

    }
}
