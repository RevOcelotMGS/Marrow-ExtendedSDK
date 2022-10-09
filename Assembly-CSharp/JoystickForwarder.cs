using UnityEngine;

public class JoystickForwarder : MonoBehaviour
{
	public Powerable[] xObjs;

	public Powerable[] yObjs;

	[Tooltip("The size of center swtich dead zone where output will be 0, 0 is no dead zone.")]
	public float deadZoneSize;

	public bool canForward;

	public void JOYSTICK(PropJoystick.JoystickData _joystickData)
	{
	}

	private void SendVoltage(Powerable[] objs, float voltage)
	{
	}

	public JoystickForwarder()
		: base()
	{
	}
}
