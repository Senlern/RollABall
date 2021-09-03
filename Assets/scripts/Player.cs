using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    int score = 0;
    Text showScore;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        showScore = GameObject.Find("Canvas/Text").GetComponent<Text>();
        showScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(new Vector3(1,0,0));
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log(h);
        rd.AddForce(new Vector3(h, 0, v));
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "food")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            score++;
            showScore.text = score.ToString();
            Destroy(other.gameObject);
        }
    }
}
