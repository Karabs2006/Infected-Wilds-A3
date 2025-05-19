using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    int initial = 0;
    public TMP_Text myText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myText.text = $"{initial}";

    }

    // Update is called once per frame
    public void AddScore(int score)
    {
        initial += score;
        print(myText.text = $"{initial}");

    }
}
