using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEvent : MonoBehaviour
{
    public GameObject _category;

    private void OnMouseEnter()
    {
        print("mouse enter");
        print(gameObject.name);
        
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
