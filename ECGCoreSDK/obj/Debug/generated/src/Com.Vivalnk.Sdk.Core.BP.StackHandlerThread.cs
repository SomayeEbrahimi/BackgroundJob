using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Core.BP {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/core/bp/StackHandlerThread", DoNotGenerateAcw=true)]
	public partial class StackHandlerThread : global::Java.Lang.Thread {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/field[@name='mHandler']"
		[Register ("mHandler")]
		public global::Android.OS.Handler MHandler {
			get {
				const string __id = "mHandler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHandler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/field[@name='mLooper']"
		[Register ("mLooper")]
		public global::Android.OS.Looper MLooper {
			get {
				const string __id = "mLooper.Landroid/os/Looper;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLooper.Landroid/os/Looper;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/field[@name='mPriority']"
		[Register ("mPriority")]
		public int MPriority {
			get {
				const string __id = "mPriority.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mPriority.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/field[@name='mTid']"
		[Register ("mTid")]
		public int MTid {
			get {
				const string __id = "mTid.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTid.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/core/bp/StackHandlerThread", typeof (StackHandlerThread));
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

		protected StackHandlerThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/constructor[@name='StackHandlerThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StackHandlerThread (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/constructor[@name='StackHandlerThread' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;J)V", "")]
		public unsafe StackHandlerThread (string p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLooper;
#pragma warning disable 0169
		static Delegate GetGetLooperHandler ()
		{
			if (cb_getLooper == null)
				cb_getLooper = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLooper);
			return cb_getLooper;
		}

		static IntPtr n_GetLooper (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Looper);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Looper Looper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/method[@name='getLooper' and count(parameter)=0]"
			[Register ("getLooper", "()Landroid/os/Looper;", "GetGetLooperHandler")]
			get {
				const string __id = "getLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThreadHandler;
#pragma warning disable 0169
		static Delegate GetGetThreadHandlerHandler ()
		{
			if (cb_getThreadHandler == null)
				cb_getThreadHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThreadHandler);
			return cb_getThreadHandler;
		}

		static IntPtr n_GetThreadHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadHandler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Handler ThreadHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/method[@name='getThreadHandler' and count(parameter)=0]"
			[Register ("getThreadHandler", "()Landroid/os/Handler;", "GetGetThreadHandlerHandler")]
			get {
				const string __id = "getThreadHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThreadId;
#pragma warning disable 0169
		static Delegate GetGetThreadIdHandler ()
		{
			if (cb_getThreadId == null)
				cb_getThreadId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetThreadId);
			return cb_getThreadId;
		}

		static int n_GetThreadId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThreadId;
		}
#pragma warning restore 0169

		public virtual unsafe int ThreadId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/method[@name='getThreadId' and count(parameter)=0]"
			[Register ("getThreadId", "()I", "GetGetThreadIdHandler")]
			get {
				const string __id = "getThreadId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onLooperPrepared;
#pragma warning disable 0169
		static Delegate GetOnLooperPreparedHandler ()
		{
			if (cb_onLooperPrepared == null)
				cb_onLooperPrepared = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnLooperPrepared);
			return cb_onLooperPrepared;
		}

		static void n_OnLooperPrepared (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLooperPrepared ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/method[@name='onLooperPrepared' and count(parameter)=0]"
		[Register ("onLooperPrepared", "()V", "GetOnLooperPreparedHandler")]
		public virtual unsafe void OnLooperPrepared ()
		{
			const string __id = "onLooperPrepared.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_quit;
#pragma warning disable 0169
		static Delegate GetQuitHandler ()
		{
			if (cb_quit == null)
				cb_quit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Quit);
			return cb_quit;
		}

		static bool n_Quit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/method[@name='quit' and count(parameter)=0]"
		[Register ("quit", "()Z", "GetQuitHandler")]
		public virtual unsafe bool Quit ()
		{
			const string __id = "quit.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_quitSafely;
#pragma warning disable 0169
		static Delegate GetQuitSafelyHandler ()
		{
			if (cb_quitSafely == null)
				cb_quitSafely = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_QuitSafely);
			return cb_quitSafely;
		}

		static bool n_QuitSafely (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QuitSafely ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.core.bp']/class[@name='StackHandlerThread']/method[@name='quitSafely' and count(parameter)=0]"
		[Register ("quitSafely", "()Z", "GetQuitSafelyHandler")]
		public virtual unsafe bool QuitSafely ()
		{
			const string __id = "quitSafely.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
