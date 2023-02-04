using UnityEngine;

namespace Root66.PlayerSystems
{
    public struct InputData
    {
        public bool Accelerate;
        public bool Brake;
        public float TurnInput;
    }

    public interface IInput
    {
        InputData GenerateInput();
    }

    public abstract class BaseInput : MonoBehaviour, IInput
    {
        public abstract InputData GenerateInput();
    }
}
