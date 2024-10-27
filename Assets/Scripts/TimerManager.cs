using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = GameManager.instance.GetTimeRemaining();
    }
}
