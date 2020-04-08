using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        // transform.Translate(2 * Time.deltaTime, 0, 0);
        transform.Rotate(verticalInput * 45 * Time.deltaTime, 0, 0);
    }
}