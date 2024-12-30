using UnityEngine;
using System.Collections.Generic;

public class applyTag : MonoBehaviour
{
    private string[] Tags = { "Player", "button", "Enemy", "fruit" };

    public string TagToGet = "Player";
    public int GetIndex;

    public string TagToSet = "Player";
    public int SetIndex;

    private Dictionary<string, RuntimeAnimatorController> tagToAnimator;

    public RuntimeAnimatorController Player;      // Animator for "Player" tag
    public RuntimeAnimatorController Enemy;       // Animator for "Enemy" tag
    public RuntimeAnimatorController buttonAC;    // Animator for "button" tag
    public RuntimeAnimatorController Pineapple_0; // Animator for "fruit" tag


    public void Start()
    {
        Tags = new string[] { "Player", "button", "Enemy", "fruit" };
        tagToAnimator = new Dictionary<string, RuntimeAnimatorController>
        {
            { "Player", Player },
            { "button", buttonAC },
            { "Enemy", Enemy },
            { "fruit", Pineapple_0 }
        };
        applyButtons();
    }


    public string GetTag()
    {
        TagToGet = Tags[GetIndex];
        GetIndex++;
        if (GetIndex >= Tags.Length) { GetIndex = 0; }
        return TagToGet;
    }

    public string SetTag()
    {
        TagToSet = Tags[SetIndex];
        SetIndex++;
        if (SetIndex >= Tags.Length) { SetIndex = 0; }
        return TagToSet;
    }

    void applyButtons()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("button");
        foreach (GameObject obj in taggedObjects)
        {
            Animator animator = obj.GetComponent<Animator>();
            if (animator == null)
            {
                animator = obj.AddComponent<Animator>();
            }

            animator.runtimeAnimatorController = tagToAnimator["button"];
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(TagToGet);
            foreach (GameObject obj in taggedObjects)
            {
                obj.tag = TagToSet;
                Animator animator = obj.GetComponent<Animator>();
                if (animator == null)
                {
                    animator = obj.AddComponent<Animator>();
                }

                animator.runtimeAnimatorController = tagToAnimator[TagToSet];
            }

        }
    }
}