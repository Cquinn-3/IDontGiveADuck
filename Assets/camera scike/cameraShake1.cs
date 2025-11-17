using UnityEngine;
using Unity.Cinemachine;

public class cameraShake : MonoBehaviour
{
    public static cameraShake instance;
    [SerializeField] private float globalShakeForce = 1.0f; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void CameraShake(CinemachineImpulseSource impulseSource)
    {
        impulseSource.GenerateImpulseWithForce(globalShakeForce);
    }

}

