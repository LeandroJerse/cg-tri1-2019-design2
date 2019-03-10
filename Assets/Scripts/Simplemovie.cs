using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplemovie : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;
     [SerializeField]
    private float limitetop= 4f;
     [SerializeField]
    private float limitebot= -4;
     [SerializeField]
    private float limiteleft= -8;
     [SerializeField]
    private float limiteright= 8;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(HorizontalInput,VerticalInput,0f)* SpeedFactor;


        
        transform.position =  transform.position + velocity * Time.deltaTime;
        if (transform.position.y < limitebot) {
            transform.position =new Vector3(transform.position.x, limitebot,transform.position.z);
        }
        if (transform.position.y > limitetop) {
            transform.position =new Vector3(transform.position.x, limitetop,transform.position.z);
        }
        if (transform.position.x < limiteleft) {
            transform.position =new Vector3(limiteleft,transform.position.y,transform.position.z);
        }
        if (transform.position.x > limiteright) {
            transform.position =new Vector3(limiteright,transform.position.y,transform.position.z);
        }
    }
}
