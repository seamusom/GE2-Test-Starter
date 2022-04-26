using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    Transform spawn;

    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < count; i++)
        {
            float rotation = Random.Range(0f, 360f);
            spawn.transform.position = Random.insideUnitSphere * radius;
            Instantiate(prefab,spawn);
            prefab.transform.Rotate(0, rotation, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
