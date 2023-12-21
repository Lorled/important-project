using UnityEngine;

public class DisappearTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player")) 
        {
            
            gameObject.SetActive(false);

             Renderer renderer = GetComponent<Renderer>();
             if (renderer != null)
             {
                 Color objectColor = renderer.material.color;
                 objectColor.a = 0f;
                 renderer.material.color = objectColor;
             }
        }
    }
}
