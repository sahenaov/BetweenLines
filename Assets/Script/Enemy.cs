using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    //private int vida = 3;
    GameObject jugador;
    float velocidad = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
    }

    private void FindPlayer()
    {
        transform.LookAt(jugador.transform);
        GetComponent<Rigidbody>().velocity = transform.forward;
    }

}
