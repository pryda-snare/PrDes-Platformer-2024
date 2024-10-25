

using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaseObject : MonoBehaviour
{
    [SerializeField]
    protected GameObject target;

    public void setTarget(GameObject nextTarget){
        target = nextTarget;
    }

    protected void ChaseTarget(){
        if(target != null)
        {
            Vector3 dest = target.transform.position;
            Vector3 pos = transform.position;
            float distance = 2 * Time.deltaTime;

            if (pos.x > dest.x)
            {
                pos.x -= distance;
            }
            else
            {
                pos.x += distance;
            }

            transform.position = pos;
        } else {
            SceneManager.LoadScene("SampleScene");
        } 
    }
}