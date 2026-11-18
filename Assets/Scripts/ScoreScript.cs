using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform playerTransform;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0");
    }
}
