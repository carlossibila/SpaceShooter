using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 0f;
    [SerializeField] float clampRangeX = 0f;
    [SerializeField] float clampRangeY = 0f;


    [SerializeField] float controlPitchFactor = 0f;
    [SerializeField] float controlRollFactor = 0f;
    [SerializeField] float rollFactorSpeed = 0f;


    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }


    public void OnMove(InputValue inputValue)
    {
        movement = inputValue.Get<Vector2>();
    }

    void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampXPos = Mathf.Clamp(rawXPos, -clampRangeX, clampRangeX);

        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampYPos = Mathf.Clamp(rawYPos, -clampRangeY, clampRangeY);

        transform.localPosition = new Vector3(clampXPos, clampYPos, 0f);
    }

    void ProcessRotation()
    {
        float pitch = -controlPitchFactor * movement.y;
        float roll = -controlRollFactor * movement.x;   

        Quaternion targetRotation = Quaternion.Euler(pitch, 0f, roll);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, rollFactorSpeed * Time.deltaTime);
    }
}
