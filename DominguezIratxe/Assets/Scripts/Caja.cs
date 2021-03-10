using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour
{

    
    public float speed=10f;

    //Punto de destino
    //private Vector3 moveInput;





    // Start is called before the first frame update
    void Start()
    {
        speed=10f;


    }

    // Update is called once per frame
    void Update()
    {

        MoverCaja();


    }




    void MoverCaja()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        if (posX < 18f && posX > -18f || posX < -18f && desplX > 0 || posX > 18f && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        if (posZ < 18f && posZ > -18f || posZ < -18f && desplZ > 0 || posZ > 18f && desplZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }
    }
}
