using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BookCatalog : MonoBehaviour
{
    [SerializeField] private GameObject lebleBookScrollView;
    [SerializeField] private GameObject lebleEnvironmentalScrollView;
    [SerializeField] private GameObject bookScrollView;
    [SerializeField] private GameObject environmentalScrollView;
    [SerializeField] private GameObject readyMenu;

    void Start()
    {


        lebleBookScrollView.SetActive(true);
        lebleEnvironmentalScrollView.SetActive(false);
        bookScrollView.SetActive(true);
        environmentalScrollView.SetActive(false);
        readyMenu.SetActive(false);
    }

    void Update()
    {
        // Any additional logic you may need in the Update method
    }

    public void OnBookButtonClicked()
    {
        lebleBookScrollView.SetActive(false);
        lebleEnvironmentalScrollView.SetActive(true);
        bookScrollView.SetActive(false);
        environmentalScrollView.SetActive(true);
    }

    public void OnEnvironmentalButtonClicked()
    {
        lebleEnvironmentalScrollView.SetActive(false);
        environmentalScrollView.SetActive(false);
        readyMenu.SetActive(true);
    }

    public void OnYesReadyButtonClicked()
    {
        GameObject.Find("XRInteractionManager").SetActive(false);
        SceneManager.LoadScene(2);
    }
    public void OnNoReadyButtonClicked()
    {
        Start();
    }
    
}
