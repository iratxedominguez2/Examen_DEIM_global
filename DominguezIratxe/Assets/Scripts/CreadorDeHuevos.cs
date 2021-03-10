using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeHuevos : MonoBehaviour
{
    [SerializeField] GameObject Huevo;
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("HuevoCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerarHuevos()
    {
        float randomX = Random.Range(-18f, 18f);
        float randomZ = Random.Range(-18f, 18f);

        Vector3 RndmPos = new Vector3(randomX, 0, randomZ);
        Instantiate(Huevo, RndmPos, Quaternion.identity);

    }
    IEnumerator HuevoCoroutine()
    {
        for (contador = 1; contador <= 5; contador++)
        {
            GenerarHuevos();
            yield return new WaitForSeconds(2);
        }
        for (contador = 6; contador <= 10 && contador > 5; contador++)
        {
            GenerarHuevos();
            yield return new WaitForSeconds(1);
        }
        for (contador = 11; contador > 10; contador++)
        {
            GenerarHuevos();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
