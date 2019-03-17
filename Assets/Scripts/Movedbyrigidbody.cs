using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedbyrigidbody : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 10f ;
    
    private Rigidbody2D Rb ;
    void Start()
    {
        Rb= GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");
        Rb.velocity =new Vector3(HorizontalInput, VerticalInput, 0f) * SpeedFactor;
    }
}
