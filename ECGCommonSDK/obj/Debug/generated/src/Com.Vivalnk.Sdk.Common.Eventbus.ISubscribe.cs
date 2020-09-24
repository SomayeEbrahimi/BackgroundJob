using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Eventbus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Subscribe']"
	[Register ("com/vivalnk/sdk/common/eventbus/Subscribe", "", "Com.Vivalnk.Sdk.Common.Eventbus.ISubscribeInvoker")]
	public partial interface ISubscribe : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Subscribe']/method[@name='priority' and count(parameter)=0]"
		[Register ("priority", "()I", "GetPriorityHandler:Com.Vivalnk.Sdk.Common.Eventbus.ISubscribeInvoker, ECGCommonSDK")]
		int Priority ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Subscribe']/method[@name='sticky' and count(parameter)=0]"
		[Register ("sticky", "()Z", "GetStickyHandler:Com.Vivalnk.Sdk.Common.Eventbus.ISubscribeInvoker, ECGCommonSDK")]
		bool Sticky ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.eventbus']/interface[@name='Subscribe']/method[@name='threadMode' and count(parameter)=0]"
		[Register ("threadMode", "()Lcom/vivalnk/sdk/common/eventbus/ThreadMode;", "GetThreadModeHandler:Com.Vivalnk.Sdk.Common.Eventbus.ISubscribeInvoker, ECGCommonSDK")]
		global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode ThreadMode ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/eventbus/Subscribe", DoNotGenerateAcw=true)]
	internal partial class ISubscribeInvoker : global::Java.Lang.Object, ISubscribe {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/eventbus/Subscribe", typeof (ISubscribeInvoker));

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

		public static ISubscribe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscribe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.common.eventbus.Subscribe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscribeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_priority;
#pragma warning disable 0169
		static Delegate GetPriorityHandler ()
		{
			if (cb_priority == null)
				cb_priority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Priority);
			return cb_priority;
		}

		static int n_Priority (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priority ();
		}
#pragma warning restore 0169

		IntPtr id_priority;
		public unsafe int Priority ()
		{
			if (id_priority == IntPtr.Zero)
				id_priority = JNIEnv.GetMethodID (class_ref, "priority", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_priority);
		}

		static Delegate cb_sticky;
#pragma warning disable 0169
		static Delegate GetStickyHandler ()
		{
			if (cb_sticky == null)
				cb_sticky = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Sticky);
			return cb_sticky;
		}

		static bool n_Sticky (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sticky ();
		}
#pragma warning restore 0169

		IntPtr id_sticky;
		public unsafe bool Sticky ()
		{
			if (id_sticky == IntPtr.Zero)
				id_sticky = JNIEnv.GetMethodID (class_ref, "sticky", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sticky);
		}

		static Delegate cb_threadMode;
#pragma warning disable 0169
		static Delegate GetThreadModeHandler ()
		{
			if (cb_threadMode == null)
				cb_threadMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ThreadMode);
			return cb_threadMode;
		}

		static IntPtr n_ThreadMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThreadMode ());
		}
#pragma warning restore 0169

		IntPtr id_threadMode;
		public unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode ThreadMode ()
		{
			if (id_threadMode == IntPtr.Zero)
				id_threadMode = JNIEnv.GetMethodID (class_ref, "threadMode", "()Lcom/vivalnk/sdk/common/eventbus/ThreadMode;");
			return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ThreadMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_threadMode), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.ISubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
