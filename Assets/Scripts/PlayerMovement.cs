using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int healthPoints = 89;
        Debug.Log(speed);
        Debug.Log(healthPoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
