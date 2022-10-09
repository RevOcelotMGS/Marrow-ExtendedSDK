using System;
using UnityEngine;

[Serializable]
public class LTRect
{
	public Rect _rect;

	public float alpha;

	public float rotation;

	public Vector2 pivot;

	public Vector2 margin;

	public Rect relativeRect;

	public bool rotateEnabled;

	[HideInInspector]
	public bool rotateFinished;

	public bool alphaEnabled;

	public string labelStr;

	public LTGUI.Element_Type type;

	public GUIStyle style;

	public bool useColor;

	public Color color;

	public bool fontScaleToFit;

	public bool useSimpleScale;

	public bool sizeByHeight;

	public Texture texture;

	private int _id;

	[HideInInspector]
	public int counter;

	public static bool colorTouched;

	public bool hasInitiliazed
	{
		get
		{
			return default(bool);
		}
	}

	public int id
	{
		get
		{
			return default(int);
		}
	}

	public float x
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float y
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float width
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float height
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public Rect rect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public LTRect()
		: base()
	{
	}

	public LTRect(Rect rect)
		: this()
	{
	}

	public LTRect(float x, float y, float width, float height)
		: this()
	{
	}

	public LTRect(float x, float y, float width, float height, float alpha)
		: this()
	{
	}

	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
		: this()
	{
	}

	public void setId(int id, int counter)
	{
	}

	public void reset()
	{
	}

	public void resetForRotation()
	{
	}

	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	public LTRect setColor(Color color)
	{
		return null;
	}

	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	public LTRect setLabel(string str)
	{
		return null;
	}

	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
