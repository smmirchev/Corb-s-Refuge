using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Locomotion
    public float walkSpeed = 2;
    public float runSpeed = 6;
    public float gravity = -12;

    public float speedTime = 0.1f;
    float speedVelocity;
    float currentSpeed;
    float velocityY;
    public float turnTime = 0.2f;
    float turnVelocity;

    Animator animator;
    Transform cameraTrans;
    CharacterController controller;
    Rigidbody rb;

    // Weapons

    public GameObject handWeapon, mace, axe;

    // Stats
    PlayerStats playerStats;
    bool attackEnemy;

    void Start()
    {
        // Animator / Camera
        animator = GetComponent<Animator>();
        cameraTrans = Camera.main.transform;
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

        //Weapons
        mace.SetActive(false);
        axe.SetActive(false);

        //Stats
        playerStats = GetComponent<PlayerStats>();
        attackEnemy = false;
        
    }

    void Update()
    {
        Vector2 temp = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 input = temp.normalized;

        animator.SetBool("jump", false);
        animator.SetBool("attack", false);
        bool jumping = Input.GetKey(KeyCode.Space);
        bool attacking = Input.GetKey(KeyCode.Mouse0);

        if (jumping)
        {
            animator.SetBool("jump", true);
        }

        if (input != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + cameraTrans.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnVelocity, turnTime);
            
        }

        bool running = Input.GetKey(KeyCode.LeftShift);
        float targetSpeed = ((running) ? runSpeed : walkSpeed) * input.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, speedTime);

        velocityY += Time.deltaTime * gravity;

        Vector3 velocity = transform.forward * currentSpeed + Vector3.up * velocityY;

        controller.Move(velocity * Time.deltaTime);

        attackEnemy = false;

        if(controller.isGrounded)
        {
            velocityY = 0;
            if (attacking)
            {
                attackEnemy = true;
                animator.SetBool("attack", true);
            }
        }

        float animationSpeed = ((running) ? 1 : .5f) * input.magnitude;
        animator.SetFloat("speed", animationSpeed, speedTime, Time.deltaTime);

        //Stats Changes
        if(handWeapon == mace)
        {
            playerStats.damage = 20;
        }

        if (handWeapon == axe)
        {
            playerStats.damage = 15;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mace")
        {
            
            if (Input.GetKeyDown(KeyCode.F))
            {
                handWeapon = mace;
                mace.SetActive(true);
                axe.SetActive(false);
            }
        }

        if (other.gameObject.tag == "Axe")
        {

            if (Input.GetKeyDown(KeyCode.F))
            {
                handWeapon = axe;
                axe.SetActive(true);
                mace.SetActive(false);
            }
        }
    }

    public bool getPlayerAttackingEnemy()
    {
        return attackEnemy;
    }
}