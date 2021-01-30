using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying_Bird_Right : MonoBehaviour
{

    private Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {

        rb2 = GetComponent<Rigidbody2D>();
        rb2.AddForce(transform.right * 200);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
