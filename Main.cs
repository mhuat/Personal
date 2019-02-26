using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    BST tree = new BST();
    int dataValue = 5;
    int keyValue = 0;
    int i = 0, j = 5;

    private void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            Node newNode = new Node();
            AutomatedInsert(newNode);
            Debug.Log("Node: " + newNode + " has a key value of: " + newNode.key + " and a data value of: " + newNode.data + ".");
        }
    }

    void AutomatedInsert(Node node)
    {
        node.data = dataValue--;
        node.key = keyValue++;
        tree.Insert(node);
    }

}
