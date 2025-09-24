using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance = 0f;


    bool isAttacking = false;


    void Start()
    {
        //Cursor.visible = false;
    }

    void Update()
    {
        ProcessAttack();
        MoveCrosshair();
        MoveTargetPoint();
        AimLasers();
    }


    public void OnAttack(InputValue value)
    {
        isAttacking = value.isPressed;
    }

    void ProcessAttack()
    {
        foreach (GameObject laser in lasers)
        {
            ParticleSystem.EmissionModule emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isAttacking;
        }
    }

    void MoveCrosshair()
    {
        crosshair.position = Input.mousePosition;
    }

    void MoveTargetPoint()
    {
        Vector3 targetPointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        targetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition);
    }

    void AimLasers()
    {
        foreach (GameObject laser in lasers)
        {
            Vector3 aimDirection = targetPoint.position - this.transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(aimDirection);
            laser.transform.rotation = rotationToTarget;
        }
    }
}
