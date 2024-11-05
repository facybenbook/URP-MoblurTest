using UnityEngine;

public sealed class Config : MonoBehaviour
{
    [field:SerializeField] int TargetFPS { get; set; } = 30;

    void Start()
      => Application.targetFrameRate = TargetFPS;
}
