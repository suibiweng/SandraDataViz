using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
    public Node n1,n2;
    public Color high_light_color,originColor;
    MeshRenderer meshRenderer;
    Manager m;
    // Start is called before the first frame update
    void Start()
    {
        n1.addConnection(this);
        n2.addConnection(this);

        n1.addConnectedNode(n2);
        n2.addConnectedNode(n1);

        meshRenderer = GetComponent<MeshRenderer>();
        m= GameObject.FindObjectOfType<Manager>();

        high_light_color = m.ConnectlineColor;
        originColor = meshRenderer.material.color ;






    }





    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighLight() {
        //
        meshRenderer.material.color = high_light_color;
        if (n1.isConnection) {

            n1.connectionHighlight();
        }
        if (n2.isConnection) {

            n2.connectionHighlight();
        }
    }

    public void noHighLight()
    {
        meshRenderer.material.color = originColor;
        //
        n1.NoconnectionHighlight();
        n2.NoconnectionHighlight();
        
    }



}
