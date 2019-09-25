using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform cube;
    private Vector3 pos = new Vector3(0f,0f,0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            pos.z += 0.2f;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= 0.2f;
        }
        if (Input.GetKey("d"))
        {
            pos.x += 0.2f;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= 0.2f;
        }
        if (Input.GetKey("e"))
        {
            pos.y += 0.2f;
        }
        if (Input.GetKey("q"))
        {
            pos.y -= 0.2f;
        }
        cube.Translate(pos);
        pos = new Vector3(0f, 0f, 0f);
    }
}
