using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrcPlayer : MonoBehaviour
{
    [SerializeField]
    float velocitat = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y; // para leer gamepad
        x = Input.GetAxis("Horizontal"); //leer movimiento horizontal
        y = Input.GetAxis("Vertical"); //leer movimiento vertical 
        //print("Horizontal: " + x + "/Vertical: " + y); //mostramos x e y 
        transform.Translate(x *Time.deltaTime*velocitat, y*Time.deltaTime*velocitat, 0);
    }

}
