using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 500;
    
    public int count = 10;
    



    // Start is called before the first frame update
    void Awake()
    {
        
        for(int i = 0; i < count; i++)
        {
            float rotation = Random.Range(0f, 360f);
            Vector3 spawn= (Random.insideUnitSphere * radius) + new Vector3(10,20,30);
            Quaternion rot = Quaternion.Euler(0, rotation, 0);
            Instantiate(prefab,spawn,rot);
            //prefab.transform.Rotate(0, rotation, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
