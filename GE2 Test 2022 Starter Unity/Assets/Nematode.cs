using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 15;
    bool leader = true;
    public Material material;

    void Awake()
    {




        length = Random.Range(15, 25);
        for (int i = 1; i < length; i ++ )
        {
            float height = i / length;
            float width = i / length;
            float color = 1f/ length*i;


            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
           MeshRenderer mesh = sphere.GetComponent<MeshRenderer>();
            mesh.material.color = Color.HSVToRGB(color,1f,1f);
            sphere.transform.position = new Vector3(height, width, i);
            //sphere.transform.localScale = new Vector3(3f*(height),3f*(width), 1);
            sphere.transform.SetParent(transform);
            if(i == 1)
            {
                sphere.AddComponent<Boid>();
                sphere.AddComponent<ObstacleAvoidance>();
                sphere.AddComponent<Constrain>();
                sphere.AddComponent<NoiseWander>();
            }
            

            
           
        }



    }
        


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
