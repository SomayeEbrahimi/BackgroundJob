using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Excutors {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/excutors/AndroidExecutors", DoNotGenerateAcw=true)]
	public sealed partial class AndroidExecutors : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/excutors/AndroidExecutors", typeof (AndroidExecutors));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal AndroidExecutors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='allowCoreThreadTimeout' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.ThreadPoolExecutor'] and parameter[2][@type='boolean']]"
		[Register ("allowCoreThreadTimeout", "(Ljava/util/concurrent/ThreadPoolExecutor;Z)V", "")]
		public static unsafe void AllowCoreThreadTimeout (global::Java.Util.Concurrent.ThreadPoolExecutor executor, bool value)
		{
			const string __id = "allowCoreThreadTimeout.(Ljava/util/concurrent/ThreadPoolExecutor;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((executor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) executor).Handle);
				__args [1] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='newCachedThreadPool' and count(parameter)=0]"
		[Register ("newCachedThreadPool", "()Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool ()
		{
			const string __id = "newCachedThreadPool.()Ljava/util/concurrent/ExecutorService;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='newCachedThreadPool' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
		[Register ("newCachedThreadPool", "(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutorService NewCachedThreadPool (global::Java.Util.Concurrent.IThreadFactory threadFactory)
		{
			const string __id = "newCachedThreadPool.(Ljava/util/concurrent/ThreadFactory;)Ljava/util/concurrent/ExecutorService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((threadFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) threadFactory).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.excutors']/class[@name='AndroidExecutors']/method[@name='uiThread' and count(parameter)=0]"
		[Register ("uiThread", "()Ljava/util/concurrent/Executor;", "")]
		public static unsafe global::Java.Util.Concurrent.IExecutor UiThread ()
		{
			const string __id = "uiThread.()Ljava/util/concurrent/Executor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
