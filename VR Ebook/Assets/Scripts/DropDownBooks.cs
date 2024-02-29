using UnityEngine;
using TMPro;

public class DropDownBooks : MonoBehaviour
{
    public TextMeshProUGUI catagoriesName;

    public void ChangeCatagoriesBook(int val){
        if (val == 0)
        {
            catagoriesName.text = "1";
        }
        if (val == 1)
        {
            catagoriesName.text = "2";
        }
        if (val == 2)
        {
            catagoriesName.text = "3";
        }
        if (val == 3)
        {
            catagoriesName.text = "4";
        }
        if (val == 4)
        {
            catagoriesName.text = "5";
        }
    }
}