using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{

    public float speed = 40;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
