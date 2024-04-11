using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    private int _energy = 20;
    public int Energy { get { return _energy; } set { _energy = value; } }
    [SerializeField]
    private Transform _respawnPoint;
    // Start is called before the first frame update
    private void ReceiveDamage()
    {

        if (Energy < 1)
        {
            SceneManager.LoadScene(0);
            transform.position = _respawnPoint.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            Energy = Energy+ 5;
            Debug.Log("Hemos recogido un item");
            Destroy(other.gameObject);
        }
        if (other.tag == "Obstacle")
        {
            Energy = Energy - 5;
            Debug.Log("Hemos perdido vida");
            Destroy(other.gameObject);
        }
        ReceiveDamage();
    }


    private void OnDestroy()
    {
        Deadzone.OnPlayerFall -= ReceiveDamage;
    }

}
