using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    private Vector2 direction;
    private Animator animator;

    /*creates animator object with refference to local "Animator" from whatever game object script is tied to. Since this is 
     * tied to the player game object "GetComponent<Animator>" looks for an Animator Component within player and uses that.
     */
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        KeyInput();
        Move();
    }


    // checks to see if the player is moving at all. If they are moving SetAnimator. Else Layer Weight set 1,0
    // This allows the change between idle and moving animations.
    
    private void Move()
    {
        transform.Translate(direction * MoveSpeed * Time.deltaTime);

        if (direction.x != 0 || direction.y != 0)
        {
            SetAnimator(direction);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
    }



    private void KeyInput() 
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if(Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if(Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if(Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }

    }
    

    //Sets layer weight of layer 1 (walking in this case) to 1; this allows the walking layer to outweigh the idle layer allowing the walk animation
    //to play. When directional input stops layer weight is set back to 0 allowing default layer 0 (idle) to outweigh walking. Player stands in idle animation.
    private void SetAnimator(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);


        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
        print(animator.GetFloat("xDir"));
    }





}
