using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPositions : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] myObjects;

    private void Start()
    {
        for(int i = 0; i< 30; i++)
        {
            RandomSpawn();
        }
       
    }


    private void RandomSpawn()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 5), 0.206f, Random.Range(-4, 5));

        Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);

    }
}
