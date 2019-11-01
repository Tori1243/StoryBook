using UnityEngine;

public class AnimatorTrigger : MonoBehaviour
{
    public string name;
    
    public Animator anim;
    
    public void Set()
    {
        anim.SetTrigger(name);
    }
}