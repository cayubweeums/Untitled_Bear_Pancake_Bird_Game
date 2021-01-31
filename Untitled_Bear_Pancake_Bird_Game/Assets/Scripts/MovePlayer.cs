using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject gunPos;
    [SerializeField] float projectileSpeed = 10f;
    private Rigidbody2D rigBod;
   
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
        Fire();
    }

    private void Fire()
    {
        if (Input.GetKeyDown("space")) 
        {
            GameObject bullet = Instantiate(bulletPrefab, gunPos.transform.position,Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        }
    }
}
