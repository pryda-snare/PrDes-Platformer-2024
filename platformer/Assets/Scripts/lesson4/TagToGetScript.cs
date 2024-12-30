using UnityEngine;
using TMPro;

public class TagToGetorSetScript : MonoBehaviour
{
    public enum GS { getter, setter }
    public GS gs = GS.getter;

    public TextMeshProUGUI textToSet;
    public applyTag applyTagScript; 

    private void Start()
    {
        if (applyTagScript == null)
        {
            Debug.LogError("applyTagScript is not assigned");
            return;
        }

        UpdateUIText();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            switch (gs)
            {
                case GS.getter:
                    textToSet.text = applyTagScript.GetTag(); // Use applyTag's GetTag method
                    break;
                case GS.setter:
                    textToSet.text = applyTagScript.SetTag(); // Use applyTag's SetTag method
                    break;
            }
        }
    }

    private void UpdateUIText()
    {
        switch (gs)
        {
            case GS.getter:
                textToSet.text = applyTagScript.GetTag(); // Initialize with applyTag's current TagToGet
                break;
            case GS.setter:
                textToSet.text = applyTagScript.SetTag(); // Initialize with applyTag's current TagToSet
                break;
        }
    }
}