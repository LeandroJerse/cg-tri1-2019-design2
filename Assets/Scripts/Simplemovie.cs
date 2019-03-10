using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplemovie : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");



        float SO= transform.position.x;
        float S = (SO + HorizontalInput * SpeedFactor * Time.deltaTime);
        transform.position = new Vector3(S, transform.position.y,transform.position.z);
    }
}
