using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPush : MonoBehaviour
{
    //Awesome game!

    [SerializeField]
    private GameObject Wall;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("WallStarter"))
        {
            Destroy(other.gameObject);
            Wall.SetActive(true);
        }
    }
}
