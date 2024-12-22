using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=1;
    private float timer=0;
    public float height_of_set=10;
    public float minGap =2;
    public float maxGap=4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate){
            timer=timer+Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer=0;

        }
        
    }
    void spawnPipe()
    {
        float lowest_point=transform.position.y-height_of_set;
        float highest_point=transform.position.y+height_of_set;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowest_point,highest_point),0),transform.rotation);

    }
}
