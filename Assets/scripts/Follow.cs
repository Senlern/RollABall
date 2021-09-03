using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    GameObject p;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Player");
        offset = transform.position-p.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = p.transform.position + offset;
    }
}
