using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DumpsterController : MonoBehaviour
{
    [Header("Dumpsters")]
    [SerializeField] private GameObject dumpsterGrey;
    [SerializeField] private GameObject dumpsterGreen;
    [SerializeField] private GameObject dumpsterBlue;
    [SerializeField] private GameObject dumpsterRed;

    [Header("Reward Panel")]
    [SerializeField] private GameObject rewardPanel;
    [SerializeField] private Image dumpsterReward;
    [SerializeField] private TMP_Text dumpsterRewardHeader;
    [SerializeField] private TMP_Text dumpsterRewardDescription;

    [Header("Sprites")]
    [SerializeField] private Sprite CouplesPhotoImage;
    [SerializeField] private Sprite HardDriveImage;
    [SerializeField] private Sprite DogCollarImage;
    [SerializeField] private Sprite NotebookImage;
    [SerializeField] private Sprite MascotImage;
    [SerializeField] private Sprite QuestionMarkImage;

    public void DumpsterGrey_OnClick()
    {
        TryOpenDumpster(dumpsterGrey);
    }

    public void DumpsterGreen_OnClick()
    {
        TryOpenDumpster(dumpsterGreen);
    }

    public void DumpsterBlue_OnClick()
    {
        TryOpenDumpster(dumpsterBlue);
    }

    public void DumpsterRed_OnClick()
    {
        TryOpenDumpster(dumpsterRed);
    }

    private void TryOpenDumpster(GameObject dumpster)
    {
        //Fix after credit manager is working
        if (CreditsManager.instance.GetCredits() > 1000)
        {
            StartCoroutine(ShakeAndOpen(dumpster));
            CreditsManager.instance.DeductFromScore(1000);
        }
    }

    IEnumerator ShakeAndOpen(GameObject dumpster)
    {
        float shakeValue = 5f;
        AudioManager.instance.Play("Rummage");
        for (int i = 0; i < 10; i++)
        {
            dumpster.transform.position += new Vector3(shakeValue, 0, 0);
            yield return new WaitForSeconds(0.1f);
            dumpster.transform.position -= new Vector3(shakeValue, 0, 0f);
            yield return new WaitForSeconds(0.1f);

            shakeValue += 1f;
        }
        dumpster.SetActive(false);
        ShowReward();
    }

    void ShowReward()
    {
        bool isReward = Random.Range(0, 2) == 0;
        if (isReward)
        {
            //pick a random unclaimed reward here, right now hardcoded to harddrive
            dumpsterRewardHeader.text = "You found a piece of your past!";
            dumpsterReward.sprite = HardDriveImage;
            dumpsterRewardDescription.text = "You found your lost harddrive!";

            rewardPanel.SetActive(true);
        }
        else
        {
            dumpsterRewardHeader.text = "No luck this time!";
            dumpsterReward.sprite = QuestionMarkImage;
            dumpsterRewardDescription.text = "Only trash in this one, keep looking!";
            rewardPanel.SetActive(true);
        }

    }

    public void hideRewardPanel_OnClick()
    {
        rewardPanel.SetActive(false);
    }
}