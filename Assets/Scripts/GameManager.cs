using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    TextMeshProUGUI countText;

    [SerializeField]
    GameObject youWinText;

    int victoryScore = 12;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetCount(int count)
    {
        countText.text = $"count: {count.ToString()}";

        if (count >= victoryScore)
            youWinText.SetActive(true);
    }
}
