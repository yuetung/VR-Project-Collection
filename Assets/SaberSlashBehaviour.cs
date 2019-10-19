using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberSlashBehaviour : MonoBehaviour
{
    [Tooltip("Layer of the destroyable objects")]
    public LayerMask layer;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawLine(transform.position, transform.position+1*transform.forward, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 1, layer))
        {
            Debug.Log("hit");
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
            {
                Debug.Log("good hit");
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position;
    }
}
