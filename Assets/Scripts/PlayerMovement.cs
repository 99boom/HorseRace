using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float forwardForce = 5.0f;
    [SerializeField] private float sidewaysForce = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, forwardForce);
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        } 
    }
}
