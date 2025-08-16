using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour
{
    
    public float Geschwindigkeit = 3f;
    public float Sprungkraft = 3f;
    public float Sprungkraft0 = 3f;
    public Rigidbody2D rigidbody;
    

    Vector2 bewegungsvektor = new Vector2(0,0);
    Vector2 laufvector = new Vector2(0,0);
    Vector2 sprungvektor = new Vector2(0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bewegungsvektor = new Vector2(0,0);


        if (Input.GetKey("right"))
        {
            bewegungsvektor = bewegungsvektor+Vector2.right*Geschwindigkeit;
        }

        if (Input.GetKey("left"))
        {
            bewegungsvektor = bewegungsvektor+Vector2.left*Geschwindigkeit;
        }
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(bewegungsvektor, ForceMode2D.Impulse);
    }


}