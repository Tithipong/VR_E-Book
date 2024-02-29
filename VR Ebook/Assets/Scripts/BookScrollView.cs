using UnityEngine;
using UnityEngine.UI;

public class BookScrollView : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform[] contentObjects;
    public TMPro.TMP_Dropdown  dropdown;

    private void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        SetContent(0);
    }

    private void OnDropdownValueChanged(int index)
    {
        SetContent(index);
    }

    private void SetContent(int index)
    {
        for (int i = 0; i < contentObjects.Length; i++)
        {
            contentObjects[i].gameObject.SetActive(false);
        }

        contentObjects[index].gameObject.SetActive(true);

        scrollRect.content = contentObjects[index];
    }
}
