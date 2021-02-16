using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] int moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = -Input.GetAxis("Horizontal")*Time.deltaTime;
        float zValue = -Input.GetAxis("Vertical")*Time.deltaTime;

        transform.Translate(xValue*moveSpeed,0,zValue*moveSpeed);
    }
}
