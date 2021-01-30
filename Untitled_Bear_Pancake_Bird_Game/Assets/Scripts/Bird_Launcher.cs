using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Launcher : MonoBehaviour
{

    public GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("FireBird");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FireBird()
    {
        yield return new WaitForSeconds(1.5f);
        for(; ; )
        {
            Instantiate(bird);
            yield return new WaitForSeconds(Random.Range(1.5f,3.5f));
        }
        
    }

}
