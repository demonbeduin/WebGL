using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    public GameObject _category;

    private void OnMouseEnter()
    {
        print("mouse enter");
    }
    private void OnMouseExit()
    {
        print("mouse exit");
    }
    void Start()
    {
        _category.GetComponent<GameObject>();
    }
    void Update()
    {
        
    }
}
