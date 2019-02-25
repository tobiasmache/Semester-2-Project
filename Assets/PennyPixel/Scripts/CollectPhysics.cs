using UnityEngine;
using System.Collections;

public class CollectPhysics : MonoBehaviour
{

    void OnCollisionEnter2d(Collider2D col)
    {
        Debug.Log("Hell1");
        if (col.gameObject.FindWithTag("Collectable"))
        {
            Debug.Log("Hello");
        }
    }
}