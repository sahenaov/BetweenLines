using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    //private int vida = 3;
    private int rutina;
    private float cronometro;
    private Quaternion angulo;
    private float grado;

    public GameObject target;
    // Start is called before the first frame update


    public void Update()
    {
        Comportamiento_enemigo();
    }
    // Update is called once per frame
    public void Comportamiento_enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 1)
        {
            cronometro += 1 * Time.deltaTime;
            if (cronometro > 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;

            }

            switch (rutina)
            {
                case 0:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;
                case 1:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * 0.5f * Time.deltaTime);
                    break;
            }
        }

        else
        {
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
            transform.Translate(Vector3.forward*0.7f*Time.deltaTime);
        }
    }


}
