// This is from the Unity Game Project.

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public PS3Controller Controller;
    public Camera camera;
    public float CameraSpeed;

    public int Speed;
    public Vector3 movement;
    public bool Jumping = false;
    public bool WallTrigger = false;
    public float checking;
    public float Degrees;

    public bool DamageFlagInfo;
    public bool IdleFlagInfo;
    public bool Idle2FlagInfo;
    public bool Idle3FlagInfo;
    public bool JumpFlagInfo;
    public bool Attack1FlagInfo;
    public bool Attack2FlagInfo;
    public bool Attack3FlagInfo;
    public bool DeathFlagInfo;

    float LeftStickX;
    float LeftStickY;
    float RightStickX;
    float RightStickY;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftStickX = Controller.LeftStickXMove;
        LeftStickY = Controller.LeftStickYMove;
        RightStickX = Controller.RightStickXMove;
        RightStickY = Controller.RightStickYMove;

        float XAxisRot = RightStickX * CameraSpeed;
        float YAxisRot = RightStickY * CameraSpeed;

        camera.transform.Rotate(-YAxisRot,XAxisRot,0);
        float z = camera.transform.eulerAngles.z;
        camera.transform.Rotate(0, 0, -z);

        UpdateFlags();
        Move();
        ControlUpdate();
    }
    void Move()
    {

        if (DamageFlagInfo == false)
        {

            if (WallTrigger == false)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                GetComponent<Rigidbody>().useGravity = true;
                movement = new Vector3(h * Speed, 0, v * Speed);
            }
            else
            {
                GetComponent<Rigidbody>().useGravity = false;
            }

            transform.localPosition += movement * Time.fixedDeltaTime;

        }

    }
    void UpdateFlags()
    {

       DamageFlagInfo = GetComponent<Animator>().GetBool("DamageFlag");
       IdleFlagInfo = GetComponent<Animator>().GetBool("IdleFlag");
       Idle2FlagInfo = GetComponent<Animator>().GetBool("Idle2Flag");
       Idle3FlagInfo = GetComponent<Animator>().GetBool("Idle3Flag");
       JumpFlagInfo = GetComponent<Animator>().GetBool("JumpFlag");
       Attack1FlagInfo = GetComponent<Animator>().GetBool("Attack1Flag");
       Attack2FlagInfo = GetComponent<Animator>().GetBool("Attack2Flag");
       Attack3FlagInfo = GetComponent<Animator>().GetBool("Attack3Flag");
       DeathFlagInfo = GetComponent<Animator>().GetBool("DeathFlag");
    }
    void ControlUpdate()
    {

        if (LeftStickX == 0 && LeftStickY == 0)
        {
            GetComponent<Animator>().SetBool("IdleFlag", true);
        }
        else
        {
            if (WallTrigger == false)
            {
                GetComponent<Animator>().SetBool("IdleFlag", false);
                transform.localRotation = Quaternion.LookRotation(movement);
            }
        }
        if (Controller.XButton || Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("JumpFlag", true);
        }
       if (Controller.SquareButton || Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("Attack1Flag", true);
        }

    }
    void OnTriggerStay(Collider col)
    {

        if (col.gameObject.tag == "Chest")
        {
            if (Controller.XButton || Input.GetKeyDown(KeyCode.Space))
            {
                col.gameObject.GetComponent<TreasureChest>().OpenChest();
            }
        }
        else if(col.gameObject.tag == "Collectible")
        {
            col.gameObject.GetComponent<FindItem>().FoundItem();
        }
    }
}


