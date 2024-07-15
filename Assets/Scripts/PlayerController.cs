using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveHorizintal;
    [SerializeField] float moveVertical;
    float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizintal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        // w: 1    s: -1
        // a: -1   d: 1
        
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * moveVertical);
        transform.Rotate(Vector3.up * speed * Time.deltaTime * moveHorizintal);

    }
}
