using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
