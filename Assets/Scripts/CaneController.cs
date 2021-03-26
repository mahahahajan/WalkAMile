using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 down = transform.TransformDirection(Vector3.down);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, down, out hit, 2)){
            print(hit.collider.gameObject.name);
        }
    }
    // private void OnCollisionEnter(Collision other) {
    //     Debug.Log("Test with");
    // }
}
