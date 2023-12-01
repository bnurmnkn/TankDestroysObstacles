using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DestroyEngel : MonoBehaviour
{

    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                
                if (hit.collider.gameObject.tag=="engel")
                {
                    
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
