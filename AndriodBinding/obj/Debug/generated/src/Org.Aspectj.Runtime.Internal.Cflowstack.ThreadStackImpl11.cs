using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal.Cflowstack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/cflowstack/ThreadStackImpl11", DoNotGenerateAcw=true)]
	public partial class ThreadStackImpl11 : global::Java.Lang.Object, global::Org.Aspectj.Runtime.Internal.Cflowstack.IThreadStack {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/cflowstack/ThreadStackImpl11", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadStackImpl11); }
		}

		protected ThreadStackImpl11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']/constructor[@name='ThreadStackImpl11' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadStackImpl11 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ThreadStackImpl11)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getThreadStack;
#pragma warning disable 0169
		static Delegate GetGetThreadStackHandler ()
		{
			if (cb_getThreadStack == null)
				cb_getThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetThreadStack);
			return cb_getThreadStack;
		}

		static IntPtr n_GetThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadStack);
		}
#pragma warning restore 0169

		static IntPtr id_getThreadStack;
		public virtual unsafe global::Java.Util.Stack ThreadStack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']/method[@name='getThreadStack' and count(parameter)=0]"
			[Register ("getThreadStack", "()Ljava/util/Stack;", "GetGetThreadStackHandler")]
			get {
				if (id_getThreadStack == IntPtr.Zero)
					id_getThreadStack = JNIEnv.GetMethodID (class_ref, "getThreadStack", "()Ljava/util/Stack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Stack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThreadStack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Stack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreadStack", "()Ljava/util/Stack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_removeThreadStack;
#pragma warning disable 0169
		static Delegate GetRemoveThreadStackHandler ()
		{
			if (cb_removeThreadStack == null)
				cb_removeThreadStack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveThreadStack);
			return cb_removeThreadStack;
		}

		static void n_RemoveThreadStack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Runtime.Internal.Cflowstack.ThreadStackImpl11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveThreadStack ();
		}
#pragma warning restore 0169

		static IntPtr id_removeThreadStack;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.runtime.internal.cflowstack']/class[@name='ThreadStackImpl11']/method[@name='removeThreadStack' and count(parameter)=0]"
		[Register ("removeThreadStack", "()V", "GetRemoveThreadStackHandler")]
		public virtual unsafe void RemoveThreadStack ()
		{
			if (id_removeThreadStack == IntPtr.Zero)
				id_removeThreadStack = JNIEnv.GetMethodID (class_ref, "removeThreadStack", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeThreadStack);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeThreadStack", "()V"));
			} finally {
			}
		}

	}
}
