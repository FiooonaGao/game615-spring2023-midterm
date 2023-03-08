using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI NumberText;
    public TextMeshProUGUI WinText;
    public int Number;
    public bool GameIsOver = false;
    public GameObject modelToShow;
    private int collectedObjects = 0;


    // Start is called before the first frame update
    void Start()
    {
        Number = 1;
        WinText.enabled = false;
        GameIsOver = false;
        modelToShow.SetActive(false);
    }

    public void UpdateNumber()
    {
        NumberText.text = Number.ToString();
        Number++;
        collectedObjects++;

        if (collectedObjects >= 6)
        {
            modelToShow.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Number >= 6)
        {
            WinText.enabled = true;
            GameIsOver = true;

        }
    }
}
