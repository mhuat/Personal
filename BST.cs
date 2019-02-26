using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BST
{
    public Node root = new Node(); //Creates a reference to the root node of the BST

    public void Insert(Node newNode) //Inserts a new node to BST
    {
        if (root == null)
        {
            root = newNode; //if the BST's root is null, set the new node to the root of the BST
            return;
        }

        //The new node being insrted references the root to start it's traversal
        Node tempNode = root; //Sets a temporary reference to the current node being inserted


        while (newNode != null)
        {
            if (newNode.key > tempNode.key) //If the new node's key is greater than the temp node's key
            {
                if (tempNode.right == null) //If the temp node's right object reference is null
                {
                    tempNode.right = newNode; //Set the new node to the temp node's right reference
                    newNode.parent = tempNode; //The temp node is the new node's parent reference
                    Debug.Log("New Node is Root's Right.");
                    break;
                }
                else tempNode = tempNode.right; //Set the temp node's right object reference to the object reference of temp node
            }
            else if (newNode.key < root.key) //If the new node's key is greater than the temp node's key
            {
                if (tempNode.left == null) //If the temp node's left object reference is null
                {
                    tempNode.left = newNode; //Set the new node to the temp node's left reference
                    newNode.parent = tempNode; //The temp node is the new node's parent reference
                    Debug.Log("Parent is Root's Left.");
                    break;
                }
                else tempNode = tempNode.left;
            }
            else if (newNode.key == tempNode.key) //If the new node's key is equal to the temp node's key
            {
                tempNode.data = newNode.data; //Replaces the temp node's data with the new node's data
                Debug.Log("Parent is Root."); 
                break;
            }
        }        
    }

}


