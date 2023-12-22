using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.1f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch !!!");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "package" && !hasPackage)
        {
            Debug.Log("package picked up !!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject , destroyDelay);
        }
        
        if (other.gameObject.tag == "customer" && hasPackage)
        {
            Debug.Log("package delivered  !!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            // Destroy(other.gameObject , destroyDelay);
            
        } 
        
        
  



        // Debug.Log("WTF !!!");

    }
}
