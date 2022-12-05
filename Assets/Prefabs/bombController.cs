using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb= GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(new Vector2(5f, 5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
