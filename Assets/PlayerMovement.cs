using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }
        public float speed=5f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")){
        transform.Translate(Vector2.up* Time.deltaTime* speed);    
    }

    
        if(Input.GetKey("a")){
        transform.Translate(Vector2.left* Time.deltaTime* speed);
    }


         if(Input.GetKey("d")){
        transform.Translate(Vector2.right* Time.deltaTime* speed);
    }
    }
}