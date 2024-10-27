using UnityEngine;
using UnityEngine.EventSystems;

public class Dumpstser_Animator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator sharedAnimator;
    public string hoverParameterName;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (sharedAnimator != null)
        {
            sharedAnimator.SetBool(hoverParameterName, true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (sharedAnimator != null)
        {
            sharedAnimator.SetBool(hoverParameterName, false);
        }
    }
}
