using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeBoxCode : MonoBehaviour
{
    public static int badScore = 0;
    public static int goodScore = 0;
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "bad"){
            badScore = badScore + 2;
            print("so sad( you have " + badScore + " bad Score");
            Destroy(gameObject);  
        }
        if(col.gameObject.tag == "good"){
             rb.AddForce(0, 200f, 0);
        }
    }

    void OnMouseDown(){
        if(gameObject.tag == "sphere"){
            goodScore = goodScore + 2; 
            Destroy(gameObject);
            print("nice! you have " + goodScore + " good Score");
        }
    }
}
