using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS
    public static event KeyPressedDelegate OnEnterKeyPressed, OnEscKeyPressed;
    public delegate void KeyPressedDelegate();

    private void Update() 
    {
        //if not null, execute the event
        if (Input.GetKeyDown(KeyCode.Space)){
            OnEnterKeyPressed?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            OnEscKeyPressed?.Invoke();
        }
    }
}
