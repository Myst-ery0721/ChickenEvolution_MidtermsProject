using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public GameObject Egg;
    public Transform HenEggSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LayEggs", 30f);
        HenEggSpawn = GetComponent<Transform>();
       
    }

    private void LayEggs()
    {
        int random;
        
        random = Random.Range(3, 10);
        for (int i = 0; i < random; i++)
        {
            Instantiate(Egg, HenEggSpawn.position, Quaternion.identity);
        }
        
        Destroy(gameObject, 40f);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
