using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectSystem : MonoBehaviour
{
    private int _energy = 20;
    public int Energy { get { return _energy; } set {  _energy = value; } }
    //public int Energy { get { return _energy; } }
    [SerializeField]
    private Transform _respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            Energy = Energy ++;
            Debug.Log("Hemos recogido un item");
            Destroy(other.gameObject);
        }
        if(other.tag == "Obstacle")
        {
            Energy = Energy --;
            Debug.Log("Hemos perdido vida");
            Destroy(other.gameObject);
        }
    }



}
