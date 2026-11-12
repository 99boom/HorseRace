using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class Playmovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rbPlayer.AddForce(0.0f, 0.0f, 2000.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        UnityEngine.Debug.Log("Fixed = " + Time.fixedDeltaTime + " ; DeltaTime = " + Time.deltaTime);

    }
}