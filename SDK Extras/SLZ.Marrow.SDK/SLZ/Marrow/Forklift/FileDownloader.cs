using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Networking;

namespace SLZ.Marrow.Forklift
{
	public sealed class FileDownloader : IDisposable
	{
		public delegate void OnDownloadStartedDelegate(FileDownloader fileDownloader, UnityWebRequest uwr, TaskItem taskItem);

		public delegate void OnDownloadProgressedDelegate(FileDownloader fileDownloader, TaskItem taskItem, float progress);

		public delegate void OnDownloadFinishedDelegate(FileDownloader fileDownloader, UnityWebRequest uwr, TaskItem taskItem);

		public struct TaskItem
		{
			public Uri url;

			public AsyncLazy<UnityWebRequest> asyncLazy;

			public IProgress<float> progress;

			public CancellationTokenSource cancelTokenSource;

			public CancellationTokenSource linkedCancelTokenSource;

			public readonly FileDownloader downloader;

			public readonly OnDownloadProgressedDelegate OnDownloadProgressed;

			public bool IsCancelled
			{
				get
				{
					return default(bool);
				}
			}

			internal TaskItem(FileDownloader downloader, OnDownloadProgressedDelegate progressedDelegate)
			{
				this.OnDownloadProgressed = default(OnDownloadProgressedDelegate);
				this.downloader = default(FileDownloader);
				this.linkedCancelTokenSource = default(CancellationTokenSource);
				this.cancelTokenSource = default(CancellationTokenSource);
				this.progress = default(IProgress<float>);
				this.asyncLazy = default(AsyncLazy<UnityWebRequest>);
				this.url = default(Uri);
			}

			internal void ReportProgress(float progress)
			{
			}
		}

		private const bool VERBOSE_LOGGING = false;

		private Queue<UnityWebRequest> _queue;

		private int _totalCompleted;

		private CancellationTokenSource _globalStopImmediately;

		private CancellationTokenSource _globalStopWhenDone;

		private List<TaskItem> _tasks;

		private List<UnityWebRequest> _inflight;

		public int MaximumConcurrentRequests { get; set; }

		public int MaximumConcurrentRequestsPerHost { get; set; }

		public int TimeoutSeconds { get; set; }

		internal bool Looping { get; private set; }

		private void Reset()
		{
		}

		public UnityWebRequest Enqueue(UnityWebRequest uwr)
		{
			return null;
		}

		private bool ShouldAdd(UnityWebRequest request, List<UnityWebRequest> toRequests)
		{
			return default(bool);
		}

		private UniTaskVoid Loop()
		{
			return default(UniTaskVoid);
		}

		private TaskItem StartDownloadTask(UnityWebRequest uwr, OnDownloadStartedDelegate startedDelegate, OnDownloadProgressedDelegate progressedDelegate)
		{
			return default(TaskItem);
		}

		public UniTask<List<UnityWebRequest>> DownloadQueueToCompletion(Queue<UnityWebRequest> queue)
		{
			return default(UniTask<List<UnityWebRequest>>);
		}

		public void Dispose()
		{
		}

		public FileDownloader()
			: base()
		{
		}

		public event OnDownloadStartedDelegate OnDownloadStarted;

		public event OnDownloadProgressedDelegate OnDownloadProgressed;

		public event OnDownloadFinishedDelegate OnDownloadFinished;
	}
}
