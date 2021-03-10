using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Huevo : MonoBehaviour
{
    private AudioSource huevoSound;
    private CreadorDeHuevos creadordeHuevos;
    public int huevosdestruidos;


    void Start()
    {
        huevoSound = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Plane")
        {
            huevosdestruidos++;
            Destroy(this.gameObject);
            huevoSound.Play(0);

        }
        
    }

}
