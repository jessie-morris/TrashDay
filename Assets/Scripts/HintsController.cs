using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintsController : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private Image CouplesPhoto;
    [SerializeField] private Image HardDrive;
    [SerializeField] private Image DogCollar;
    [SerializeField] private Image Notebook;
    [SerializeField] private Image Mascot;

    [Header("Sprites")]
    [SerializeField] private Sprite CouplesPhotoImage;
    [SerializeField] private Sprite HardDriveImage;
    [SerializeField] private Sprite DogCollarImage;
    [SerializeField] private Sprite NotebookImage;
    [SerializeField] private Sprite MascotImage;
    [SerializeField] private Sprite QuestionMarkImage;

    // Start is called before the first frame update
    void Start()
    {
        ShowHintImage(GameManager.instance.IsPhotoAquired, CouplesPhoto, CouplesPhotoImage);
        ShowHintImage(GameManager.instance.IsHardDriveAquired, HardDrive, HardDriveImage);
        ShowHintImage(GameManager.instance.IsCollarAquired, DogCollar, DogCollarImage);
        ShowHintImage(GameManager.instance.IsNotebookAquired, Notebook, NotebookImage);
        ShowHintImage(GameManager.instance.IsMascotAquired, Mascot, MascotImage);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowHintImage(Func<bool> foundFunction, Image hintImage, Sprite hintSprite)
    {
        if (foundFunction())
        {
            hintImage.sprite = hintSprite;
        }
        else
        {
            hintImage.sprite = QuestionMarkImage;
        }
    }
}
