using System.Collections.Generic;

namespace Oculus.Platform
{
	public static class Callback
	{
		private class RequestCallback
		{
			private Message.Callback messageCallback;

			public RequestCallback()
				: base()
			{
			}

			public RequestCallback(Message.Callback callback)
				: this()
			{
			}

			public virtual void HandleMessage(Message msg)
			{
			}
		}

		private sealed class RequestCallback<T> : RequestCallback
		{
			private Message<T>.Callback callback;

			public RequestCallback(Message<T>.Callback callback)
				: base()
			{
			}

			public override void HandleMessage(Message msg)
			{
			}
		}

		private static Dictionary<ulong, Request> requestIDsToRequests;

		private static Dictionary<Message.MessageType, RequestCallback> notificationCallbacks;

		private static bool hasRegisteredRoomInviteNotificationHandler;

		private static List<Message> pendingRoomInviteNotifications;

		private static bool hasRegisteredJoinIntentNotificationHandler;

		private static Message latestPendingJoinIntentNotifications;

		internal static void SetNotificationCallback<T>(Message.MessageType type, Message<T>.Callback callback)
		{
		}

		internal static void SetNotificationCallback(Message.MessageType type, Message.Callback callback)
		{
		}

		internal static void AddRequest(Request request)
		{
		}

		internal static void RunCallbacks()
		{
		}

		internal static void RunLimitedCallbacks(uint limit)
		{
		}

		internal static void OnApplicationQuit()
		{
		}

		private static void FlushRoomInviteNotificationQueue()
		{
		}

		private static void FlushJoinIntentNotificationQueue()
		{
		}

		internal static void HandleMessage(Message msg)
		{
		}
	}
}
