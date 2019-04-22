using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject _earth;
    public float speed = 20;

    void Start()
    {
        _earth.GetComponent<Transform>();
    }

    void Update()
    {
        _earth.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
