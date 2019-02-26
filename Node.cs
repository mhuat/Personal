using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Node
{
    public Node parent; //Reference to the node's parent object
    public Node left; //Reference to the node's left child object
    public Node right; //Reference to the node's right child object
    public int data; //Stores the node's data value
    public int key; //Stores the node's key value 
}

