using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectParentMaterial : MonoBehaviour
{
    MeshRenderer mesr;
    // Start is called before the first frame update
    void Start()
    {
        mesr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mesr.material = transform.parent.GetComponent<MeshRenderer>().material;
    }
}
