using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 targetPosition;
    public float grabRadius = 2.0f; //a partir de que distancia el objeto es interactuable
    private GameObject grabObject;

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Collider2D[] hitObjects = Physics2D.OverlapCircleAll(transform.position, grabRadius);
            foreach (Collider2D hitObject in hitObjects)
            {
                //si el tag del objeto coincide, se agarra
                if(hitObject.gameObject.CompareTag("Grabbable"))        
                {
                    grabObject = hitObject.gameObject;
                    grabObject.transform.parent=transform;
                    break;                
                //sino se mueve hacia el lugar
                } else 
                {
                    targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    targetPosition.z = transform.position.z;
                    break;
                }
            }
            
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player collided with " + other.gameObject.name),
    }


}
