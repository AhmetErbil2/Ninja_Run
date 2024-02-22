using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polis : MonoBehaviour
{
    public Transform Char;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(Char.position.x, Char.position.y+1, Char.position.z - 5f);
    }
    
}
