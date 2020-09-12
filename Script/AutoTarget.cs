using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTarget : MonoBehaviour{


    // Start is called before the first frame update
    public GameObject prefab;
    private int num = 50;
    void Start()
    {
        for (int i= 1; i < num; i++)
        {
        Vector3 position = new Vector3(Random.Range(-200.0f, 200.0f), 7, Random.Range(-200.0f, 200.0f));
        Instantiate(prefab, position, Quaternion.identity);

        }
        

    }

}
