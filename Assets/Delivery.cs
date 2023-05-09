using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]
    private Color32 hasPackageColor = new Color32(255,0,150,255);

    [SerializeField]
    private Color32 noPackageColor = new Color32(255,255,255,255);

    private SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    [SerializeField]
    private float destroyDelay = 0.25f;

    private bool hasPackage;

    // private void OnCollisionEnter2D(Collision2D other) 
    // {
    //     Debug.Log("Collision Detected");
    // }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == Tags.Package.ToString() && !hasPackage)
        {
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
            Debug.Log("Package picked up!");
        }
        
        if(other.tag == Tags.Customer.ToString() && hasPackage)
        {
            spriteRenderer.color = noPackageColor;
            Debug.Log("Delivered to customer!");
            hasPackage = false;
        }
    }
}
