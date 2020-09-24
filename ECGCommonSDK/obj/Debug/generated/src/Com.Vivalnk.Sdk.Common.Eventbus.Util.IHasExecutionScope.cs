using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/interface[@name='HasExecutionScope']"
	[Register ("com/vivalnk/sdk/common/eventbus/util/HasExecutionScope", "", "Com.Vivalnk.Sdk.Common.Eventbus.Util.IHasExecutionScopeInvoker")]
	public partial interface IHasExecutionScope : IJavaObject, IJavaPeerable {

		global::Java.Lang.Object ExecutionScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/interface[@name='HasExecutionScope']/method[@name='getExecutionScope' and count(parameter)=0]"
			[Register ("getExecutionScope", "()Ljava/lang/Object;", "GetGetExecutionScopeHandler:Com.Vivalnk.Sdk.Common.Eventbus.Util.IHasExecutionScopeInvoker, ECGCommonSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus.util']/interface[@name='HasExecutionScope']/method[@name='setExecutionScope' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setExecutionScope", "(Ljava/lang/Object;)V", "GetSetExecutionScope_Ljava_lang_Object_Handler:Com.Vivalnk.Sdk.Common.Eventbus.Util.IHasExecutionScopeInvoker, ECGCommonSDK")] set;
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/util/HasExecutionScope", DoNotGenerateAcw=true)]
	internal partial class IHasExecutionScopeInvoker : global::Java.Lang.Object, IHasExecutionScope {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/util/HasExecutionScope", typeof (IHasExecutionScopeInvoker));

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

		public static IHasExecutionScope GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHasExecutionScope> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.util.HasExecutionScope"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHasExecutionScopeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getExecutionScope;
#pragma warning disable 0169
		static Delegate GetGetExecutionScopeHandler ()
		{
			if (cb_getExecutionScope == null)
				cb_getExecutionScope = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExecutionScope);
			return cb_getExecutionScope;
		}

		static IntPtr n_GetExecutionScope (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.IHasExecutionScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecutionScope);
		}
#pragma warning restore 0169

		static Delegate cb_setExecutionScope_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetExecutionScope_Ljava_lang_Object_Handler ()
		{
			if (cb_setExecutionScope_Ljava_lang_Object_ == null)
				cb_setExecutionScope_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExecutionScope_Ljava_lang_Object_);
			return cb_setExecutionScope_Ljava_lang_Object_;
		}

		static void n_SetExecutionScope_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.Util.IHasExecutionScope> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecutionScope = p0;
		}
#pragma warning restore 0169

		IntPtr id_getExecutionScope;
		IntPtr id_setExecutionScope_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object ExecutionScope {
			get {
				if (id_getExecutionScope == IntPtr.Zero)
					id_getExecutionScope = JNIEnv.GetMethodID (class_ref, "getExecutionScope", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExecutionScope), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setExecutionScope_Ljava_lang_Object_ == IntPtr.Zero)
					id_setExecutionScope_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExecutionScope", "(Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExecutionScope_Ljava_lang_Object_, __args);
			}
		}

	}

}
