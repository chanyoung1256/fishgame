using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public Animator Left, Right;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Left.SetBool("forward", true);
            Right.SetBool("forward", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Left.SetBool("forward", true);
            Right.SetBool("forward", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Right.SetBool("forward", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Left.SetBool("forward", true);
        }
        else
        {
            Left.SetBool("forward", false);
            Left.SetBool("backward", false);
            Right.SetBool("forward", false);
            Right.SetBool("backward", false);
        }
        // Right.SetBool("forward", Input.GetKey(KeyCode.A));
        // Left.SetBool("forward", Input.GetKey(KeyCode.D));
    }
}
