using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FightMessageController : MonoBehaviour
{
    public TMP_Text fightText; // Use TMP_Text instead of Text
    public float displayDuration = 2.0f;
    private float currentTime = 0.0f;
    private bool showMessage = true;

    private void Start()
    {
        fightText.enabled = true;
        currentTime = 0.0f;
    }

    private void Update()
    {
        if (showMessage)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= displayDuration)
            {
                fightText.enabled = false;
                showMessage = false;
            }
        }
    }

    public void StartFightMessage()
    {
        Start();
    }
}
