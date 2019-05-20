using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Lock")
        {
            Destroy(gameObject);
        }
    }
}