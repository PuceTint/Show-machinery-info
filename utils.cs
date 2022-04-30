using UnityEngine;

namespace ShowMachineryInfo
{
    public class Utils
    {
        // machinery checks for update

        // Double trigger checks
        public static string IsDoubleGate(GateBehaviour gate)
        {
            if (gate.GetComponent<GateBehaviour>().DoubleTrigger) { return "Double"; }
            else { return "Single"; }
        }

        public static string IsDoubleKey(KeyTriggerBehaviour keyTrigger)
        {
            if (keyTrigger.GetComponent<KeyTriggerBehaviour>().DoubleTrigger) { return "Double"; }
            else { return "Single"; }
        }

        public static string IsDoubleButton(ButtonBehaviour button)
        {
            if (button.GetComponent<ButtonBehaviour>().TriggerOnExit) { return "Double"; }
            else { return "Single"; }
        }

        public static string IsDoubleDetector(DetectorBehaviour detector)
        {
            if (detector.GetComponent<DetectorBehaviour>().TriggerOnExit) { return "Double"; }
            else { return "Single"; }
        }


        public static string IsForward(BoatMotorBehaviour boatMotor)
        {
            if (boatMotor.GetComponent<BoatMotorBehaviour>().Force < 0) { return "Reverse"; }
            else { return ""; }
        }
        
        public static string IsReversed(MagnetBehaviour magnet)
        {
            if (magnet.GetComponent<MagnetBehaviour>().Reversed) { return "Repell"; }
            else { return "Attract"; }
        }
    }
}