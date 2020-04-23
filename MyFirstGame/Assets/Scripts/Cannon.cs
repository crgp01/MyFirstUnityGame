using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public Transform shootingPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Horizontal");
        // transform.Translate(2 * Time.deltaTime, 0, 0);
        //transform.Translate(2 * Time.deltaTime, 0, 0);
        transform.Rotate(verticalInput * 45 * Time.deltaTime, 0, 0);
        // transform.Translate(verticalInput * 45 * Time.deltaTime, 0, 0);

        if(Input.GetKeyDown("space")){
        
            GameObject cannonBall = Instantiate(cannonBallPrefab);
            cannonBall.transform.position = shootingPoint.position;

            Rigidbody cannonBallRb = cannonBall.GetComponent<Rigidbody>();
            cannonBallRb.velocity = transform.up * 8;
        }
    }
}