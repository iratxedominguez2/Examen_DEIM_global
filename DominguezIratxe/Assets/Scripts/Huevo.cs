using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{
    private AudioSource huevoSound;
    private CreadorDeHuevos creadordeHuevos;
    

    void Start()
    {
        huevoSound = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Plane")
        {
            Destroy(this.gameObject);
            huevoSound.Play(0);

        }

    }

}
