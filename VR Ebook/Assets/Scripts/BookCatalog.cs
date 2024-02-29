using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BookCatalog : MonoBehaviour
{
    [SerializeField] private GameObject lebleBookScrollView;
    [SerializeField] private GameObject lebleEnvironmentalScrollView;

    [SerializeField] private GameObject space;
    [SerializeField] private GameObject catagoriesTopic;
    [SerializeField] private GameObject catagoriesDropdown;

    [SerializeField] private GameObject bookScrollView;
    [SerializeField] private GameObject environmentalScrollView;
    [SerializeField] private GameObject readyMenu;

    void Start()
    {
        lebleBookScrollView.SetActive(true);
        lebleEnvironmentalScrollView.SetActive(false);

        space.SetActive(false);
        catagoriesTopic.SetActive(true);
        catagoriesDropdown.SetActive(true);

        bookScrollView.SetActive(true);
        environmentalScrollView.SetActive(false);
        readyMenu.SetActive(false);
    }

    public void OnBookButtonClicked()
    {
        lebleBookScrollView.SetActive(false);
        lebleEnvironmentalScrollView.SetActive(true);

        space.SetActive(true);
        catagoriesTopic.SetActive(false);
        catagoriesDropdown.SetActive(false);

        bookScrollView.SetActive(false);
        environmentalScrollView.SetActive(true);
    }

    public void OnEnvironmentalButtonClicked()
    {
        lebleEnvironmentalScrollView.SetActive(false);

        space.SetActive(false);
        
        environmentalScrollView.SetActive(false);
        readyMenu.SetActive(true);
    }

    public void OnYesReadyButtonClicked()
    {
        SceneManager.LoadScene(2);
    }
    public void OnNoReadyButtonClicked()
    {
        Start();
    }
    
}
