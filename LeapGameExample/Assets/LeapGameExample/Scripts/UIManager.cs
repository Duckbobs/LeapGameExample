using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider slider;
    public GameObject endUI;
    public Text endUIScore;
    public Text UIScore;

    public int score;

    public void OnHit()
    {
        slider.value -= 10;
        if (slider.value <= 0 && endUI.active == false)
        {
            endUIScore.text = score.ToString();
            endUI.SetActive(true);
        }
    }
    public void OnScore()
    {
        score += 100;
        UIScore.text = score.ToString();
    }


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
