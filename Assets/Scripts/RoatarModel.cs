using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoatarModel : MonoBehaviour
{
    public Vector3 rSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rSpeed);
    }
}
