using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float movespeed;
    public float deadzone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<deadzone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
        transform.position = transform.position+(Vector3.left * movespeed)*Time.deltaTime;
    }
}
