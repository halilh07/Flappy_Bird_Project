using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int scorePoint;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Score>(out Score score))
        {
            scorePoint++;
            scoreText.text = "Score: " + scorePoint.ToString();
        }
    }

}
