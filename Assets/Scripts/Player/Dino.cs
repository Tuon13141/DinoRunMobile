using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dino : MonoBehaviour
{
    public DinoState DinoState;
    public List<BoxCollider2D> Dino_RunAndJumpCollinder;
    public BoxCollider2D Dino_DuckCollinder;

    public float moveSpeed;
    public bool IsGrounded { get; set; } = true;
    public bool CanMoveHorizontal { get; set; } = false;

    public Rigidbody2D rb;
    public Animator DinoAnimator;
    public float jumpForce = 8f;

    public AudioSource JumpSound;
    public AudioSource DeadSound;

    public GameObject DeadDino;
    public ParticleSystem JumpParticle;
    public ParticleSystem RunParticle;

    InputSystem inputActions;
    public Button LeftButton;
    public Button RightButton;

    public bool IsDucking { get; set; } = false;
    float moveDirection;
    public void ChangeState(DinoState state)
    {
        DinoState = state;
        DinoState.SetDino(this);
        //Debug.Log(DinoState.GetType());
    }
    // Start is called before the first frame update
    void Start()
    {
        InputSystemPlugin();
        rb = GetComponent<Rigidbody2D>();
        ChangeState(new IdleState());

    }

    // Update is called once per frame
    void Update()
    {
      
        CheckIsGrounded();
        if (transform.position.x <= -5.5f)
        {
            transform.position = new Vector2(-5.5f, transform.position.y);
        }
        else if(transform.position.x >= 6.3f)
        {
            transform.position = new Vector2(6.3f, transform.position.y);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
        else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.DownArrow) || IsDucking)
        { 
            ChangeState(new DuckState());
        }
        else if (IsGrounded)
        {
            ChangeState(new IdleState());
        }

        if (!IsGrounded)
        {
            
            ChangeState(new JumpState());
        }

        GetDirection();

        DinoState.ControllMovement();
    }
    
    private void CheckIsGrounded()
    {
        // Check if the character is grounded
        if (gameObject.transform.position.y <= -0.2)
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
       
    }
    void Jump()
    {
        if(IsGrounded)
        {
            JumpParticle.Play();
            JumpSound.Play();
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnDuck()
    {
        IsDucking = true;
    }

    void OffDuck()
    {
        IsDucking = false;
    }

    void GetDirection()
    {
        if (CanMoveHorizontal)
        {
            //if(SystemInfo.deviceType != DeviceType.Desktop)
            //{
                LeftButton.gameObject.SetActive(true);
                RightButton.gameObject.SetActive(true);
            //}
            

            if(moveDirection == 0)// || SystemInfo.deviceType == DeviceType.Desktop)
                moveDirection = Input.GetAxisRaw("Horizontal");
            Debug.Log(moveDirection);
            transform.Translate(new Vector2(moveDirection, 0) * moveSpeed * Time.deltaTime);
        }
        else
        {
            LeftButton.gameObject.SetActive(false);
            RightButton.gameObject.SetActive(false);    
        }
    }

    void MoveLeft()
    { 
        moveDirection = -1;
    }
    void MoveRight() 
    {
        Debug.Log("right");
        moveDirection = 1;
        Debug.Log(moveDirection);
    }
    void ResetMove()
    {
        moveDirection = 0;
    }
   
    void InputSystemPlugin()
    {
        inputActions = new InputSystem();
        inputActions.Enable();

        inputActions.Input.Jump.performed += ctx => Jump();
        inputActions.Input.Duck.started += context => OnDuck();
        inputActions.Input.Duck.canceled += context => OffDuck();

        inputActions.Input.MoveLeft.started += context => MoveLeft();
        inputActions.Input.MoveLeft.canceled += context => ResetMove();

        inputActions.Input.MoveRight.started += context => MoveRight();
        inputActions.Input.MoveRight.canceled += context => ResetMove();
    }
}
