using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public List<Connection> connections;
    public List<Node> ConnectedNodes;
    public Color touchColor, connectionColor,OringinColor,ConnectlineColor;
    public bool isConnection=true;
    public MeshRenderer meshRenderer;
    public bool isToching = false;

    // Start is called before the first frame update
    void Start()
    {
        connections = new List<Connection>();
        meshRenderer = GetComponent<MeshRenderer>();
      //OringinColor  =meshRenderer.material.color;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addConnectedNode(Node n) {
        if(n!=this)
        ConnectedNodes.Add(n);
    }



    public void addConnection(Connection c){
        c.high_light_color = ConnectlineColor;
        connections.Add(c);






    }

    public void isTouch() {
        isToching = true;
        isConnection = false;
        meshRenderer.material.color = touchColor;

        foreach (var c in connections) {
            c.HighLight();
        }

    }

    public void notTouch() {
        isToching = false;
        meshRenderer.material.color = OringinColor;
        isConnection = true;


        foreach (var c in connections) {
            c.noHighLight();
        }

    }

    public void connectionHighlight() {

        meshRenderer.material.color = connectionColor;


    }

    public void NoconnectionHighlight()
    {

        meshRenderer.material.color = OringinColor;


    }


}
