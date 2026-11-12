using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int healthPoints = 54;
        
        Debug.Log(speed);
        Debug.Log(healthPoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
