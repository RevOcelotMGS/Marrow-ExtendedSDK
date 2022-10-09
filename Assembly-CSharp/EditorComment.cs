using UnityEngine;

public class EditorComment : MonoBehaviour
{
	[TextArea(16, 32)]
	public string comments;

	public EditorComment()
		: base()
	{
	}
}
