using UnityEngine;

namespace Root66.PlayerSystems
{
    public class PlayerControls : BaseInput
    {
        private string TurnInputName = "Horizontal";
        private string AccelerateButtonName = "Accelerate";
        private string BrakeButtonName = "Brake";

        public override InputData GenerateInput()
        {
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
                TurnInput = Input.GetAxis("Horizontal")
            };
        }
    }
}
