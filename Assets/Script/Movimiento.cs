using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float _velocidad = 0.008f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Input.GetAxis("Horizontal") * _velocidad, 0, Input.GetAxis("Vertical") * _velocidad);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
    }
}
