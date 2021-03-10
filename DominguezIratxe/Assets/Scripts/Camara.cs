using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject caja;
    private Vector3 desplazamiento;
    // Start is called before the first frame update
    void Start()
    {
        desplazamiento = transform.position - caja.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = caja.transform.position + desplazamiento;

    }
}
