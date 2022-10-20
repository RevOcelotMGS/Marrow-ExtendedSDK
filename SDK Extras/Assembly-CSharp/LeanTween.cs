using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeanTween : MonoBehaviour
{
	public static bool throwErrors;

	public static float tau;

	public static float PI_DIV2;

	private static LTSeq[] sequences;

	private static LTDescr[] tweens;

	private static int[] tweensFinished;

	private static int[] tweensFinishedIds;

	private static LTDescr tween;

	private static int tweenMaxSearch;

	private static int maxTweens;

	private static int maxSequences;

	private static int frameRendered;

	private static GameObject _tweenEmpty;

	public static float dtEstimated;

	public static float dtManual;

	public static float dtActual;

	private static uint global_counter;

	private static int i;

	private static int j;

	private static int finishedCnt;

	public static AnimationCurve punch;

	public static AnimationCurve shake;

	private static int maxTweenReached;

	public static int startSearch;

	public static LTDescr d;

	private static Action<LTEvent>[] eventListeners;

	private static GameObject[] goListeners;

	private static int eventsMaxSearch;

	public static int EVENTS_MAX;

	public static int LISTENERS_MAX;

	private static int INIT_LISTENERS_MAX;

	public static int maxSearch
	{
		get
		{
			return default(int);
		}
	}

	public static int maxSimulataneousTweens
	{
		get
		{
			return default(int);
		}
	}

	public static int tweensRunning
	{
		get
		{
			return default(int);
		}
	}

	public static GameObject tweenEmpty
	{
		get
		{
			return null;
		}
	}

	public static void init()
	{
	}

	public static void init(int maxSimultaneousTweens)
	{
	}

	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	public static void reset()
	{
	}

	public void Update()
	{
	}

	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	public static void update()
	{
	}

	public static void removeTween(int i, int uniqueId)
	{
	}

	public static void removeTween(int i)
	{
	}

	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	public static void cancelAll()
	{
	}

	public static void cancelAll(bool callComplete)
	{
	}

	public static void cancel(GameObject gameObject)
	{
	}

	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	public static void cancel(RectTransform rect)
	{
	}

	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	public static void cancel(int uniqueId)
	{
	}

	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	public static LTDescr[] descriptions(GameObject gameObject = default(GameObject))
	{
		return null;
	}

	[Obsolete("Use 'pause( id )' instead")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	public static void pause(int uniqueId)
	{
	}

	public static void pause(GameObject gameObject)
	{
	}

	public static void pauseAll()
	{
	}

	public static void resumeAll()
	{
	}

	[Obsolete("Use 'resume( id )' instead")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	public static void resume(int uniqueId)
	{
	}

	public static void resume(GameObject gameObject)
	{
	}

	public static bool isPaused(GameObject gameObject = default(GameObject))
	{
		return default(bool);
	}

	public static bool isPaused(RectTransform rect)
	{
		return default(bool);
	}

	public static bool isPaused(int uniqueId)
	{
		return default(bool);
	}

	public static bool isTweening(GameObject gameObject = default(GameObject))
	{
		return default(bool);
	}

	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, Transform arrowTransform = default(Transform))
	{
	}

	public static object logError(string error)
	{
		return null;
	}

	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	public static LTDescr options()
	{
		return null;
	}

	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	public static LTDescr followDamp(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f)
	{
		return null;
	}

	public static LTDescr followSpring(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return null;
	}

	public static LTDescr followBounceOut(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return null;
	}

	public static LTDescr followLinear(Transform trans, Transform target, LeanProp prop, float moveSpeed)
	{
		return null;
	}

	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	public static void dispatchEvent(int eventId)
	{
	}

	public static void dispatchEvent(int eventId, object data)
	{
	}

	public LeanTween()
		: base()
	{
	}
}
