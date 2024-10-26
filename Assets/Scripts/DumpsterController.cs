using System.Collections;
using UnityEngine;

public class DumpsterController : MonoBehaviour
{
    [SerializeField] private GameObject dumpsterGrey;
    [SerializeField] private GameObject dumpsterGreen;
    [SerializeField] private GameObject dumpsterBlue;
    [SerializeField] private GameObject dumpsterRed;

    public void DumpsterGrey_OnClick()
    {
        StartCoroutine(ShakeAndOpen(dumpsterGrey));
    }

    public void DumpsterGreen_OnClick()
    {
        StartCoroutine(ShakeAndOpen(dumpsterGreen));
    }

    public void DumpsterBlue_OnClick()
    {
        StartCoroutine(ShakeAndOpen(dumpsterBlue));
    }

    public void DumpsterRed_OnClick()
    {
        StartCoroutine(ShakeAndOpen(dumpsterRed));
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
    }
}