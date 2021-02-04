using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inc_Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BirdRight" || collision.gameObject.tag == "BirdLeft")
        {
            GameManager.Instance.IncScore(1);
        }

        Destroy(collision.gameObject);
   
    }
}
