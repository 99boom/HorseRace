using UnityEngine;

public class Playmovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbPlayer.AddForce(0.0f, 0.0f, 2000.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}