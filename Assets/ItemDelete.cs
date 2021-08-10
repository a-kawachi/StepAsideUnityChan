using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    private GameObject Camera;

    private void Start()
    {
        this.Camera = GameObject.Find("Main Camera");

    }

    private void Update()
    {
        if (this.Camera.transform.position.z > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}