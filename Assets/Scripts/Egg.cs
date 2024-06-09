using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject chick;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 10f);
       
    }

    private void Spawn() 
    {
        Instantiate(chick, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
