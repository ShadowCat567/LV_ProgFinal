using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseOver : MonoBehaviour
{
    Camera mainCamera;
    bool cardClick = false;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        HoverOver();
        HoverOverUI();
    }

    void HoverOver()
    {
        RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if(ray.collider != null && ray.collider.tag == "Card")
        {
            Debug.Log("Hit something");
        }
    }

    public void OnPickUp()
    {
        cardClick = true;
        Debug.Log("pickup");
    }

    void HoverOverUI()
    {
        
    }
}
