using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Transform AsterPos;
    public GameObject[] Rock;
    public int delay;
    public UIManager uiManager;
    public AudioSource audioSource;

    public void OnHit()
    {
        uiManager.OnHit();
    }
    public void OnScore()
    {
        uiManager.OnScore();
    }
    // Start is called before the first frame update
    void Start()
    {
        delay = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (++delay >= 50)
        {
            delay = 0;
            GameObject ins = Instantiate(
                Rock[Random.Range(0, 1)]
                , new Vector3(AsterPos.position.x + Random.Range(-2.5f, 2.5f)
                , AsterPos.position.y + Random.Range(-0.5f, 0.5f)
                , AsterPos.position.z)
                , Quaternion.identity
            );
            ins.GetComponent<Aster>().gameManager = gameObject.GetComponent<Manager>();
        }
    }
}
