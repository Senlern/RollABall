using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(new Vector3(1,0,0));
        float h = Input.GetAxis("Horizontal");
        Debug.Log(h);
    }
}
