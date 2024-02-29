using UnityEngine;
using TMPro;

public class DropDownBooks : MonoBehaviour
{
    public TextMeshProUGUI catagoriesName;

    public void ChangeCatagoriesBook(int val){
        if (val == 0)
        {
            catagoriesName.text = "Kid";
        }
        if (val == 1)
        {
            catagoriesName.text = "Comic";
        }
        if (val == 2)
        {
            catagoriesName.text = "Horror";
        }
        if (val == 3)
        {
            catagoriesName.text = "Knowledge";
        }
        if (val == 4)
        {
            catagoriesName.text = "Science";
        }
    }
}