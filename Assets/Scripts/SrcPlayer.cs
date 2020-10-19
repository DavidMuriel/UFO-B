using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrcPlayer : MonoBehaviour
{
    [SerializeField]
    float forsa = 3;
    float x, y; //variables para guardar la lectura de los cursores 
    float velocitat = 3;

    //acceder al componente RigidBody:
    Rigidbody2D rb;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal"); //leer movimiento horizontal
        y = Input.GetAxis("Vertical"); //leer movimiento vertical
        








      
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(x*forsa, y*forsa));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if (collision.tag == "pickup")
        {
            Destroy(collision.gameObject);
            ScrControl.punt += 5;
            print(ScrControl.punt);
        }

    }

    
    
        
    

}
