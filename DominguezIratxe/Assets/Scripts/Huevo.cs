using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{
    
    private CreadorDeHuevos creadordeHuevos;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Plane")
        {
            Destroy(this.gameObject);
                   
        }

    }

}
