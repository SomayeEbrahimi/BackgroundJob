using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/MainThreadSupport$AndroidHandlerMainThreadSupport", DoNotGenerateAcw=true)]
	public partial class MainThreadSupportAndroidHandlerMainThreadSupport : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupport {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/MainThreadSupport$AndroidHandlerMainThreadSupport", typeof (MainThreadSupportAndroidHandlerMainThreadSupport));
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

		protected MainThreadSupportAndroidHandlerMainThreadSupport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']/constructor[@name='MainThreadSupport.AndroidHandlerMainThreadSupport' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
		[Register (".ctor", "(Landroid/os/Looper;)V", "")]
		public unsafe MainThreadSupportAndroidHandlerMainThreadSupport (global::Android.OS.Looper looper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Looper;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((looper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) looper).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isMainThread;
#pragma warning disable 0169
		static Delegate GetIsMainThreadHandler ()
		{
			if (cb_isMainThread == null)
				cb_isMainThread = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMainThread);
			return cb_isMainThread;
		}

		static bool n_IsMainThread (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.MainThreadSupportAndroidHandlerMainThreadSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMainThread;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMainThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/class[@name='MainThreadSupport.AndroidHandlerMainThreadSupport']/method[@name='isMainThread' and count(parameter)=0]"
			[Register ("isMainThread", "()Z", "GetIsMainThreadHandler")]
			get {
				const string __id = "isMainThread.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='MainThreadSupport']"
	[Register ("com/vivalnk/sdk/common/eventbus/MainThreadSupport", "", "Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupportInvoker")]
	public partial interface IMainThreadSupport : IJavaObject, IJavaPeerable {

		bool IsMainThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='MainThreadSupport']/method[@name='isMainThread' and count(parameter)=0]"
			[Register ("isMainThread", "()Z", "GetIsMainThreadHandler:Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupportInvoker, ECGCommonSDK")] get;
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/MainThreadSupport", DoNotGenerateAcw=true)]
	internal partial class IMainThreadSupportInvoker : global::Java.Lang.Object, IMainThreadSupport {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/MainThreadSupport", typeof (IMainThreadSupportInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMainThreadSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMainThreadSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.MainThreadSupport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMainThreadSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isMainThread;
#pragma warning disable 0169
		static Delegate GetIsMainThreadHandler ()
		{
			if (cb_isMainThread == null)
				cb_isMainThread = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMainThread);
			return cb_isMainThread;
		}

		static bool n_IsMainThread (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.IMainThreadSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMainThread;
		}
#pragma warning restore 0169

		IntPtr id_isMainThread;
		public unsafe bool IsMainThread {
			get {
				if (id_isMainThread == IntPtr.Zero)
					id_isMainThread = JNIEnv.GetMethodID (class_ref, "isMainThread", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMainThread);
			}
		}

	}

}
