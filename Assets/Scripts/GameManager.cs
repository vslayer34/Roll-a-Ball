using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    TextMeshProUGUI countText;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        //SetCount(0);
    }

    public void SetCount(int count)
    {
        countText.text = $"count: {count.ToString()}";
    }
}
